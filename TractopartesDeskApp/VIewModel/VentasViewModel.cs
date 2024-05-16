using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.VIewModel.Propertys;
using TractopartesDeskApp.Views;

namespace TractopartesDeskApp.VIewModel
{
    public class VentasViewModel:VentasProperty
    {
        ICommand GenerarVentaCommand { get; set; }
        public  ICommand ShowProductosCommand { get; set; }  
        private ProductoModel _productoSeleccionado = new();
        public ProductoModel _productoModel
        {
            get { return _productoSeleccionado; }
            set
            {
                var detalleExistente = DetallesVentaList.FirstOrDefault(x => x.producto.p_idproducto == value.p_idproducto);
              
                if (detalleExistente==null)
                {

                    DetalleVentaModel detalleVenta = new(P_idventaP)
                    {
                        
                        producto=value,
                        cantidad=1,
                        precio_unitario=value.p_precioventa
                    };
                  
                    DetallesVentaList.Add(detalleVenta);
                  
                }
                else
                {

                    DetallesVentaList.Remove(detalleExistente);

                    detalleExistente.cantidad += 1;
                    detalleExistente.precio_unitario = detalleExistente.producto.p_precioventa *
                    detalleExistente.cantidad;
                    DetallesVentaList.Add(detalleExistente);
                }
                DetalleventaModel.producto = value;
                

                OnPropertyChanged(nameof(DetallesVentaList.CollectionChanged));
                OnPropertyChanged(nameof(DetallesVentaList));


            }
        }
        private ObservableCollection<DetalleVentaModel> _detallesVentaList = new();
        public ObservableCollection<DetalleVentaModel> DetallesVentaList
        {
            get => _detallesVentaList;
            set
            {
                if(_detallesVentaList != null)
                {
                    _detallesVentaList = value;
                    OnPropertyChanged(nameof(DetallesVentaList));
                }
            }
        }
        public VentasViewModel()
        {
            ShowProductosCommand = new ViewModelCommand(ExecuteShowWindowCommand);
            GenerarVentaCommand = new ViewModelCommand(ExecuteCommand, CanExecuteCommand);
        }

        private void ExecuteCommand(object obj)
        {
            ventaModel.detalleVentas = DetallesVentaList.ToList();

            throw new NotImplementedException();
        }
        private void ExecuteShowWindowCommand(object obj)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window is ProductosTablaView)
                {
                    window.Focus();
                    return;
                }
            }

            ProductosTablaView productosTablaView = new ProductosTablaView()
            {
                DataContext = this
            };
            productosTablaView.Show();

        }

        private bool CanExecuteCommand(object obj)
        {
            bool resultData;
            if (P_Total <=0 )
                resultData = false;
            else 
                resultData = true;
            return resultData;
        }
    }
}
