using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.VIewModel
{
    public class UsuariosViewModel
    {
        private readonly UserModel _userModel;
        public int idclientedp => _userModel.idclientedp;
        public string nombres => _userModel.nombres;
        public string apellidomaterno => _userModel.apellidomaterno;
        public string apellidopaterno => _userModel.apellidopaterno;
        public string genero => _userModel.genero;
        public string email => _userModel.email;
        public int telefono1 => _userModel.telefono1;
        public int telefono2 => _userModel.telefono2;
        public UsuariosViewModel(UserModel userModel)
        {
            _userModel = userModel;
        }
    }
}
