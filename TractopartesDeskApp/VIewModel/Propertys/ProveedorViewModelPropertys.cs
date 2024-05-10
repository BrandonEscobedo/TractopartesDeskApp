using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        //public ObservableCollection<ProveedorModel> Proveedores;
        //public ObservableCollection<ProveedorModel> _proveedores
        //{
        //    get => Proveedores;
        //    set
        //    {
        //        if(Proveedores!= value)
        //        {
        //            Proveedores = value;
        //            OnPropertyChanged(nameof(_proveedores));
        //        }
        //    }
        //}
        public string NombreEmpresa
        {
            get { return _proveedorModel.nombreempresa; }
            set
            {
                _proveedorModel.nombreempresa = value;
                OnPropertyChanged(nameof(NombreEmpresa));
            }
        }

        public string RazonSocial
        {
            get { return _proveedorModel.razonsocial; }
            set
            {
                _proveedorModel.razonsocial = value;
                OnPropertyChanged(nameof(RazonSocial));
            }
        }


        public string Correo
        {
            get { return _proveedorModel.correo; }
            set
            {
                _proveedorModel.correo = value;
                OnPropertyChanged(nameof(Correo));
            }
        }

        public int Telefono
        {
            get { return _proveedorModel.telefono; }
            set
            {
                _proveedorModel.telefono = value;
                OnPropertyChanged(nameof(Telefono));
            }
        }
        public string direccion
        {
            get
            {
                return _proveedorModel.direccion;
            }
            set
            {
                _proveedorModel.direccion = value;
                OnPropertyChanged(nameof(direccion));
            }
        }



    }
}
