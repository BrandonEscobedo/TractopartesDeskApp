﻿using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.VIewModel.Propertys
{
    public class VentasProperty: ViewModelBase
    {
        public VentaModel ventaModel;
        public VentasProperty()
        {
            ventaModel = new VentaModel();
            DetalleventaModel = new(ventaModel.idventa);
        }

       
        public Guid P_idventaP
        {
            get { return ventaModel.idventa; }
            set
            {
                ventaModel.idventa=value;
                OnPropertyChanged(nameof(P_idventaP));
            }

        }
        public DateTime P_FechaVenta
        {
            get { return ventaModel.fechanventa; }
            set
            {
                ventaModel.fechanventa = value;
                OnPropertyChanged(nameof(P_FechaVenta));
            }
        }
        public int P_idCliente
        {
            get { return ventaModel.idcliente; }
            set
            {
                ventaModel.idcliente = value;
                OnPropertyChanged(nameof(P_idCliente));
            }
        }
        public decimal P_Total
        {
            get { return ventaModel.total; }
            set
            {
                ventaModel.total = value;
                OnPropertyChanged(nameof(P_Total));
            }
        }

        //propiedades DetalleVenta
      public  DetalleVentaModel DetalleventaModel { get; set; }
        public ProductoModel productoModel
        {
            get { return DetalleventaModel.producto; }
            set
            {
                DetalleventaModel.producto = value;
                OnPropertyChanged(nameof(DetalleventaModel));
            }
        }
        public decimal P_PrecioUnitario
        {
            get
            {
                return productoModel.p_precioventa;
            }
            set
            {
                DetalleventaModel.precio_unitario= value;
                OnPropertyChanged(nameof(P_PrecioUnitario));
            }
        }

        public int P_cantdad
        {
            get { return DetalleventaModel.cantidad; }
            set
            {
                DetalleventaModel.cantidad = value;
                OnPropertyChanged(nameof(P_cantdad));
            }
        }
    }
}
