using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase MateriaRepository dentro del namespace Tematika.CapaDeDatos
    public class MateriaRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase MateriaRepository
        public MateriaRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público que obtiene todas las materias registradas
        public List<Materia> ObtenerTodas()
        {
            // Inicializa la lista que almacenará las materias obtenidas
            var materias = new List<Materia>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener todas las materias
            var query = "SELECT * FROM materia";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Itera sobre los resultados obtenidos
            while (reader.Read())
            {
                // Agrega un nuevo objeto Materia a la lista con los datos del lector
                materias.Add(new Materia
                {
                    IdMateria = (int)reader["id_materia"],                   // Asigna el id de la materia
                    Nombre = reader["nombre"].ToString() ?? "",              // Asigna el nombre de la materia
                    Nivel = reader["nivel"].ToString(),                      // Asigna el nivel de la materia
                    Descripcion = reader["descripcion"].ToString(),          // Asigna la descripción
                    Eliminado = (bool)reader["eliminado"]                    // Asigna el estado de eliminado
                });
            }

            // Retorna la lista de materias obtenidas
            return materias;
        }

        // Método público para obtener una materia por su id
        public Materia? ObtenerPorId(int id)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener la materia por id
            var query = "SELECT * FROM materia WHERE id_materia = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor recibido
            command.Parameters.AddWithValue("@id", id);
            // Abre la conexión a la base de datos
            connection.Open();

            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();
            // Retorna el objeto Materia si se encuentra, o null si no hay resultados
            return reader.Read() ? new Materia
            {
                IdMateria = (int)reader["id_materia"],                   // Asigna el id de la materia
                Nombre = reader["nombre"].ToString() ?? "",              // Asigna el nombre de la materia
                Nivel = reader["nivel"].ToString(),                      // Asigna el nivel de la materia
                Descripcion = reader["descripcion"].ToString(),          // Asigna la descripción
                Eliminado = (bool)reader["eliminado"]                    // Asigna el estado de eliminado
            } : null;
        }

        // Método público para crear una nueva materia
        public void Crear(Materia materia)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar una nueva materia con eliminado en false
            var query = @"INSERT INTO materia (nombre, nivel, descripcion, eliminado)
                          VALUES (@nombre, @nivel, @descripcion, 0)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @nombre con el valor del objeto materia
            command.Parameters.AddWithValue("@nombre", materia.Nombre);
            // Agrega el parámetro @nivel con el valor del objeto materia o DBNull si es null
            command.Parameters.AddWithValue("@nivel", materia.Nivel ?? (object)DBNull.Value);
            // Agrega el parámetro @descripcion con el valor del objeto materia o DBNull si es null
            command.Parameters.AddWithValue("@descripcion", materia.Descripcion ?? (object)DBNull.Value);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para insertar la materia
            command.ExecuteNonQuery();
        }

        // Método público para actualizar una materia existente
        public void Actualizar(Materia materia)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para actualizar los campos de la materia
            var query = @"UPDATE materia SET nombre = @nombre, nivel = @nivel,
                          descripcion = @descripcion, eliminado = @eliminado
                          WHERE id_materia = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el id de la materia
            command.Parameters.AddWithValue("@id", materia.IdMateria);
            // Agrega el parámetro @nombre con el nuevo valor
            command.Parameters.AddWithValue("@nombre", materia.Nombre);
            // Agrega el parámetro @nivel con el nuevo valor o DBNull si es null
            command.Parameters.AddWithValue("@nivel", materia.Nivel ?? (object)DBNull.Value);
            // Agrega el parámetro @descripcion con el nuevo valor o DBNull si es null
            command.Parameters.AddWithValue("@descripcion", materia.Descripcion ?? (object)DBNull.Value);
            // Agrega el parámetro @eliminado con el nuevo valor booleano convertido a entero
            command.Parameters.AddWithValue("@eliminado", materia.Eliminado ? 1 : 0);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para actualizar la materia
            command.ExecuteNonQuery();
        }

        // Método público para marcar una materia como eliminada
        public void Eliminar(int id)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para actualizar el campo eliminado a true
            var query = "UPDATE materia SET eliminado = 1 WHERE id_materia = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor recibido
            command.Parameters.AddWithValue("@id", id);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para marcar la materia como eliminada
            command.ExecuteNonQuery();
        }
    }
}
