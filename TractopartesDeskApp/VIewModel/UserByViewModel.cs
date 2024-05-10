using System.Collections.ObjectModel;
using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Views;
namespace TractopartesDeskApp.VIewModel
{
    public class UserByViewModel 
    {
        public ICommand ShowWindowCommand { get; }
        public ICommand UpdateByUserCommand { get; }
        public ObservableCollection<UserModel> userModels { get; set; }

        public UserByViewModel()
        {
            userModels = Usermanager.GetUsers();
            ShowWindowCommand = new ViewModelCommand(ExecuteUserCommand, CanExecuteUserCommand);
            UpdateByUserCommand = new ViewModelCommand(UpdateUserCommand, CanExecuteUserCommand);
        }
        private void UpdateUserCommand(object obj)
        {
            UserModel user = (UserModel)obj;
            UsuariosView usuarios = new UsuariosView();
            usuarios.DataContext = new AddUserByViewModel()
            { P_apellidomaterno=user.apellidopaterno,
            
            P_genero=user.genero,
            P_nombres=user.nombres,
            P_apellidopaterno=user.apellidopaterno,
            Telefono1=user.telefono1,
            Telefono2=user.telefono2,
            Email=user.email,
           }
            ;
            usuarios.Show();

        }
        private void ExecuteUserCommand(object obj)
        {
            UsuariosView usuarios = new UsuariosView();
            usuarios.DataContext = new UserByViewModel();
            usuarios.Show();

        }
        private bool CanExecuteUserCommand(object obj)
        {
            return true;
          
        }

        
    }
}
