using System;
using System.Drawing;
using System.Windows.Forms;
using Tematika.Forms;
using Tematika.Utils;

namespace Tematika
{
    public partial class FormAdmin : Form
    {
        // Guarda una referencia al formulario hijo actualmente abierto
        private Form activeForm = null;

        public FormAdmin()
        {
            InitializeComponent();

            // --- ASIGNACIÓN DE EVENTOS A LOS BOTONES DEL PANEL LATERAL ---

            // Botón "Back Up" → Abre el formulario de backup
            BBackUp.Click += (s, e) =>
            {
                OpenChildForm(new Back_Up()); // Carga el formulario Back_Up dentro del panel principal
                SetActiveButton(BBackUp);     // Marca visualmente este botón como activo
            };

            // Botón "Usuarios" → Abre la gestión de usuarios
            BUsuarios.Click += (s, e) =>
            {
                OpenChildForm(new FormGestionUsuarios());
                SetActiveButton(BUsuarios);
            };

            // Botón "Gestión Temática" → Abre el formulario de gestión de contenidos
            BGestionTematica.Click += (s, e) =>
            {
                OpenChildForm(new FormGestionContenidos());
                SetActiveButton(BGestionTematica);
            };

            // Botón "Informes" → Abre el formulario de reportes o estadísticas
            BInformes.Click += (s, e) =>
            {
                OpenChildForm(new FormInformes());
                SetActiveButton(BInformes);
            };

            // Botón "Suscripciones" → Abre la lista de suscriptores
            BSuscripciones.Click += (s, e) =>
            {
                OpenChildForm(new FormListaSuscriptos());
                SetActiveButton(BSuscripciones);
            };
        }

        // --- MÉTODO PARA ABRIR FORMULARIOS HIJOS DENTRO DEL PANEL PRINCIPAL ---
        private void OpenChildForm(Form childForm)
        {
            // Cierra el formulario activo (si existe) antes de abrir otro
            if (activeForm != null)
                activeForm.Close();

            // Asigna el nuevo formulario como activo
            activeForm = childForm;

            // Configura el formulario hijo para que se muestre dentro del formulario principal
            childForm.TopLevel = false; // No es un formulario independiente
            childForm.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            childForm.Dock = DockStyle.Fill; // Ocupa todo el espacio del panel

            // Agrega el formulario hijo al panel principal del formulario admin
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;

            // Trae el formulario al frente y lo muestra
            childForm.BringToFront();
            childForm.Show();
        }

        /*
        // --- VERSIÓN ANTERIOR DEL MÉTODO PARA CAMBIAR EL BOTÓN ACTIVO ---
        private void SetActiveButton(Button activeBtn)
        {
            foreach (Control ctrl in sideBar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(44, 62, 80); // Fondo normal
                    btn.ForeColor = Color.FromArgb(189, 195, 199); // Texto gris claro
                }
            }
            activeBtn.BackColor = Color.FromArgb(52, 152, 219); // Fondo azul cuando está activo
            activeBtn.ForeColor = Color.White; // Texto blanco cuando está activo
        }
        */

        // --- MÉTODO ACTUAL PARA RESALTAR EL BOTÓN ACTIVO ---
        private void SetActiveButton(Button activeBtn)
        {
            // Recorre todos los controles dentro del panel lateral (sideBar)
            foreach (Control ctrl in sideBar.Controls)
            {
                if (ctrl is Button btn)
                {
                    // Restaura los colores de los botones no activos
                    btn.BackColor = ColorTranslator.FromHtml("#34495e"); // Fondo gris azulado
                    btn.ForeColor = ColorTranslator.FromHtml("#bdc3c7"); // Texto gris claro
                }
            }

            // Aplica el estilo del botón activo
            activeBtn.BackColor = ColorTranslator.FromHtml("#2980b9"); // Azul más intenso
            activeBtn.ForeColor = Color.White; // Texto blanco
        }

        // --- EVENTO LOAD: SE EJECUTA AL CARGAR EL FORMULARIO ---
        private void Form1_Load(object sender, EventArgs e)
        {
            // Define el color de fondo del panel lateral
            sideBar.BackColor = ColorTranslator.FromHtml("#2c3e50");

            // Inicializa los colores de todos los botones del menú lateral
            foreach (Control ctrl in sideBar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = ColorTranslator.FromHtml("#34495e"); // Fondo por defecto
                    btn.ForeColor = ColorTranslator.FromHtml("#bdc3c7"); // Texto gris claro
                }
            }

            // Obtiene el usuario actualmente logueado desde el gestor de sesión
            var usuario = SesionManager.UsuarioActual;

            // Control de visibilidad y permisos según el perfil del usuario
            if (usuario != null && usuario.IdPerfil == 1) // Ejemplo: Administrador general
            {
                BBackUp.Visible = false; // No puede ver el botón de backup
            }

            if (usuario != null && usuario.IdPerfil == 2) // Perfil Docente
            {
                // Oculta botones que el docente no debe usar
                BBackUp.Visible = false;
                BUsuarios.Visible = false;
                BInformes.Visible = false;
                BSuscripciones.Visible = false;
                LRol.Text = "Docente"; // Actualiza la etiqueta de rol
            }
            else if (usuario != null)
            {
                // Si no es docente, se asume que es administrador
                LRol.Text = "Administrador";
            }

            // Muestra el nombre del usuario actual en la interfaz
            if (usuario != null)
            {
                LNombreUsuario.Text = usuario.Nombre;
            }
        }

        // --- BOTÓN "SALIR" ---
        private void BSalir_Click(object sender, EventArgs e)
        {
            // Cierra la sesión actual mediante la clase de utilidad
            SesionManager.CerrarSesion();

            // Cierra el formulario; el contexto de la aplicación (AppContext) abrirá el login nuevamente
            this.Close();
        }
    }
}
