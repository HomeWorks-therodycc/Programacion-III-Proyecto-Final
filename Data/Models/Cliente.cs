using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_final.Data.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La Cedula es obligatoria")]
        [Cedula(
            LengthErrorMessage = "La Cedula debe tener 11 digitos",
            FormatErrorMessage = "La Cedula NO debe tener letras",
            ValidErrorMessage = "La Cedula ingresada no es valida")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El Telefono es obligatorio")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "El Telefono debe tener 10 digitos, sin letras")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El Correo es obligatorio")]
        [EmailAddress(ErrorMessage = "El Correo ingresado no es valido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "La Licencia es obligatoria")]
        [Cedula(
            LengthErrorMessage = "La Licencia debe tener 11 digitos",
            FormatErrorMessage = "La Licencia NO debe tener letras",
            ValidErrorMessage = "La Licencia ingresada no es valida")]
        public string Licencia { get; set; }

        [Required(ErrorMessage = "La Nacionalidad es obligatoria")]
        public string Nacionalidad { get; set; }

        [Required(ErrorMessage = "El Tipo de Sangre es obligatorio")]
        public string Sangre { get; set; }

        [Required(ErrorMessage = "La foto de Cliente es obligatoria")]
        public string FotoPersona { get; set; }

        [Required(ErrorMessage = "La foto de la Licencia del Cliente es obligatoria")]
        public string FotoLicencia { get; set; }

        [Required]
        public bool Habilitado { get; set; } = true;


        public ICollection<Reservacion> Reservaciones { get; set; }



        public string NombreCompleto {
            get => $"{Nombre} {Apellido}";
        }

        public double Deuda {
            get {
                double deuda = 0d;
                foreach (var r in Reservaciones) {
                    deuda += r.MontoDebido;
                }
                return deuda;
            }
        }
    }
}
