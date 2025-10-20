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
        private readonly string cadenaConexion;

        public Back_Up()
        {
            InitializeComponent();

            // Obtiene la cadena de conexión desde App.config
            cadenaConexion = ConfigurationManager.ConnectionStrings["TematikaConnectionString"].ConnectionString;

            Load += Back_Up_Load;
            LocationChanged += Back_Up_LocationChanged;
            BRuta.Click += BRuta_Click;
            BConectar.Click += BConectar_Click;
            BBackUp.Click += BBackUp_Click;
        }

        private void Back_Up_Load(object sender, EventArgs e)
        {
            EstiloEncabezado.Aplicar(panelEncabezado, LTituloBackUp);
            panelMain.BackColor = ColorTranslator.FromHtml("#cfd8dc");
        }

        private void Back_Up_LocationChanged(object sender, EventArgs e) { }

        private void BRuta_Click(object sender, EventArgs e)
        {
            string rutaBackupSqlServer = @"C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\Backup";

            // Asegura que la carpeta exista
            if (!Directory.Exists(rutaBackupSqlServer))
            {
                MessageBox.Show("La carpeta de backup de SQL Server no existe o no es accesible.", "Ruta no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var dialogo = new FolderBrowserDialog();
            dialogo.Description = "Seleccionar carpeta para guardar el archivo .bak";
            dialogo.SelectedPath = rutaBackupSqlServer;

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dialogo.SelectedPath;
            }
        }


        /*private void BConectar_Click(object sender, EventArgs e)
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
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void BConectar_Click(object sender, EventArgs e)
        {
            try
            {
                using var connection = new SqlConnection(cadenaConexion);
                var query = "SELECT name FROM sys.databases WHERE name = 'Tematika'";

                using var command = new SqlCommand(query, connection);
                connection.Open();
                using var reader = command.ExecuteReader();

                var lista = new List<string>();
                while (reader.Read())
                {
                    lista.Add(reader.GetString(0));
                }

                if (lista.Count == 0)
                {
                    MessageBox.Show("La base de datos 'Tematika' no fue encontrada en el servidor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CBBackUp.DataSource = null;
                }
                else
                {
                    CBBackUp.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BBackUp_Click(object sender, EventArgs e)
        {
            string nombreBD = CBBackUp.SelectedItem?.ToString() ?? "";
            string rutaCarpeta = textBox2.Text;

            if (string.IsNullOrWhiteSpace(nombreBD) || string.IsNullOrWhiteSpace(rutaCarpeta))
            {
                MessageBox.Show("Debe seleccionar una base de datos y una ruta de destino.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string archivoBackup = Path.Combine(rutaCarpeta, $"Backup_{nombreBD}_{DateTime.Now:yyyyMMdd_HHmmss}.bak");

            var helper = new BackupHelper(cadenaConexion);
            var error = helper.RealizarBackup(nombreBD, archivoBackup);

            if (error == null)
            {
                MessageBox.Show("Backup realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
