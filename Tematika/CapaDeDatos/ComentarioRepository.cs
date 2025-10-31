using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class ComentarioRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase ComentarioRepository
        public ComentarioRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público que obtiene una lista de comentarios filtrados por idRecurso
        public List<Comentario> ObtenerPorRecurso(int idRecurso)
        {
            // Inicializa la lista que almacenará los comentarios obtenidos
            var lista = new List<Comentario>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener comentarios por id_recurso
            var query = "SELECT * FROM comentario WHERE id_recurso = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor de idRecurso
            command.Parameters.AddWithValue("@id", idRecurso);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Itera sobre los resultados obtenidos
            while (reader.Read())
            {
                // Agrega un nuevo objeto Comentario a la lista con los datos del lector
                lista.Add(new Comentario
                {
                    IdComentario = (int)reader["id_comentario"], // Asigna el id del comentario
                    Texto = reader["texto"].ToString() ?? "",     // Asigna el texto del comentario
                    Fecha = (DateTime)reader["fecha"],            // Asigna la fecha del comentario
                    IdUsuario = (int)reader["id_usuario"],        // Asigna el id del usuario
                    IdRecurso = (int)reader["id_recurso"]         // Asigna el id del recurso
                });
            }

            // Retorna la lista de comentarios obtenidos
            return lista;
        }

        // Método público para crear un nuevo comentario en la base de datos
        public void Crear(Comentario comentario)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar un nuevo comentario
            var query = @"INSERT INTO comentario (texto, fecha, id_usuario, id_recurso)
                          VALUES (@texto, @fecha, @idUsuario, @idRecurso)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega los parámetros con los valores del objeto Comentario
            command.Parameters.AddWithValue("@texto", comentario.Texto);
            command.Parameters.AddWithValue("@fecha", comentario.Fecha);
            command.Parameters.AddWithValue("@idUsuario", comentario.IdUsuario);
            command.Parameters.AddWithValue("@idRecurso", comentario.IdRecurso);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para insertar el comentario
            command.ExecuteNonQuery();
        }
    }
}
