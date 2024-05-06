using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Repository;
namespace TractopartesDeskApp.VIewModel
{
    public class UserByViewModel : UserViewModelPropertys
    {
        private IUserRepository _userRepository;
        public ICommand AddUserCommand { get; }
        public ICommand ClearFieldsCommand { get; }
        public UserByViewModel()
        {
            _userRepository = new UserRepository();
            Users = _userRepository.GetAllUser();
            ClearFieldsCommand = new ViewModelCommand(ExecuteClearFieldsCommand);
            AddUserCommand = new ViewModelCommand(ExecuteUserCommand, CanExecuteUserCommand);
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
            _userRepository.AddUser(new UserModel
            {
                email = Email,
                nombres = P_nombres,
                apellidomaterno = P_apellidomaterno,
                apellidopaterno = P_apellidopaterno,
                genero = P_genero,
                telefono1 = Telefono1,
                telefono2 = Telefono2
            });
            _users = _userRepository.GetAllUser();
            ExecuteClearFieldsCommand(null);
        }
        private bool CanExecuteUserCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(P_nombres) || string.IsNullOrWhiteSpace(P_apellidomaterno) || string.IsNullOrWhiteSpace(P_apellidopaterno) ||
               string.IsNullOrWhiteSpace(P_genero) || Telefono1 <= 0 || Telefono2 <= 0 || string.IsNullOrEmpty(Email))
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
