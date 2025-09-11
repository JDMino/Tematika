using System;

namespace Tematika.Models
{
    public class VisitaRecurso
    {
        public int IdVisita { get; set; }
        public DateTime FechaHora { get; set; }
        public int IdUsuario { get; set; }
        public int IdRecurso { get; set; }
    }
}