using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class FavoritoRepository
    {
        private readonly string _connectionString;

        public FavoritoRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public List<Favorito> ObtenerPorUsuario(int idUsuario)
        {
            var lista = new List<Favorito>();
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM favorito WHERE id_usuario = @id AND eliminado = 0";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idUsuario);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Favorito
                {
                    IdFavorito = (int)reader["id_favorito"],
                    FechaMarcado = (DateTime)reader["fecha_marcado"],
                    IdUsuario = (int)reader["id_usuario"],
                    IdRecurso = (int)reader["id_recurso"],
                    Eliminado = (bool)reader["eliminado"]
                });
            }

            return lista;
        }

        public void Crear(Favorito favorito)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO favorito (fecha_marcado, id_usuario, id_recurso, eliminado)
                          VALUES (@fecha, @idUsuario, @idRecurso, 0)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@fecha", favorito.FechaMarcado);
            command.Parameters.AddWithValue("@idUsuario", favorito.IdUsuario);
            command.Parameters.AddWithValue("@idRecurso", favorito.IdRecurso);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Eliminar(int idFavorito)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "UPDATE favorito SET eliminado = 1 WHERE id_favorito = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idFavorito);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
