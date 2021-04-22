using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Proyecto_final.Data.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Cedula(
            LengthErrorMessage = "La Cedula debe tener 11 digitos",
            FormatErrorMessage = "La Cedula NO debe tener letras",
            ValidErrorMessage = "La Cedula ingresada no es valida")]
        public string Cedula { get; set; }

        public string Foto { get; set; }


        public string NombreCompleto {
            get => $"{Nombre} {Apellido}";
        }
    }
}
