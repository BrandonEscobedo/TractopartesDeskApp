using System.Collections.ObjectModel;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Repository
{
    public interface IProductoRepository
    {
        Task<int> AddProducto(ProductoModel productoModel);
        Task< ObservableCollection<ProductoModel>> GetProductos();
    }
}