using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.VIewModel.Propertys
{
    public class ProveedorViewModelPropertys:ViewModelBase
    {
       private ProveedorModel _proveedorModel;

        public ProveedorViewModelPropertys()
        {
            _proveedorModel = new ProveedorModel();
        }

        public string NombreEmpresa
        {
            get { return _proveedorModel.NombreEmpresa; }
            set
            {
                _proveedorModel.NombreEmpresa = value;
                OnPropertyChanged(nameof(NombreEmpresa));
            }
        }

        public string RazonSocial
        {
            get { return _proveedorModel.RazonSocial; }
            set
            {
                _proveedorModel.RazonSocial = value;
                OnPropertyChanged(nameof(RazonSocial));
            }
        }


        public string Correo
        {
            get { return _proveedorModel.Correo; }
            set
            {
                _proveedorModel.Correo = value;
                OnPropertyChanged(nameof(Correo));
            }
        }

        public int Telefono
        {
            get { return _proveedorModel.Telefono; }
            set
            {
                _proveedorModel.Telefono = value;
                OnPropertyChanged(nameof(Telefono));
            }
        }


    }
}
