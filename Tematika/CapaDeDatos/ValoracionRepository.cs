using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class ValoracionRepository
    {
        private readonly string _connectionString;

        public ValoracionRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public List<Valoracion> ObtenerPorRecurso(int idRecurso)
        {
            var lista = new List<Valoracion>();
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM valoracion WHERE id_recurso = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idRecurso);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Valoracion
                {
                    IdValoracion = (int)reader["id_valoracion"],
                    Puntuacion = (int)reader["puntuacion"],
                    Fecha = (DateTime)reader["fecha"],
                    IdUsuario = (int)reader["id_usuario"],
                    IdRecurso = (int)reader["id_recurso"]
                });
            }

            return lista;
        }

        public void Crear(Valoracion valoracion)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO valoracion (puntuacion, fecha, id_usuario, id_recurso)
                          VALUES (@puntuacion, @fecha, @idUsuario, @idRecurso)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@puntuacion", valoracion.Puntuacion);
            command.Parameters.AddWithValue("@fecha", valoracion.Fecha);
            command.Parameters.AddWithValue("@idUsuario", valoracion.IdUsuario);
            command.Parameters.AddWithValue("@idRecurso", valoracion.IdRecurso);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public Valoracion? ObtenerPorUsuarioYRecurso(int idUsuario, int idRecurso)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM valoracion WHERE id_usuario = @idUsuario AND id_recurso = @idRecurso";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idUsuario", idUsuario);
            command.Parameters.AddWithValue("@idRecurso", idRecurso);
            connection.Open();

            using var reader = command.ExecuteReader();
            return reader.Read() ? new Valoracion
            {
                IdValoracion = (int)reader["id_valoracion"],
                Puntuacion = (int)reader["puntuacion"],
                Fecha = (DateTime)reader["fecha"],
                IdUsuario = (int)reader["id_usuario"],
                IdRecurso = (int)reader["id_recurso"]
            } : null;
        }


        public void Actualizar(Valoracion valoracion)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"UPDATE valoracion SET puntuacion = @puntuacion, fecha = @fecha
                  WHERE id_valoracion = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", valoracion.IdValoracion);
            command.Parameters.AddWithValue("@puntuacion", valoracion.Puntuacion);
            command.Parameters.AddWithValue("@fecha", valoracion.Fecha);

            connection.Open();
            command.ExecuteNonQuery();
        }

    }
}
