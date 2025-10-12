using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class NotaRepository
    {
        private readonly string _connectionString;

        public NotaRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public List<Nota> ObtenerPorUsuario(int idUsuario)
        {
            var lista = new List<Nota>();
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM nota WHERE id_usuario = @id AND eliminado = 0";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idUsuario);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Nota
                {
                    IdNota = (int)reader["id_nota"],
                    Texto = reader["texto"].ToString() ?? "",
                    Fecha = (DateTime)reader["fecha"],
                    IdUsuario = (int)reader["id_usuario"],
                    IdRecurso = (int)reader["id_recurso"],
                    Eliminado = (bool)reader["eliminado"]
                });
            }

            return lista;
        }

        public void Crear(Nota nota)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO nota (texto, fecha, id_usuario, id_recurso, eliminado)
                          VALUES (@texto, @fecha, @idUsuario, @idRecurso, 0)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@texto", nota.Texto);
            command.Parameters.AddWithValue("@fecha", nota.Fecha);
            command.Parameters.AddWithValue("@idUsuario", nota.IdUsuario);
            command.Parameters.AddWithValue("@idRecurso", nota.IdRecurso);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Eliminar(int idNota)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "UPDATE nota SET eliminado = 1 WHERE id_nota = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idNota);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
