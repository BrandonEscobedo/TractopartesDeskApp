using System.ComponentModel;
using TractopartesDeskApp.VIewModel;

namespace TractopartesDeskApp.Models
{
    public class DetalleVentaModel:ViewModelBase
    {
        public Guid idventa { get; set; }
        public ProductoModel producto { get; set; } = new();
        public int P_cantidad;
        public int cantidad
        {
            get => P_cantidad;
            set {
           if(P_cantidad != value)
                {
                    P_cantidad = value;
                    OnPropertyChanged(nameof(cantidad));
                }            
            }
        }
        public decimal P_precio_Total
        {
            get => precioNeto;
            set
            {
                if(precioNeto != value)
                {
                    precioNeto = value;
                    OnPropertyChanged(nameof(P_precio_Total));
                }
            }
        }
        public decimal precioNeto { get; set; }
        public DetalleVentaModel(Guid Id)
        {
            idventa=Id;          
        }
    }
}
