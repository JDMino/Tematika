using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase SuscripcionService dentro del namespace Tematika.CapaDeNegocio
    public class SuscripcionService
    {
        // Campo privado que instancia el repositorio de suscripciones
        private readonly SuscripcionRepository _repo = new SuscripcionRepository();

        // Método público para crear una nueva suscripción y retornar su id generado
        public int CrearSuscripcion(Suscripcion suscripcion)
        {
            // Llama al repositorio para registrar la suscripción
            return _repo.Crear(suscripcion);
        }

        // Método público para obtener todas las suscripciones asociadas a un usuario
        public List<Suscripcion> ObtenerPorUsuario(int idUsuario)
        {
            // Llama al repositorio para obtener las suscripciones por id de usuario
            return _repo.ObtenerPorUsuario(idUsuario);
        }

        // Método público que obtiene todas las suscripciones registradas en el sistema
        public List<Suscripcion> ObtenerTodas()
        {
            // Llama al repositorio para obtener todas las suscripciones
            return _repo.ObtenerTodas();
        }

        // Método público para dar de baja una suscripción por su id
        public void DarDeBaja(int idSuscripcion)
        {
            // Llama al repositorio para marcar la suscripción como dada de baja
            _repo.DarDeBaja(idSuscripcion);
        }
    }
}
