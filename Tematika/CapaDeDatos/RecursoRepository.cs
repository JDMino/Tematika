using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase RecursoRepository dentro del namespace Tematika.CapaDeDatos
    public class RecursoRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase RecursoRepository
        public RecursoRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público que obtiene todos los recursos registrados
        public List<Recurso> ObtenerTodos()
        {
            // Inicializa la lista que almacenará los recursos obtenidos
            var recursos = new List<Recurso>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener todos los recursos
            var query = "SELECT * FROM recurso";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Itera sobre los resultados obtenidos
            while (reader.Read())
            {
                // Agrega un nuevo objeto Recurso a la lista con los datos del lector
                recursos.Add(new Recurso
                {
                    IdRecurso = (int)reader["id_recurso"],                         // Asigna el id del recurso
                    Titulo = reader["titulo"].ToString() ?? "",                    // Asigna el título del recurso
                    Texto = reader["texto"]?.ToString(),                           // Asigna el texto del recurso (nullable)
                    Ruta = reader["ruta"]?.ToString(),                             // Asigna la ruta del recurso (nullable)
                    Url = reader["url"]?.ToString(),                               // Asigna la URL del recurso (nullable)
                    Tipo = reader["tipo"].ToString() ?? "",                        // Asigna el tipo de recurso
                    FechaCreacion = (DateTime)reader["fecha_creacion"],           // Asigna la fecha de creación
                    FechaModificacion = (DateTime)reader["fecha_modificacion"],   // Asigna la fecha de modificación
                    IdTema = (int)reader["id_tema"],                               // Asigna el id del tema asociado
                    Eliminado = (bool)reader["eliminado"]                          // Asigna el estado de eliminado
                });
            }

            // Retorna la lista de recursos obtenidos
            return recursos;
        }

        // Método público para obtener un recurso por su id
        public Recurso? ObtenerPorId(int id)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener el recurso por id
            var query = "SELECT * FROM recurso WHERE id_recurso = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor recibido
            command.Parameters.AddWithValue("@id", id);
            // Abre la conexión a la base de datos
            connection.Open();

            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();
            // Retorna el objeto Recurso si se encuentra, o null si no hay resultados
            return reader.Read() ? new Recurso
            {
                IdRecurso = (int)reader["id_recurso"],                         // Asigna el id del recurso
                Titulo = reader["titulo"].ToString() ?? "",                    // Asigna el título del recurso
                Texto = reader["texto"]?.ToString(),                           // Asigna el texto del recurso (nullable)
                Ruta = reader["ruta"]?.ToString(),                             // Asigna la ruta del recurso (nullable)
                Url = reader["url"]?.ToString(),                               // Asigna la URL del recurso (nullable)
                Tipo = reader["tipo"].ToString() ?? "",                        // Asigna el tipo de recurso
                FechaCreacion = (DateTime)reader["fecha_creacion"],           // Asigna la fecha de creación
                FechaModificacion = (DateTime)reader["fecha_modificacion"],   // Asigna la fecha de modificación
                IdTema = (int)reader["id_tema"],                               // Asigna el id del tema asociado
                Eliminado = (bool)reader["eliminado"]                          // Asigna el estado de eliminado
            } : null;
        }

        // Método público para crear un nuevo recurso
        public void Crear(Recurso recurso)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar un nuevo recurso con eliminado en false
            var query = @"INSERT INTO recurso (titulo, texto, ruta, url, tipo, fecha_creacion, fecha_modificacion, id_tema, eliminado)
                          VALUES (@titulo, @texto, @ruta, @url, @tipo, @creacion, @modificacion, @idTema, 0)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @titulo con el valor del objeto recurso
            command.Parameters.AddWithValue("@titulo", recurso.Titulo);
            // Agrega el parámetro @texto con el valor o DBNull si es null
            command.Parameters.AddWithValue("@texto", recurso.Texto ?? (object)DBNull.Value);
            // Agrega el parámetro @ruta con el valor o DBNull si es null
            command.Parameters.AddWithValue("@ruta", recurso.Ruta ?? (object)DBNull.Value);
            // Agrega el parámetro @url con el valor o DBNull si es null
            command.Parameters.AddWithValue("@url", recurso.Url ?? (object)DBNull.Value);
            // Agrega el parámetro @tipo con el valor del objeto recurso
            command.Parameters.AddWithValue("@tipo", recurso.Tipo);
            // Agrega el parámetro @creacion con la fecha de creación
            command.Parameters.AddWithValue("@creacion", recurso.FechaCreacion);
            // Agrega el parámetro @modificacion con la fecha de modificación
            command.Parameters.AddWithValue("@modificacion", recurso.FechaModificacion);
            // Agrega el parámetro @idTema con el id del tema asociado
            command.Parameters.AddWithValue("@idTema", recurso.IdTema);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para insertar el recurso
            command.ExecuteNonQuery();
        }

        // Método público para actualizar un recurso existente
        public void Actualizar(Recurso recurso)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para actualizar los campos del recurso
            var query = @"UPDATE recurso SET titulo = @titulo, texto = @texto, ruta = @ruta, url = @url, tipo = @tipo,
                          fecha_modificacion = @modificacion, id_tema = @idTema, eliminado = @eliminado
                          WHERE id_recurso = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el id del recurso
            command.Parameters.AddWithValue("@id", recurso.IdRecurso);
            // Agrega el parámetro @titulo con el nuevo valor
            command.Parameters.AddWithValue("@titulo", recurso.Titulo);
            // Agrega el parámetro @texto con el nuevo valor o DBNull si es null
            command.Parameters.AddWithValue("@texto", recurso.Texto ?? (object)DBNull.Value);
            // Agrega el parámetro @ruta con el nuevo valor o DBNull si es null
            command.Parameters.AddWithValue("@ruta", recurso.Ruta ?? (object)DBNull.Value);
            // Agrega el parámetro @url con el nuevo valor o DBNull si es null
            command.Parameters.AddWithValue("@url", recurso.Url ?? (object)DBNull.Value);
            // Agrega el parámetro @tipo con el nuevo valor
            command.Parameters.AddWithValue("@tipo", recurso.Tipo);
            // Agrega el parámetro @modificacion con la nueva fecha de modificación
            command.Parameters.AddWithValue("@modificacion", recurso.FechaModificacion);
            // Agrega el parámetro @idTema con el nuevo id de tema
            command.Parameters.AddWithValue("@idTema", recurso.IdTema);
            // Agrega el parámetro @eliminado con el nuevo estado booleano
            command.Parameters.AddWithValue("@eliminado", recurso.Eliminado);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para actualizar el recurso
            command.ExecuteNonQuery();
        }

        // Método público para marcar un recurso como eliminado
        public void Eliminar(int id)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para actualizar el campo eliminado a true
            var query = "UPDATE recurso SET eliminado = 1 WHERE id_recurso = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor recibido
            command.Parameters.AddWithValue("@id", id);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para marcar el recurso como eliminado
            command.ExecuteNonQuery();
        }
    }
}
