using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractopartesDeskApp.Data;
using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Repository
{

    public class ProductoRepository : SqlDataAccess, IProductoRepository
    {

        public  async Task<ObservableCollection<ProductoModel>> GetProductos()
        {
            var sql = @"
    SELECT pr.codigopieza AS p_codigopieza,
           pr.descripcion AS p_descripcion,
           cat.categoria AS categoria,
           prv.nombreempresa AS nombreempresa,
           prv.razonsocial AS razonsocial,
           prv.telefono AS telefono
    FROM productos AS pr
    INNER JOIN categorias AS cat ON pr.idcategoria = cat.idcategoria
    INNER JOIN public.proveedores AS prv ON pr.idprovedor = prv.idproveedor";

            var producto = await LoadDataWithRelations<ProductoModel, CategoriaModel, ProveedorModel>(sql,
                (producto, categoria, proveedor) =>
                {
                    producto.p_categoria = categoria;
                    producto.p_proveedor = proveedor;
                    return producto;
                },
                "categoria,razonsocial");
            return producto;
        }
        public  async Task AddProducto(ProductoModel productoModel)
        {

        }
    }
}
