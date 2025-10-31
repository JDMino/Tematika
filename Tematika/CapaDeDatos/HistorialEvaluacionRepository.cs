using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase HistorialEvaluacionRepository dentro del namespace Tematika.CapaDeDatos
    public class HistorialEvaluacionRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase HistorialEvaluacionRepository
        public HistorialEvaluacionRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público para crear un nuevo historial de evaluación
        public void Crear(HistorialEvaluacion historial)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar un nuevo historial y devolver el id generado
            var query = @"INSERT INTO historial_evaluacion (id_usuario, id_evaluacion, fecha_inicio)
                          VALUES (@idUsuario, @idEvaluacion, @fechaInicio);
                          SELECT SCOPE_IDENTITY();";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @idUsuario con el valor del objeto historial
            command.Parameters.AddWithValue("@idUsuario", historial.IdUsuario);
            // Agrega el parámetro @idEvaluacion con el valor del objeto historial
            command.Parameters.AddWithValue("@idEvaluacion", historial.IdEvaluacion);
            // Agrega el parámetro @fechaInicio con el valor del objeto historial
            command.Parameters.AddWithValue("@fechaInicio", historial.FechaInicio);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y asigna el id generado al objeto historial
            historial.IdHistorial = Convert.ToInt32(command.ExecuteScalar());
        }

        // Método público para finalizar un historial de evaluación existente
        public void Finalizar(HistorialEvaluacion historial)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para actualizar los campos de finalización
            var query = @"UPDATE historial_evaluacion
                          SET fecha_fin = @fechaFin, puntaje_total = @puntaje, aprobado = @aprobado
                          WHERE id_historial = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el id del historial
            command.Parameters.AddWithValue("@id", historial.IdHistorial);
            // Agrega el parámetro @fechaFin con el valor del objeto o la fecha actual si es null
            command.Parameters.AddWithValue("@fechaFin", historial.FechaFin ?? DateTime.Now);
            // Agrega el parámetro @puntaje con el valor o DBNull si es null
            command.Parameters.AddWithValue("@puntaje", historial.PuntajeTotal ?? (object)DBNull.Value);
            // Agrega el parámetro @aprobado con el valor o DBNull si es null
            command.Parameters.AddWithValue("@aprobado", historial.Aprobado ?? (object)DBNull.Value);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para actualizar el historial
            command.ExecuteNonQuery();
        }

        // Método público para obtener un historial de evaluación por su id
        public HistorialEvaluacion? ObtenerPorId(int id)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener el historial por id
            var query = "SELECT * FROM historial_evaluacion WHERE id_historial = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor recibido
            command.Parameters.AddWithValue("@id", id);
            // Abre la conexión a la base de datos
            connection.Open();

            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();
            // Retorna el objeto HistorialEvaluacion si se encuentra, o null si no hay resultados
            return reader.Read() ? new HistorialEvaluacion
            {
                IdHistorial = (int)reader["id_historial"],                      // Asigna el id del historial
                IdUsuario = (int)reader["id_usuario"],                         // Asigna el id del usuario
                IdEvaluacion = (int)reader["id_evaluacion"],                   // Asigna el id de la evaluación
                FechaInicio = (DateTime)reader["fecha_inicio"],                // Asigna la fecha de inicio
                FechaFin = reader["fecha_fin"] as DateTime?,                   // Asigna la fecha de fin (nullable)
                PuntajeTotal = reader["puntaje_total"] as int?,                // Asigna el puntaje total (nullable)
                Aprobado = reader["aprobado"] as bool?                         // Asigna el estado de aprobado (nullable)
            } : null;
        }

        // Método público para listar todos los historiales de evaluación de un usuario
        public List<HistorialEvaluacion> ListarPorUsuario(int idUsuario)
        {
            // Inicializa la lista que almacenará los historiales obtenidos
            var lista = new List<HistorialEvaluacion>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener los historiales por usuario ordenados por fecha de inicio descendente
            var query = "SELECT * FROM historial_evaluacion WHERE id_usuario = @id ORDER BY fecha_inicio DESC";

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
                // Agrega un nuevo objeto HistorialEvaluacion a la lista con los datos del lector
                lista.Add(new HistorialEvaluacion
                {
                    IdHistorial = (int)reader["id_historial"],                // Asigna el id del historial
                    IdUsuario = (int)reader["id_usuario"],                   // Asigna el id del usuario
                    IdEvaluacion = (int)reader["id_evaluacion"],             // Asigna el id de la evaluación
                    FechaInicio = (DateTime)reader["fecha_inicio"],          // Asigna la fecha de inicio
                    FechaFin = reader["fecha_fin"] as DateTime?,             // Asigna la fecha de fin (nullable)
                    PuntajeTotal = reader["puntaje_total"] as int?,          // Asigna el puntaje total (nullable)
                    Aprobado = reader["aprobado"] as bool?                   // Asigna el estado de aprobado (nullable)
                });
            }

            // Retorna la lista de historiales obtenidos
            return lista;
        }

    }
}
