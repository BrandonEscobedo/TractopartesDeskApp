using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TractopartesDeskApp.Commands;
using TractopartesDeskApp.Data;
using TractopartesDeskApp.Data.UserCommandBd;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.VIewModel
{
    internal class UserByViewModel:ViewModelBase
    {

        private readonly UserBd userBd;
        private ObservableCollection<UserModel> _users;
        private UserModel _user;
        public UserByViewModel( )
        {
            
            _user = new UserModel();

            //_users = _dataAccess.LoadDataAsync()
        }
        public UserModel User
        {
            get => _user;
            set
            {
                if(_user != value)
                {
                    _user = value;
                    OnpropertyChanged(nameof(User));
                }
            }
        }
        public ObservableCollection<UserModel> Users
        {
            get=> _users;
            set
            {

                if (_users != value) 
                {        
                _users = value;
                    OnpropertyChanged(nameof(Users));
                }
            }
        }
        public ICommand command
        {
            get
            {
                return new CommandHandler(AddExecute, AddCanExecute);
            }
        }
        private void AddExecute(object user  )
        {
            userBd.AddUser(User);
        }
        private bool AddCanExecute(object user)
        {
            return true;
        }

    }
}
