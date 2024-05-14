using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractopartesDeskApp.Models
{
    public class VentaModel
    {
        public Guid idventa { get; set; }
        public DateTime fechanventa { get; set; }
        public int idcliente { get; set; }
        public decimal total { get; set; }

        //crear metodo propio o contructor para set la fecha de venta
    }
}
