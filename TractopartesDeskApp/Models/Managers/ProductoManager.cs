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
         static IProductoRepository _productoRepository;
          static ProductoManager()
        {
            _productoRepository= new ProductoRepository();
            GetProductosRepository();
        }
        public static  async Task<ObservableCollection<ProductoModel>> GetProductos()
        {
         await GetProductosRepositoryAsync();
            return productos;
        }
        public static void AddProducto(ProductoModel productoModel)
        {
            productos.Add(productoModel);

        }
        public static void RemoveProducto(int idproducto)
        {
            var producto = productos.FirstOrDefault(x => x.p_idproducto == idproducto);
            if (producto != null)
            {
                productos.Remove(producto);
            }
        }
        public static void UpdateProducto(ProductoModel productoModel)
        {
            var producto= productos.FirstOrDefault(x=>x.p_idproducto==productoModel.p_idproducto);  
            if(producto != null)
            {
                productos.Remove(producto);
                productos.Add(producto);
            }
        }
        public static async Task GetProductosRepositoryAsync()
        {
           
            productos = await _productoRepository.GetProductos();
        }
        public static async void GetProductosRepository()
        {

            productos = await _productoRepository.GetProductos();
        }

    }
}
