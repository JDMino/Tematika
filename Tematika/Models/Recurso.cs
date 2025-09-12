using System;

namespace Tematika.Models
{
    public class Recurso
    {
        public int IdRecurso { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string? Texto { get; set; }
        public string? ImagenRuta { get; set; }
        public string? Url { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int IdTema { get; set; }
        public bool Eliminado { get; set; }
    }
}