using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase OpcionPreguntaRepository dentro del namespace Tematika.CapaDeDatos
    public class OpcionPreguntaRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase OpcionPreguntaRepository
        public OpcionPreguntaRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público que obtiene todas las opciones asociadas a una pregunta
        public List<OpcionPregunta> ObtenerPorPregunta(int idPregunta)
        {
            // Inicializa la lista que almacenará las opciones obtenidas
            var lista = new List<OpcionPregunta>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener opciones por id_pregunta
            var query = "SELECT * FROM opcion_pregunta WHERE id_pregunta = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor de idPregunta
            command.Parameters.AddWithValue("@id", idPregunta);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Itera sobre los resultados obtenidos
            while (reader.Read())
            {
                // Agrega un nuevo objeto OpcionPregunta a la lista con los datos del lector
                lista.Add(new OpcionPregunta
                {
                    IdOpcion = (int)reader["id_opcion"],               // Asigna el id de la opción
                    Texto = reader["texto"].ToString() ?? "",          // Asigna el texto de la opción
                    EsCorrecta = (bool)reader["es_correcta"],          // Asigna si la opción es correcta
                    IdPregunta = (int)reader["id_pregunta"]            // Asigna el id de la pregunta
                });
            }

            // Retorna la lista de opciones obtenidas
            return lista;
        }

        // Método público para crear una nueva opción de pregunta
        public void Crear(OpcionPregunta opcion)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar una nueva opción
            var query = @"INSERT INTO opcion_pregunta (texto, es_correcta, id_pregunta)
                          VALUES (@texto, @esCorrecta, @idPregunta)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @texto con el valor del objeto opcion
            command.Parameters.AddWithValue("@texto", opcion.Texto);
            // Agrega el parámetro @esCorrecta con el valor del objeto opcion
            command.Parameters.AddWithValue("@esCorrecta", opcion.EsCorrecta);
            // Agrega el parámetro @idPregunta con el valor del objeto opcion
            command.Parameters.AddWithValue("@idPregunta", opcion.IdPregunta);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para insertar la opción
            command.ExecuteNonQuery();
        }

        // Método público para eliminar todas las opciones asociadas a una pregunta
        public void EliminarPorPregunta(int idPregunta)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para eliminar opciones por id_pregunta
            var query = "DELETE FROM opcion_pregunta WHERE id_pregunta = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor de idPregunta
            command.Parameters.AddWithValue("@id", idPregunta);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para eliminar las opciones
            command.ExecuteNonQuery();
        }

        // Método público para actualizar una opción existente
        public void Actualizar(OpcionPregunta opcion)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para actualizar los campos de la opción
            var query = @"UPDATE opcion_pregunta SET texto = @texto, es_correcta = @esCorrecta
                  WHERE id_opcion = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el id de la opción
            command.Parameters.AddWithValue("@id", opcion.IdOpcion);
            // Agrega el parámetro @texto con el nuevo valor
            command.Parameters.AddWithValue("@texto", opcion.Texto);
            // Agrega el parámetro @esCorrecta con el nuevo valor
            command.Parameters.AddWithValue("@esCorrecta", opcion.EsCorrecta);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para actualizar la opción
            command.ExecuteNonQuery();
        }

    }
}
