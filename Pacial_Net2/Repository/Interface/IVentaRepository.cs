using Pacial_Net2.Models;

namespace Pacial_Net2.Repository.Interface
{
    public interface IVentaRepository
    {
        Venta AddVenta(Venta venta);
        List<Venta> DetalleVenta(int id);
        List<Vehiculo> FiltroModelos(int id);
        List<Venta> GetVenta();
    }
}
