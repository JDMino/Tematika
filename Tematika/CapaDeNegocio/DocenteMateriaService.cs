using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class DocenteMateriaService
    {
        private readonly DocenteMateriaRepository _repository;

        public DocenteMateriaService()
        {
            _repository = new DocenteMateriaRepository();
        }

        public List<DocenteMateria> ListarAsignaciones()
        {
            return _repository.ObtenerTodas();
        }

        public string? AsignarDocente(DocenteMateria dm)
        {
            try
            {
                _repository.Crear(dm);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al asignar docente: " + ex.Message;
            }
        }

        public void EliminarAsignacion(int idDocenteMateria)
        {
            _repository.Eliminar(idDocenteMateria);
        }
    }
}