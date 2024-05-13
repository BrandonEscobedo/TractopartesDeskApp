using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Repository;
using TractopartesDeskApp.VIewModel.Propertys;

namespace TractopartesDeskApp.VIewModel
{
    public class ProductosViewModel:ProductosProperty
    {
        ICommand AddProductoCommand;
        ICommand UpdateProductoCommand;
        ICommand RemoveProductoCommand;
        IProductoRepository _productoRepository;
        ProductoModel productoModel = new();
        public ProductosViewModel()
        {

            //Verificar  si se puede compartir instancia de ProductoModel(UserModel) de propertys a ProductosViewModel
            AddProductoCommand = new ViewModelCommand(ExecuteAddProductoCommand, CanExecuteCommand);
            UpdateProductoCommand = new ViewModelCommand(ExecuteUpdateProductoCommand, CanExecuteCommand);
            RemoveProductoCommand = new ViewModelCommand(ExecuteRemoveProductoCommand);
        }

        private void ExecuteUpdateProductoCommand(object obj)
        {
            throw new NotImplementedException();
        }

        private void ExecuteRemoveProductoCommand(object obj)
        {
            throw new NotImplementedException();
        }

        private async void ExecuteAddProductoCommand(object obj)
        {

            await _productoRepository.AddProducto(productoModel);
        }

        private bool CanExecuteCommand(object obj)
        {
            bool resultdata;
            if (string.IsNullOrEmpty(P_CodigoPieza) || string.IsNullOrEmpty(P_CategoriaNombre) || string.IsNullOrEmpty(P_descripcion)
                || string.IsNullOrEmpty(P_ProveedorNombreEmpresa)
                || P_cantidad<=0 || P_precioCompra<=0|| P_precioVenta<=0 || string.IsNullOrEmpty(P_ProveedorNombreEmpresa)
                || string.IsNullOrEmpty(P_CategoriaNombre))
                resultdata = false;
            else
                resultdata=true;
            return resultdata;
                
        }
    }
}
