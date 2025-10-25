using System;
using System.Collections.Generic;

namespace Tematika.Models
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int IdUsuario { get; set; }
        public int IdSuscripcion { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal Total { get; set; }
        public string MetodoPago { get; set; } = string.Empty;
        public string DescripcionPago { get; set; } = string.Empty;
        public List<DetalleFactura> Detalles { get; set; } = new();
    }
}
