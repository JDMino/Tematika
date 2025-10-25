using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class FacturaService
    {
        private readonly FacturaRepository _repo = new FacturaRepository();

        public int CrearFactura(Factura factura)
        {
            return _repo.Crear(factura);
        }

        public Factura ObtenerPorSuscripcion(int idSuscripcion)
        {
            return _repo.ObtenerPorSuscripcion(idSuscripcion);
        }

    }
}
