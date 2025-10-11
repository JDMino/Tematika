using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class EvaluacionRepository
    {
        private readonly string _connectionString;

        public EvaluacionRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public List<Evaluacion> ObtenerTodas()
        {
            var lista = new List<Evaluacion>();
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM evaluacion";

            using var command = new SqlCommand(query, connection);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Evaluacion
                {
                    IdEvaluacion = (int)reader["id_evaluacion"],
                    IdTema = (int)reader["id_tema"],
                    Eliminado = (bool)reader["eliminado"]
                });
            }

            return lista;
        }

        public Evaluacion? ObtenerPorId(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM evaluacion WHERE id_evaluacion = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();

            using var reader = command.ExecuteReader();
            return reader.Read() ? new Evaluacion
            {
                IdEvaluacion = (int)reader["id_evaluacion"],
                IdTema = (int)reader["id_tema"],
                Eliminado = (bool)reader["eliminado"]
            } : null;
        }

        public Evaluacion? ObtenerPorTema(int idTema)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM evaluacion WHERE id_tema = @idTema";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idTema", idTema);
            connection.Open();

            using var reader = command.ExecuteReader();
            return reader.Read() ? new Evaluacion
            {
                IdEvaluacion = (int)reader["id_evaluacion"],
                IdTema = (int)reader["id_tema"],
                Eliminado = (bool)reader["eliminado"]
            } : null;
        }

        public void Crear(Evaluacion evaluacion)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO evaluacion (id_tema, eliminado)
                          VALUES (@idTema, @eliminado)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idTema", evaluacion.IdTema);
            command.Parameters.AddWithValue("@eliminado", evaluacion.Eliminado ? 1 : 0);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Actualizar(Evaluacion evaluacion)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"UPDATE evaluacion SET id_tema = @idTema, eliminado = @eliminado
                          WHERE id_evaluacion = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", evaluacion.IdEvaluacion);
            command.Parameters.AddWithValue("@idTema", evaluacion.IdTema);
            command.Parameters.AddWithValue("@eliminado", evaluacion.Eliminado ? 1 : 0);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "UPDATE evaluacion SET eliminado = 1 WHERE id_evaluacion = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
