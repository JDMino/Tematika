using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos;

// Define la clase UsuarioRepository dentro del namespace Tematika.CapaDeDatos
public class UsuarioRepository
{
    // Campo privado para almacenar la cadena de conexi�n
    private readonly string _connectionString;

    // Constructor de la clase UsuarioRepository
    public UsuarioRepository()
    {
        // Obtiene la cadena de conexi�n desde el archivo de configuraci�n
        _connectionString = System.Configuration.ConfigurationManager
            .ConnectionStrings["TematikaConnectionString"].ConnectionString;
    }

    // M�todo p�blico que obtiene todos los usuarios registrados
    public List<Usuario> ObtenerTodos()
    {
        // Inicializa la lista que almacenar� los usuarios obtenidos
        var usuarios = new List<Usuario>();

        // Crea una conexi�n SQL usando la cadena de conexi�n
        using var connection = new SqlConnection(_connectionString);
        // Define la consulta SQL para obtener todos los usuarios sin filtro
        var query = "SELECT * FROM usuario"; // sin filtro

        // Crea el comando SQL con la consulta y la conexi�n
        using var command = new SqlCommand(query, connection);
        // Abre la conexi�n a la base de datos
        connection.Open();
        // Ejecuta el comando y obtiene un lector de datos
        using var reader = command.ExecuteReader();

        // Itera sobre los resultados obtenidos
        while (reader.Read())
        {
            // Agrega un nuevo objeto Usuario a la lista con los datos del lector
            usuarios.Add(new Usuario
            {
                IdUsuario = (int)reader["id_usuario"],                   // Asigna el id del usuario
                Dni = (int)reader["dni"],                                // Asigna el DNI
                Nombre = reader["nombre"].ToString() ?? "",              // Asigna el nombre
                Apellido = reader["apellido"].ToString() ?? "",          // Asigna el apellido
                Correo = reader["correo"].ToString() ?? "",              // Asigna el correo electr�nico
                FechaRegistro = (DateTime)reader["fecha_registro"],      // Asigna la fecha de registro
                IdPerfil = (int)reader["id_perfil"],                     // Asigna el id del perfil
                ContrasenaHash = reader["contrasena_hash"].ToString() ?? "", // Asigna el hash de la contrase�a
                Sexo = Convert.ToChar(reader["sexo"]),                   // Asigna el sexo como car�cter
                Eliminado = (bool)reader["eliminado"]                    // Asigna el estado de eliminado
            });
        }

        // Retorna la lista de usuarios obtenidos
        return usuarios;
    }

    // M�todo p�blico para obtener un usuario por su id
    public Usuario? ObtenerPorId(int id)
    {
        // Crea una conexi�n SQL usando la cadena de conexi�n
        using var connection = new SqlConnection(_connectionString);
        // Define la consulta SQL para obtener el usuario por id
        var query = "SELECT * FROM usuario WHERE id_usuario = @id";

        // Crea el comando SQL con la consulta y la conexi�n
        using var command = new SqlCommand(query, connection);
        // Agrega el par�metro @id con el valor recibido
        command.Parameters.AddWithValue("@id", id);
        // Abre la conexi�n a la base de datos
        connection.Open();

        // Ejecuta el comando y obtiene un lector de datos
        using var reader = command.ExecuteReader();
        // Retorna el objeto Usuario si se encuentra, o null si no hay resultados
        return reader.Read() ? MapearUsuario(reader) : null;
    }

    // M�todo p�blico para crear un nuevo usuario
    public void Crear(Usuario usuario)
    {
        // Crea una conexi�n SQL usando la cadena de conexi�n
        using var connection = new SqlConnection(_connectionString);
        // Define la consulta SQL para insertar un nuevo usuario
        var query = @"INSERT INTO usuario (dni, nombre, apellido, correo, id_perfil, contrasena_hash, sexo)
                          VALUES (@dni, @nombre, @apellido, @correo, @idPerfil, @contrasenaHash, @sexo)";

        // Crea el comando SQL con la consulta y la conexi�n
        using var command = new SqlCommand(query, connection);
        // Agrega los par�metros con los valores del objeto usuario
        command.Parameters.AddWithValue("@dni", usuario.Dni);
        command.Parameters.AddWithValue("@nombre", usuario.Nombre);
        command.Parameters.AddWithValue("@apellido", usuario.Apellido);
        command.Parameters.AddWithValue("@correo", usuario.Correo);
        command.Parameters.AddWithValue("@idPerfil", usuario.IdPerfil);
        command.Parameters.AddWithValue("@contrasenaHash", usuario.ContrasenaHash);
        command.Parameters.AddWithValue("@sexo", usuario.Sexo);

        // Abre la conexi�n a la base de datos
        connection.Open();
        // Ejecuta el comando para insertar el usuario
        command.ExecuteNonQuery();
    }

