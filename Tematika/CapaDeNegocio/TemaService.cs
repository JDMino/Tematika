using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class TemaService
    {
        private readonly TemaRepository _repository;

        public TemaService()
        {
            _repository = new TemaRepository();
        }

        public List<Tema> ListarTemas()
        {
            return _repository.ObtenerTodos();
        }

        public Tema? ObtenerTema(int id)
        {
            return _repository.ObtenerPorId(id);
        }

        public string? CrearTema(Tema tema)
        {
            try
            {
                _repository.Crear(tema);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al crear el tema: " + ex.Message;
            }
        }

        public string? ActualizarTema(Tema tema)
        {
            try
            {
                _repository.Actualizar(tema);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al actualizar el tema: " + ex.Message;
            }
        }

        public void EliminarTema(int id)
        {
            _repository.Eliminar(id);
        }
    }
}
