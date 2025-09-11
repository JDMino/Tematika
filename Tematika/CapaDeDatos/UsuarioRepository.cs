using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos;

public class UsuarioRepository
{
    private readonly string _connectionString;

    public UsuarioRepository()
    {
        _connectionString = System.Configuration.ConfigurationManager
            .ConnectionStrings["TematikaConnectionString"].ConnectionString;
    }

    public List<Usuario> ObtenerTodos()
    {
        var usuarios = new List<Usuario>();

        using var connection = new SqlConnection(_connectionString);
        var query = "SELECT * FROM usuario"; // sin filtro

        using var command = new SqlCommand(query, connection);
        connection.Open();
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            usuarios.Add(new Usuario
            {
                IdUsuario = (int)reader["id_usuario"],
                Dni = (int)reader["dni"],
                Nombre = reader["nombre"].ToString() ?? "",
                Apellido = reader["apellido"].ToString() ?? "",
                Correo = reader["correo"].ToString() ?? "",
                FechaRegistro = (DateTime)reader["fecha_registro"],
                IdPerfil = (int)reader["id_perfil"],
                ContrasenaHash = reader["contrasena_hash"].ToString() ?? "",
                Sexo = Convert.ToChar(reader["sexo"]),
                Eliminado = (bool)reader["eliminado"]
            });
        }

        return usuarios;
    }


    public Usuario? ObtenerPorId(int id)
    {
        using var connection = new SqlConnection(_connectionString);
        var query = "SELECT * FROM usuario WHERE id_usuario = @id AND eliminado = 0";

        using var command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@id", id);
        connection.Open();

        using var reader = command.ExecuteReader();
        return reader.Read() ? MapearUsuario(reader) : null;
    }

    public void Crear(Usuario usuario)
    {
        using var connection = new SqlConnection(_connectionString);
        var query = @"INSERT INTO usuario (dni, nombre, apellido, correo, id_perfil, contrasena_hash, sexo)
                          VALUES (@dni, @nombre, @apellido, @correo, @idPerfil, @contrasenaHash, @sexo)";

        using var command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@dni", usuario.Dni);
        command.Parameters.AddWithValue("@nombre", usuario.Nombre);
        command.Parameters.AddWithValue("@apellido", usuario.Apellido);
        command.Parameters.AddWithValue("@correo", usuario.Correo);
        command.Parameters.AddWithValue("@idPerfil", usuario.IdPerfil);
        command.Parameters.AddWithValue("@contrasenaHash", usuario.ContrasenaHash);
        command.Parameters.AddWithValue("@sexo", usuario.Sexo);

        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Actualizar(Usuario usuario)
    {
        using var connection = new SqlConnection(_connectionString);
        var query = @"UPDATE usuario SET dni = @dni, nombre = @nombre, apellido = @apellido,
                          correo = @correo, id_perfil = @idPerfil, contrasena_hash = @contrasenaHash, sexo = @sexo
                          WHERE id_usuario = @id";

        using var command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@id", usuario.IdUsuario);
        command.Parameters.AddWithValue("@dni", usuario.Dni);
        command.Parameters.AddWithValue("@nombre", usuario.Nombre);
        command.Parameters.AddWithValue("@apellido", usuario.Apellido);
        command.Parameters.AddWithValue("@correo", usuario.Correo);
        command.Parameters.AddWithValue("@idPerfil", usuario.IdPerfil);
        command.Parameters.AddWithValue("@contrasenaHash", usuario.ContrasenaHash);
        command.Parameters.AddWithValue("@sexo", usuario.Sexo);

        connection.Open();
        command.ExecuteNonQuery();
    }

    public void Eliminar(int id)
    {
        using var connection = new SqlConnection(_connectionString);
        var query = "UPDATE usuario SET eliminado = 1 WHERE id_usuario = @id";

        using var command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@id", id);

        connection.Open();
        command.ExecuteNonQuery();
    }

    private Usuario MapearUsuario(SqlDataReader reader)
    {
        return new Usuario
        {
            IdUsuario = (int)reader["id_usuario"],
            Dni = (int)reader["dni"],
            Nombre = reader["nombre"].ToString() ?? "",
            Apellido = reader["apellido"].ToString() ?? "",
            Correo = reader["correo"].ToString() ?? "",
            FechaRegistro = (DateTime)reader["fecha_registro"],
            IdPerfil = (int)reader["id_perfil"],
            ContrasenaHash = reader["contrasena_hash"].ToString() ?? "",
            Sexo = Convert.ToChar(reader["sexo"]),
            Eliminado = (bool)reader["eliminado"]
        };
    }
}
