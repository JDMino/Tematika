using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class DetalleFacturaService
    {
        private readonly DetalleFacturaRepository _repo = new DetalleFacturaRepository();

        public void CrearDetalle(DetalleFactura detalle)
        {
            _repo.Crear(detalle);
        }

        public DetalleFactura ObtenerPorFactura(int idFactura)
        {
            return _repo.ObtenerPorFactura(idFactura);
        }

    }
}