using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class OpcionPreguntaRepository
    {
        private readonly string _connectionString;

        public OpcionPreguntaRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public List<OpcionPregunta> ObtenerPorPregunta(int idPregunta)
        {
            var lista = new List<OpcionPregunta>();
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM opcion_pregunta WHERE id_pregunta = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idPregunta);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new OpcionPregunta
                {
                    IdOpcion = (int)reader["id_opcion"],
                    Texto = reader["texto"].ToString() ?? "",
                    EsCorrecta = (bool)reader["es_correcta"],
                    IdPregunta = (int)reader["id_pregunta"]
                });
            }

            return lista;
        }

        public void Crear(OpcionPregunta opcion)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO opcion_pregunta (texto, es_correcta, id_pregunta)
                          VALUES (@texto, @esCorrecta, @idPregunta)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@texto", opcion.Texto);
            command.Parameters.AddWithValue("@esCorrecta", opcion.EsCorrecta);
            command.Parameters.AddWithValue("@idPregunta", opcion.IdPregunta);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void EliminarPorPregunta(int idPregunta)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "DELETE FROM opcion_pregunta WHERE id_pregunta = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idPregunta);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Actualizar(OpcionPregunta opcion)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"UPDATE opcion_pregunta SET texto = @texto, es_correcta = @esCorrecta
                  WHERE id_opcion = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", opcion.IdOpcion);
            command.Parameters.AddWithValue("@texto", opcion.Texto);
            command.Parameters.AddWithValue("@esCorrecta", opcion.EsCorrecta);

            connection.Open();
            command.ExecuteNonQuery();
        }

    }
}
