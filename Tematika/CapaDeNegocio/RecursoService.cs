using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase RecursoService dentro del namespace Tematika.CapaDeNegocio
    public class RecursoService
    {
        // Campo privado para acceder al repositorio de recursos
        private readonly RecursoRepository _repository;

        // Constructor de la clase RecursoService
        public RecursoService()
        {
            // Inicializa el repositorio de recursos
            _repository = new RecursoRepository();
        }

        // Método público que obtiene todos los recursos registrados
        public List<Recurso> ListarRecursos()
        {
            // Llama al repositorio para obtener todos los recursos
            return _repository.ObtenerTodos();
        }

        // Método público para obtener un recurso por su id
        public Recurso? ObtenerRecurso(int id)
        {
            // Llama al repositorio para obtener el recurso correspondiente
            return _repository.ObtenerPorId(id);
        }

        // Método público para crear un nuevo recurso, con manejo de errores por duplicados
        public string? CrearRecurso(Recurso recurso)
        {
            try
            {
                // Asigna la fecha de creación y modificación como la fecha actual
                recurso.FechaCreacion = DateTime.Now;
                recurso.FechaModificacion = DateTime.Now;
                // Llama al repositorio para registrar el recurso
                _repository.Crear(recurso);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Maneja errores por claves duplicadas
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_Recurso_titulo"))
                        return "Ya existe un recurso con ese título.";
                    return "Ya existe un recurso con datos duplicados.";
                }

                // Retorna mensaje genérico si no es error de duplicado
                return "Error al crear el recurso: " + ex.Message;
            }
        }

        // Método público para actualizar un recurso existente, con manejo de errores por duplicados
        public string? ActualizarRecurso(Recurso recurso)
        {
            try
            {
                // Actualiza la fecha de modificación como la fecha actual
                recurso.FechaModificacion = DateTime.Now;
                // Llama al repositorio para actualizar el recurso
                _repository.Actualizar(recurso);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Maneja errores por claves duplicadas
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_Recurso_titulo"))
                        return "Ya existe otro recurso con ese título.";
                    return "Ya existe otro recurso con datos duplicados.";
                }

                // Retorna mensaje genérico si no es error de duplicado
                return "Error al actualizar el recurso: " + ex.Message;
            }
        }

        // Método público para eliminar un recurso por su id
        public void EliminarRecurso(int id)
        {
            // Llama al repositorio para eliminar el recurso correspondiente
            _repository.Eliminar(id);
        }
    }
}
