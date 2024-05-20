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
    public class ProductosManagerViewModel:ViewModelBase
    {
       
     public ICommand ShowAddProductoCommand { get; }
     public ICommand ShowRemoveCommand { get; }
     public ICommand ShowUpdateCommand { get; }
       
    private ObservableCollection<ProductoModel> _products=new();

        public ObservableCollection<ProductoModel> Productos
        {
            get => _products;
            set
            {
                if (_products != value)
                {
                    _products = value;
                    OnPropertyChanged(nameof(Productos));
                }
            }
        }

        public ProductoModel ProductoModel { get; set; } = new();
        public ProductosManagerViewModel()
        {
            _products =  ProductoManager.productos;
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
                P_idProducto = producto.P_idproducto,
                P_cantidad= producto._P_cantidad,
                P_descripcion= producto.P_descripcion,
                P_CategoriaNombre= producto.P_categoria,
                P_CodigoPieza= producto.P_codigopieza,
                P_NombreProducto= producto.P_productonombre,
                P_ProveedorRazonSocial= producto.P_proveedor,
                P_precioVenta= producto.P_precioventa,
                P_precioCompra=producto.P_preciocompra,
                P_ImagenURL=producto.P_ImagenURL,
        };
            Updateproducto.Show();
        }

        private void ExecuteRemoveCommand(object obj)
        {
            ProductoModel producto = (ProductoModel)obj;
            RemoveProductoView removeProductoView = new();
            removeProductoView.DataContext = new ProductosViewModel
            {
                P_idProducto = producto.P_idproducto,
                P_cantidad = producto._P_cantidad,
                P_CategoriaNombre = producto.P_categoria,
                P_CodigoPieza = producto.P_codigopieza,
                P_NombreProducto = producto.P_productonombre,
                P_ProveedorRazonSocial = producto.P_proveedor,
                P_precioVenta = producto.P_precioventa,
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
