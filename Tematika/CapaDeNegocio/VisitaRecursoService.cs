using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase VisitaRecursoService dentro del namespace Tematika.CapaDeNegocio
    public class VisitaRecursoService
    {
        // Campo privado para acceder al repositorio de visitas a recursos
        private readonly VisitaRecursoRepository _repository;

        // Constructor de la clase VisitaRecursoService
        public VisitaRecursoService()
        {
            // Inicializa el repositorio de visitas a recursos
            _repository = new VisitaRecursoRepository();
        }

        // Método público que obtiene todas las visitas realizadas por un usuario
        public List<VisitaRecurso> ListarPorUsuario(int idUsuario)
        {
            // Llama al repositorio para obtener las visitas por id de usuario
            return _repository.ObtenerPorUsuario(idUsuario);
        }

        // Método público para registrar una nueva visita a un recurso, con manejo de errores
        public string? RegistrarVisita(VisitaRecurso visita)
        {
            try
            {
                // Llama al repositorio para registrar la visita
                _repository.RegistrarVisita(visita);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Retorna un mensaje de error si ocurre una excepción SQL
                return "Error al registrar la visita: " + ex.Message;
            }
        }

        // Método público para contar la cantidad de visitas realizadas a un recurso
        public int ContarVisitas(int idRecurso)
        {
            // Llama al repositorio para contar las visitas por id de recurso
            return _repository.ContarVisitasPorRecurso(idRecurso);
        }

        // Método público que obtiene todas las visitas registradas en el sistema
        public List<VisitaRecurso> ListarTodas()
        {
            // Llama al repositorio para obtener todas las visitas
            return _repository.ObtenerTodas();
        }
    }
}
