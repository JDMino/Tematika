using System;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class HistorialEvaluacionService
    {
        private readonly HistorialEvaluacionRepository _repository;

        public HistorialEvaluacionService()
        {
            _repository = new HistorialEvaluacionRepository();
        }

        public int CrearHistorial(int idUsuario, int idEvaluacion)
        {
            var historial = new HistorialEvaluacion
            {
                IdUsuario = idUsuario,
                IdEvaluacion = idEvaluacion,
                FechaInicio = DateTime.Now
            };

            _repository.Crear(historial);
            return historial.IdHistorial;
        }

        public void FinalizarHistorial(int idHistorial, int puntaje, bool aprobado)
        {
            var historial = _repository.ObtenerPorId(idHistorial);
            if (historial == null) return;

            historial.FechaFin = DateTime.Now;
            historial.PuntajeTotal = puntaje;
            historial.Aprobado = aprobado;

            _repository.Finalizar(historial);
        }

        public HistorialEvaluacion? ObtenerHistorial(int id)
        {
            return _repository.ObtenerPorId(id);
        }

        public List<HistorialEvaluacion> ListarPorUsuario(int idUsuario)
        {
            return _repository.ListarPorUsuario(idUsuario);
        }

    }
}
