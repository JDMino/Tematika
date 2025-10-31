using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase DetalleFacturaRepository dentro del namespace Tematika.CapaDeDatos
    public class DetalleFacturaRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase DetalleFacturaRepository
        public DetalleFacturaRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público para insertar un nuevo detalle de factura en la base de datos
        public void Crear(DetalleFactura detalle)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar un nuevo detalle de factura
            var query = @"INSERT INTO detalle_factura (id_factura, descripcion, precio)
                          VALUES (@idFactura, @descripcion, @precio)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @idFactura con el valor del objeto detalle
            command.Parameters.AddWithValue("@idFactura", detalle.IdFactura);
            // Agrega el parámetro @descripcion con el valor del objeto detalle
            command.Parameters.AddWithValue("@descripcion", detalle.Descripcion);
            // Agrega el parámetro @precio con el valor del objeto detalle
            command.Parameters.AddWithValue("@precio", detalle.Precio);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para insertar el detalle de factura
            command.ExecuteNonQuery();
        }

        // Método público para obtener un detalle de factura por idFactura
        public DetalleFactura ObtenerPorFactura(int idFactura)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener el detalle de factura por id_factura
            var query = @"SELECT * FROM detalle_factura WHERE id_factura = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor de idFactura
            command.Parameters.AddWithValue("@id", idFactura);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Verifica si se obtuvo algún resultado
            if (reader.Read())
            {
                // Retorna un nuevo objeto DetalleFactura con los datos obtenidos
                return new DetalleFactura
                {
                    IdDetalleFactura = (int)reader["id_detalle_factura"], // Asigna el id del detalle
                    IdFactura = (int)reader["id_factura"],                 // Asigna el id de la factura
                    Descripcion = reader["descripcion"].ToString() ?? "", // Asigna la descripción
                    Precio = (decimal)reader["precio"]                    // Asigna el precio
                };
            }

            // Lanza una excepción si no se encontró el detalle de factura
            throw new Exception("Detalle de factura no encontrado.");
        }

    }
}
