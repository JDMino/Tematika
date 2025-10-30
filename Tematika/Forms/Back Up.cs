using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tematika.Styles;
using Tematika.Utils;

namespace Tematika.Forms
{
    public partial class Back_Up : Form
    {
        // Cadena de conexión leída desde App.config
        private readonly string cadenaConexion;

        public Back_Up()
        {
            InitializeComponent();

            // Obtiene la cadena de conexión definida en App.config (archivo de configuración del proyecto)
            cadenaConexion = ConfigurationManager.ConnectionStrings["TematikaConnectionString"].ConnectionString;

            // Suscripción de eventos a sus respectivos manejadores
            Load += Back_Up_Load;                 // Evento al cargar el formulario
            LocationChanged += Back_Up_LocationChanged; // Evento al mover el formulario
            BRuta.Click += BRuta_Click;           // Botón para seleccionar la ruta del backup
            BConectar.Click += BConectar_Click;   // Botón para conectar al servidor SQL
            BBackUp.Click += BBackUp_Click;       // Botón para ejecutar el backup
        }

        private void Back_Up_Load(object sender, EventArgs e)
        {
            // Aplica el estilo del encabezado (color, fuente, etc.)
            EstiloEncabezado.Aplicar(panelEncabezado, LTituloBackUp);

            // Cambia el color de fondo del panel principal
            panelMain.BackColor = ColorTranslator.FromHtml("#cfd8dc");
        }

        private void Back_Up_LocationChanged(object sender, EventArgs e)
        {
        }

        private void BRuta_Click(object sender, EventArgs e)
        {
            // Ruta por defecto donde SQL Server guarda los backups
            string rutaBackupSqlServer = @"C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\Backup";

            // Verifica que la carpeta exista antes de continuar
            if (!Directory.Exists(rutaBackupSqlServer))
            {
                MessageBox.Show("La carpeta de backup de SQL Server no existe o no es accesible.",
                                "Ruta no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Abre un diálogo para que el usuario elija la carpeta donde guardar el backup
            using var dialogo = new FolderBrowserDialog();
            dialogo.Description = "Seleccionar carpeta para guardar el archivo .bak";
            dialogo.SelectedPath = rutaBackupSqlServer;

            // Si el usuario selecciona una carpeta, se guarda la ruta en el textbox
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dialogo.SelectedPath;
            }
        }

        /*
        // Versión original del botón conectar: obtenía TODAS las bases de datos del servidor
        private void BConectar_Click(object sender, EventArgs e)
        {
            try
            {
                using var connection = new SqlConnection(cadenaConexion);
                var query = "SELECT name FROM sys.databases WHERE database_id > 4";

                using var command = new SqlCommand(query, connection);
                connection.Open();
                using var reader = command.ExecuteReader();

                var lista = new List<string>();
                while (reader.Read())
                {
                    lista.Add(reader.GetString(0));
                }

                CBBackUp.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message, 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        private void BConectar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crea una conexión a SQL Server usando la cadena del App.config
                using var connection = new SqlConnection(cadenaConexion);

                // Consulta solo la base de datos llamada "Tematika"
                var query = "SELECT name FROM sys.databases WHERE name = 'Tematika'";

                using var command = new SqlCommand(query, connection);
                connection.Open();

                // Ejecuta la consulta y lee los resultados
                using var reader = command.ExecuteReader();
                var lista = new List<string>();

                while (reader.Read())
                {
                    lista.Add(reader.GetString(0)); // Agrega el nombre de la base de datos a la lista
                }

                // Si no se encontró la base de datos, muestra advertencia
                if (lista.Count == 0)
                {
                    MessageBox.Show("La base de datos 'Tematika' no fue encontrada en el servidor.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CBBackUp.DataSource = null;
                }
                else
                {
                    // Asigna la lista al ComboBox para seleccionar la base de datos
                    CBBackUp.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                // Muestra mensaje de error en caso de fallo de conexión
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BBackUp_Click(object sender, EventArgs e)
        {
            // Obtiene el nombre de la base seleccionada y la ruta del destino
            string nombreBD = CBBackUp.SelectedItem?.ToString() ?? "";
            string rutaCarpeta = textBox2.Text;

            // Validación: se deben seleccionar base de datos y ruta
            if (string.IsNullOrWhiteSpace(nombreBD) || string.IsNullOrWhiteSpace(rutaCarpeta))
            {
                MessageBox.Show("Debe seleccionar una base de datos y una ruta de destino.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Construye el nombre del archivo de backup con fecha y hora
            string archivoBackup = Path.Combine(rutaCarpeta,
                $"Backup_{nombreBD}_{DateTime.Now:yyyyMMdd_HHmmss}.bak");

            // Crea una instancia de la clase auxiliar que realiza el backup
            var helper = new BackupHelper(cadenaConexion);

            // Ejecuta el backup y captura posibles errores
            var error = helper.RealizarBackup(nombreBD, archivoBackup);

            // Si no hubo error, muestra mensaje de éxito; si no, muestra el error
            if (error == null)
            {
                MessageBox.Show("Backup realizado correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
