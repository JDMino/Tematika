using System;

namespace Tematika.Models
{
    public class LogAccion
    {
        public int IdLog { get; set; }
        public DateTime FechaHora { get; set; }
        public int? IdUsuario { get; set; } // Puede ser NULL si la acción no está asociada a un usuario específico
        public string TipoAccion { get; set; } = string.Empty;
        public string? Entidad { get; set; }
        public int? IdEntidad { get; set; }
    }
}