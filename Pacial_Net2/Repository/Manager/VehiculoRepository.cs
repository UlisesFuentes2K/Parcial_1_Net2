using Microsoft.EntityFrameworkCore;
using Pacial_Net2.Data;
using Pacial_Net2.Models;
using Pacial_Net2.Repository.Interface;

namespace Pacial_Net2.Repository.Manager
{
    public class VehiculoRepository : IVehiculoRepository
    {
        private readonly ApplicationDbContext _context;
        public VehiculoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Vehiculo AddVehiculo(Vehiculo vehiculo)
        {
            _context.Add(vehiculo);
            _context.SaveChanges();
            return vehiculo;
            throw new NotImplementedException();
        }

        public void DeleteVehiculo(int id)
        {
            var vehiculo = _context.vehiculos.Where(v => v.Id == id).FirstOrDefault();
            if (vehiculo != null)
            {
                _context.Remove(vehiculo);
                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public Vehiculo EditVehiculo(int id)
        {
            var vehiculo = _context.vehiculos.Where(v => v.Id == id).FirstOrDefault();
            return vehiculo;
            throw new NotImplementedException();
        }

        public List<Vehiculo> GetVehiculo()
        {
            return _context.vehiculos.Include(v => v.Marca).ToList();
            throw new NotImplementedException();
        }

        public Vehiculo UpdateVehiculo(Vehiculo vehiculo)
        {
            var vehiculos = _context.vehiculos.Where(v => v.Id == vehiculo.Id).FirstOrDefault();
            if(vehiculos != null)
            {
                vehiculos.modelo = vehiculo.modelo;
                vehiculos.IdMArca = vehiculo.IdMArca;
                vehiculos.anio = vehiculo.anio;
                vehiculos.isActivo = vehiculo.isActivo;
                vehiculos.precio = vehiculo.precio;
                vehiculos.cantidadPuertas = vehiculo.cantidadPuertas;

                _context.Update(vehiculos);
                _context.SaveChanges(true);

                return vehiculo;
            }
            throw new NotImplementedException();
        }
    }
}
