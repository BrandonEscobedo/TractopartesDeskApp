﻿using System.Collections.ObjectModel;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Repository
{
    public interface IProveedorRepository
    {
        public void AddProveedor(ProveedorModel proveedor);
        public ObservableCollection<ProveedorModel> GetProveedores();
    }
}
