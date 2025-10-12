using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class ComentarioService
    {
        private readonly ComentarioRepository _repository;

        public ComentarioService()
        {
            _repository = new ComentarioRepository();
        }

        public List<Comentario> ListarPorRecurso(int idRecurso)
        {
            return _repository.ObtenerPorRecurso(idRecurso);
        }

        public string? CrearComentario(Comentario comentario)
        {
            try
            {
                _repository.Crear(comentario);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al registrar el comentario: " + ex.Message;
            }
        }
    }
}
