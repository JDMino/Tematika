using System;

namespace Tematika.Models
{
    public class Valoracion
    {
        public int IdValoracion { get; set; }
        public int Puntuacion { get; set; }
        public DateTime Fecha { get; set; }
        public int IdUsuario { get; set; }
        public int IdRecurso { get; set; }
    }
}