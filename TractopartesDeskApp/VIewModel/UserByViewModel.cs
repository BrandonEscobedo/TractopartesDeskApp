using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Repository;

namespace TractopartesDeskApp.VIewModel
{
    public class UserByViewModel : UserViewModelPropertys
    {
        private IUserRepository _userRepository;
        public ICommand AddUserCommand { get; }
        public ICommand GetUserCommand { get; }

        public UserByViewModel( )
        {
            _userRepository = new UserRepository();
            Users = _userRepository.GetAllUser();
            AddUserCommand = new ViewModelCommand(ExecuteUserCommand, CanExecuteUserCommand);
        }
        private void ExecuteUserCommand(object obj)
        {
                 _userRepository.AddUser(new UserModel { email=Email,nombres= P_nombres,
                apellidomaterno= P_apellidomaterno,
                apellidopaterno= P_apellidopaterno, genero= P_genero,
                     telefono1= Telefono1,
                     telefono2= Telefono2
                 });
            _users = _userRepository.GetAllUser();
        }
        private bool CanExecuteUserCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(P_nombres) || string.IsNullOrWhiteSpace(P_apellidomaterno) || string.IsNullOrWhiteSpace(P_apellidopaterno) ||
               string.IsNullOrWhiteSpace(P_genero) || Telefono1<=0|| Telefono2<=0 || string.IsNullOrEmpty(Email))   
                validData = false;
            else
                validData = true;
            return validData;
        }
    }
}
