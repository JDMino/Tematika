// Importa el repositorio Factura desde la capa de datos
using Tematika.CapaDeDatos;
// Importa el modelo Factura desde la capa de modelos
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase FacturaService dentro del namespace Tematika.CapaDeNegocio
    public class FacturaService
    {
        // Campo privado que instancia el repositorio de facturas
        private readonly FacturaRepository _repo = new FacturaRepository();

        // Método público para crear una nueva factura y retornar su id generado
        public int CrearFactura(Factura factura)
        {
            // Llama al repositorio para registrar la factura
            return _repo.Crear(factura);
        }

        // Método público para obtener una factura asociada a una suscripción
        public Factura ObtenerPorSuscripcion(int idSuscripcion)
        {
            // Llama al repositorio para obtener la factura correspondiente
            return _repo.ObtenerPorSuscripcion(idSuscripcion);
        }
    }
}
