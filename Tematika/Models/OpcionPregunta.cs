namespace Tematika.Models
{
    public class OpcionPregunta
    {
        public int IdOpcion { get; set; }

        public string Texto { get; set; } = string.Empty;

        public bool EsCorrecta { get; set; }

        public int IdPregunta { get; set; }
    }
}
