using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase EvaluacionRepository dentro del namespace Tematika.CapaDeDatos
    public class EvaluacionRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase EvaluacionRepository
        public EvaluacionRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público que obtiene todas las evaluaciones
        public List<Evaluacion> ObtenerTodas()
        {
            // Inicializa la lista que almacenará las evaluaciones
            var lista = new List<Evaluacion>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener todas las evaluaciones
            var query = "SELECT * FROM evaluacion";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Itera sobre los resultados obtenidos
            while (reader.Read())
            {
                // Agrega un nuevo objeto Evaluacion a la lista con los datos del lector
                lista.Add(new Evaluacion
                {
                    IdEvaluacion = (int)reader["id_evaluacion"], // Asigna el id de la evaluación
                    IdTema = (int)reader["id_tema"],              // Asigna el id del tema
                    Eliminado = (bool)reader["eliminado"]         // Asigna el estado de eliminado
                });
            }

            // Retorna la lista de evaluaciones obtenidas
            return lista;
        }

        // Método público que obtiene una evaluación por su id
        public Evaluacion? ObtenerPorId(int id)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener la evaluación por id
            var query = "SELECT * FROM evaluacion WHERE id_evaluacion = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor recibido
            command.Parameters.AddWithValue("@id", id);
            // Abre la conexión a la base de datos
            connection.Open();

            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();
            // Retorna el objeto Evaluacion si se encuentra, o null si no hay resultados
            return reader.Read() ? new Evaluacion
            {
                IdEvaluacion = (int)reader["id_evaluacion"], // Asigna el id de la evaluación
                IdTema = (int)reader["id_tema"],              // Asigna el id del tema
                Eliminado = (bool)reader["eliminado"]         // Asigna el estado de eliminado
            } : null;
        }

        // Método público que obtiene una evaluación por idTema
        public Evaluacion? ObtenerPorTema(int idTema)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener la evaluación por id_tema
            var query = "SELECT * FROM evaluacion WHERE id_tema = @idTema";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @idTema con el valor recibido
            command.Parameters.AddWithValue("@idTema", idTema);
            // Abre la conexión a la base de datos
            connection.Open();

            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();
            // Retorna el objeto Evaluacion si se encuentra, o null si no hay resultados
            return reader.Read() ? new Evaluacion
            {
                IdEvaluacion = (int)reader["id_evaluacion"], // Asigna el id de la evaluación
                IdTema = (int)reader["id_tema"],              // Asigna el id del tema
                Eliminado = (bool)reader["eliminado"]         // Asigna el estado de eliminado
            } : null;
        }

        // Método público para insertar una nueva evaluación en la base de datos
        public void Crear(Evaluacion evaluacion)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar una nueva evaluación
            var query = @"INSERT INTO evaluacion (id_tema, eliminado)
                          VALUES (@idTema, @eliminado)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @idTema con el valor del objeto evaluacion
            command.Parameters.AddWithValue("@idTema", evaluacion.IdTema);
            // Agrega el parámetro @eliminado con el valor booleano convertido a entero
            command.Parameters.AddWithValue("@eliminado", evaluacion.Eliminado ? 1 : 0);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para insertar la evaluación
            command.ExecuteNonQuery();
        }

        // Método público para actualizar una evaluación existente
        public void Actualizar(Evaluacion evaluacion)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para actualizar los campos de la evaluación
            var query = @"UPDATE evaluacion SET id_tema = @idTema, eliminado = @eliminado
                          WHERE id_evaluacion = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el id de la evaluación
            command.Parameters.AddWithValue("@id", evaluacion.IdEvaluacion);
            // Agrega el parámetro @idTema con el nuevo valor
            command.Parameters.AddWithValue("@idTema", evaluacion.IdTema);
            // Agrega el parámetro @eliminado con el nuevo valor booleano convertido a entero
            command.Parameters.AddWithValue("@eliminado", evaluacion.Eliminado ? 1 : 0);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para actualizar la evaluación
            command.ExecuteNonQuery();
        }

        // Método público para marcar una evaluación como eliminada
        public void Eliminar(int id)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para actualizar el campo eliminado a true
            var query = "UPDATE evaluacion SET eliminado = 1 WHERE id_evaluacion = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor recibido
            command.Parameters.AddWithValue("@id", id);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para marcar la evaluación como eliminada
            command.ExecuteNonQuery();
        }
    }
}
