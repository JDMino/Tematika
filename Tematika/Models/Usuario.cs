using System;

namespace Tematika.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; }
        public int IdPerfil { get; set; }
        public string ContrasenaHash { get; set; } = string.Empty;
        public char Sexo { get; set; }
        public bool Eliminado { get; set; }
    }
}
