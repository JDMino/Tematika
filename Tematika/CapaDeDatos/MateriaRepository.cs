using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class MateriaRepository
    {
        private readonly string _connectionString;

        public MateriaRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public List<Materia> ObtenerTodas()
        {
            var materias = new List<Materia>();
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM materia";

            using var command = new SqlCommand(query, connection);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                materias.Add(new Materia
                {
                    IdMateria = (int)reader["id_materia"],
                    Nombre = reader["nombre"].ToString() ?? "",
                    Nivel = reader["nivel"].ToString(),
                    Descripcion = reader["descripcion"].ToString(),
                    Eliminado = (bool)reader["eliminado"]
                });
            }

            return materias;
        }

        public Materia? ObtenerPorId(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM materia WHERE id_materia = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();

            using var reader = command.ExecuteReader();
            return reader.Read() ? new Materia
            {
                IdMateria = (int)reader["id_materia"],
                Nombre = reader["nombre"].ToString() ?? "",
                Nivel = reader["nivel"].ToString(),
                Descripcion = reader["descripcion"].ToString(),
                Eliminado = (bool)reader["eliminado"]
            } : null;
        }

        public void Crear(Materia materia)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO materia (nombre, nivel, descripcion, eliminado)
                          VALUES (@nombre, @nivel, @descripcion, 0)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nombre", materia.Nombre);
            command.Parameters.AddWithValue("@nivel", materia.Nivel ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@descripcion", materia.Descripcion ?? (object)DBNull.Value);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Actualizar(Materia materia)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"UPDATE materia SET nombre = @nombre, nivel = @nivel,
                          descripcion = @descripcion, eliminado = @eliminado
                          WHERE id_materia = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", materia.IdMateria);
            command.Parameters.AddWithValue("@nombre", materia.Nombre);
            command.Parameters.AddWithValue("@nivel", materia.Nivel ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@descripcion", materia.Descripcion ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@eliminado", materia.Eliminado ? 1 : 0);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "UPDATE materia SET eliminado = 1 WHERE id_materia = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
