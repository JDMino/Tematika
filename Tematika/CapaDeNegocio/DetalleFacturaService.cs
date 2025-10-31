using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase DetalleFacturaService dentro del namespace Tematika.CapaDeNegocio
    public class DetalleFacturaService
    {
        // Campo privado que instancia el repositorio de detalle de factura
        private readonly DetalleFacturaRepository _repo = new DetalleFacturaRepository();

        // Método público para crear un nuevo detalle de factura
        public void CrearDetalle(DetalleFactura detalle)
        {
            // Llama al repositorio para registrar el detalle
            _repo.Crear(detalle);
        }

        // Método público para obtener un detalle de factura por id de factura
        public DetalleFactura ObtenerPorFactura(int idFactura)
        {
            // Llama al repositorio para obtener el detalle correspondiente
            return _repo.ObtenerPorFactura(idFactura);
        }
    }
}
