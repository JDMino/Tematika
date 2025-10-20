using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Tematika.Utils;
public class BackupHelper
{
    private readonly string connectionString;

    public BackupHelper(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public string? RealizarBackup(string nombreBaseDatos, string rutaDestino)
    {
        try
        {
            // Asegura que la carpeta exista
            Directory.CreateDirectory(Path.GetDirectoryName(rutaDestino)!);

            using var connection = new SqlConnection(connectionString);
            var query = $@"
                BACKUP DATABASE [{nombreBaseDatos}]
                TO DISK = @ruta
                WITH FORMAT, INIT, NAME = @nombreArchivo, STATS = 10";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ruta", rutaDestino);
            command.Parameters.AddWithValue("@nombreArchivo", $"Backup_{nombreBaseDatos}_{DateTime.Now:yyyyMMdd_HHmmss}");

            connection.Open();
            command.ExecuteNonQuery();

            return null; // Sin errores
        }
        catch (Exception ex)
        {
            return $"Error al realizar el backup: {ex.Message}";
        }
    }
}
