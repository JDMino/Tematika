using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class HistorialEvaluacionRepository
    {
        private readonly string _connectionString;

        public HistorialEvaluacionRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public void Crear(HistorialEvaluacion historial)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO historial_evaluacion (id_usuario, id_evaluacion, fecha_inicio)
                          VALUES (@idUsuario, @idEvaluacion, @fechaInicio);
                          SELECT SCOPE_IDENTITY();";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idUsuario", historial.IdUsuario);
            command.Parameters.AddWithValue("@idEvaluacion", historial.IdEvaluacion);
            command.Parameters.AddWithValue("@fechaInicio", historial.FechaInicio);

            connection.Open();
            historial.IdHistorial = Convert.ToInt32(command.ExecuteScalar());
        }

        public void Finalizar(HistorialEvaluacion historial)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"UPDATE historial_evaluacion
                          SET fecha_fin = @fechaFin, puntaje_total = @puntaje, aprobado = @aprobado
                          WHERE id_historial = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", historial.IdHistorial);
            command.Parameters.AddWithValue("@fechaFin", historial.FechaFin ?? DateTime.Now);
            command.Parameters.AddWithValue("@puntaje", historial.PuntajeTotal ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@aprobado", historial.Aprobado ?? (object)DBNull.Value);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public HistorialEvaluacion? ObtenerPorId(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM historial_evaluacion WHERE id_historial = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();

            using var reader = command.ExecuteReader();
            return reader.Read() ? new HistorialEvaluacion
            {
                IdHistorial = (int)reader["id_historial"],
                IdUsuario = (int)reader["id_usuario"],
                IdEvaluacion = (int)reader["id_evaluacion"],
                FechaInicio = (DateTime)reader["fecha_inicio"],
                FechaFin = reader["fecha_fin"] as DateTime?,
                PuntajeTotal = reader["puntaje_total"] as int?,
                Aprobado = reader["aprobado"] as bool?
            } : null;
        }

        public List<HistorialEvaluacion> ListarPorUsuario(int idUsuario)
        {
            var lista = new List<HistorialEvaluacion>();
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM historial_evaluacion WHERE id_usuario = @id ORDER BY fecha_inicio DESC";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idUsuario);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new HistorialEvaluacion
                {
                    IdHistorial = (int)reader["id_historial"],
                    IdUsuario = (int)reader["id_usuario"],
                    IdEvaluacion = (int)reader["id_evaluacion"],
                    FechaInicio = (DateTime)reader["fecha_inicio"],
                    FechaFin = reader["fecha_fin"] as DateTime?,
                    PuntajeTotal = reader["puntaje_total"] as int?,
                    Aprobado = reader["aprobado"] as bool?
                });
            }

            return lista;
        }

    }
}
