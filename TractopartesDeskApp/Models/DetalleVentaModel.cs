namespace TractopartesDeskApp.Models
{
    public class DetalleVentaModel
    {
        public Guid idventa { get; set; }
        public ProductoModel producto { get; set; } = new();
        public int cantidad { get; set; } = 0;
        public decimal precio_unitario { get; set; }
        public DetalleVentaModel(Guid Id)
        {
            idventa=Id;          
        }
    }
}
