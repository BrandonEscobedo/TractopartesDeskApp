using System.Collections.ObjectModel;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Repository
{
    public interface IProductoRepository
    {
        Task RemoveProducto(int idproducto);
        Task<bool> UpdateProducto(ProductoModel productoModel);
        Task<int> AddProducto(ProductoModel productoModel);
        Task< ObservableCollection<ProductoModel>> GetProductos();
    }
}