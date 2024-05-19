using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TractopartesDeskApp.Models;
using TractopartesDeskApp.Models.Managers;
using TractopartesDeskApp.Repository;
using TractopartesDeskApp.VIewModel.Propertys;
using TractopartesDeskApp.Views;

namespace TractopartesDeskApp.VIewModel
{
    public class VentasViewModel : VentasProperty
    {
        public ICommand GenerarVentaCommand { get; }
        public ICommand ShowClientesCommand { get; }
        public ICommand RemoveProductoCommand { get; }
        public ICommand ShowProductosCommand { get; }
        private IVentaRepository ventaRepository { get; set; }
        private ProductoModel _productoSeleccionado = new();
        public ProductoModel _productoModel
        {

            get { return _productoSeleccionado; }
            set
            {
                var detalleExistente = DetallesVentaList.FirstOrDefault(x => x.producto.p_idproducto == value.p_idproducto);

                if (detalleExistente == null)
                {

                    DetalleVentaModel detalleVenta = new(P_idventaP)
                    {

                        producto = value,
                        cantidad = 1,
                        precioNeto = value.p_precioventa
                    };
                    P_Total += detalleVenta.precioNeto;
                    DetallesVentaList.Add(detalleVenta);

                }
                else
                {

                    detalleExistente.cantidad += 1;
                    detalleExistente.P_precio_Total = detalleExistente.producto.p_precioventa *
                    detalleExistente.cantidad;
                    P_Total += detalleExistente.producto.p_precioventa;
                }

                OnPropertyChanged(nameof(DetallesVentaList));
                OnPropertyChanged(nameof(P_Total));

            }
        }
        private ObservableCollection<ProductoModel> _productos = new();
        public ObservableCollection<ProductoModel> Productos
        {
            get => _productos;
            set
            {
                if (_productos != value)
                {
                    _productos = value;
                    OnPropertyChanged(nameof(Productos));
                }
            }
        }
        private ObservableCollection<DetalleVentaModel> _detallesVentaList = new();
        public ObservableCollection<DetalleVentaModel> DetallesVentaList
        {
            get => _detallesVentaList;
            set
            {
                if (_detallesVentaList != null)
                {
                    _detallesVentaList = value;
                    OnPropertyChanged(nameof(DetallesVentaList));
                }
            }
        }
        public VentasViewModel()
        {
            ventaRepository = new VentasRepository();
            _productos = ProductoManager.productos;
            ShowClientesCommand = new ViewModelCommand(ExecuteShowClientesCommand);
            RemoveProductoCommand = new ViewModelCommand(ExecuteRemoveCommand);
            ShowProductosCommand = new ViewModelCommand(ExecuteShowWindowCommand);
            GenerarVentaCommand = new ViewModelCommand(ExecuteCommand, CanExecuteCommand);
        }


        private void ExecuteRemoveCommand(object obj)
        {
            ProductoModel producto = (ProductoModel)obj;
            if (producto != null)
            {
                var detalleProducto = DetallesVentaList.FirstOrDefault(x => x.producto.p_idproducto == producto.p_idproducto);
                if (detalleProducto != null)
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        detalleProducto.cantidad -= 1;
                        detalleProducto.P_precio_Total = detalleProducto.P_precio_Total - detalleProducto.producto.p_precioventa;
                        P_Total -= detalleProducto.producto.p_precioventa;
                    });
                    if (detalleProducto.cantidad == 0)
                    {
                        DetallesVentaList.Remove(detalleProducto);
                    }
                }
            }
        }
        private async void ExecuteCommand(object obj)
        {
            ventaModel.detalleVentas = DetallesVentaList.ToList();

            var result = await ventaRepository.GenerarVenta(ventaModel);
            if (result)
            {

                await ProductoManager.GetProductosRepositoryAsync();
                Application.Current.Dispatcher.Invoke(() =>
                {
                  
                    ventaModel = new();
                    DetallesVentaList.Clear();
                    P_Total = 0;
                    P_Cliente = new();

                });
            }
        }
        private void ExecuteShowClientesCommand(object obj)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window is ClientesTablaView clientesView)
                {
                    if (window.WindowState == WindowState.Minimized)
                    {
                        // Restaurar la ventana si está minimizada
                        window.WindowState = WindowState.Normal;
                    }

                    // Enfocar la ventana si no tiene el enfoque
                    if (!window.IsActive)
                    {
                        window.Activate();
                    }

                    return;
                }
            }
            //agregar txt para buscar en clientes y productos
            // Si no se encuentra una instancia existente, crear una nueva y mostrarla
            ClientesTablaView clientesTablaView = new ClientesTablaView()
            {
                DataContext = this
            };
            clientesTablaView.Show();
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
            if (P_Total <= 0)
                resultData = false;
            else
                resultData = true;
            return resultData;
        }
    }
}
