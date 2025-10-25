using System;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class SuscripcionRepository
    {
        private readonly string _connectionString;
        private readonly TipoSuscripcionRepository tipoRepo;

        public SuscripcionRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;

            tipoRepo = new TipoSuscripcionRepository();
        }

        public int Crear(Suscripcion suscripcion)
        {
            // Obtener duración desde tipo_suscripcion
            var tipo = tipoRepo.ObtenerPorId(suscripcion.IdTipoSuscripcion);
            if (tipo == null)
                throw new Exception("Tipo de suscripción no válido.");

            suscripcion.FechaFin = suscripcion.FechaInicio.AddDays(tipo.DuracionDias);

            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO suscripcion (id_usuario, id_tipo_suscripcion, activa, fecha_inicio, fecha_fin)
                          OUTPUT INSERTED.id_suscripcion
                          VALUES (@idUsuario, @idTipo, @activa, @fechaInicio, @fechaFin)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idUsuario", suscripcion.IdUsuario);
            command.Parameters.AddWithValue("@idTipo", suscripcion.IdTipoSuscripcion);
            command.Parameters.AddWithValue("@activa", suscripcion.Activa);
            command.Parameters.AddWithValue("@fechaInicio", suscripcion.FechaInicio);
            command.Parameters.AddWithValue("@fechaFin", suscripcion.FechaFin ?? (object)DBNull.Value);

            connection.Open();
            return (int)command.ExecuteScalar();
        }

        public List<Suscripcion> ObtenerPorUsuario(int idUsuario)
        {
            var lista = new List<Suscripcion>();
            using var connection = new SqlConnection(_connectionString);
            var query = @"SELECT s.id_suscripcion, s.activa, s.fecha_inicio, s.fecha_fin, t.nombre AS tipo
                  FROM suscripcion s
                  JOIN tipo_suscripcion t ON s.id_tipo_suscripcion = t.id_tipo_suscripcion
                  WHERE s.id_usuario = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idUsuario);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Suscripcion
                {
                    IdSuscripcion = (int)reader["id_suscripcion"],
                    Activa = (bool)reader["activa"],
                    FechaInicio = (DateTime)reader["fecha_inicio"],
                    FechaFin = reader["fecha_fin"] as DateTime?,
                    Tipo = new TipoSuscripcion { Nombre = reader["tipo"].ToString() ?? "" }
                });
            }

            return lista;
        }

    }
}