using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Views;
using TractopartesDeskApp.Views.RemoveViews;
namespace TractopartesDeskApp.VIewModel
{
    public class UserByViewModel
    {
        public ICommand ShowWindowCommand { get; }

        public ICommand RemoveWindowCommand { get; }
        public ICommand UpdateByUserCommand { get; }
        public ObservableCollection<UserModel> userModels { get; set; }
        public UserByViewModel()
        {
            userModels = Usermanager.GetUsers();
            ShowWindowCommand = new ViewModelCommand(ExecuteUserCommand, CanExecuteUserCommand);
            RemoveWindowCommand = new ViewModelCommand(RemoveUserCommand, CanExecuteUserCommand);
            UpdateByUserCommand = new ViewModelCommand(UpdateUserCommand, CanExecuteUserCommand);
        }
        private void RemoveUserCommand(object obj)
        {
            UserModel user = (UserModel)obj;
            RemoveClienteView removeClienteView = new();
            removeClienteView.DataContext = new AddUserByViewModel()
            {
                P_apellidomaterno = user.apellidomaterno,
                P_apellidopaterno = user.apellidopaterno,
                P_nombres = user.nombres,
                Telefono1 = user.telefono1,
                Telefono2 = user.telefono2,
                P_genero = user.genero,
                Email = user.email,
                P_idclientedp=user.idclientedp
            };
            removeClienteView.Show();

        }
        private void UpdateUserCommand(object obj)
        {
            UserModel user = (UserModel)obj;
            UsuariosView usuarios = new UsuariosView();
            usuarios.DataContext = new AddUserByViewModel()
            {
                P_apellidomaterno = user.apellidopaterno,
                P_idclientedp = user.idclientedp,
                P_genero = user.genero,
                P_nombres = user.nombres,
                P_apellidopaterno = user.apellidopaterno,
                Telefono1 = user.telefono1,
                Telefono2 = user.telefono2,
                Email = user.email,
                Direccion = user.direccion,
                RFC = user.rfc,
            };

            usuarios.Show();
        }
        private void ExecuteUserCommand(object obj)
        {
            UsuariosView usuarios = new UsuariosView();
            usuarios.DataContext = new AddUserByViewModel();
            usuarios.Show();
        }
        private bool CanExecuteUserCommand(object obj)
        {
            return true;

        }
    }
}
