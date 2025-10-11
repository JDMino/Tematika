using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class DocenteMateriaRepository
    {
        private readonly string _connectionString;

        public DocenteMateriaRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public List<DocenteMateria> ObtenerTodas()
        {
            var lista = new List<DocenteMateria>();
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM docente_materia";

            using var command = new SqlCommand(query, connection);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new DocenteMateria
                {
                    IdDocenteMateria = (int)reader["id_docente_materia"],
                    IdUsuario = (int)reader["id_usuario"],
                    IdMateria = (int)reader["id_materia"]
                });
            }

            return lista;
        }

        public void Crear(DocenteMateria dm)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO docente_materia (id_usuario, id_materia)
                          VALUES (@idUsuario, @idMateria)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idUsuario", dm.IdUsuario);
            command.Parameters.AddWithValue("@idMateria", dm.IdMateria);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Eliminar(int idDocenteMateria)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "DELETE FROM docente_materia WHERE id_docente_materia = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idDocenteMateria);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
