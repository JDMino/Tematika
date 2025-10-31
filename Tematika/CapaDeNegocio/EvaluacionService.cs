// Importa el espacio de nombres para listas genéricas
using System.Collections.Generic;
// Importa el proveedor de datos SQL Server
using Microsoft.Data.SqlClient;
// Importa el repositorio Evaluacion desde la capa de datos
using Tematika.CapaDeDatos;
// Importa el modelo Evaluacion desde la capa de modelos
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase EvaluacionService dentro del namespace Tematika.CapaDeNegocio
    public class EvaluacionService
    {
        // Campo privado para acceder al repositorio de evaluaciones
        private readonly EvaluacionRepository _repository;

        // Constructor de la clase EvaluacionService
        public EvaluacionService()
        {
            // Inicializa el repositorio de evaluaciones
            _repository = new EvaluacionRepository();
        }

        // Método público que obtiene todas las evaluaciones registradas
        public List<Evaluacion> ListarEvaluaciones()
        {
            // Llama al repositorio para obtener todas las evaluaciones
            return _repository.ObtenerTodas();
        }

        // Método público para obtener una evaluación por su id
        public Evaluacion? ObtenerEvaluacion(int id)
        {
            // Llama al repositorio para obtener la evaluación correspondiente
            return _repository.ObtenerPorId(id);
        }

        // Método público para obtener una evaluación asociada a un tema
        public Evaluacion? ObtenerPorTema(int idTema)
        {
            // Llama al repositorio para obtener la evaluación por id de tema
            return _repository.ObtenerPorTema(idTema);
        }

        // Método público para crear una nueva evaluación, con manejo de errores
        public string? CrearEvaluacion(Evaluacion evaluacion)
        {
            try
            {
                // Intenta registrar la evaluación usando el repositorio
                _repository.Crear(evaluacion);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Retorna un mensaje de error si ocurre una excepción SQL
                return "Error al crear la evaluación: " + ex.Message;
            }
        }

        // Método público para actualizar una evaluación existente, con manejo de errores
        public string? ActualizarEvaluacion(Evaluacion evaluacion)
        {
            try
            {
                // Intenta actualizar la evaluación usando el repositorio
                _repository.Actualizar(evaluacion);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Retorna un mensaje de error si ocurre una excepción SQL
                return "Error al actualizar la evaluación: " + ex.Message;
            }
        }

        // Método público para eliminar una evaluación por su id
        public void EliminarEvaluacion(int id)
        {
            // Llama al repositorio para eliminar la evaluación correspondiente
            _repository.Eliminar(id);
        }
    }
}
