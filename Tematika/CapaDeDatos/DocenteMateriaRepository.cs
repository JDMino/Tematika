using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase DocenteMateriaRepository dentro del namespace Tematika.CapaDeDatos
    public class DocenteMateriaRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase DocenteMateriaRepository
        public DocenteMateriaRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público que obtiene todas las relaciones docente-materia
        public List<DocenteMateria> ObtenerTodas()
        {
            // Inicializa la lista que almacenará los resultados
            var lista = new List<DocenteMateria>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener todos los registros
            var query = "SELECT * FROM docente_materia";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Itera sobre los resultados obtenidos
            while (reader.Read())
            {
                // Agrega un nuevo objeto DocenteMateria a la lista con los datos del lector
                lista.Add(new DocenteMateria
                {
                    IdDocenteMateria = (int)reader["id_docente_materia"], // Asigna el id de la relación
                    IdUsuario = (int)reader["id_usuario"],                // Asigna el id del docente
                    IdMateria = (int)reader["id_materia"]                 // Asigna el id de la materia
                });
            }

            // Retorna la lista completa de relaciones docente-materia
            return lista;
        }

        // Método público para crear una nueva relación docente-materia
        public void Crear(DocenteMateria dm)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar una nueva relación
            var query = @"INSERT INTO docente_materia (id_usuario, id_materia)
                          VALUES (@idUsuario, @idMateria)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @idUsuario con el valor del objeto dm
            command.Parameters.AddWithValue("@idUsuario", dm.IdUsuario);
            // Agrega el parámetro @idMateria con el valor del objeto dm
            command.Parameters.AddWithValue("@idMateria", dm.IdMateria);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para insertar la relación
            command.ExecuteNonQuery();
        }

        // Método público para eliminar una relación docente-materia por su id
        public void Eliminar(int idDocenteMateria)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para eliminar la relación por id
            var query = "DELETE FROM docente_materia WHERE id_docente_materia = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor de idDocenteMateria
            command.Parameters.AddWithValue("@id", idDocenteMateria);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para eliminar la relación
            command.ExecuteNonQuery();
        }
    }
}
