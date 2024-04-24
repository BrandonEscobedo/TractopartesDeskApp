using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractopartesDeskApp.Models
{
    public class UserModel
    {
        [Column("p_nombres")]
        public string p_nombres { get; set; } = "";
        [Column("p_apellidomaterno")]
        public string p_apellidomaterno { get; set; } = "";
        [Column("p_apellidopaterno")]
        public string p_apellidopaterno { get; set; } = "";
        [Column("p_genero")]
        public string p_genero { get; set; } = "";
        public string email { get; set; } = "";
        public int telefono1 { get; set; }
        public int telefono2 { get; set; }


    }
}
