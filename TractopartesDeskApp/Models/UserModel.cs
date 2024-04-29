using NpgsqlTypes;
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
        
        [PgName("nombres")]
        [Column(TypeName = "nombres")]
       
        public string nombres { get; set; } = "";
        [Column("p_apellidomaterno")]
        public string apellidomaterno { get; set; } = "";
        [Column("p_apellidopaterno")]
        public string apellidopaterno { get; set; } = "";
        [Column("p_genero")]
        public string genero { get; set; } = "";
        public string email { get; set; } = "";
        public int telefono1 { get; set; }
        public int telefono2 { get; set; }
    }
}
