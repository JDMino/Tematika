using System;

namespace Tematika.Models
{
    public class Intento
    {
        public int IdIntento { get; set; }
        public DateTime Fecha { get; set; }
        public string Respuesta { get; set; } = string.Empty;
        public bool Correcta { get; set; }
        public int IdUsuario { get; set; }
        public int IdPregunta { get; set; }
    }
}