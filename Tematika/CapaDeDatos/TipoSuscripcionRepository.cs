using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase TipoSuscripcionRepository dentro del namespace Tematika.CapaDeDatos
    public class TipoSuscripcionRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase TipoSuscripcionRepository
        public TipoSuscripcionRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público que obtiene todos los tipos de suscripción registrados
        public List<TipoSuscripcion> ObtenerTodos()
        {
            // Inicializa la lista que almacenará los tipos de suscripción obtenidos
            var lista = new List<TipoSuscripcion>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener todos los registros de tipo_suscripcion
            var query = "SELECT * FROM tipo_suscripcion";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Itera sobre los resultados obtenidos
            while (reader.Read())
            {
                // Agrega un nuevo objeto TipoSuscripcion a la lista con los datos del lector
                lista.Add(new TipoSuscripcion
                {
                    IdTipoSuscripcion = (int)reader["id_tipo_suscripcion"], // Asigna el id del tipo
                    Nombre = reader["nombre"].ToString() ?? "",             // Asigna el nombre del tipo
                    DuracionDias = (int)reader["duracion_dias"],           // Asigna la duración en días
                    Precio = (decimal)reader["precio"]                     // Asigna el precio
                });
            }

            // Retorna la lista de tipos de suscripción obtenidos
            return lista;
        }

        // Método público para obtener un tipo de suscripción por su id
        public TipoSuscripcion? ObtenerPorId(int id)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener el tipo por id
            var query = "SELECT * FROM tipo_suscripcion WHERE id_tipo_suscripcion = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor recibido
            command.Parameters.AddWithValue("@id", id);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Verifica si se obtuvo algún resultado
            if (reader.Read())
            {
                // Retorna un nuevo objeto TipoSuscripcion con los datos obtenidos
                return new TipoSuscripcion
                {
                    IdTipoSuscripcion = (int)reader["id_tipo_suscripcion"], // Asigna el id del tipo
                    Nombre = reader["nombre"].ToString() ?? "",             // Asigna el nombre del tipo
                    DuracionDias = (int)reader["duracion_dias"],           // Asigna la duración en días
                    Precio = (decimal)reader["precio"]                     // Asigna el precio
                };
            }

            // Retorna null si no se encontró el tipo de suscripción
            return null;
        }
    }
}
