using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Repository;
using TractopartesDeskApp.VIewModel.Propertys;

namespace TractopartesDeskApp.VIewModel
{
    public class ProveedorByViewModel:ProveedorViewModelPropertys
    {
        public ICommand AddProveedorCommand { get; }
        public ICommand GetProveedorCommand { get; }
        public IProveedorRepository _proveedorRepository;
        public ProveedorByViewModel()
        {
            _proveedorRepository = new ProveedorRepository();
            Proveedores = _proveedorRepository.GetProveedores();

            AddProveedorCommand = new ViewModelCommand(ExecuteProveedorCommand, CanExecuteProveedorCommand);
        }
        private void ExecuteProveedorCommand(object obj)
        {
            _proveedorRepository.AddProveedor(new ProveedorModel
            {
                correo = Correo,
                nombreempresa = NombreEmpresa,
                telefono = Telefono,
                razonsocial = RazonSocial            
            });
            _proveedores = _proveedorRepository.GetProveedores();
        }

        private bool CanExecuteProveedorCommand(object obj)
        {
            return true;
            //bool validData;
            //if (string.IsNullOrWhiteSpace(Correo) || string.IsNullOrWhiteSpace(NombreEmpresa) || string.IsNullOrWhiteSpace(RazonSocial) 
            //    || string.IsNullOrWhiteSpace(direccion)
            //    || Telefono <= 0)
            //    validData = false;
            //else
            //    validData = true;
            //return validData;
        }
    }
}
