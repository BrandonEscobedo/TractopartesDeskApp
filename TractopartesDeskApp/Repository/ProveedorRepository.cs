using System.Collections.ObjectModel;
using TractopartesDeskApp.Data;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Repository
{
    public class ProveedorRepository :SqlDataAccess, IProveedorRepository
    {

        public async Task<int> AddProveedor(ProveedorModel proveedor)
        {
            var parameters = new
            {
                proveedor.correo,
                proveedor.direccion,
                proveedor.razonsocial,
                proveedor.nombreempresa,
                proveedor.telefono
            };

           return await  ExecuteGenericWithDynamicParameters("CrearProveedor", parameters, "p_new_producto");
      }

      public  ObservableCollection<ProveedorModel> GetProveedores()
        {
          var  proveedores= LoadDataObservable<ProveedorModel>("select* from proveedores");
            return proveedores;
        }
    }
}
