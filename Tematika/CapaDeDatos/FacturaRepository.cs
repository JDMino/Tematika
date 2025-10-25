using System;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class FacturaRepository
    {
        private readonly string _connectionString;

        public FacturaRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public int Crear(Factura factura)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO factura (id_usuario, id_suscripcion, fecha_emision, total, metodo_pago, descripcion_pago)
                          OUTPUT INSERTED.id_factura
                          VALUES (@idUsuario, @idSuscripcion, @fecha, @total, @metodo, @descripcion)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idUsuario", factura.IdUsuario);
            command.Parameters.AddWithValue("@idSuscripcion", factura.IdSuscripcion);
            command.Parameters.AddWithValue("@fecha", factura.FechaEmision);
            command.Parameters.AddWithValue("@total", factura.Total);
            command.Parameters.AddWithValue("@metodo", factura.MetodoPago);
            command.Parameters.AddWithValue("@descripcion", factura.DescripcionPago);

            connection.Open();
            return (int)command.ExecuteScalar();
        }

        public Factura ObtenerPorSuscripcion(int idSuscripcion)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"SELECT * FROM factura WHERE id_suscripcion = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idSuscripcion);
            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Factura
                {
                    IdFactura = (int)reader["id_factura"],
                    IdUsuario = (int)reader["id_usuario"],
                    IdSuscripcion = (int)reader["id_suscripcion"],
                    FechaEmision = (DateTime)reader["fecha_emision"],
                    Total = (decimal)reader["total"],
                    MetodoPago = reader["metodo_pago"].ToString() ?? "",
                    DescripcionPago = reader["descripcion_pago"].ToString() ?? ""
                };
            }

            throw new Exception("Factura no encontrada.");
        }

    }
}
