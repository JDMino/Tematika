namespace Tematika.Models
{
    public class Tema
    {
        public int IdTema { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int IdMateria { get; set; }
        public bool Eliminado { get; set; }
    }
}