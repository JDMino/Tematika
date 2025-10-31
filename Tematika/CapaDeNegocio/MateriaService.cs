using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase MateriaService dentro del namespace Tematika.CapaDeNegocio
    public class MateriaService
    {
        // Campo privado para acceder al repositorio de materias
        private readonly MateriaRepository _repository;

        // Constructor de la clase MateriaService
        public MateriaService()
        {
            // Inicializa el repositorio de materias
            _repository = new MateriaRepository();
        }

        // Método público que obtiene todas las materias registradas
        public List<Materia> ListarMaterias()
        {
            // Llama al repositorio para obtener todas las materias
            return _repository.ObtenerTodas();
        }

        // Método público para obtener una materia por su id
        public Materia? ObtenerMateria(int id)
        {
            // Llama al repositorio para obtener la materia correspondiente
            return _repository.ObtenerPorId(id);
        }

        // Método público para crear una nueva materia, con manejo de errores por duplicados
        public string? CrearMateria(Materia materia)
        {
            try
            {
                // Intenta registrar la materia usando el repositorio
                _repository.Crear(materia);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Maneja errores por claves duplicadas
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_Materia_nombre"))
                        return "Ya existe una materia con ese nombre.";
                    return "Ya existe una materia con datos duplicados.";
                }

                // Retorna mensaje genérico si no es error de duplicado
                return "Error al crear la materia: " + ex.Message;
            }
        }

        // Método público para actualizar una materia existente, con manejo de errores por duplicados
        public string? ActualizarMateria(Materia materia)
        {
            try
            {
                // Intenta actualizar la materia usando el repositorio
                _repository.Actualizar(materia);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Maneja errores por claves duplicadas
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_Materia_nombre"))
                        return "Ya existe otra materia con ese nombre.";
                    return "Ya existe otra materia con datos duplicados.";
                }

                // Retorna mensaje genérico si no es error de duplicado
                return "Error al actualizar la materia: " + ex.Message;
            }
        }

        // Método público para marcar una materia como eliminada por su id
        public void EliminarMateria(int id)
        {
            // Llama al repositorio para marcar la materia como eliminada
            _repository.Eliminar(id);
        }

        // Método público para listar las materias asignadas a un docente
        public List<Materia> ListarMateriasPorDocente(int idUsuario)
        {
            // Obtiene las asignaciones del docente desde el servicio correspondiente
            var asignaciones = new DocenteMateriaService().ListarAsignaciones()
                .Where(dm => dm.IdUsuario == idUsuario)         // Filtra por id de usuario
                .Select(dm => dm.IdMateria)                     // Obtiene los ids de materia
                .ToList();

            // Filtra las materias que coinciden con las asignaciones y no están eliminadas
            return _repository.ObtenerTodas()
                .Where(m => asignaciones.Contains(m.IdMateria) && !m.Eliminado)
                .OrderBy(m => m.Nombre)                         // Ordena alfabéticamente por nombre
                .ToList();
        }
    }
}
