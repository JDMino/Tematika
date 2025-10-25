using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class TipoSuscripcionRepository
    {
        private readonly string _connectionString;

        public TipoSuscripcionRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public List<TipoSuscripcion> ObtenerTodos()
        {
            var lista = new List<TipoSuscripcion>();
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM tipo_suscripcion";

            using var command = new SqlCommand(query, connection);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new TipoSuscripcion
                {
                    IdTipoSuscripcion = (int)reader["id_tipo_suscripcion"],
                    Nombre = reader["nombre"].ToString() ?? "",
                    DuracionDias = (int)reader["duracion_dias"],
                    Precio = (decimal)reader["precio"]
                });
            }

            return lista;
        }

        public TipoSuscripcion? ObtenerPorId(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM tipo_suscripcion WHERE id_tipo_suscripcion = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new TipoSuscripcion
                {
                    IdTipoSuscripcion = (int)reader["id_tipo_suscripcion"],
                    Nombre = reader["nombre"].ToString() ?? "",
                    DuracionDias = (int)reader["duracion_dias"],
                    Precio = (decimal)reader["precio"]
                };
            }

            return null;
        }
    }
}
