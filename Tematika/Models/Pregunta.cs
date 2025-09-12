namespace Tematika.Models
{
    public class Pregunta
    {
        public int IdPregunta { get; set; }
        public string Enunciado { get; set; } = string.Empty;
        public string OpcionCorrecta { get; set; } = string.Empty;
        public int IdEvaluacion { get; set; }
    }
}