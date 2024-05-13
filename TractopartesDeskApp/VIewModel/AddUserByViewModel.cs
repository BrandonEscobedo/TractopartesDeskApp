using System.Windows;
using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Repository;

namespace TractopartesDeskApp.VIewModel
{
    public class AddUserByViewModel : UserViewModelPropertys
    {
        public ICommand AddUserCommand { get; }
        public ICommand DeleteUserCommand { get; }
        private IUserRepository _userRepository;
        public UserModel userModel { get; set; } = new UserModel();

        public AddUserByViewModel()
        {
            _userRepository = new UserRepository();
            AddUserCommand = new ViewModelCommand(ExecuteAddUserCommand, CanExecuteUserCommand);
            DeleteUserCommand = new ViewModelCommand(ExecuteDeleteUserCommand);
            
        }
        private void ExecuteDeleteUserCommand(object obj)
        {
            if (P_idclientedp != 0)
                _userRepository.RemoveUser(P_idclientedp);
            Usermanager.RemoveUserList(P_idclientedp);
            CloseWindow();
        }
        private void CloseWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.DataContext == this)
                {
                    window.Close();
                    break;
                }
            }
        }

        private void ExecuteClearFieldsCommand( )
        {
            P_nombres = string.Empty;
            P_genero = string.Empty;
            Telefono1 = new int();
            P_apellidomaterno = string.Empty;
            Telefono2 = new int();
            P_apellidopaterno = string.Empty;
            Email = string.Empty;
        }
        private async void ExecuteAddUserCommand(object obj)
        {
            try
            {
                userModel.email = Email;
                userModel.nombres = P_nombres;
                userModel.apellidomaterno = P_apellidomaterno;
                userModel.apellidopaterno = P_apellidopaterno;
                userModel.genero = P_genero;
                userModel.telefono1 = Telefono1;
                userModel.telefono2 = Telefono2;
                userModel.idclientedp = P_idclientedp;
                if (userModel.idclientedp == 0)
                {
                    var result = await _userRepository.AddUser(userModel);
                    userModel.idclientedp = result;
                    Usermanager.AddUsers(userModel);
                }
                else
                {
                    _userRepository.UpdateUser(userModel);
                    Usermanager.UpdateUserList(userModel);
                }
                ExecuteClearFieldsCommand();
            }
            catch (Exception)
            {

                throw;
            }



        }

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
