using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class PreguntaRepository
    {
        private readonly string _connectionString;

        public PreguntaRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public List<Pregunta> ObtenerTodas()
        {
            var lista = new List<Pregunta>();
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM pregunta";

            using var command = new SqlCommand(query, connection);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Pregunta
                {
                    IdPregunta = (int)reader["id_pregunta"],
                    Enunciado = reader["enunciado"].ToString() ?? "",
                    OpcionCorrecta = reader["opcion_correcta"].ToString() ?? "",
                    IdEvaluacion = (int)reader["id_evaluacion"]
                });
            }

            return lista;
        }

        public void Crear(Pregunta pregunta)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO pregunta (enunciado, opcion_correcta, id_evaluacion)
                          VALUES (@enunciado, @correcta, @idEval)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@enunciado", pregunta.Enunciado);
            command.Parameters.AddWithValue("@correcta", pregunta.OpcionCorrecta);
            command.Parameters.AddWithValue("@idEval", pregunta.IdEvaluacion);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Actualizar(Pregunta pregunta)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"UPDATE pregunta SET enunciado = @enunciado,
                          opcion_correcta = @correcta, id_evaluacion = @idEval
                          WHERE id_pregunta = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", pregunta.IdPregunta);
            command.Parameters.AddWithValue("@enunciado", pregunta.Enunciado);
            command.Parameters.AddWithValue("@correcta", pregunta.OpcionCorrecta);
            command.Parameters.AddWithValue("@idEval", pregunta.IdEvaluacion);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "DELETE FROM pregunta WHERE id_pregunta = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
