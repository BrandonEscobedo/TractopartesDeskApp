using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractopartesDeskApp.Models
{
    public class ProductoModel
    {

        public int p_idproducto { get; set; }
        public string p_productonombre { get; set; } = "";
        public string p_codigopieza { get; set; } = "";
        public string p_descripcion { get; set; } = "";
        public string p_ImagenURL { get; set; } = "";
        public decimal p_precioventa { get; set; }
        public decimal  p_preciocompra { get; set; }
        public bool p_estado { get; set; } = true; 
        public int p_cantidad { get; set; }
        public ProveedorModel p_proveedor { get; set; } = new();
        public CategoriaModel p_categoria { get; set; } = new();
       
    }
}
