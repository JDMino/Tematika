using System;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase HistorialEvaluacionService dentro del namespace Tematika.CapaDeNegocio
    public class HistorialEvaluacionService
    {
        // Campo privado para acceder al repositorio de historial de evaluaciones
        private readonly HistorialEvaluacionRepository _repository;

        // Constructor de la clase HistorialEvaluacionService
        public HistorialEvaluacionService()
        {
            // Inicializa el repositorio de historial de evaluaciones
            _repository = new HistorialEvaluacionRepository();
        }

        // Método público para crear un nuevo historial de evaluación y retornar su id generado
        public int CrearHistorial(int idUsuario, int idEvaluacion)
        {
            // Crea un nuevo objeto HistorialEvaluacion con los datos iniciales
            var historial = new HistorialEvaluacion
            {
                IdUsuario = idUsuario,                  // Asigna el id del usuario
                IdEvaluacion = idEvaluacion,           // Asigna el id de la evaluación
                FechaInicio = DateTime.Now             // Asigna la fecha de inicio como ahora
            };

            // Llama al repositorio para registrar el historial
            _repository.Crear(historial);
            // Retorna el id generado del historial
            return historial.IdHistorial;
        }

        // Método público para finalizar un historial de evaluación existente
        public void FinalizarHistorial(int idHistorial, int puntaje, bool aprobado)
        {
            // Obtiene el historial correspondiente desde el repositorio
            var historial = _repository.ObtenerPorId(idHistorial);
            // Si no se encuentra, no hace nada
            if (historial == null) return;

            // Asigna los valores de finalización
            historial.FechaFin = DateTime.Now;         // Asigna la fecha de finalización como ahora
            historial.PuntajeTotal = puntaje;          // Asigna el puntaje obtenido
            historial.Aprobado = aprobado;             // Asigna el estado de aprobado

            // Llama al repositorio para actualizar el historial
            _repository.Finalizar(historial);
        }

        // Método público para obtener un historial por su id
        public HistorialEvaluacion? ObtenerHistorial(int id)
        {
            // Llama al repositorio para obtener el historial correspondiente
            return _repository.ObtenerPorId(id);
        }

        // Método público para listar todos los historiales de un usuario
        public List<HistorialEvaluacion> ListarPorUsuario(int idUsuario)
        {
            // Llama al repositorio para obtener los historiales por id de usuario
            return _repository.ListarPorUsuario(idUsuario);
        }
    }
}
