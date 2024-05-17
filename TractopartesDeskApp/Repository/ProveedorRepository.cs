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

        public async Task RemoveProveedor(int idproveedor)
        {

            await ExecuteGenericScalar("delete  from proveedores where idproveedor=@Idproveedor", new {IdProveedor= idproveedor });
        }

        public  async Task UpdateProveedor(ProveedorModel proveedor)
        {
            var parameters = new
            {
                p_idproveedor = proveedor.idproveedor,
                p_nombreempresa = proveedor.nombreempresa,
                p_razonsocial = proveedor.razonsocial,
                p_telefono = proveedor.telefono,
                p_correo = proveedor.correo,
                p_direccion = proveedor.direccion,
            };
            await ExecuteGeneric("SP_UpdateProveedor", parameters);

        }
    }
}
