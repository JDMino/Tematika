using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class VisitaRecursoService
    {
        private readonly VisitaRecursoRepository _repository;

        public VisitaRecursoService()
        {
            _repository = new VisitaRecursoRepository();
        }

        public List<VisitaRecurso> ListarPorUsuario(int idUsuario)
        {
            return _repository.ObtenerPorUsuario(idUsuario);
        }

        public string? RegistrarVisita(VisitaRecurso visita)
        {
            try
            {
                _repository.RegistrarVisita(visita);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al registrar la visita: " + ex.Message;
            }
        }

        public int ContarVisitas(int idRecurso)
        {
            return _repository.ContarVisitasPorRecurso(idRecurso);
        }

    }
}
