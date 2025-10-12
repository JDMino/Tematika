using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class ValoracionService
    {
        private readonly ValoracionRepository _repository;

        public ValoracionService()
        {
            _repository = new ValoracionRepository();
        }

        public List<Valoracion> ListarPorRecurso(int idRecurso)
        {
            return _repository.ObtenerPorRecurso(idRecurso);
        }

        public string? RegistrarValoracion(Valoracion valoracion)
        {
            try
            {
                var existente = _repository.ObtenerPorUsuarioYRecurso(valoracion.IdUsuario, valoracion.IdRecurso);
                if (existente != null)
                {
                    valoracion.IdValoracion = existente.IdValoracion;
                    _repository.Actualizar(valoracion);
                }
                else
                {
                    _repository.Crear(valoracion);
                }

                return null;
            }
            catch (SqlException ex)
            {
                return "Error al registrar la valoración: " + ex.Message;
            }
        }

    }
}
