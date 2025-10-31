using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    // Define la clase VisitaRecursoRepository dentro del namespace Tematika.CapaDeDatos
    public class VisitaRecursoRepository
    {
        // Campo privado para almacenar la cadena de conexión
        private readonly string _connectionString;

        // Constructor de la clase VisitaRecursoRepository
        public VisitaRecursoRepository()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        // Método público que obtiene todas las visitas realizadas por un usuario
        public List<VisitaRecurso> ObtenerPorUsuario(int idUsuario)
        {
            // Inicializa la lista que almacenará las visitas obtenidas
            var lista = new List<VisitaRecurso>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener visitas por id_usuario
            var query = "SELECT * FROM visita_recurso WHERE id_usuario = @id";

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
                // Agrega un nuevo objeto VisitaRecurso a la lista con los datos del lector
                lista.Add(new VisitaRecurso
                {
                    IdVisita = (int)reader["id_visita"],               // Asigna el id de la visita
                    FechaHora = (DateTime)reader["fecha_hora"],        // Asigna la fecha y hora de la visita
                    IdUsuario = (int)reader["id_usuario"],             // Asigna el id del usuario
                    IdRecurso = (int)reader["id_recurso"]              // Asigna el id del recurso visitado
                });
            }

            // Retorna la lista de visitas obtenidas
            return lista;
        }

        // Método público para registrar una nueva visita a un recurso
        public void RegistrarVisita(VisitaRecurso visita)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para insertar una nueva visita
            var query = @"INSERT INTO visita_recurso (fecha_hora, id_usuario, id_recurso)
                          VALUES (@fechaHora, @idUsuario, @idRecurso)";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega los parámetros con los valores del objeto visita
            command.Parameters.AddWithValue("@fechaHora", visita.FechaHora);
            command.Parameters.AddWithValue("@idUsuario", visita.IdUsuario);
            command.Parameters.AddWithValue("@idRecurso", visita.IdRecurso);

            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando para insertar la visita
            command.ExecuteNonQuery();
        }

        // Método público para contar la cantidad de visitas realizadas a un recurso
        public int ContarVisitasPorRecurso(int idRecurso)
        {
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para contar las visitas por id_recurso
            var query = "SELECT COUNT(*) FROM visita_recurso WHERE id_recurso = @id";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Agrega el parámetro @id con el valor de idRecurso
            command.Parameters.AddWithValue("@id", idRecurso);
            // Abre la conexión a la base de datos
            connection.Open();

            // Ejecuta el comando y retorna el número total de visitas
            return (int)command.ExecuteScalar();
        }

        // Método público que obtiene todas las visitas registradas en el sistema
        public List<VisitaRecurso> ObtenerTodas()
        {
            // Inicializa la lista que almacenará las visitas obtenidas
            var lista = new List<VisitaRecurso>();
            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(_connectionString);
            // Define la consulta SQL para obtener todas las visitas
            var query = "SELECT * FROM visita_recurso";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);
            // Abre la conexión a la base de datos
            connection.Open();
            // Ejecuta el comando y obtiene un lector de datos
            using var reader = command.ExecuteReader();

            // Itera sobre los resultados obtenidos
            while (reader.Read())
            {
                // Agrega un nuevo objeto VisitaRecurso a la lista con los datos del lector
                lista.Add(new VisitaRecurso
                {
                    IdVisita = (int)reader["id_visita"],               // Asigna el id de la visita
                    FechaHora = (DateTime)reader["fecha_hora"],        // Asigna la fecha y hora de la visita
                    IdUsuario = (int)reader["id_usuario"],             // Asigna el id del usuario
                    IdRecurso = (int)reader["id_recurso"]              // Asigna el id del recurso visitado
                });
            }

            // Retorna la lista de visitas obtenidas
            return lista;
        }
    }
}
