using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_final.Data.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La Marca es obligatoria")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "El Modelo es obligatorio")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "El Año es obligatorio")]
        public string Año { get; set; }

        [Required(ErrorMessage = "El Color es obligatorio")]
        public string Color { get; set; }

        [Required(ErrorMessage = "El Precio por Dia es obligatorio")]
        public int PrecioDia { get; set; }

        [Required(ErrorMessage = "El Tipo de Vehiculo es obligatorio")]
        public int TipoId { get; set; }

        [Required(ErrorMessage = "La Capacidad de Carga es obligatoria")]
        public int Carga { get; set; }

        [Required(ErrorMessage = "El Numero de Pasajeros es obligatorio")]
        public int Pasajeros { get; set; }

        [Required(ErrorMessage = "La Matricula es obligatoria")]
        [RegularExpression(@"^([A-Z]{1}\d{6,7}|[A-Z]{2}\d{5})$",
            ErrorMessage = "La Matricula debe tener una letra mayuscula y 6 digitos")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "La Marca del Seguro es obligatoria")]
        public string MarcaSeguro { get; set; }

        [Required(ErrorMessage = "El Numero de Seguro es obligatorio")]
        public string NumeroSeguro { get; set; }

        [Required(ErrorMessage = "La Foto es obligatoria")]
        public string Foto { get; set; }

        [Required(ErrorMessage = "La Latitud es obligatoria")]
        public float Latitud { get; set; }

        [Required(ErrorMessage = "La Longitud es obligatoria")]
        public float Longitud { get; set; }

        [Required]
        public bool Habilitado { get; set; } = true;


        public TipoVehiculo Tipo { get; set; }

        public ICollection<Reservacion> Reservaciones { get; set; }



        public string Informacion {
            get => $"{Año} {Marca} {Modelo}";
        }

        public string SeguroCompleto {
            get => $"{MarcaSeguro} - No.{NumeroSeguro}";
        }

        public double Beneficios {
            get {
                double beneficios = 0d;
                foreach (var r in Reservaciones) {
                    beneficios += r.MontoPagado;
                }
                return beneficios;
            }
        }
    }
}
