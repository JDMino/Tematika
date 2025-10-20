using System;

namespace Tematika.Models
{
    public class HistorialEvaluacion
    {
        public int IdHistorial { get; set; }
        public int IdUsuario { get; set; }
        public int IdEvaluacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? PuntajeTotal { get; set; }
        public bool? Aprobado { get; set; }
    }
}
