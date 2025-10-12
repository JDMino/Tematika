using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class ComentarioRepository
    {
        private readonly string _connectionString;

        public ComentarioRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public List<Comentario> ObtenerPorRecurso(int idRecurso)
        {
            var lista = new List<Comentario>();
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM comentario WHERE id_recurso = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idRecurso);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Comentario
                {
                    IdComentario = (int)reader["id_comentario"],
                    Texto = reader["texto"].ToString() ?? "",
                    Fecha = (DateTime)reader["fecha"],
                    IdUsuario = (int)reader["id_usuario"],
                    IdRecurso = (int)reader["id_recurso"]
                });
            }

            return lista;
        }

        public void Crear(Comentario comentario)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO comentario (texto, fecha, id_usuario, id_recurso)
                          VALUES (@texto, @fecha, @idUsuario, @idRecurso)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@texto", comentario.Texto);
            command.Parameters.AddWithValue("@fecha", comentario.Fecha);
            command.Parameters.AddWithValue("@idUsuario", comentario.IdUsuario);
            command.Parameters.AddWithValue("@idRecurso", comentario.IdRecurso);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
