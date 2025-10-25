using System.Collections.Generic;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class TipoSuscripcionService
    {
        private readonly TipoSuscripcionRepository _repo = new TipoSuscripcionRepository();

        public List<TipoSuscripcion> ObtenerPlanes()
        {
            return _repo.ObtenerTodos();
        }

        public TipoSuscripcion? ObtenerPorId(int id)
        {
            return _repo.ObtenerPorId(id);
        }
    }
}
