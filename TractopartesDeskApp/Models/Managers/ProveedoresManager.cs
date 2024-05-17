using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.Repository;

namespace TractopartesDeskApp.Models.Managers
{
    public static class ProveedoresManager
    {
        public static ObservableCollection<ProveedorModel> proveedorModels = new();
        static ProveedoresManager()
        {
            ProveedorRepository proveedorRepository = new();

            proveedorModels = proveedorRepository.GetProveedores();

        }
        public static void UpdateProveedor(ProveedorModel proveedor)
        {
            var proveedorm = proveedorModels.FirstOrDefault(x => x.idproveedor ==proveedor.idproveedor);
            if(proveedorm != null)
            {
                proveedorModels.Remove(proveedorm);
                proveedorModels.Add(proveedor);
            }
        }
        public static void RemoveProveedor(int idproveedor)
        {
            var proveedor= proveedorModels.Where(x=>x.idproveedor==idproveedor).FirstOrDefault();
            if(proveedor!=null)
            {
                proveedorModels.Remove(proveedor);
            }
        }
        public static ObservableCollection<ProveedorModel> GetProveedores()
        {
            return proveedorModels;
        }
        public static void AddPrveedor(ProveedorModel proveedor)
        {
            proveedorModels.Add(proveedor);
        }
    }
}
