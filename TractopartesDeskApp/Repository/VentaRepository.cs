﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.Data;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Repository
{
  
    public class VentasRepository : SqlDataAccess, IVentaRepository
    {
        public async Task<bool> GenerarVenta( VentaModel ventaModel)
        {
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
                        p_idproducto = item.producto.p_idproducto,
                        p_cantidad = item.cantidad,
                        precio_unitario = item.producto.p_precioventa
                    };
                  var resultProcedure=  await ExecuteGeneric("DetalleVenta", parametersDetalleVenta);
                }
            }
            else
                return false;
            return true;
        }
    }
}
