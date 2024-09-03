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
            _context.Remove(id);
            _context.SaveChanges();
            throw new NotImplementedException();
        }

        public List<Vehiculo> GetVehiculo()
        {
            return _context.vehiculos.ToList();
            throw new NotImplementedException();
        }

        public Vehiculo UpdateVehiculo(Vehiculo vehiculo)
        {
            _context.Update(vehiculo); 
            _context.SaveChanges(true);
            return vehiculo;
            throw new NotImplementedException();
        }
    }
}
