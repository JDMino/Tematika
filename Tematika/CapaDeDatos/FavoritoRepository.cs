using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase FavoritoRepository dentro del namespace Tematika.CapaDeDatos
    public class FavoritoRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase FavoritoRepository
        public FavoritoRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público que obtiene todos los favoritos activos de un usuario
        public List<Favorito> ObtenerPorUsuario(int idUsuario)
        {
            // Inicializa la lista que almacenará los favoritos obtenidos
            var lista = new List<Favorito>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener favoritos no eliminados por id_usuario
            var query = "SELECT * FROM favorito WHERE id_usuario = @id AND eliminado = 0";

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
                // Agrega un nuevo objeto Favorito a la lista con los datos del lector
                lista.Add(new Favorito
                {
                    IdFavorito = (int)reader["id_favorito"],               // Asigna el id del favorito
                    FechaMarcado = (DateTime)reader["fecha_marcado"],      // Asigna la fecha en que fue marcado
                    IdUsuario = (int)reader["id_usuario"],                 // Asigna el id del usuario
                    IdRecurso = (int)reader["id_recurso"],                 // Asigna el id del recurso
                    Eliminado = (bool)reader["eliminado"]                  // Asigna el estado de eliminado
                });
            }

            // Retorna la lista de favoritos obtenidos
            return lista;
        }

        // Método público para crear un nuevo favorito
        public void Crear(Favorito favorito)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar un nuevo favorito con eliminado en false
            var query = @"INSERT INTO favorito (fecha_marcado, id_usuario, id_recurso, eliminado)
                          VALUES (@fecha, @idUsuario, @idRecurso, 0)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @fecha con el valor del objeto favorito
            command.Parameters.AddWithValue("@fecha", favorito.FechaMarcado);
            // Agrega el parámetro @idUsuario con el valor del objeto favorito
            command.Parameters.AddWithValue("@idUsuario", favorito.IdUsuario);
            // Agrega el parámetro @idRecurso con el valor del objeto favorito
            command.Parameters.AddWithValue("@idRecurso", favorito.IdRecurso);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para insertar el favorito
            command.ExecuteNonQuery();
        }

        // Método público para marcar un favorito como eliminado
        public void Eliminar(int idFavorito)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para actualizar el campo eliminado a true
            var query = "UPDATE favorito SET eliminado = 1 WHERE id_favorito = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor de idFavorito
            command.Parameters.AddWithValue("@id", idFavorito);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para marcar el favorito como eliminado
            command.ExecuteNonQuery();
        }
    }
}
