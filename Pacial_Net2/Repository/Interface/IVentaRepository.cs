using Pacial_Net2.Models;

namespace Pacial_Net2.Repository.Interface
{
    public interface IVentaRepository
    {
        Venta AddVenta(Venta venta);
        Venta UpdateVenta(Venta venta);
        void DeleteVenta(int id);
        List<Venta> GetVenta();
    }
}
