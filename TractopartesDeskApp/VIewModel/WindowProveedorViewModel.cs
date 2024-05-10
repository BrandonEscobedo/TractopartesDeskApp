using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Models.Managers;
using TractopartesDeskApp.Repository;
using TractopartesDeskApp.VIewModel.Propertys;
using TractopartesDeskApp.Views;

namespace TractopartesDeskApp.VIewModel
{
    class WindowProveedorViewModel
    {
        public ICommand ShowWindowCommand { get; }
        public ObservableCollection<ProveedorModel> Proveedores { get; set; }

        public WindowProveedorViewModel()
        {
         
            Proveedores = ProveedoresManager.GetProveedores();

            ShowWindowCommand = new ViewModelCommand(ExecuteProveedorCommand, CanExecuteProveedorCommand);
        }
        private void ExecuteProveedorCommand(object obj)
        {
            ProveedoresView proveedores = new ProveedoresView();
            proveedores.Show();
        }

        private bool CanExecuteProveedorCommand(object obj)
        {
            return true;
        }
    }
}
