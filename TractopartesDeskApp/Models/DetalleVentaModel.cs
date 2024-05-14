using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractopartesDeskApp.Models
{
    public class DetalleVentaModel
    {
        public Guid idventa { get; set; }
        public int idproducto { get; set; } 
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
    }
}
