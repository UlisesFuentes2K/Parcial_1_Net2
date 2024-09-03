using System.ComponentModel.DataAnnotations.Schema;

namespace Pacial_Net2.Models
{
    public class Vehiculo : BaseEntity
    {
        public string modelo { get; set; }
        public int anio { get;}
        public int cantidadPuertas { get; set; }

        [ForeignKey("Marca")]
        public int IdMArca { get; set; }
        public Marca? Marca { get; set; }

    }
}
