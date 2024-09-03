using Pacial_Net2.Models;

namespace Pacial_Net2.Repository.Interface
{
    public interface IVehiculoRepository
    {
        Vehiculo AddVehiculo(Vehiculo vehiculo);
        Vehiculo UpdateVehiculo(Vehiculo vehiculo);
        void DeleteVehiculo(int id);
        List<Vehiculo> GetVehiculo();
    }
}
