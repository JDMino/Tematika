using System; 
using System.Data;
using System.Data.SqlClient; 
using Microsoft.Data.SqlClient;
using System.IO; 
using System.Windows.Forms; 

namespace Tematika.Utils; 

public class BackupHelper
{
    // Cadena de conexión a la base de datos
    private readonly string connectionString;

    // Constructor que recibe la cadena de conexión y la guarda en el campo privado
    public BackupHelper(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // Método público que realiza el backup de una base de datos y retorna un mensaje de error si ocurre
    public string? RealizarBackup(string nombreBaseDatos, string rutaDestino)
    {
        try
        {
            // Asegura que la carpeta de destino exista; si no, la crea
            Directory.CreateDirectory(Path.GetDirectoryName(rutaDestino)!);

            // Crea una conexión SQL usando la cadena de conexión
            using var connection = new SqlConnection(connectionString);

            // Define la consulta SQL para realizar el backup con parámetros
            var query = $@"
                BACKUP DATABASE [{nombreBaseDatos}]
                TO DISK = @ruta
                WITH FORMAT, INIT, NAME = @nombreArchivo, STATS = 10";

            // Crea el comando SQL con la consulta y la conexión
            using var command = new SqlCommand(query, connection);

            // Asigna el valor del parámetro @ruta con la ruta de destino
            command.Parameters.AddWithValue("@ruta", rutaDestino);

            // Asigna el valor del parámetro @nombreArchivo con un nombre dinámico basado en fecha y hora
            command.Parameters.AddWithValue("@nombreArchivo", $"Backup_{nombreBaseDatos}_{DateTime.Now:yyyyMMdd_HHmmss}");

            // Abre la conexión a la base de datos
            connection.Open();

            // Ejecuta el comando SQL para realizar el backup
            command.ExecuteNonQuery();

            // Si todo sale bien, retorna null indicando que no hubo errores
            return null;
        }
        catch (Exception ex)
        {
            // Si ocurre una excepción, retorna el mensaje de error
            return $"Error al realizar el backup: {ex.Message}";
        }
    }
}
