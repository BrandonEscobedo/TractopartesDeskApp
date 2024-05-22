using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Models.Managers;
using TractopartesDeskApp.Repository;
using TractopartesDeskApp.VIewModel.Propertys;

namespace TractopartesDeskApp.VIewModel
{
    public class ProveedorByViewModel:ProveedorViewModelPropertys
    {
        public ICommand AddProveedorCommand { get; }
        public ICommand RemoveProveedorCommand { get; }
        public ICommand ClearFieldsCommand { get; }

        public IProveedorRepository _proveedorRepository;
        public ProveedorByViewModel()
        {
            _proveedorRepository = new ProveedorRepository();
            ClearFieldsCommand = new ViewModelCommand(ExecuteClearFieldsCommand);
            RemoveProveedorCommand = new ViewModelCommand(ExecuteRemoveProveedor);
            AddProveedorCommand = new ViewModelCommand(ExecuteProveedorCommand, CanExecuteProveedorCommand);
        }

   

        private void ExecuteRemoveProveedor(object obj)
        {
            if (P_idProveedor != 0)
            {
                _proveedorRepository.RemoveProveedor(P_idProveedor);
                ProveedoresManager.RemoveProveedor(P_idProveedor);
            }
        }

        private void ExecuteClearFieldsCommand(object obj)
        {
            NombreEmpresa = string.Empty;
            RazonSocial = string.Empty;
            Telefono = new int();
            Correo = string.Empty;
            direccion = string.Empty;
        }
        private async void ExecuteProveedorCommand(object obj)
        {
            
            ProveedorModel proveedor = new()
            {

                correo = Correo,
                nombreempresa = NombreEmpresa,
                telefono = Telefono,
                razonsocial = RazonSocial,
                direccion=direccion
            };
            if(P_idProveedor == 0)
            {
                var idproveedor = await _proveedorRepository.AddProveedor(proveedor);
                if (idproveedor != 0)
                {
                    proveedor.idproveedor = idproveedor;
                    ProveedoresManager.AddPrveedor(proveedor);
                }
            }
            else
            {
            proveedor.idproveedor = P_idProveedor;
            await  _proveedorRepository.UpdateProveedor(proveedor);
                ProveedoresManager.UpdateProveedor(proveedor);
            }
      
           
            ExecuteClearFieldsCommand(obj);
        }

        private bool CanExecuteProveedorCommand(object obj)
        {
           
            bool validData;
            if (string.IsNullOrEmpty(Correo) || string.IsNullOrEmpty(NombreEmpresa) || string.IsNullOrEmpty(RazonSocial)
                || string.IsNullOrEmpty(direccion)
                || Telefono <= 0)
                validData = false;
            else
                validData = true;
            return validData;
        }
    }
}
