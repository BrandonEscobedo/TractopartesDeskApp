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
using TractopartesDeskApp.Views.RemoveViews;

namespace TractopartesDeskApp.VIewModel
{
    class WindowProveedorViewModel
    {
        public ICommand ShowWindowCommand { get; }
        public ICommand ShowWindowRemoveCommand { get; }
        public ICommand ShowWindowUpdateCommand { get; }
        public ObservableCollection<ProveedorModel> Proveedores { get; set; }

        public WindowProveedorViewModel()
        {

            Proveedores = ProveedoresManager.GetProveedores();
            ShowWindowRemoveCommand = new ViewModelCommand(ExecuteShowRemoveWindowCommand);
            ShowWindowCommand = new ViewModelCommand(ExecuteProveedorCommand, CanExecuteProveedorCommand);
            ShowWindowUpdateCommand = new ViewModelCommand(ExecuteShowUpdateWindowCommand);
        }

        private void ExecuteShowUpdateWindowCommand(object obj)
        {
            ProveedorModel proveedor = (ProveedorModel)obj;
            ProveedoresView proveedores = new ProveedoresView();
            proveedores.DataContext = new ProveedorByViewModel
            {
                P_idProveedor = proveedor.idproveedor,
                Correo = proveedor.correo,
                NombreEmpresa = proveedor.nombreempresa,
                direccion = proveedor.direccion,
                Telefono = proveedor.telefono,
                RazonSocial = proveedor.razonsocial
            };

            proveedores.Show();
        }

        private void ExecuteShowRemoveWindowCommand(object obj)
        {
            ProveedorModel proveedor = (ProveedorModel)obj;
            RemoveProveedorView removeProveedorView = new();
            removeProveedorView.DataContext = new ProveedorByViewModel
            {
                P_idProveedor = proveedor.idproveedor,
                Correo = proveedor.correo,
                NombreEmpresa = proveedor.nombreempresa,
                direccion = proveedor.direccion,
                Telefono = proveedor.telefono,
                RazonSocial = proveedor.razonsocial
            };

            removeProveedorView.Show();
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
