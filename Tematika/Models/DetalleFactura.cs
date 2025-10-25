namespace Tematika.Models
{
    public class DetalleFactura
    {
        public int IdDetalleFactura { get; set; }
        public int IdFactura { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; }
    }
}
