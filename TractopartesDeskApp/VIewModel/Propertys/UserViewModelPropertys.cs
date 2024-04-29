using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.VIewModel
{
    public class UserViewModelPropertys : ViewModelBase
    {
        private UserModel _userModel;

        public UserViewModelPropertys()
        {
            _userModel = new UserModel();
        }

        public string P_nombres
        {
            get { return _userModel.p_nombres; }
            set
            {
                _userModel.p_nombres = value;
                OnPropertyChanged(nameof(P_nombres));
            }
        }

        public string P_apellidomaterno
        {
            get { return _userModel.p_apellidomaterno; }
            set
            {
                _userModel.p_apellidomaterno = value;
                OnPropertyChanged(nameof(P_apellidomaterno));
            }
        }

        public string P_apellidopaterno
        {
            get { return _userModel.p_apellidopaterno; }
            set
            {
                _userModel.p_apellidopaterno = value;
                OnPropertyChanged(nameof(P_apellidopaterno));
            }
        }

        public string P_genero
        {
            get { return _userModel.p_genero; }
            set
            {
                _userModel.p_genero = value;
                OnPropertyChanged(nameof(P_genero));
            }
        }

        public string Email
        {
            get { return _userModel.email; }
            set
            {
                _userModel.email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public int Telefono1
        {
            get { return _userModel.telefono1; }
            set
            {
                _userModel.telefono1 = value;
                OnPropertyChanged(nameof(Telefono1));
            }
        }

        public int Telefono2
        {
            get { return _userModel.telefono2; }
            set
            {
                _userModel.telefono2 = value;
                OnPropertyChanged(nameof(Telefono2));
            }
        }

    }
}
