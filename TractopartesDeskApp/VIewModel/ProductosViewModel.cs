using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Models.Managers;
using TractopartesDeskApp.Repository;
using TractopartesDeskApp.VIewModel.Propertys;

namespace TractopartesDeskApp.VIewModel
{
    public class ProductosViewModel : ProductosProperty
    {
        public ICommand AddProductoCommand { get; }
        public ICommand UpdateProductoCommand { get; }
        public ICommand RemoveProductoCommand { get; }
        public IProductoRepository _productoRepository;
        ProductoModel productoModel { get; set; } = new();
        public ProductosViewModel()
        {
            _productoRepository = new ProductoRepository();
            AddProductoCommand = new ViewModelCommand(ExecuteAddProductoCommand, CanExecuteCommand);
            UpdateProductoCommand = new ViewModelCommand(ExecuteUpdateProductoCommand, CanExecuteCommand);
            RemoveProductoCommand = new ViewModelCommand(ExecuteRemoveProductoCommand);
        }

        private void ExecuteUpdateProductoCommand(object obj)
        {
            throw new NotImplementedException();
        }

        private async void ExecuteRemoveProductoCommand(object obj)
        {
            if (P_idProducto != 0)
            {
              await  _productoRepository.RemoveProducto(P_idProducto);
                ProductoManager.RemoveProducto(P_idProducto);

            }

        }
        private async void ExecuteAddProductoCommand(object obj)

        {
            productoModel.p_idproducto = P_idProducto;
            productoModel.p_productonombre = P_NombreProducto;
            productoModel.p_codigopieza = P_CodigoPieza;
            productoModel.p_descripcion = P_descripcion;
            productoModel.p_ImagenURL = P_ImagenURL;
            productoModel.p_precioventa = P_precioVenta;
            productoModel.p_preciocompra = P_precioCompra;
            productoModel.p_categoria.idcategoria = P_CategoriaNombre.idcategoria;
            productoModel.p_proveedor.idproveedor = P_ProveedorRazonSocial.idproveedor;
            productoModel.p_cantidad = P_cantidad;
            if (P_idProducto == 0)
            {
                var iduser = await _productoRepository.AddProducto(productoModel);
                if (iduser != 0)
                {
                    productoModel.p_idproducto = iduser;
                    ProductoManager.AddProducto(productoModel);
                    CleanPropertys();

                }
            }
            else
            {
               var result= await _productoRepository.UpdateProducto(productoModel);
                if (result)
                {
                    CleanPropertys();

                    ProductoManager.UpdateProducto(productoModel);
                }
                   
            }


        }
        private void CleanPropertys()
        {
            P_idProducto = 0;
            P_NombreProducto = "";
            P_NombreProducto = "";
           P_CodigoPieza="";
            P_descripcion = "";
            P_ImagenURL = "";
            P_precioVenta = 0;
            P_precioCompra = 0;
            P_CategoriaNombre = new();
            P_ProveedorRazonSocial=new() ;
         P_cantidad = 0;
        }

        private bool CanExecuteCommand(object obj)
        {
            bool resultdata;
            if (string.IsNullOrEmpty(P_CodigoPieza) | string.IsNullOrEmpty(P_CategoriaNombre.categoria) || string.IsNullOrEmpty(P_descripcion)
                || string.IsNullOrEmpty(P_ProveedorRazonSocial.razonsocial)
                || P_cantidad <= 0 || P_precioCompra <= 0 || P_precioVenta <= 0 || string   .IsNullOrEmpty(P_NombreProducto))
               resultdata = false;
            else
                resultdata = true;
            return resultdata;

        }
    }
}
