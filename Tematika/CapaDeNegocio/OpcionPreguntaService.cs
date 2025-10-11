using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class OpcionPreguntaService
    {
        private readonly OpcionPreguntaRepository _repository;

        public OpcionPreguntaService()
        {
            _repository = new OpcionPreguntaRepository();
        }

        public List<OpcionPregunta> ListarPorPregunta(int idPregunta)
        {
            return _repository.ObtenerPorPregunta(idPregunta);
        }

        public string? CrearOpcion(OpcionPregunta opcion)
        {
            try
            {
                _repository.Crear(opcion);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al crear opción: " + ex.Message;
            }
        }

        public void EliminarOpcionesDePregunta(int idPregunta)
        {
            _repository.EliminarPorPregunta(idPregunta);
        }
    }
}
