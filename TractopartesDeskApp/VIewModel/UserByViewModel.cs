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
            AddUserCommand = new ViewModelCommand(ExecuteUserCommand, CanExecuteUserCommand);
        }
        private void ExecuteUserCommand(object obj)
        {
                 _userRepository.AddUser(new UserModel { email=_email,p_nombres=_p_nombres,
                p_apellidomaterno=_p_apellidomaterno,
                p_apellidopaterno=_p_apellidopaterno, p_genero=_p_genero,telefono1=_telefono1,telefono2=_telefono2});
        }

        private bool CanExecuteUserCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(_p_nombres) || string.IsNullOrWhiteSpace(_p_apellidomaterno) || string.IsNullOrWhiteSpace(_p_apellidopaterno) ||
               string.IsNullOrWhiteSpace(_p_genero) )
                validData = false;
            else
                validData = true;
            return validData;
        }
    }
}
