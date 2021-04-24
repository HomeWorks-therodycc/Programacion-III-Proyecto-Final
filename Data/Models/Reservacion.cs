using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_final.Data.Models
{
    public class Reservacion
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Cliente es obligatorio")]
        [ForeignKey("ClienteId")]
        public int? ClienteId { get; set; }

        [Required(ErrorMessage = "El Vehiculo es obligatorio")]
        [ForeignKey("VehiculoId")]
        public int? VehiculoId { get; set; }

        [Required(ErrorMessage = "La Fecha Inicial es obligatoria")]
        public DateTime FechaInicio { get; set; } = DateTime.Now.Date;

        [Required(ErrorMessage = "La Fecha Final es obligatoria")]
        [DateTimeGreaterThan("FechaInicio",
            ErrorMessage = "La Fecha Final no puede ser anterior o igual a la Fecha Inicial")]
        public DateTime FechaFin { get; set; } = DateTime.Now.Date.AddDays(7);

        [Required(ErrorMessage = "El Monto Pagado es obligatorio")]
        public double MontoPagado { get; set; }

        [Required]
        public double MontoTotal { get; set; }


        public Cliente Cliente { get; set; }
        public Vehiculo Vehiculo { get; set; }



        public double MontoCalculado {
            get {
                if (Vehiculo == null) return 0.0d;
                return Vehiculo.PrecioDia * FechaFin.Subtract(FechaInicio).TotalDays;
            }
        }

        public string FechaInicioCorta {
            get => FechaInicio.ToShortDateString();
        }
        public string FechaFinCorta {
            get => FechaFin.ToShortDateString();
        }

        public string Estado {
            get {
                var hoy = DateTime.Now.Date;

                if ((FechaFin < hoy) && (FechaFin < hoy))
                    return "Finalizada";
                else if ((FechaInicio < hoy) && (FechaFin > hoy))
                    return "En curso";
                else if ((FechaInicio > hoy))
                    return "Sin iniciar";
                else if (FechaInicio == hoy)
                    return "Inicia hoy";
                else
                    return "Finaliza hoy";
            }
        }

        public bool Pagada {
            get => MontoPagado >= MontoTotal;
        }

        public double MontoDebido {
            get => MontoTotal - MontoPagado;
        }
    }
}
