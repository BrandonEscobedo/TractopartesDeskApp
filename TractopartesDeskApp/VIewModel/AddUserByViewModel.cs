using System.Windows;
using System.Windows.Input;
using TractopartesDeskApp.Command;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Repository;
using TractopartesDeskApp.Stores;

namespace TractopartesDeskApp.VIewModel
{
    public class AddUserByViewModel : UserViewModelPropertys
    {
        public ICommand AddUserCommand { get; }
        public ICommand DeleteUserCommand { get; }
        private IUserRepository _userRepository;
        public UserModel userModel { get; set; } = new UserModel();
        private readonly UsuariosStore _usersStore;
        public AddUserByViewModel(UsuariosStore usuariosStore )
        {
            _userRepository = new UserRepository();
            _usersStore= usuariosStore;
            AddUserCommand = new ViewModelCommand(ExecuteAddUserCommand, CanExecuteUserCommand); 
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
                    _usersStore.CreateUser(userModel);
                }
                else
                {                              
                }
             
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
