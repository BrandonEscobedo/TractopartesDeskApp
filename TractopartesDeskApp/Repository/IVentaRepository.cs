using TractopartesDeskApp.Models;

namespace TractopartesDeskApp.Repository
{
    public interface IVentaRepository
    {
        Task<bool> GenerarVenta(VentaModel ventaModel);
    }
}