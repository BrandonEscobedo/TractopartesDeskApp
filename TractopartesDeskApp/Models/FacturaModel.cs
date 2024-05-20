using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractopartesDeskApp.Models
{
    public class FacturaModel
    {
        public Guid idventa { get; set; }
        public List<ProductoModel> Productos { get; set; } = new();    
        public UserModel userModel { get; set; }=new();
        public decimal Total { get; set; }
        public DateTime FechaVenta { get; set; }
    }
}
