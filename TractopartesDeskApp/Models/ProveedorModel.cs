using NpgsqlTypes;

namespace TractopartesDeskApp.Models
{
    public class ProveedorModel
    {
        public int idproveedor { get; set; }
        [PgName("nombreempresa")]
        public string nombreempresa { get; set; } = "";
        [PgName("razonsocial")]
        public string razonsocial { get; set; } = "";
        [PgName("telefono")]
        public int telefono { get; set; } = 0;
        [PgName("correo")]
        public string correo { get; set; } = "";
        [PgName("direccion")]
        public string direccion { get; set; } = "";
    }
}
