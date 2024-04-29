using TractopartesDeskApp.Data;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Repository
{
    public class ProveedorRepository :SqlDataAccess, IProveedorRepository
    {
        public async void AddProveedor(ProveedorModel proveedor)
        {
              await  SaveData("CrearProveedor", proveedor);
      }
    }
}
