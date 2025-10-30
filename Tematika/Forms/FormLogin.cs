using System;
using System.Drawing;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;
using Tematika.Utils;

namespace Tematika.Forms
{
    // Formulario de login para la aplicación
    public partial class FormLogin : Form
    {
        // Evento que se dispara cuando el login es exitoso
        public event Action? OnLoginSuccess;

        // Constructor del formulario
        public FormLogin()
        {
            InitializeComponent(); // Inicializa los componentes del formulario

            // Asigna los manejadores de eventos para los botones
            BIniciarSesion.Click += BIniciarSesion_Click; // Botón de iniciar sesión
            BInvitado.Click += BInvitado_Click;           // Botón para entrar como invitado
        }

        // Evento que se ejecuta cuando se carga el formulario
        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Configura colores del panel principal y botones usando códigos hex
            panelMainLogin.BackColor = ColorTranslator.FromHtml("#2c3e50"); // Fondo del panel principal
            BIniciarSesion.BackColor = ColorTranslator.FromHtml("#34495e"); // Fondo botón iniciar sesión
            BInvitado.BackColor = ColorTranslator.FromHtml("#34495e");      // Fondo botón invitado

            // Configura color del texto de los botones
            BIniciarSesion.ForeColor = ColorTranslator.FromHtml("#bdc3c7");
            BInvitado.ForeColor = ColorTranslator.FromHtml("#bdc3c7");
        }

        // Evento que se ejecuta al hacer click en "Iniciar Sesión"
        private void BIniciarSesion_Click(object sender, EventArgs e)
        {
            // Obtiene el correo y contraseña ingresados por el usuario
            var correo = TBUsuario.Text.Trim();
            var contrasena = TBContraseña.Text;

            // Servicio para validar credenciales
            var servicio = new UsuarioService();
            var (usuario, mensajeError) = servicio.ValidarCredenciales(correo, contrasena);

            // Si las credenciales son incorrectas, muestra mensaje y sale
            if (usuario == null)
            {
                MessageBox.Show(mensajeError, "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Inicia sesión con el usuario validado
            SesionManager.IniciarSesion(usuario);

            // Dispara evento para notificar a la aplicación que el login fue exitoso
            OnLoginSuccess?.Invoke();

            // Cierra el formulario de login
            this.Close();
        }

        // Evento que se ejecuta al hacer click en "Entrar como Invitado"
        private void BInvitado_Click(object sender, EventArgs e)
        {
            // Inicia sesión como invitado (usuario nulo)
            SesionManager.IniciarSesion(null);

            // Notifica al AppContext que se debe abrir el formulario principal
            OnLoginSuccess?.Invoke();

            // Cierra el formulario de login
            this.Close();
        }
    }
}
