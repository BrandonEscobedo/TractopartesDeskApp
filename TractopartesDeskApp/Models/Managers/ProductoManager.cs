using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.Repository;

namespace TractopartesDeskApp.Models.Managers
{
    public  static class ProductoManager
    {
        public static ObservableCollection<ProductoModel> productos = new ObservableCollection<ProductoModel>();
        private static IProductoRepository _productoRepository;
         static ProductoManager()
        {
            _productoRepository= new ProductoRepository();
            GetProductosRepository();

        }
        public static  ObservableCollection<ProductoModel> GetProductos()
        {
            return productos;
        }
        private static async void GetProductosRepository()
        {
            productos = await _productoRepository.GetProductos();
        }

    }
}
