using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class VisitaRecursoRepository
    {
        private readonly string _connectionString;

        public VisitaRecursoRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public List<VisitaRecurso> ObtenerPorUsuario(int idUsuario)
        {
            var lista = new List<VisitaRecurso>();
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM visita_recurso WHERE id_usuario = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idUsuario);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new VisitaRecurso
                {
                    IdVisita = (int)reader["id_visita"],
                    FechaHora = (DateTime)reader["fecha_hora"],
                    IdUsuario = (int)reader["id_usuario"],
                    IdRecurso = (int)reader["id_recurso"]
                });
            }

            return lista;
        }

        public void RegistrarVisita(VisitaRecurso visita)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO visita_recurso (fecha_hora, id_usuario, id_recurso)
                          VALUES (@fechaHora, @idUsuario, @idRecurso)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@fechaHora", visita.FechaHora);
            command.Parameters.AddWithValue("@idUsuario", visita.IdUsuario);
            command.Parameters.AddWithValue("@idRecurso", visita.IdRecurso);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public int ContarVisitasPorRecurso(int idRecurso)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT COUNT(*) FROM visita_recurso WHERE id_recurso = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idRecurso);
            connection.Open();

            return (int)command.ExecuteScalar();
        }

    }
}
