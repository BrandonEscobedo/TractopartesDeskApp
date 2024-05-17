using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Models.Managers;
using TractopartesDeskApp.Views;
using TractopartesDeskApp.Views.RemoveViews;

namespace TractopartesDeskApp.VIewModel
{
    public class ProductosManagerViewModel
    {
       
     public ICommand ShowAddProductoCommand { get; }
     public ICommand ShowRemoveCommand { get; }
     public ICommand ShowUpdateCommand { get; }
        public ObservableCollection<ProductoModel> Productos { get; set; }
        public ProductoModel ProductoModel { get; set; } = new();
        public event EventHandler ProductoInsertado;
        public ProductosManagerViewModel()
        {
            Productos = ProductoManager.GetProductos();
            ShowAddProductoCommand = new ViewModelCommand(ExecuteAddCommand);
            ShowRemoveCommand = new ViewModelCommand(ExecuteRemoveCommand);
            ShowUpdateCommand = new ViewModelCommand(ExecuteUpdateCommand);
        }

        private void ExecuteUpdateCommand(object obj)
        {
            ProductoModel producto = (ProductoModel)obj;
            ProductoView Updateproducto = new();
            Updateproducto.DataContext = new ProductosViewModel
            {
                P_idProducto = producto.p_idproducto,
                P_cantidad= producto.p_cantidad,
                P_CategoriaNombre= producto.p_categoria,
                P_CodigoPieza= producto.p_codigopieza,
                P_NombreProducto= producto.p_productonombre,
                P_ProveedorRazonSocial= producto.p_proveedor,
                P_precioVenta= producto.p_precioventa,
                P_precioCompra=producto.p_preciocompra,
                P_ImagenURL=producto.p_ImagenURL,
        };
            Updateproducto.Show();
        }

        private void ExecuteRemoveCommand(object obj)
        {
            ProductoModel producto = (ProductoModel)obj;
            RemoveProductoView removeProductoView = new();
            removeProductoView.DataContext = new ProductosViewModel
            {
                P_idProducto = producto.p_idproducto,
                P_cantidad = producto.p_cantidad,
                P_CategoriaNombre = producto.p_categoria,
                P_CodigoPieza = producto.p_codigopieza,
                P_NombreProducto = producto.p_productonombre,
                P_ProveedorRazonSocial = producto.p_proveedor,
                P_precioVenta = producto.p_precioventa,
            };
            removeProductoView.Show();
        }
    

        private void ExecuteAddCommand(object obj)
        {
            ProductoView productoView = new();
            productoView.DataContext = new ProductosViewModel();
            productoView.Show();

        }

    }
}
