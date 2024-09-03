using System.ComponentModel.DataAnnotations.Schema;

namespace Pacial_Net2.Models
{
    public class Venta : BaseEntity
    {
        public double totalVenta { get; set; }
        public int cantidad { get; set; }


        [ForeignKey("Vehiculo")]
        public int IdVehiculo { get; set; }
        public Vehiculo? Vehiculo { get; set; }
    }
}