    // M�todo p�blico para actualizar un usuario existente
    public void Actualizar(Usuario usuario)
    {
        // Crea una conexi�n SQL usando la cadena de conexi�n
        using var connection = new SqlConnection(_connectionString);
        // Define la consulta SQL para actualizar los campos del usuario
        var query = @"UPDATE usuario SET dni = @dni, nombre = @nombre, apellido = @apellido,
                      correo = @correo, id_perfil = @idPerfil, contrasena_hash = @contrasenaHash,
                      sexo = @sexo, eliminado = @eliminado
                  WHERE id_usuario = @id";

        // Crea el comando SQL con la consulta y la conexi�n
        using var command = new SqlCommand(query, connection);
        // Agrega los par�metros con los valores del objeto usuario
        command.Parameters.AddWithValue("@id", usuario.IdUsuario);
        command.Parameters.AddWithValue("@dni", usuario.Dni);
        command.Parameters.AddWithValue("@nombre", usuario.Nombre);
        command.Parameters.AddWithValue("@apellido", usuario.Apellido);
        command.Parameters.AddWithValue("@correo", usuario.Correo);
        command.Parameters.AddWithValue("@idPerfil", usuario.IdPerfil);
        command.Parameters.AddWithValue("@contrasenaHash", usuario.ContrasenaHash);
        command.Parameters.AddWithValue("@sexo", usuario.Sexo);
        command.Parameters.AddWithValue("@eliminado", usuario.Eliminado ? 1 : 0);

        // Abre la conexi�n a la base de datos
        connection.Open();
        // Ejecuta el comando para actualizar el usuario
        command.ExecuteNonQuery();
    }

    // M�todo p�blico para marcar un usuario como eliminado
    public void Eliminar(int id)
    {
        // Crea una conexi�n SQL usando la cadena de conexi�n
        using var connection = new SqlConnection(_connectionString);
        // Define la consulta SQL para actualizar el campo eliminado a true
        var query = "UPDATE usuario SET eliminado = 1 WHERE id_usuario = @id";

        // Crea el comando SQL con la consulta y la conexi�n
        using var command = new SqlCommand(query, connection);
        // Agrega el par�metro @id con el valor recibido
        command.Parameters.AddWithValue("@id", id);

        // Abre la conexi�n a la base de datos
        connection.Open();
        // Ejecuta el comando para marcar el usuario como eliminado
        command.ExecuteNonQuery();
    }

    // M�todo privado para mapear un lector de datos a un objeto Usuario
    private Usuario MapearUsuario(SqlDataReader reader)
    {
        // Retorna un nuevo objeto Usuario con los datos obtenidos del lector
        return new Usuario
        {
            IdUsuario = (int)reader["id_usuario"],                   // Asigna el id del usuario
            Dni = (int)reader["dni"],                                // Asigna el DNI
            Nombre = reader["nombre"].ToString() ?? "",              // Asigna el nombre
            Apellido = reader["apellido"].ToString() ?? "",          // Asigna el apellido
            Correo = reader["correo"].ToString() ?? "",              // Asigna el correo electr�nico
            FechaRegistro = (DateTime)reader["fecha_registro"],      // Asigna la fecha de registro
            IdPerfil = (int)reader["id_perfil"],                     // Asigna el id del perfil
            ContrasenaHash = reader["contrasena_hash"].ToString() ?? "", // Asigna el hash de la contrase�a
            Sexo = Convert.ToChar(reader["sexo"]),                   // Asigna el sexo como car�cter
            Eliminado = (bool)reader["eliminado"]                    // Asigna el estado de eliminado
        };
    }
}
