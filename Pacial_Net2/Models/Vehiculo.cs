using System.ComponentModel.DataAnnotations.Schema;

namespace Pacial_Net2.Models
{
    public class Vehiculo : BaseEntity
    {
        public string modelo { get; set; }
        public int anio { get; set; }
        public int cantidadPuertas { get; set; }
        public double precio { get; set; }
        public bool isActivo { get; set; }

        [ForeignKey("Marca")]
        public int IdMArca { get; set; }
        public Marca? Marca { get; set; }

    }
}
