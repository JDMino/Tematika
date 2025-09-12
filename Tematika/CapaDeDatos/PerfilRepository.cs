using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.Models;

namespace Tematika.CapaDeDatos;

public class PerfilRepository
{
    private readonly string _connectionString;

    public PerfilRepository()
    {
        _connectionString = System.Configuration.ConfigurationManager
            .ConnectionStrings["TematikaConnectionString"].ConnectionString;
    }

    public List<Perfil> ObtenerTodos()
    {
        var perfiles = new List<Perfil>();

        using var connection = new SqlConnection(_connectionString);
        var query = "SELECT id_perfil, nombre_perfil, descripcion FROM perfil";

        using var command = new SqlCommand(query, connection);
        connection.Open();
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            perfiles.Add(new Perfil
            {
                IdPerfil = (int)reader["id_perfil"],
                NombrePerfil = reader["nombre_perfil"].ToString() ?? "",
                Descripcion = reader["descripcion"].ToString()
            });
        }

        return perfiles;
    }
}
