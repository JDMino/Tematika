using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase PreguntaRepository dentro del namespace Tematika.CapaDeDatos
    public class PreguntaRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase PreguntaRepository
        public PreguntaRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público que obtiene todas las preguntas registradas
        public List<Pregunta> ObtenerTodas()
        {
            // Inicializa la lista que almacenará las preguntas obtenidas
            var lista = new List<Pregunta>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener todas las preguntas
            var query = "SELECT * FROM pregunta";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Itera sobre los resultados obtenidos
            while (reader.Read())
            {
                // Agrega un nuevo objeto Pregunta a la lista con los datos del lector
                lista.Add(new Pregunta
                {
                    IdPregunta = (int)reader["id_pregunta"],                   // Asigna el id de la pregunta
                    Enunciado = reader["enunciado"].ToString() ?? "",         // Asigna el enunciado de la pregunta
                    OpcionCorrecta = reader["opcion_correcta"].ToString() ?? "", // Asigna el texto de la opción correcta
                    IdEvaluacion = (int)reader["id_evaluacion"]               // Asigna el id de la evaluación asociada
                });
            }

            // Retorna la lista de preguntas obtenidas
            return lista;
        }

        // Método público para crear una nueva pregunta
        public void Crear(Pregunta pregunta)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar una nueva pregunta
            var query = @"INSERT INTO pregunta (enunciado, opcion_correcta, id_evaluacion)
                          VALUES (@enunciado, @correcta, @idEval)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @enunciado con el valor del objeto pregunta
            command.Parameters.AddWithValue("@enunciado", pregunta.Enunciado);
            // Agrega el parámetro @correcta con el valor del objeto pregunta
            command.Parameters.AddWithValue("@correcta", pregunta.OpcionCorrecta);
            // Agrega el parámetro @idEval con el valor del objeto pregunta
            command.Parameters.AddWithValue("@idEval", pregunta.IdEvaluacion);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para insertar la pregunta
            command.ExecuteNonQuery();
        }

        // Método público para actualizar una pregunta existente
        public void Actualizar(Pregunta pregunta)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para actualizar los campos de la pregunta
            var query = @"UPDATE pregunta SET enunciado = @enunciado,
                          opcion_correcta = @correcta, id_evaluacion = @idEval
                          WHERE id_pregunta = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el id de la pregunta
            command.Parameters.AddWithValue("@id", pregunta.IdPregunta);
            // Agrega el parámetro @enunciado con el nuevo valor
            command.Parameters.AddWithValue("@enunciado", pregunta.Enunciado);
            // Agrega el parámetro @correcta con el nuevo valor
            command.Parameters.AddWithValue("@correcta", pregunta.OpcionCorrecta);
            // Agrega el parámetro @idEval con el nuevo valor
            command.Parameters.AddWithValue("@idEval", pregunta.IdEvaluacion);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para actualizar la pregunta
            command.ExecuteNonQuery();
        }

        // Método público para eliminar una pregunta por su id
        public void Eliminar(int id)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para eliminar la pregunta por id
            var query = "DELETE FROM pregunta WHERE id_pregunta = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor recibido
            command.Parameters.AddWithValue("@id", id);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para eliminar la pregunta
            command.ExecuteNonQuery();
        }
    }
}
