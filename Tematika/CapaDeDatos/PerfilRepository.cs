using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos;

// Define la clase PerfilRepository dentro del namespace Tematika.CapaDeDatos
public class PerfilRepository
{
    // Campo privado para almacenar la cadena de conexi�n
    private readonly string _connectionString;

    // Constructor de la clase PerfilRepository
    public PerfilRepository()
    {
        // Obtiene la cadena de conexi�n desde el archivo de configuraci�n
        _connectionString = System.Configuration.ConfigurationManager
            .ConnectionStrings["TematikaConnectionString"].ConnectionString;
    }

    // M�todo p�blico que obtiene todos los perfiles registrados
    public List<Perfil> ObtenerTodos()
    {
        // Inicializa la lista que almacenar� los perfiles obtenidos
        var perfiles = new List<Perfil>();

        // Crea una conexi�n SQL usando la cadena de conexi�n
        using var connection = new SqlConnection(_connectionString);
        // Define la consulta SQL para obtener los campos deseados de la tabla perfil
        var query = "SELECT id_perfil, nombre_perfil, descripcion FROM perfil";

        // Crea el comando SQL con la consulta y la conexi�n
        using var command = new SqlCommand(query, connection);
        // Abre la conexi�n a la base de datos
        connection.Open();
        // Ejecuta el comando y obtiene un lector de datos
        using var reader = command.ExecuteReader();

        // Itera sobre los resultados obtenidos
        while (reader.Read())
        {
            // Agrega un nuevo objeto Perfil a la lista con los datos del lector
            perfiles.Add(new Perfil
            {
                IdPerfil = (int)reader["id_perfil"],                          // Asigna el id del perfil
                NombrePerfil = reader["nombre_perfil"].ToString() ?? "",     // Asigna el nombre del perfil
                Descripcion = reader["descripcion"].ToString()               // Asigna la descripci�n del perfil
            });
        }

        // Retorna la lista de perfiles obtenidos
        return perfiles;
    }
}
