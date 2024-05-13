using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Repository;
using TractopartesDeskApp.Stores;
using TractopartesDeskApp.VIewModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TractopartesDeskApp.Command
{
    public class UserCommand: CommandBase
    {
        private readonly AddUserByViewModel viewModel;
        private readonly UsuariosStore usuariosStore;
        private readonly IUserRepository _usuariosRepository;
        public UserModel userModel { get; set; } = new UserModel();


        public UserCommand(AddUserByViewModel viewModel, UsuariosStore usuariosStore,Predicate<object> canExecuteAction)
        {
            _usuariosRepository = new UserRepository();
            this.viewModel = viewModel;
            this.usuariosStore = usuariosStore;
        }
        public override bool CanExecute(object parameter)
        {
            bool resultdata;
            if (string.IsNullOrEmpty(viewModel.Email))
                resultdata = false;
            else
                resultdata = true;
            return resultdata;
        }
        public  async override void Execute(object parameter)
        {
            {
                userModel.email = viewModel.Email;
                userModel.nombres = viewModel.P_nombres;
                userModel.apellidomaterno = viewModel.P_apellidomaterno;
                userModel.apellidopaterno = viewModel.P_apellidopaterno;
                userModel.genero = viewModel.P_genero;
                userModel.telefono1 = viewModel.Telefono1;
                userModel.telefono2 = viewModel.Telefono2;
                userModel.idclientedp = viewModel.P_idclientedp;
            }
            await _usuariosRepository.AddUser(userModel);
            usuariosStore.CreateUser(userModel);

        }
    }
}
