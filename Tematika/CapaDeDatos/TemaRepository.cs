using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase TemaRepository dentro del namespace Tematika.CapaDeDatos
    public class TemaRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase TemaRepository
        public TemaRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público que obtiene todos los temas registrados
        public List<Tema> ObtenerTodos()
        {
            // Inicializa la lista que almacenará los temas obtenidos
            var temas = new List<Tema>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener todos los temas
            var query = "SELECT * FROM tema";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Itera sobre los resultados obtenidos
            while (reader.Read())
            {
                // Agrega un nuevo objeto Tema a la lista con los datos del lector
                temas.Add(new Tema
                {
                    IdTema = (int)reader["id_tema"],                   // Asigna el id del tema
                    Nombre = reader["nombre"].ToString() ?? "",        // Asigna el nombre del tema
                    IdMateria = (int)reader["id_materia"],             // Asigna el id de la materia asociada
                    Eliminado = (bool)reader["eliminado"]              // Asigna el estado de eliminado
                });
            }

            // Retorna la lista de temas obtenidos
            return temas;
        }

        // Método público para obtener un tema por su id
        public Tema? ObtenerPorId(int id)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener el tema por id
            var query = "SELECT * FROM tema WHERE id_tema = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor recibido
            command.Parameters.AddWithValue("@id", id);
            // Abre la conexión a la base de datos
            connection.Open();

            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();
            // Retorna el objeto Tema si se encuentra, o null si no hay resultados
            return reader.Read() ? new Tema
            {
                IdTema = (int)reader["id_tema"],                   // Asigna el id del tema
                Nombre = reader["nombre"].ToString() ?? "",        // Asigna el nombre del tema
                IdMateria = (int)reader["id_materia"],             // Asigna el id de la materia asociada
                Eliminado = (bool)reader["eliminado"]              // Asigna el estado de eliminado
            } : null;
        }

        // Método público para crear un nuevo tema
        public void Crear(Tema tema)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar un nuevo tema con eliminado en false
            var query = @"INSERT INTO tema (nombre, id_materia, eliminado)
                          VALUES (@nombre, @idMateria, 0)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @nombre con el valor del objeto tema
            command.Parameters.AddWithValue("@nombre", tema.Nombre);
            // Agrega el parámetro @idMateria con el valor del objeto tema
            command.Parameters.AddWithValue("@idMateria", tema.IdMateria);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para insertar el tema
            command.ExecuteNonQuery();
        }

        // Método público para actualizar un tema existente
        public void Actualizar(Tema tema)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para actualizar los campos del tema
            var query = @"UPDATE tema SET nombre = @nombre, id_materia = @idMateria, eliminado = @eliminado
                          WHERE id_tema = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el id del tema
            command.Parameters.AddWithValue("@id", tema.IdTema);
            // Agrega el parámetro @nombre con el nuevo valor
            command.Parameters.AddWithValue("@nombre", tema.Nombre);
            // Agrega el parámetro @idMateria con el nuevo valor
            command.Parameters.AddWithValue("@idMateria", tema.IdMateria);
            // Agrega el parámetro @eliminado con el nuevo estado booleano convertido a entero
            command.Parameters.AddWithValue("@eliminado", tema.Eliminado ? 1 : 0);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para actualizar el tema
            command.ExecuteNonQuery();
        }

        // Método público para marcar un tema como eliminado
        public void Eliminar(int id)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para actualizar el campo eliminado a true
            var query = "UPDATE tema SET eliminado = 1 WHERE id_tema = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor recibido
            command.Parameters.AddWithValue("@id", id);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para marcar el tema como eliminado
            command.ExecuteNonQuery();
        }
    }
}
