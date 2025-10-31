using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase IntentoRepository dentro del namespace Tematika.CapaDeDatos
    public class IntentoRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase IntentoRepository
        public IntentoRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público para registrar un nuevo intento de respuesta
        public void Registrar(Intento intento)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar un nuevo intento
            var query = @"INSERT INTO intento (fecha, correcta, id_usuario, id_pregunta, id_opcion, id_historial)
                          VALUES (@fecha, @correcta, @idUsuario, @idPregunta, @idOpcion, @idHistorial)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @fecha con el valor del objeto intento
            command.Parameters.AddWithValue("@fecha", intento.Fecha);
            // Agrega el parámetro @correcta con el valor del objeto intento
            command.Parameters.AddWithValue("@correcta", intento.Correcta);
            // Agrega el parámetro @idUsuario con el valor del objeto intento
            command.Parameters.AddWithValue("@idUsuario", intento.IdUsuario);
            // Agrega el parámetro @idPregunta con el valor del objeto intento
            command.Parameters.AddWithValue("@idPregunta", intento.IdPregunta);
            // Agrega el parámetro @idOpcion con el valor del objeto intento
            command.Parameters.AddWithValue("@idOpcion", intento.IdOpcion);
            // Agrega el parámetro @idHistorial con el valor del objeto intento o DBNull si es 0
            command.Parameters.AddWithValue("@idHistorial", intento.IdHistorial == 0 ? DBNull.Value : intento.IdHistorial);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para insertar el intento
            command.ExecuteNonQuery();
        }

        // Método público para listar todos los intentos asociados a un historial
        public List<Intento> ListarPorHistorial(int idHistorial)
        {
            // Inicializa la lista que almacenará los intentos obtenidos
            var lista = new List<Intento>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener intentos por id_historial
            var query = "SELECT * FROM intento WHERE id_historial = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor de idHistorial
            command.Parameters.AddWithValue("@id", idHistorial);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Itera sobre los resultados obtenidos
            while (reader.Read())
            {
                // Agrega un nuevo objeto Intento a la lista con los datos del lector
                lista.Add(new Intento
                {
                    IdIntento = (int)reader["id_intento"],                   // Asigna el id del intento
                    Fecha = (DateTime)reader["fecha"],                       // Asigna la fecha del intento
                    Correcta = (bool)reader["correcta"],                     // Asigna si fue correcta
                    IdUsuario = (int)reader["id_usuario"],                   // Asigna el id del usuario
                    IdPregunta = (int)reader["id_pregunta"],                 // Asigna el id de la pregunta
                    IdOpcion = (int)reader["id_opcion"],                     // Asigna el id de la opción elegida
                    IdHistorial = reader["id_historial"] as int? ?? 0        // Asigna el id del historial o 0 si es null
                });
            }

            // Retorna la lista de intentos obtenidos
            return lista;
        }
    }
}
