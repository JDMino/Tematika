using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;
using Tematika.Utils;

namespace Tematika.Forms
{
    public partial class FormDashboardEstudiante : Form
    {
        public FormDashboardEstudiante()
        {
            InitializeComponent();
            Load += FormDashboardEstudiante_Load;
            BUModificar.Click += BUModificar_Click;
        }

        private void FormDashboardEstudiante_Load(object sender, EventArgs e)
        {
            var usuario = SesionManager.UsuarioActual;
            if (usuario == null || usuario.IdPerfil != 3) // Solo estudiantes
            {
                MessageBox.Show("Acceso no autorizado.");
                Close();
                return;
            }

            TBNombreUsuario.Text = usuario.Nombre;
            TBApellidoUsuario.Text = usuario.Apellido;
            TBEmailUsuario.Text = usuario.Correo;
            TBDNIUsuario.Text = usuario.Dni.ToString();
            TBContraseñaUsuario.Text = ""; // No se muestra el hash
            RBHombre.Checked = usuario.Sexo == 'm';
            RBMujer.Checked = usuario.Sexo == 'f';
        }

        private void BUModificar_Click(object sender, EventArgs e)
        {
            var controles = panelDatosEstudiante.Controls
                .OfType<Control>()
                .Where(c => c.Name != "TBContraseñaUsuario")
                .ToList();

            if (!Validaciones.ValidarControlesObligatorios(controles))
                return;

            var usuarioActual = SesionManager.UsuarioActual;
            if (usuarioActual == null)
                return;

            usuarioActual.Nombre = TBNombreUsuario.Text;
            usuarioActual.Apellido = TBApellidoUsuario.Text;
            usuarioActual.Correo = TBEmailUsuario.Text;
            usuarioActual.Dni = int.Parse(TBDNIUsuario.Text);
            usuarioActual.Sexo = RBHombre.Checked ? 'm' : 'f';

            var nuevaContrasena = TBContraseñaUsuario.Text;
            var servicio = new UsuarioService();
            var mensajeError = servicio.ActualizarUsuario(usuarioActual, string.IsNullOrWhiteSpace(nuevaContrasena) ? null : nuevaContrasena);

            if (mensajeError != null)
            {
                MessageBox.Show(mensajeError, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Tus datos han sido actualizados correctamente.");
        }
    }
}