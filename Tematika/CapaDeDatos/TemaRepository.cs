using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class TemaRepository
    {
        private readonly string _connectionString;

        public TemaRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public List<Tema> ObtenerTodos()
        {
            var temas = new List<Tema>();
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM tema";

            using var command = new SqlCommand(query, connection);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                temas.Add(new Tema
                {
                    IdTema = (int)reader["id_tema"],
                    Nombre = reader["nombre"].ToString() ?? "",
                    IdMateria = (int)reader["id_materia"],
                    Eliminado = (bool)reader["eliminado"]
                });
            }

            return temas;
        }

        public Tema? ObtenerPorId(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM tema WHERE id_tema = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();

            using var reader = command.ExecuteReader();
            return reader.Read() ? new Tema
            {
                IdTema = (int)reader["id_tema"],
                Nombre = reader["nombre"].ToString() ?? "",
                IdMateria = (int)reader["id_materia"],
                Eliminado = (bool)reader["eliminado"]
            } : null;
        }

        public void Crear(Tema tema)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO tema (nombre, id_materia, eliminado)
                          VALUES (@nombre, @idMateria, 0)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nombre", tema.Nombre);
            command.Parameters.AddWithValue("@idMateria", tema.IdMateria);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Actualizar(Tema tema)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"UPDATE tema SET nombre = @nombre, id_materia = @idMateria, eliminado = @eliminado
                          WHERE id_tema = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", tema.IdTema);
            command.Parameters.AddWithValue("@nombre", tema.Nombre);
            command.Parameters.AddWithValue("@idMateria", tema.IdMateria);
            command.Parameters.AddWithValue("@eliminado", tema.Eliminado ? 1 : 0);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "UPDATE tema SET eliminado = 1 WHERE id_tema = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
