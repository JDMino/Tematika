using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase NotaRepository dentro del namespace Tematika.CapaDeDatos
    public class NotaRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase NotaRepository
        public NotaRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público que obtiene todas las notas activas de un usuario
        public List<Nota> ObtenerPorUsuario(int idUsuario)
        {
            // Inicializa la lista que almacenará las notas obtenidas
            var lista = new List<Nota>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener notas no eliminadas por id_usuario
            var query = "SELECT * FROM nota WHERE id_usuario = @id AND eliminado = 0";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor de idUsuario
            command.Parameters.AddWithValue("@id", idUsuario);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Itera sobre los resultados obtenidos
            while (reader.Read())
            {
                // Agrega un nuevo objeto Nota a la lista con los datos del lector
                lista.Add(new Nota
                {
                    IdNota = (int)reader["id_nota"],                   // Asigna el id de la nota
                    Texto = reader["texto"].ToString() ?? "",          // Asigna el texto de la nota
                    Fecha = (DateTime)reader["fecha"],                 // Asigna la fecha de la nota
                    IdUsuario = (int)reader["id_usuario"],             // Asigna el id del usuario
                    IdRecurso = (int)reader["id_recurso"],             // Asigna el id del recurso
                    Eliminado = (bool)reader["eliminado"]              // Asigna el estado de eliminado
                });
            }

            // Retorna la lista de notas obtenidas
            return lista;
        }

        // Método público para crear una nueva nota
        public void Crear(Nota nota)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar una nueva nota con eliminado en false
            var query = @"INSERT INTO nota (texto, fecha, id_usuario, id_recurso, eliminado)
                          VALUES (@texto, @fecha, @idUsuario, @idRecurso, 0)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @texto con el valor del objeto nota
            command.Parameters.AddWithValue("@texto", nota.Texto);
            // Agrega el parámetro @fecha con el valor del objeto nota
            command.Parameters.AddWithValue("@fecha", nota.Fecha);
            // Agrega el parámetro @idUsuario con el valor del objeto nota
            command.Parameters.AddWithValue("@idUsuario", nota.IdUsuario);
            // Agrega el parámetro @idRecurso con el valor del objeto nota
            command.Parameters.AddWithValue("@idRecurso", nota.IdRecurso);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para insertar la nota
            command.ExecuteNonQuery();
        }

        // Método público para marcar una nota como eliminada
        public void Eliminar(int idNota)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para actualizar el campo eliminado a true
            var query = "UPDATE nota SET eliminado = 1 WHERE id_nota = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor de idNota
            command.Parameters.AddWithValue("@id", idNota);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para marcar la nota como eliminada
            command.ExecuteNonQuery();
        }

        // Método público que obtiene todas las notas activas del sistema
        public List<Nota> ObtenerTodas()
        {
            // Inicializa la lista que almacenará las notas obtenidas
            var lista = new List<Nota>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener todas las notas no eliminadas
            var query = "SELECT * FROM nota WHERE eliminado = 0";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Itera sobre los resultados obtenidos
            while (reader.Read())
            {
                // Agrega un nuevo objeto Nota a la lista con los datos del lector
                lista.Add(new Nota
                {
                    IdNota = (int)reader["id_nota"],                   // Asigna el id de la nota
                    Texto = reader["texto"].ToString() ?? "",          // Asigna el texto de la nota
                    Fecha = (DateTime)reader["fecha"],                 // Asigna la fecha de la nota
                    IdUsuario = (int)reader["id_usuario"],             // Asigna el id del usuario
                    IdRecurso = (int)reader["id_recurso"],             // Asigna el id del recurso
                    Eliminado = (bool)reader["eliminado"]              // Asigna el estado de eliminado
                });
            }

            // Retorna la lista de notas obtenidas
            return lista;
        }

    }
}
