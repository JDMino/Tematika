using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class IntentoRepository
    {
        private readonly string _connectionString;

        public IntentoRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public void Registrar(Intento intento)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO intento (fecha, correcta, id_usuario, id_pregunta, id_opcion, id_historial)
                          VALUES (@fecha, @correcta, @idUsuario, @idPregunta, @idOpcion, @idHistorial)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@fecha", intento.Fecha);
            command.Parameters.AddWithValue("@correcta", intento.Correcta);
            command.Parameters.AddWithValue("@idUsuario", intento.IdUsuario);
            command.Parameters.AddWithValue("@idPregunta", intento.IdPregunta);
            command.Parameters.AddWithValue("@idOpcion", intento.IdOpcion);
            command.Parameters.AddWithValue("@idHistorial", intento.IdHistorial == 0 ? DBNull.Value : intento.IdHistorial);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public List<Intento> ListarPorHistorial(int idHistorial)
        {
            var lista = new List<Intento>();
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM intento WHERE id_historial = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", idHistorial);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Intento
                {
                    IdIntento = (int)reader["id_intento"],
                    Fecha = (DateTime)reader["fecha"],
                    Correcta = (bool)reader["correcta"],
                    IdUsuario = (int)reader["id_usuario"],
                    IdPregunta = (int)reader["id_pregunta"],
                    IdOpcion = (int)reader["id_opcion"],
                    IdHistorial = reader["id_historial"] as int? ?? 0
                });
            }

            return lista;
        }
    }
}
