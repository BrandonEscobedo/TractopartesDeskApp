using System.Collections.ObjectModel;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Repository
{
    public interface IProductoRepository
    {
        Task AddProducto(ProductoModel productoModel);
        Task< ObservableCollection<ProductoModel>> GetProductos();
    }
}