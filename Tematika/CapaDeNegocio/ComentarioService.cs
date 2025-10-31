using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase ComentarioService dentro del namespace Tematika.CapaDeNegocio
    public class ComentarioService
    {
        // Campo privado para acceder al repositorio de comentarios
        private readonly ComentarioRepository _repository;

        // Constructor de la clase ComentarioService
        public ComentarioService()
        {
            // Inicializa el repositorio de comentarios
            _repository = new ComentarioRepository();
        }

        // Método público que obtiene todos los comentarios asociados a un recurso
        public List<Comentario> ListarPorRecurso(int idRecurso)
        {
            // Llama al repositorio para obtener los comentarios por recurso
            return _repository.ObtenerPorRecurso(idRecurso);
        }

        // Método público para crear un nuevo comentario y retornar un mensaje de error si ocurre
        public string? CrearComentario(Comentario comentario)
        {
            try
            {
                // Intenta registrar el comentario usando el repositorio
                _repository.Crear(comentario);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Retorna un mensaje de error si ocurre una excepción SQL
                return "Error al registrar el comentario: " + ex.Message;
            }
        }
    }
}
