using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TractopartesDeskApp.Repository;

namespace TractopartesDeskApp.VIewModel
{

    public class LoginViewModel : ViewModelBase
    {

        public string nombreUsuario;
        public SecureString Password;
        public string ErrorMessage;
        public bool Isvisible = true;
        public string P_NombreUsuario
        {
            get { return nombreUsuario; }
            set
            {
                nombreUsuario = value;
                OnPropertyChanged(nameof(P_NombreUsuario));
            }
        }
        public SecureString P_Paswword
        {
            get { return Password; }
            set
            {
                Password = value;
                OnPropertyChanged(nameof(P_Paswword));
            }
        }
        public string P_ErrorMessage
        {
            get { return ErrorMessage; }
            set
            {
                ErrorMessage = value;
                OnPropertyChanged(nameof(P_ErrorMessage));
            }
        }
        public bool P_IsVisible
        {
            get { return Isvisible; }
            set
            {
                Isvisible = value;
                OnPropertyChanged(nameof(P_IsVisible));
            }
        }
        public ICommand LoginCommand { get; }
        public ICommand ShowPassWordCommand { get; }
        public ILoginRepository loginRepository;
        public LoginViewModel()
        {
            loginRepository = new LoginRepository();
            LoginCommand = new ViewModelCommand(ExecuteLogincommand, CanExecuteLoginCommand);
            ShowPassWordCommand = new ViewModelCommand(ExecuteShowPasscommand, CanExecuteShowPassCommand);
        }

        private void ExecuteShowPasscommand(object obj)
        {
            throw new NotImplementedException();
        }

        private bool CanExecuteShowPassCommand(object obj)
        {
            throw new NotImplementedException();
        }

        private async void ExecuteLogincommand(object obj)
        {

            var result =await
                loginRepository.AuthenticateUser(new System.Net.NetworkCredential(P_NombreUsuario, P_Paswword));
            if (result)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(
                    new GenericIdentity(P_NombreUsuario), null);
                P_IsVisible = false;
            }
            else
            {
                P_ErrorMessage = "Nombre de usuario o contraseña incorecto";
            }
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrEmpty(P_NombreUsuario) || P_Paswword==null) 
                validData=false;
            else validData=true;
            return validData;
        }
    }
}
