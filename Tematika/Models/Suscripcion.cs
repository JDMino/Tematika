using System;

namespace Tematika.Models
{
    public class Suscripcion
    {
        public int IdSuscripcion { get; set; }
        public int IdUsuario { get; set; }
        public bool Activa { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}