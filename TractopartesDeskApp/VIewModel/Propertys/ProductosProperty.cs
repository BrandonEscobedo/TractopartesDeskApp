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
            get { return ProductoModel.p_idproducto; }
            set
            {
              ProductoModel.p_idproducto = value;
              OnPropertyChanged(nameof(P_idProducto));
            }
        }
        public string P_CodigoPieza
        {
            get { return ProductoModel.p_codigopieza; }
            set
            {
                ProductoModel.p_codigopieza = value;
                OnPropertyChanged(nameof(P_CodigoPieza));
            }
        }
        public string P_NombreProducto
        {
            get { return ProductoModel.p_productonombre; }
            set
            {
                ProductoModel.p_productonombre = value;
                OnPropertyChanged(nameof(P_NombreProducto));
            }
        }
        public string P_descripcion
        {
            get { return ProductoModel.p_descripcion; }
            set
            {
                ProductoModel.p_descripcion = value;
                OnPropertyChanged(nameof(P_descripcion));
            }
        }
        public ProveedorModel P_ProveedorRazonSocial
        {
            get { return ProductoModel.p_proveedor; }
            set
            {
                ProductoModel.p_proveedor = value;
                OnPropertyChanged(nameof(P_ProveedorRazonSocial));
            }
        }
        public CategoriaModel P_CategoriaNombre
        {
            get { return ProductoModel.p_categoria; }
            set
            {
                ProductoModel.p_categoria = value;
                OnPropertyChanged(nameof(P_CategoriaNombre));
            }
        }

        public int P_cantidad
        {
            get { return ProductoModel.p_cantidad; }
            set
            {
                ProductoModel.p_cantidad = value;
                OnPropertyChanged(nameof(P_cantidad));
            }
        }
        public decimal P_precioVenta
        {
            get { return ProductoModel.p_precioventa; }
            set
            {
                ProductoModel.p_precioventa = value;
                OnPropertyChanged(nameof(P_precioVenta));
            }
        }
        public decimal P_precioCompra
        {
            get { return ProductoModel.p_preciocompra; }
            set
            {
                ProductoModel.p_preciocompra = value;
                OnPropertyChanged(nameof(P_precioCompra));
            }
        }
   
        public string P_ImagenURL
        {
            get { return ProductoModel.p_ImagenURL; }
            set
            {
                ProductoModel.p_ImagenURL = value;
                OnPropertyChanged(nameof(P_ImagenURL));
            }
        }
    }
}
