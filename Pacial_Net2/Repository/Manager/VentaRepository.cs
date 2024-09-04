using Microsoft.EntityFrameworkCore;
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
            var existe = _context.ventas.Where(x => x.IdVehiculo == venta.IdVehiculo).FirstOrDefault();
            Vehiculo vehiculo = _context.vehiculos.Where(v => v.Id == venta.IdVehiculo).FirstOrDefault();
            Venta datos = new Venta();

            if (existe == null)
            {
                datos.IdVehiculo = venta.IdVehiculo;
                datos.totalVenta = vehiculo.precio;
                datos.cantidad = 1;
                _context.Add(datos);
            }
            else
            {
                existe.totalVenta += vehiculo.precio;
                existe.cantidad += 1;
                _context.Update(existe);
            }
            _context.SaveChanges();

            return datos;

            throw new NotImplementedException();
        }

        public List<Vehiculo> FiltroModelos(int id)
        {
            return _context.vehiculos.Where(v => v.IdMArca == id).ToList();

            throw new NotImplementedException();
        }

        public List<Venta> GetVenta()
        {
            return _context.ventas.Include(v => v.Vehiculo.Marca).ToList();
            throw new NotImplementedException();
        }

        public List<Venta> DetalleVenta(int id)
        {
            return _context.ventas.Include(ve => ve.Vehiculo)
        .ThenInclude(v => v.Marca).Where(ve => ve.Id == id).ToList();

            throw new NotImplementedException();
        }
    }
}
