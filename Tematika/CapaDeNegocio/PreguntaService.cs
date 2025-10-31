using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase PreguntaService dentro del namespace Tematika.CapaDeNegocio
    public class PreguntaService
    {
        // Campo privado para acceder al repositorio de preguntas
        private readonly PreguntaRepository _repository;

        // Constructor de la clase PreguntaService
        public PreguntaService()
        {
            // Inicializa el repositorio de preguntas
            _repository = new PreguntaRepository();
        }

        // Método público que obtiene todas las preguntas registradas
        public List<Pregunta> ListarPreguntas()
        {
            // Llama al repositorio para obtener todas las preguntas
            return _repository.ObtenerTodas();
        }

        // Método público para crear una nueva pregunta, con manejo de errores
        public string? CrearPregunta(Pregunta pregunta)
        {
            try
            {
                // Intenta registrar la pregunta usando el repositorio
                _repository.Crear(pregunta);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Retorna un mensaje de error si ocurre una excepción SQL
                return "Error al crear la pregunta: " + ex.Message;
            }
        }

        // Método público para actualizar una pregunta existente, con manejo de errores
        public string? ActualizarPregunta(Pregunta pregunta)
        {
            try
            {
                // Intenta actualizar la pregunta usando el repositorio
                _repository.Actualizar(pregunta);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Retorna un mensaje de error si ocurre una excepción SQL
                return "Error al actualizar la pregunta: " + ex.Message;
            }
        }

        // Método público para eliminar una pregunta por su id
        public void EliminarPregunta(int id)
        {
            // Llama al repositorio para eliminar la pregunta correspondiente
            _repository.Eliminar(id);
        }

        // Método público para verificar si ya existe una pregunta con el mismo enunciado en una evaluación
        public bool ExisteEnunciadoEnEvaluacion(string enunciado, int idEvaluacion)
        {
            // Compara el enunciado normalizado contra las preguntas de la evaluación
            return _repository.ObtenerTodas()
                .Any(p => p.IdEvaluacion == idEvaluacion && p.Enunciado.Trim().ToLower() == enunciado.Trim().ToLower());
        }

        // Sobrecarga del método anterior que permite ignorar una pregunta específica por su id
        public bool ExisteEnunciadoEnEvaluacion(string enunciado, int idEvaluacion, int? ignorarIdPregunta = null)
        {
            // Compara el enunciado normalizado contra las preguntas de la evaluación, excluyendo la indicada
            return _repository.ObtenerTodas()
                .Any(p =>
                    p.IdEvaluacion == idEvaluacion &&
                    p.Enunciado.Trim().ToLower() == enunciado.Trim().ToLower() &&
                    (!ignorarIdPregunta.HasValue || p.IdPregunta != ignorarIdPregunta.Value));
        }
    }
}
