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
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_Recurso_titulo"))
                        return "Ya existe un recurso con ese título.";
                    return "Ya existe un recurso con datos duplicados.";
                }

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
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_Recurso_titulo"))
                        return "Ya existe otro recurso con ese título.";
                    return "Ya existe otro recurso con datos duplicados.";
                }

                return "Error al actualizar el recurso: " + ex.Message;
            }
        }


        public void EliminarRecurso(int id)
        {
            _repository.Eliminar(id);
        }
    }
}
