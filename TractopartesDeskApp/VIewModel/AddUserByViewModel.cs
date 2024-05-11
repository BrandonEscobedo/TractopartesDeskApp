using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Repository;

namespace TractopartesDeskApp.VIewModel
{
    public class AddUserByViewModel : UserViewModelPropertys
    {
        public ICommand AddUserCommand { get; }
        public ICommand UpdateUserCommand { get; }
        private IUserRepository _userRepository;
        public UserModel userModel { get; set; } = new UserModel();
        public ICommand ClearFieldsCommand { get; }

        public AddUserByViewModel()
        {
            _userRepository = new UserRepository();
            ClearFieldsCommand = new ViewModelCommand(ExecuteClearFieldsCommand);
            AddUserCommand = new ViewModelCommand(ExecuteAddUserCommand, CanExecuteUserCommand);
            UpdateUserCommand = new ViewModelCommand(ExecuteUpdateUserCommand, CanExecuteUserCommand);
        }
        private void ExecuteUpdateUserCommand(object obj)
        {
            throw new NotImplementedException();
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
        private void ExecuteAddUserCommand(object obj)
        {
            if (userModel.idclientedp == 0)
            {

            }
            userModel.email = Email;
            userModel.nombres = P_nombres;
            userModel.apellidomaterno = P_apellidomaterno;
            userModel.apellidopaterno = P_apellidopaterno;
            userModel.genero = P_genero;
            userModel.telefono1 = Telefono1;
            userModel.telefono2 = Telefono2;
            _userRepository.AddUser(userModel);
            Usermanager.AddUsers(userModel);
            ExecuteClearFieldsCommand(null);
        }
        e
        private bool CanExecuteUserCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(P_nombres) || string.IsNullOrWhiteSpace(P_apellidomaterno) || string.IsNullOrWhiteSpace(P_apellidopaterno) ||
               string.IsNullOrWhiteSpace(P_genero) || Telefono1 <= 0 || Telefono2 <= 0 || string.IsNullOrEmpty(Email) || !Email.Contains("@"))
                validData = false;
            else
                validData = true;
            return validData;
        }
    }
}
