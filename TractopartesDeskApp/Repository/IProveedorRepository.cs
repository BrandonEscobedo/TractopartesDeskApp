using System.Collections.ObjectModel;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Repository
{
    public interface IProveedorRepository
    {
        public Task<int> AddProveedor(ProveedorModel proveedor);
        public Task RemoveProveedor(int idproveedor);
        public Task UpdateProveedor(ProveedorModel proveedor);
        public ObservableCollection<ProveedorModel> GetProveedores();
    }
}
