using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class RecursoService
    {
        private readonly RecursoRepository _repository;

        public RecursoService()
        {
            _repository = new RecursoRepository();
        }

        public List<Recurso> ListarRecursos()
        {
            return _repository.ObtenerTodos();
        }

        public Recurso? ObtenerRecurso(int id)
        {
            return _repository.ObtenerPorId(id);
        }

        public string? CrearRecurso(Recurso recurso)
        {
            try
            {
                recurso.FechaCreacion = DateTime.Now;
                recurso.FechaModificacion = DateTime.Now;
                _repository.Crear(recurso);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al crear el recurso: " + ex.Message;
            }
        }

        public string? ActualizarRecurso(Recurso recurso)
        {
            try
            {
                recurso.FechaModificacion = DateTime.Now;
                _repository.Actualizar(recurso);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al actualizar el recurso: " + ex.Message;
            }
        }

        public void EliminarRecurso(int id)
        {
            _repository.Eliminar(id);
        }
    }
}
