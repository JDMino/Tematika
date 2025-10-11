using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class PreguntaService
    {
        private readonly PreguntaRepository _repository;

        public PreguntaService()
        {
            _repository = new PreguntaRepository();
        }

        public List<Pregunta> ListarPreguntas()
        {
            return _repository.ObtenerTodas();
        }

        public string? CrearPregunta(Pregunta pregunta)
        {
            try
            {
                _repository.Crear(pregunta);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al crear la pregunta: " + ex.Message;
            }
        }

        public string? ActualizarPregunta(Pregunta pregunta)
        {
            try
            {
                _repository.Actualizar(pregunta);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al actualizar la pregunta: " + ex.Message;
            }
        }

        public void EliminarPregunta(int id)
        {
            _repository.Eliminar(id);
        }
    }
}
