using System.Collections.Generic;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase TipoSuscripcionService dentro del namespace Tematika.CapaDeNegocio
    public class TipoSuscripcionService
    {
        // Campo privado que instancia el repositorio de tipos de suscripción
        private readonly TipoSuscripcionRepository _repo = new TipoSuscripcionRepository();

        // Método público que obtiene todos los planes de suscripción disponibles
        public List<TipoSuscripcion> ObtenerPlanes()
        {
            // Llama al repositorio para obtener todos los tipos de suscripción
            return _repo.ObtenerTodos();
        }

        // Método público para obtener un tipo de suscripción por su id
        public TipoSuscripcion? ObtenerPorId(int id)
        {
            // Llama al repositorio para obtener el tipo de suscripción correspondiente
            return _repo.ObtenerPorId(id);
        }
    }
}
