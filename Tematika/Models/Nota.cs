using System;

namespace Tematika.Models
{
    public class Nota
    {
        public int IdNota { get; set; }
        public string Texto { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public int IdUsuario { get; set; }
        public int IdRecurso { get; set; }
        public bool Eliminado { get; set; }
    }
}