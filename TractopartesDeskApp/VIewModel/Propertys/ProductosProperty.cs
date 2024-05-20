using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.VIewModel.Propertys
{
    public class ProductosProperty:ViewModelBase
    {
        public ProductoModel ProductoModel { get; set; }
        public ProductosProperty( )
        {
            ProductoModel = new();
          
        }
        public int P_idProducto
        {
            get { return ProductoModel.P_idproducto; }
            set
            {
              ProductoModel.P_idproducto = value;
              OnPropertyChanged(nameof(P_idProducto));
            }
        }
        public string P_CodigoPieza
        {
            get { return ProductoModel.P_codigopieza; }
            set
            {
                ProductoModel.P_codigopieza = value;
                OnPropertyChanged(nameof(P_CodigoPieza));
            }
        }
        public string P_NombreProducto
        {
            get { return ProductoModel.P_productonombre; }
            set
            {
                ProductoModel.P_productonombre = value;
                OnPropertyChanged(nameof(P_NombreProducto));
            }
        }
        public string P_descripcion
        {
            get { return ProductoModel.P_descripcion; }
            set
            {
                ProductoModel.P_descripcion = value;
                OnPropertyChanged(nameof(P_descripcion));
            }
        }
        public ProveedorModel P_ProveedorRazonSocial
        {
            get { return ProductoModel.P_proveedor; }
            set
            {
                ProductoModel.P_proveedor = value;
                OnPropertyChanged(nameof(P_ProveedorRazonSocial));
            }
        }
        public CategoriaModel P_CategoriaNombre
        {
            get { return ProductoModel.P_categoria; }
            set
            {
                ProductoModel.P_categoria = value;
                OnPropertyChanged(nameof(P_CategoriaNombre));
            }
        }

        public int P_cantidad
        {
            get { return ProductoModel._P_cantidad; }
            set
            {
                ProductoModel._P_cantidad = value;
                OnPropertyChanged(nameof(P_cantidad));
            }
        }
        public decimal P_precioVenta
        {
            get { return ProductoModel.P_precioventa; }
            set
            {
                ProductoModel.P_precioventa = value;
                OnPropertyChanged(nameof(P_precioVenta));
            }
        }
        public decimal P_precioCompra
        {
            get { return ProductoModel.P_preciocompra; }
            set
            {
                ProductoModel.P_preciocompra = value;
                OnPropertyChanged(nameof(P_precioCompra));
            }
        }
   
        public string P_ImagenURL
        {
            get { return ProductoModel.P_ImagenURL; }
            set
            {
                ProductoModel.P_ImagenURL = value;
                OnPropertyChanged(nameof(P_ImagenURL));
            }
        }
    }
}
