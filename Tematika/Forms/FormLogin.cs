using System;
using System.Drawing;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;
using Tematika.Utils;

namespace Tematika.Forms
{
    public partial class FormLogin : Form
    {
        public event Action? OnLoginSuccess;

        public FormLogin()
        {
            InitializeComponent();
            BIniciarSesion.Click += BIniciarSesion_Click;
            BInvitado.Click += BInvitado_Click;

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            panelMainLogin.BackColor = ColorTranslator.FromHtml("#2c3e50");
            BIniciarSesion.BackColor = ColorTranslator.FromHtml("#34495e");
            BInvitado.BackColor = ColorTranslator.FromHtml("#34495e");

            BIniciarSesion.ForeColor = ColorTranslator.FromHtml("#bdc3c7");
            BInvitado.ForeColor = ColorTranslator.FromHtml("#bdc3c7");
        }

        private void BIniciarSesion_Click(object sender, EventArgs e)
        {
            var correo = TBUsuario.Text.Trim();
            var contrasena = TBContraseña.Text;

            var servicio = new UsuarioService();
            var (usuario, mensajeError) = servicio.ValidarCredenciales(correo, contrasena);

            if (usuario == null)
            {
                MessageBox.Show(mensajeError, "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SesionManager.IniciarSesion(usuario);
            OnLoginSuccess?.Invoke(); // Notifica al AppContext
            this.Close(); // Destruye el login
        }

        private void BInvitado_Click(object sender, EventArgs e)
        {
            SesionManager.IniciarSesion(null); // Marca como invitado

            OnLoginSuccess?.Invoke(); // Notifica al AppContext que debe abrir el form principal
            this.Close(); // Destruye el login
        }
    }
}
