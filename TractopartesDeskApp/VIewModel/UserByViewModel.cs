using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Repository;
using TractopartesDeskApp.Stores;
using TractopartesDeskApp.Views;
using TractopartesDeskApp.Views.RemoveViews;
namespace TractopartesDeskApp.VIewModel
{
    public class UserByViewModel:ViewModelBase
    {
        public ICommand ShowWindowCommand { get; }
        public ICommand RemoveWindowCommand { get; }
        public ICommand UpdateByUserCommand { get; }
        public ObservableCollection<UserModel> _userModels;
        private readonly UsuariosStore _usuariosStore;
        private readonly IUserRepository userRepository;
        private ObservableCollection<UserModel> Users;
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
        public   UserByViewModel(UsuariosStore usuariosStore)
        {
            userRepository = new UserRepository();
            Users = userRepository.GetAllUser();
            ShowWindowCommand = new ViewModelCommand(ExecuteUserCommand, CanExecuteUserCommand);
            RemoveWindowCommand = new ViewModelCommand(RemoveUserCommand, CanExecuteUserCommand);
            UpdateByUserCommand = new ViewModelCommand(UpdateUserCommand, CanExecuteUserCommand);
            _usuariosStore = usuariosStore;
            _usuariosStore.UserCreated += OnProductCreated;
        }

        private  void OnProductCreated(UserModel model)
        {
           
            var users= userRepository.GetAllUser();
             _users.Add( users.Last());
        }
        private void RemoveUserCommand(object obj)
        {
            UserModel user = (UserModel)obj;
            RemoveClienteView removeClienteView = new();
          
            removeClienteView.Show();

        }
        private void UpdateUserCommand(object obj)
        {
            UserModel user = (UserModel)obj;
            UsuariosView usuarios = new UsuariosView();
            usuarios.Show();
        }

        private void ExecuteUserCommand(object obj)
        {
            AddUserByViewModel data = (AddUserByViewModel)obj;
            UsuariosView usuarios = new UsuariosView()
            {
                DataContext = data
            };
            usuarios.Show();
        }
        private bool CanExecuteUserCommand(object obj)
        {
            return true;

        }
    }
}
