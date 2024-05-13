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

namespace TractopartesDeskApp.VIewModel
{
    public class ProductosManagerViewModel
    {
       
        ICommand ShowAddProductoCommand;
        public ObservableCollection<ProductoModel> Productos { get; set; }
        public ProductoModel ProductoModel { get; set; } = new();
        public event EventHandler ProductoInsertado;
        public ProductosManagerViewModel()
        {
            Productos = ProductoManager.GetProductos();
            ShowAddProductoCommand = new ViewModelCommand(ExecuteAddCommand);
        }

        private void ExecuteAddCommand(object obj)
        {
            ProductoView productoView = new();
            productoView.DataContext = new ProductosViewModel();
            productoView.Show();

        }

    }
}
