using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class DetalleFacturaRepository
    {
        private readonly string _connectionString;

        public DetalleFacturaRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public void Crear(DetalleFactura detalle)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO detalle_factura (id_factura, descripcion, precio)
                          VALUES (@idFactura, @descripcion, @precio)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idFactura", detalle.IdFactura);
            command.Parameters.AddWithValue("@descripcion", detalle.Descripcion);
            command.Parameters.AddWithValue("@precio", detalle.Precio);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public DetalleFactura ObtenerPorFactura(int idFactura)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"SELECT * FROM detalle_factura WHERE id_factura = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idFactura);
            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new DetalleFactura
                {
                    IdDetalleFactura = (int)reader["id_detalle_factura"],
                    IdFactura = (int)reader["id_factura"],
                    Descripcion = reader["descripcion"].ToString() ?? "",
                    Precio = (decimal)reader["precio"]
                };
            }

            throw new Exception("Detalle de factura no encontrado.");
        }

    }
}