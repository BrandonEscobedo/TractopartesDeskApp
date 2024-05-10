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
