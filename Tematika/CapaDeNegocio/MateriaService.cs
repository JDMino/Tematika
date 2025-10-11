using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class MateriaService
    {
        private readonly MateriaRepository _repository;

        public MateriaService()
        {
            _repository = new MateriaRepository();
        }

        public List<Materia> ListarMaterias()
        {
            return _repository.ObtenerTodas();
        }

        public Materia? ObtenerMateria(int id)
        {
            return _repository.ObtenerPorId(id);
        }

        public string? CrearMateria(Materia materia)
        {
            try
            {
                _repository.Crear(materia);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al crear la materia: " + ex.Message;
            }
        }

        public string? ActualizarMateria(Materia materia)
        {
            try
            {
                _repository.Actualizar(materia);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al actualizar la materia: " + ex.Message;
            }
        }

        public void EliminarMateria(int id)
        {
            _repository.Eliminar(id);
        }

        public List<Materia> ListarMateriasPorDocente(int idUsuario)
        {
            var asignaciones = new DocenteMateriaService().ListarAsignaciones()
                .Where(dm => dm.IdUsuario == idUsuario)
                .Select(dm => dm.IdMateria)
                .ToList();

            return _repository.ObtenerTodas()
                .Where(m => asignaciones.Contains(m.IdMateria) && !m.Eliminado)
                .OrderBy(m => m.Nombre)
                .ToList();
        }

    }
}
