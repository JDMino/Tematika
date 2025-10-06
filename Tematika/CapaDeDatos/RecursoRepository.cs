using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos
{
    public class RecursoRepository
    {
        private readonly string _connectionString;

        public RecursoRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["TematikaConnectionString"].ConnectionString;
        }

        public List<Recurso> ObtenerTodos()
        {
            var recursos = new List<Recurso>();
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM recurso";

            using var command = new SqlCommand(query, connection);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                recursos.Add(new Recurso
                {
                    IdRecurso = (int)reader["id_recurso"],
                    Titulo = reader["titulo"].ToString() ?? "",
                    Texto = reader["texto"]?.ToString(),
                    Ruta = reader["ruta"]?.ToString(),
                    Url = reader["url"]?.ToString(),
                    Tipo = reader["tipo"].ToString() ?? "",
                    FechaCreacion = (DateTime)reader["fecha_creacion"],
                    FechaModificacion = (DateTime)reader["fecha_modificacion"],
                    IdTema = (int)reader["id_tema"],
                    Eliminado = (bool)reader["eliminado"]
                });
            }

            return recursos;
        }

        public Recurso? ObtenerPorId(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "SELECT * FROM recurso WHERE id_recurso = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();

            using var reader = command.ExecuteReader();
            return reader.Read() ? new Recurso
            {
                IdRecurso = (int)reader["id_recurso"],
                Titulo = reader["titulo"].ToString() ?? "",
                Texto = reader["texto"]?.ToString(),
                Ruta = reader["ruta"]?.ToString(),
                Url = reader["url"]?.ToString(),
                Tipo = reader["tipo"].ToString() ?? "",
                FechaCreacion = (DateTime)reader["fecha_creacion"],
                FechaModificacion = (DateTime)reader["fecha_modificacion"],
                IdTema = (int)reader["id_tema"],
                Eliminado = (bool)reader["eliminado"]
            } : null;
        }

        public void Crear(Recurso recurso)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"INSERT INTO recurso (titulo, texto, ruta, url, tipo, fecha_creacion, fecha_modificacion, id_tema, eliminado)
                          VALUES (@titulo, @texto, @ruta, @url, @tipo, @creacion, @modificacion, @idTema, 0)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@titulo", recurso.Titulo);
            command.Parameters.AddWithValue("@texto", recurso.Texto ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@ruta", recurso.Ruta ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@url", recurso.Url ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@tipo", recurso.Tipo);
            command.Parameters.AddWithValue("@creacion", recurso.FechaCreacion);
            command.Parameters.AddWithValue("@modificacion", recurso.FechaModificacion);
            command.Parameters.AddWithValue("@idTema", recurso.IdTema);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Actualizar(Recurso recurso)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = @"UPDATE recurso SET titulo = @titulo, texto = @texto, ruta = @ruta, url = @url, tipo = @tipo,
                          fecha_modificacion = @modificacion, id_tema = @idTema, eliminado = @eliminado
                          WHERE id_recurso = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", recurso.IdRecurso);
            command.Parameters.AddWithValue("@titulo", recurso.Titulo);
            command.Parameters.AddWithValue("@texto", recurso.Texto ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@ruta", recurso.Ruta ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@url", recurso.Url ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@tipo", recurso.Tipo);
            command.Parameters.AddWithValue("@modificacion", recurso.FechaModificacion);
            command.Parameters.AddWithValue("@idTema", recurso.IdTema);
            command.Parameters.AddWithValue("@eliminado", recurso.Eliminado);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "UPDATE recurso SET eliminado = 1 WHERE id_recurso = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
