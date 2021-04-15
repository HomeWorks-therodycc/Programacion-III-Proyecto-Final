using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_final.Data.Models
{
    public class TipoVehiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }


        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
