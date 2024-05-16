namespace TractopartesDeskApp.Models
{
    public class VentaModel
    {
        public Guid idventa { get; set; }
        public DateTime fechanventa { get; set; }
        public int idcliente { get; set; }
        public decimal total { get; set; }
        public List<DetalleVentaModel> detalleVentas { get; set; }
        public VentaModel()
        {
            idventa = Guid.NewGuid();
            fechanventa = DateTime.Now;
            detalleVentas=new List<DetalleVentaModel>();
        }
    }
}
