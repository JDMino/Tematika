namespace Tematika.Models
{
    public class Materia
    {
        public int IdMateria { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Nivel { get; set; }
        public string? Descripcion { get; set; }
        public bool Eliminado { get; set; }
    }
}