using System.Windows.Data;
using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Repository;
using TractopartesDeskApp.Views;
namespace TractopartesDeskApp.VIewModel
{
    public class UserByViewModel : UserViewModelPropertys
    {
        private IUserRepository _userRepository;
        public ICommand AddUserCommand { get; }
        public ICommand ClearFieldsCommand { get; }
        public event EventHandler UsersUpdated;

        public UserByViewModel()
        {
            _userRepository = new UserRepository();
            Users = _userRepository.GetAllUser();
            ClearFieldsCommand = new ViewModelCommand(ExecuteClearFieldsCommand);
            AddUserCommand = new ViewModelCommand(ExecuteUserCommand, CanExecuteUserCommand);
           _ClientesCollection = CollectionViewSource.GetDefaultView(_users);
        }
        private void ExecuteClearFieldsCommand(object obj)
        {


            P_nombres = string.Empty;
            P_genero = string.Empty;
            Telefono1 = new int();
            P_apellidomaterno = string.Empty;
            Telefono2 = new int();
            P_apellidopaterno = string.Empty;
            Email = string.Empty;
        }
        private void ExecuteUserCommand(object obj)
        {
            UsuariosView usuarios = new UsuariosView();
            usuarios.Show();

          
            _users = _userRepository.GetAllUser();
            _ClientesCollection = CollectionViewSource.GetDefaultView(_users);
            ExecuteClearFieldsCommand(null);
            UsersUpdated?.Invoke(this, EventArgs.Empty);

        }
        private bool CanExecuteUserCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(P_nombres) || string.IsNullOrWhiteSpace(P_apellidomaterno) || string.IsNullOrWhiteSpace(P_apellidopaterno) ||
               string.IsNullOrWhiteSpace(P_genero) || Telefono1 <= 0 || Telefono2 <= 0 || string.IsNullOrEmpty(Email)|| !Email.Contains("@"))
                validData = false;
            else
                validData = true;
            return validData;
        }

        public static implicit operator string(UserByViewModel v)
        {
            throw new NotImplementedException();
        }
    }
}
