using NpgsqlTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace TractopartesDeskApp.Models
{
    public class UserModel
    {
        public int idclientedp { get; set; }
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
        public string direccion { get; set; } = "";
        public string rfc { get; set; }= "";
    }
}
