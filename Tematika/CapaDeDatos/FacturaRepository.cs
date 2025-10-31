using System;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase FacturaRepository dentro del namespace Tematika.CapaDeDatos
    public class FacturaRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase FacturaRepository
        public FacturaRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público para crear una nueva factura y retornar su id generado
        public int Crear(Factura factura)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar una factura y retornar el id generado
            var query = @"INSERT INTO factura (id_usuario, id_suscripcion, fecha_emision, total, metodo_pago, descripcion_pago)
                          OUTPUT INSERTED.id_factura
                          VALUES (@idUsuario, @idSuscripcion, @fecha, @total, @metodo, @descripcion)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @idUsuario con el valor del objeto factura
            command.Parameters.AddWithValue("@idUsuario", factura.IdUsuario);
            // Agrega el parámetro @idSuscripcion con el valor del objeto factura
            command.Parameters.AddWithValue("@idSuscripcion", factura.IdSuscripcion);
            // Agrega el parámetro @fecha con el valor del objeto factura
            command.Parameters.AddWithValue("@fecha", factura.FechaEmision);
            // Agrega el parámetro @total con el valor del objeto factura
            command.Parameters.AddWithValue("@total", factura.Total);
            // Agrega el parámetro @metodo con el valor del objeto factura
            command.Parameters.AddWithValue("@metodo", factura.MetodoPago);
            // Agrega el parámetro @descripcion con el valor del objeto factura
            command.Parameters.AddWithValue("@descripcion", factura.DescripcionPago);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y retorna el id generado de la factura
            return (int)command.ExecuteScalar();
        }

        // Método público para obtener una factura por idSuscripcion
        public Factura ObtenerPorSuscripcion(int idSuscripcion)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener la factura por id_suscripcion
            var query = @"SELECT * FROM factura WHERE id_suscripcion = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor de idSuscripcion
            command.Parameters.AddWithValue("@id", idSuscripcion);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Verifica si se obtuvo algún resultado
            if (reader.Read())
            {
                // Retorna un nuevo objeto Factura con los datos obtenidos
                return new Factura
                {
                    IdFactura = (int)reader["id_factura"],                   // Asigna el id de la factura
                    IdUsuario = (int)reader["id_usuario"],                  // Asigna el id del usuario
                    IdSuscripcion = (int)reader["id_suscripcion"],          // Asigna el id de la suscripción
                    FechaEmision = (DateTime)reader["fecha_emision"],       // Asigna la fecha de emisión
                    Total = (decimal)reader["total"],                       // Asigna el total de la factura
                    MetodoPago = reader["metodo_pago"].ToString() ?? "",    // Asigna el método de pago
                    DescripcionPago = reader["descripcion_pago"].ToString() ?? "" // Asigna la descripción del pago
                };
            }

            // Lanza una excepción si no se encontró la factura
            throw new Exception("Factura no encontrada.");
        }

    }
}
