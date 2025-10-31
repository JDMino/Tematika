using System;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase SuscripcionRepository dentro del namespace Tematika.CapaDeDatos
    public class SuscripcionRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;
        // Campo privado para acceder al repositorio de tipo de suscripción
        private readonly TipoSuscripcionRepository tipoRepo;

        // Constructor de la clase SuscripcionRepository
        public SuscripcionRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;

            // Inicializa el repositorio de tipo de suscripción
            tipoRepo = new TipoSuscripcionRepository();
        }

        // Método público para crear una nueva suscripción y retornar su id generado
        public int Crear(Suscripcion suscripcion)
        {
            // Obtener duración desde tipo_suscripcion
            var tipo = tipoRepo.ObtenerPorId(suscripcion.IdTipoSuscripcion);
            // Si no se encuentra el tipo, lanza excepción
            if (tipo == null)
                throw new Exception("Tipo de suscripción no válido.");

            // Calcula la fecha de finalización sumando la duración al inicio
            suscripcion.FechaFin = suscripcion.FechaInicio.AddDays(tipo.DuracionDias);

            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar una suscripción y retornar el id generado
            var query = @"INSERT INTO suscripcion (id_usuario, id_tipo_suscripcion, activa, fecha_inicio, fecha_fin)
                          OUTPUT INSERTED.id_suscripcion
                          VALUES (@idUsuario, @idTipo, @activa, @fechaInicio, @fechaFin)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega los parámetros con los valores del objeto suscripción
            command.Parameters.AddWithValue("@idUsuario", suscripcion.IdUsuario);
            command.Parameters.AddWithValue("@idTipo", suscripcion.IdTipoSuscripcion);
            command.Parameters.AddWithValue("@activa", suscripcion.Activa);
            command.Parameters.AddWithValue("@fechaInicio", suscripcion.FechaInicio);
            command.Parameters.AddWithValue("@fechaFin", suscripcion.FechaFin ?? (object)DBNull.Value);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y retorna el id generado de la suscripción
            return (int)command.ExecuteScalar();
        }

        // Método público para obtener todas las suscripciones de un usuario
        public List<Suscripcion> ObtenerPorUsuario(int idUsuario)
        {
            // Inicializa la lista que almacenará las suscripciones obtenidas
            var lista = new List<Suscripcion>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL con JOIN para obtener datos del tipo de suscripción
            var query = @"SELECT s.id_suscripcion, s.activa, s.fecha_inicio, s.fecha_fin, t.nombre AS tipo
                  FROM suscripcion s
                  JOIN tipo_suscripcion t ON s.id_tipo_suscripcion = t.id_tipo_suscripcion
                  WHERE s.id_usuario = @id";

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
                // Agrega un nuevo objeto Suscripcion a la lista con los datos del lector
                lista.Add(new Suscripcion
                {
                    IdSuscripcion = (int)reader["id_suscripcion"],             // Asigna el id de la suscripción
                    Activa = (bool)reader["activa"],                           // Asigna el estado de activa
                    FechaInicio = (DateTime)reader["fecha_inicio"],           // Asigna la fecha de inicio
                    FechaFin = reader["fecha_fin"] as DateTime?,              // Asigna la fecha de fin (nullable)
                    Tipo = new TipoSuscripcion { Nombre = reader["tipo"].ToString() ?? "" } // Asigna el nombre del tipo
                });
            }

            // Retorna la lista de suscripciones obtenidas
            return lista;
        }

        // Método público para obtener todas las suscripciones del sistema
        public List<Suscripcion> ObtenerTodas()
        {
            // Inicializa la lista que almacenará las suscripciones obtenidas
            var lista = new List<Suscripcion>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL con JOIN para obtener todos los datos del tipo de suscripción
            var query = @"SELECT s.*, t.nombre, t.precio, t.duracion_dias
                  FROM suscripcion s
                  JOIN tipo_suscripcion t ON s.id_tipo_suscripcion = t.id_tipo_suscripcion";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Itera sobre los resultados obtenidos
            while (reader.Read())
            {
                // Agrega un nuevo objeto Suscripcion a la lista con los datos del lector
                lista.Add(new Suscripcion
                {
                    IdSuscripcion = (int)reader["id_suscripcion"],             // Asigna el id de la suscripción
                    IdUsuario = (int)reader["id_usuario"],                     // Asigna el id del usuario
                    IdTipoSuscripcion = (int)reader["id_tipo_suscripcion"],    // Asigna el id del tipo de suscripción
                    Activa = (bool)reader["activa"],                           // Asigna el estado de activa
                    FechaInicio = (DateTime)reader["fecha_inicio"],           // Asigna la fecha de inicio
                    FechaFin = reader["fecha_fin"] as DateTime?,              // Asigna la fecha de fin (nullable)
                    Tipo = new TipoSuscripcion
                    {
                        IdTipoSuscripcion = (int)reader["id_tipo_suscripcion"], // Asigna el id del tipo
                        Nombre = reader["nombre"].ToString() ?? "",             // Asigna el nombre del tipo
                        Precio = (decimal)reader["precio"],                     // Asigna el precio del tipo
                        DuracionDias = (int)reader["duracion_dias"]            // Asigna la duración en días
                    }
                });
            }

            // Retorna la lista de suscripciones obtenidas
            return lista;
        }

        // Método público para desactivar una suscripción por su id
        public void DarDeBaja(int idSuscripcion)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para actualizar el campo activa a false
            var query = "UPDATE suscripcion SET activa = 0 WHERE id_suscripcion = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor recibido
            command.Parameters.AddWithValue("@id", idSuscripcion);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para desactivar la suscripción
            command.ExecuteNonQuery();
        }

    }
}