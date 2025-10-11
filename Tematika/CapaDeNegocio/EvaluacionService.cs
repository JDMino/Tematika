using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class EvaluacionService
    {
        private readonly EvaluacionRepository _repository;

        public EvaluacionService()
        {
            _repository = new EvaluacionRepository();
        }

        public List<Evaluacion> ListarEvaluaciones()
        {
            return _repository.ObtenerTodas();
        }

        public Evaluacion? ObtenerEvaluacion(int id)
        {
            return _repository.ObtenerPorId(id);
        }

        public Evaluacion? ObtenerPorTema(int idTema)
        {
            return _repository.ObtenerPorTema(idTema);
        }

        public string? CrearEvaluacion(Evaluacion evaluacion)
        {
            try
            {
                _repository.Crear(evaluacion);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al crear la evaluación: " + ex.Message;
            }
        }

        public string? ActualizarEvaluacion(Evaluacion evaluacion)
        {
            try
            {
                _repository.Actualizar(evaluacion);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al actualizar la evaluación: " + ex.Message;
            }
        }

        public void EliminarEvaluacion(int id)
        {
            _repository.Eliminar(id);
        }
    }
}
