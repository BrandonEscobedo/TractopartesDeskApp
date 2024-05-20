using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.Data;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.PdfGenerator;

namespace TractopartesDeskApp.Repository
{
  
    public class VentasRepository : SqlDataAccess, IVentaRepository
    {
        public async Task<bool> GenerarVenta( VentaModel ventaModel)
        {
            FacturaModel factura = new();
            ventaModel.fechanventa = DateTime.Now;
            var parameters = new
            {
                idventa=  ventaModel.idventa,
                fechaventa =ventaModel.fechanventa,
                total =  ventaModel.total,
                idcliente=   ventaModel.clientemodel?.idclientedp
            };


           var result = await ExecuteGeneric("generarVenta", parameters);
            if (result)
            {
              
                foreach (var item in ventaModel.detalleVentas)
                {
                 
                    var parametersDetalleVenta = new
                    {
                        idventa = item.idventa,
                        p_idproducto = item.producto.P_idproducto,
                        p_cantidad = item.cantidad,
                        precio_unitario = item.producto.P_precioventa
                    };
                  var resultProcedure=  await ExecuteGeneric("DetalleVenta", parametersDetalleVenta);
                    ProductoModel producto = new();
                    producto = item.producto;
                    producto._P_cantidad = item.cantidad;
                    factura.Productos.Add(producto);
                   
                    
                }
                factura.userModel = ventaModel.clientemodel;
                factura.Total = ventaModel.total;
                factura.FechaVenta = ventaModel.fechanventa;
                factura.idventa = ventaModel.idventa;
                QuestGenerator questGenerator = new();
              var pdfPath=  questGenerator.GenerarPDF(factura);
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = pdfPath,
                    UseShellExecute = true
                };
                Process.Start(processStartInfo);
            }
            else
                return false;
            return true;
        }
    }
}
