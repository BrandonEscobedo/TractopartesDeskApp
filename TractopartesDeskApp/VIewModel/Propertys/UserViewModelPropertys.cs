﻿using System.Collections.ObjectModel;
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
        public ObservableCollection<UserModel> Users;
        public ObservableCollection<UserModel> _users
        {
            get => Users;
            set
            {
                if (Users != value)
                {
                    Users = value;
                    OnPropertyChanged(nameof(_users));
                }
            }
        }
        public string P_nombres
        {
            get { return _userModel.nombres; }
            set
            {
                _userModel.nombres = value;
                OnPropertyChanged(nameof(P_nombres));
            }
        }

        public string P_apellidomaterno
        {
            get { return _userModel.apellidomaterno; }
            set
            {
                _userModel.apellidomaterno = value;
                OnPropertyChanged(nameof(P_apellidomaterno));
            }
        }

        public string P_apellidopaterno
        {
            get { return _userModel.apellidopaterno; }
            set
            {
                _userModel.apellidopaterno = value;
                OnPropertyChanged(nameof(P_apellidopaterno));
            }
        }

        public string P_genero
        {
            get { return _userModel.genero; }
            set
            {
                _userModel.genero = value;
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
