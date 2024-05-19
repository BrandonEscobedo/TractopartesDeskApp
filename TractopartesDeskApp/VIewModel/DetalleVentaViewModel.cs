using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.VIewModel
{
    public class DetalleVentaViewModel : ViewModelBase
    {
        public Guid p_idventa;
        public ProductoModel P_producto;
        public decimal P_precioNeto;
        public int P_cantidad;
        public ProductoModel Productomodel
        {
            get => P_producto;
            set
            {
                if (P_producto != value)
                {
                    P_producto = value;
                    OnPropertyChanged(nameof(p_idventa));
                }
            }
        }
        public Guid Idventa
        {
            get => p_idventa;
            set
            {
                if(p_idventa != value)
                {
                    p_idventa = value;
                    OnPropertyChanged(nameof(Idventa));
                }
            }
        }
        public int cantidad
        {
            get => P_cantidad;
            set
            {
                if (P_cantidad != value)
                {
                    P_cantidad = value;
                    OnPropertyChanged(nameof(cantidad));
                }
            }
        }
        public decimal Precio_neto
        {
            get => P_precioNeto;
            set
            {
                if (P_precioNeto != value)
                {
                    P_precioNeto = value;
                    OnPropertyChanged(nameof(Precio_neto));
                }
            }
        }



    }
}
