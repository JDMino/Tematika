namespace Tematika.Models
{
    public class TipoSuscripcion
    {
        public int IdTipoSuscripcion { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int DuracionDias { get; set; }           
        public decimal Precio { get; set; }            
    }
}
