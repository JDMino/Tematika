using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class SuscripcionService
    {
        private readonly SuscripcionRepository _repo = new SuscripcionRepository();

        public int CrearSuscripcion(Suscripcion suscripcion)
        {
            return _repo.Crear(suscripcion);
        }

        public List<Suscripcion> ObtenerPorUsuario(int idUsuario)
        {
            return _repo.ObtenerPorUsuario(idUsuario);
        }

        public List<Suscripcion> ObtenerTodas()
        {
            return _repo.ObtenerTodas();
        }

        public void DarDeBaja(int idSuscripcion)
        {
            _repo.DarDeBaja(idSuscripcion);
        }

    }
}
