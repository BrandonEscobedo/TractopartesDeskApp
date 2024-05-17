using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace TractopartesDeskApp.Models
{
    public class UsuariosModel
    {
        public int idusuario { get; set; }
        public string nombre_usuario { get; set; } = "";
        public string password { get; set; } = "";
        private string nombres { get; set; } = "";
        private string apellidos { get; set; } = string.Empty;
        private string email { get; set; } = string.Empty;
    }
}
