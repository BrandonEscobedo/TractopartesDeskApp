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
            var producto = productos.FirstOrDefault(x => x.P_idproducto == idproducto);
            if (producto != null)
            {
                productos.Remove(producto);
            }
        }
        public static void UpdateProducto(ProductoModel productoModel )
        {
            var item = productos.FirstOrDefault(x => x.P_idproducto == productoModel.P_idproducto);
            if(item != null)
            {
                item._P_cantidad = productoModel._P_cantidad;
                item.P_precioventa = productoModel.P_precioventa;
                item.P_preciocompra = productoModel.P_preciocompra;
                item.P_proveedor = productoModel.P_proveedor;
                item.Estado = productoModel.Estado;
                item.P_categoria = productoModel.P_categoria;
                item.P_productonombre = productoModel.P_productonombre;
                item.P_descripcion = productoModel.P_descripcion;
                item.P_ImagenURL = productoModel.P_ImagenURL;
                item. P_codigopieza= productoModel.P_codigopieza;
            }

          
        }
        public static async Task GetProductosRepositoryAsync()
        {
           
            productos = await _productoRepository.GetAllProductos();
        }
        public static async void GetProductosRepository()
        {

            productos = await _productoRepository.GetAllProductos();
        }

    }
}
