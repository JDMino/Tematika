using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase DocenteMateriaService dentro del namespace Tematika.CapaDeNegocio
    public class DocenteMateriaService
    {
        // Campo privado para acceder al repositorio de asignaciones docente-materia
        private readonly DocenteMateriaRepository _repository;

        // Constructor de la clase DocenteMateriaService
        public DocenteMateriaService()
        {
            // Inicializa el repositorio de docente-materia
            _repository = new DocenteMateriaRepository();
        }

        // Método público que obtiene todas las asignaciones registradas
        public List<DocenteMateria> ListarAsignaciones()
        {
            // Llama al repositorio para obtener todas las asignaciones
            return _repository.ObtenerTodas();
        }

        // Método público para asignar un docente a una materia, con manejo de errores
        public string? AsignarDocente(DocenteMateria dm)
        {
            try
            {
                // Intenta registrar la asignación usando el repositorio
                _repository.Crear(dm);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Retorna un mensaje de error si ocurre una excepción SQL
                return "Error al asignar docente: " + ex.Message;
            }
        }

        // Método público para eliminar una asignación por su id
        public void EliminarAsignacion(int idDocenteMateria)
        {
            // Llama al repositorio para eliminar la asignación correspondiente
            _repository.Eliminar(idDocenteMateria);
        }
    }
}
