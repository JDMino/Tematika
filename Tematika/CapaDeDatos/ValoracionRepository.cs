using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase ValoracionRepository dentro del namespace Tematika.CapaDeDatos
    public class ValoracionRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase ValoracionRepository
        public ValoracionRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público que obtiene todas las valoraciones asociadas a un recurso
        public List<Valoracion> ObtenerPorRecurso(int idRecurso)
        {
            // Inicializa la lista que almacenará las valoraciones obtenidas
            var lista = new List<Valoracion>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener valoraciones por id_recurso
            var query = "SELECT * FROM valoracion WHERE id_recurso = @id";

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
                // Agrega un nuevo objeto Valoracion a la lista con los datos del lector
                lista.Add(new Valoracion
                {
                    IdValoracion = (int)reader["id_valoracion"],       // Asigna el id de la valoración
                    Puntuacion = (int)reader["puntuacion"],            // Asigna la puntuación
                    Fecha = (DateTime)reader["fecha"],                 // Asigna la fecha de la valoración
                    IdUsuario = (int)reader["id_usuario"],             // Asigna el id del usuario
                    IdRecurso = (int)reader["id_recurso"]              // Asigna el id del recurso
                });
            }

            // Retorna la lista de valoraciones obtenidas
            return lista;
        }

        // Método público para crear una nueva valoración
        public void Crear(Valoracion valoracion)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar una nueva valoración
            var query = @"INSERT INTO valoracion (puntuacion, fecha, id_usuario, id_recurso)
                          VALUES (@puntuacion, @fecha, @idUsuario, @idRecurso)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega los parámetros con los valores del objeto valoracion
            command.Parameters.AddWithValue("@puntuacion", valoracion.Puntuacion);
            command.Parameters.AddWithValue("@fecha", valoracion.Fecha);
            command.Parameters.AddWithValue("@idUsuario", valoracion.IdUsuario);
            command.Parameters.AddWithValue("@idRecurso", valoracion.IdRecurso);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para insertar la valoración
            command.ExecuteNonQuery();
        }

        // Método público para obtener una valoración específica por usuario y recurso
        public Valoracion? ObtenerPorUsuarioYRecurso(int idUsuario, int idRecurso)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener la valoración por id_usuario e id_recurso
            var query = "SELECT * FROM valoracion WHERE id_usuario = @idUsuario AND id_recurso = @idRecurso";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega los parámetros con los valores recibidos
            command.Parameters.AddWithValue("@idUsuario", idUsuario);
            command.Parameters.AddWithValue("@idRecurso", idRecurso);
            // Abre la conexión a la base de datos
            connection.Open();

            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();
            // Retorna el objeto Valoracion si se encuentra, o null si no hay resultados
            return reader.Read() ? new Valoracion
            {
                IdValoracion = (int)reader["id_valoracion"],       // Asigna el id de la valoración
                Puntuacion = (int)reader["puntuacion"],            // Asigna la puntuación
                Fecha = (DateTime)reader["fecha"],                 // Asigna la fecha de la valoración
                IdUsuario = (int)reader["id_usuario"],             // Asigna el id del usuario
                IdRecurso = (int)reader["id_recurso"]              // Asigna el id del recurso
            } : null;
        }

        // Método público para actualizar una valoración existente
        public void Actualizar(Valoracion valoracion)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para actualizar los campos de la valoración
            var query = @"UPDATE valoracion SET puntuacion = @puntuacion, fecha = @fecha
                  WHERE id_valoracion = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega los parámetros con los valores del objeto valoracion
            command.Parameters.AddWithValue("@id", valoracion.IdValoracion);
            command.Parameters.AddWithValue("@puntuacion", valoracion.Puntuacion);
            command.Parameters.AddWithValue("@fecha", valoracion.Fecha);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para actualizar la valoración
            command.ExecuteNonQuery();
        }
    }
}
