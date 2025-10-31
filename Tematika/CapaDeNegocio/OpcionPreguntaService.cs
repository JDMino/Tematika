using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase OpcionPreguntaService dentro del namespace Tematika.CapaDeNegocio
    public class OpcionPreguntaService
    {
        // Campo privado para acceder al repositorio de opciones de pregunta
        private readonly OpcionPreguntaRepository _repository;

        // Constructor de la clase OpcionPreguntaService
        public OpcionPreguntaService()
        {
            // Inicializa el repositorio de opciones de pregunta
            _repository = new OpcionPreguntaRepository();
        }

        // Método público que obtiene todas las opciones asociadas a una pregunta
        public List<OpcionPregunta> ListarPorPregunta(int idPregunta)
        {
            // Llama al repositorio para obtener las opciones por id de pregunta
            return _repository.ObtenerPorPregunta(idPregunta);
        }

        // Método público para crear una nueva opción de pregunta, con manejo de errores
        public string? CrearOpcion(OpcionPregunta opcion)
        {
            try
            {
                // Intenta registrar la opción usando el repositorio
                _repository.Crear(opcion);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Retorna un mensaje de error si ocurre una excepción SQL
                return "Error al crear opción: " + ex.Message;
            }
        }

        // Método público para eliminar todas las opciones asociadas a una pregunta
        public void EliminarOpcionesDePregunta(int idPregunta)
        {
            // Llama al repositorio para eliminar las opciones por id de pregunta
            _repository.EliminarPorPregunta(idPregunta);
        }

        // Método público para actualizar una opción de pregunta existente, con manejo de errores
        public string? ActualizarOpcion(OpcionPregunta opcion)
        {
            try
            {
                // Intenta actualizar la opción usando el repositorio
                _repository.Actualizar(opcion);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Retorna un mensaje de error si ocurre una excepción SQL
                return "Error al actualizar opción: " + ex.Message;
            }
        }
    }
}
