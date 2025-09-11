using System;

namespace Tematika.Models
{
    public class Favorito
    {
        public int IdFavorito { get; set; }
        public DateTime FechaMarcado { get; set; }
        public int IdUsuario { get; set; }
        public int IdRecurso { get; set; }
        public bool Eliminado { get; set; }
    }
}