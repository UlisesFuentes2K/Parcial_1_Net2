using Pacial_Net2.Data;
using Pacial_Net2.Models;
using Pacial_Net2.Repository.Interface;

namespace Pacial_Net2.Repository.Manager
{
    public class VentaRepository : IVentaRepository
    {
        private readonly ApplicationDbContext _context;
        public VentaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Venta AddVenta(Venta venta)
        {
            _context.Add(venta);
            _context.SaveChanges();

            return venta;
            throw new NotImplementedException();
        }

        public void DeleteVenta(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
            throw new NotImplementedException();
        }

        public List<Venta> GetVenta()
        {
            return _context.ventas.ToList();
            throw new NotImplementedException();
        }

        public Venta UpdateVenta(Venta venta)
        {
            _context.Update(venta);
            _context.SaveChanges(true);
            return venta;
            throw new NotImplementedException();
        }
    }
}
