using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.VIewModel;

namespace TractopartesDeskApp.Models
{
    public class ProductoModel:ViewModelBase
    {

        private int p_cantidad;
        public int _P_cantidad
        {
            get => p_cantidad;
            set
            {
                if (p_cantidad != value)
                {
                    p_cantidad = value;
                    OnPropertyChanged(nameof(_P_cantidad));
                }
            }
        }

        private int p_idproducto;
        public int P_idproducto
        {
            get => p_idproducto;
            set
            {
                if (p_idproducto != value)
                {
                    p_idproducto = value;
                    OnPropertyChanged(nameof(P_idproducto));
                }
            }
        }

        private string p_productonombre = "";
        public string P_productonombre
        {
            get => p_productonombre;
            set
            {
                if (p_productonombre != value)
                {
                    p_productonombre = value;
                    OnPropertyChanged(nameof(P_productonombre));
                }
            }
        }

        private string p_codigopieza = "";
        public string P_codigopieza
        {
            get => p_codigopieza;
            set
            {
                if (p_codigopieza != value)
                {
                    p_codigopieza = value;
                    OnPropertyChanged(nameof(P_codigopieza));
                }
            }
        }

        private string p_descripcion = "";
        public string P_descripcion
        {
            get => p_descripcion;
            set
            {
                if (p_descripcion != value)
                {
                    p_descripcion = value;
                    OnPropertyChanged(nameof(P_descripcion));
                }
            }
        }

        private string p_ImagenURL = "";
        public string P_ImagenURL
        {
            get => p_ImagenURL;
            set
            {
                if (p_ImagenURL != value)
                {
                    p_ImagenURL = value;
                    OnPropertyChanged(nameof(P_ImagenURL));
                }
            }
        }

        private decimal p_precioventa;
        public decimal P_precioventa
        {
            get => p_precioventa;
            set
            {
                if (p_precioventa != value)
                {
                    p_precioventa = value;
                    OnPropertyChanged(nameof(P_precioventa));
                }
            }
        }

        private decimal p_preciocompra;
        public decimal P_preciocompra
        {
            get => p_preciocompra;
            set
            {
                if (p_preciocompra != value)
                {
                    p_preciocompra = value;
                    OnPropertyChanged(nameof(P_preciocompra));
                }
            }
        }

        private bool p_estado = true;
        public bool P_estado
        {
            get => p_estado;
            set
            {
                if (p_estado != value)
                {
                    p_estado = value;
                    OnPropertyChanged(nameof(P_estado));
                }
            }
        }

        private bool estado = false;
        public bool Estado
        {
            get => estado;
            set
            {
                if (estado != value)
                {
                    estado = value;
                    OnPropertyChanged(nameof(Estado));
                }
            }
        }

        private ProveedorModel p_proveedor = new ProveedorModel();
        public ProveedorModel P_proveedor
        {
            get => p_proveedor;
            set
            {
                if (p_proveedor != value)
                {
                    p_proveedor = value;
                    OnPropertyChanged(nameof(P_proveedor));
                }
            }
        }

        private CategoriaModel p_categoria = new CategoriaModel();
        public CategoriaModel P_categoria
        {
            get => p_categoria;
            set
            {
                if (p_categoria != value)
                {
                    p_categoria = value;
                    OnPropertyChanged(nameof(P_categoria));
                }
            }
        }


    }
}
