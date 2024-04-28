using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TractopartesDeskApp.Repository;

namespace TractopartesDeskApp.VIewModel
{
    public class UserViewModelPropertys:ViewModelBase
    {
        internal string _p_nombres;
        internal string _p_apellidomaterno;
        internal string _p_apellidopaterno;
        internal string _p_genero;
        internal string _email;
        internal int _telefono1;
        internal int _telefono2;
        public string P_nombres
        {
            get
            {
                return _p_nombres;
            }
            set
            {
                _p_nombres = value;
                OnPropertyChanged(nameof(P_nombres));
            }
        }
        public string P_apellidomaterno
        {
            get
            {
                return _p_apellidomaterno;
            }
            set
            {
                _p_apellidomaterno = value;
                OnPropertyChanged(nameof(P_apellidomaterno));

            }
        }
        public string P_apellidopaterno
        {
            get
            {
                return _p_apellidopaterno;
            }
            set
            {
                _p_apellidopaterno = value;
                OnPropertyChanged(nameof(P_apellidopaterno));

            }
        }
        public string P_genero
        {
            get
            {
                return _p_genero;
            }
            set
            {
                _p_genero = value;
                OnPropertyChanged(nameof(P_genero));

            }
        }
        public string P_email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(P_email));

            }
        }

        public int P_telefono1
        {
            get
            {
                return _telefono1;
            }
            set
            {
                _telefono1 = value;
                OnPropertyChanged(nameof(P_telefono1));

            }
        }
        public int P_telefono2
        {
            get
            {
                return _telefono2;
            }
            set
            {
                _telefono2 = value;
                OnPropertyChanged(nameof(P_telefono2));

            }
        }
    }
}
