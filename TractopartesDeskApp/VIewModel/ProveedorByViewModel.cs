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
            AddProveedorCommand = new ViewModelCommand(ExecuteProveedorCommand, CanExecuteProveedorCommand);
        }
        private void ExecuteProveedorCommand(object obj)
        {
            _proveedorRepository.AddProveedor(new ProveedorModel
            {
                Correo = Correo,
                NombreEmpresa = NombreEmpresa,
                Telefono = Telefono,
                RazonSocial = RazonSocial            
            });
        }

        private bool CanExecuteProveedorCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(Correo) || string.IsNullOrWhiteSpace(NombreEmpresa) || string.IsNullOrWhiteSpace(RazonSocial) 
                || Telefono <= 0)
                validData = false;
            else
                validData = true;
            return validData;
        }
    }
}
