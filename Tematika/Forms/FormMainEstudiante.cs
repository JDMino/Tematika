using System;
using System.Drawing;
using System.Windows.Forms;
using Tematika.Forms;
using Tematika.Utils;

namespace Tematika
{
    // Formulario principal para usuarios tipo estudiante
    public partial class FormMainEstudiante : Form
    {
        // Variable para guardar el formulario hijo activo actualmente
        private Form activeForm = null;

        public FormMainEstudiante()
        {
            InitializeComponent(); // Inicializa los componentes del formulario

            // Configuración de botones del panel lateral (sidebar)

            // Botón Dashboard
            btnDashboard.Click += (s, e) =>
            {
                // Verifica si el usuario es invitado
                if (SesionManager.EsInvitado)
                {
                    MessageBox.Show("Función no disponible en modo invitado.");
                    return; // Sale si es invitado
                }
                OpenChildForm(new FormDashboardEstudiante()); // Abre el formulario hijo
                //SetActiveButton(btnDashboard); // Podría resaltar el botón activo
            };

            // Botón Explorar Recursos
            btnExploreResources.Click += (s, e) =>
            {
                OpenChildForm(new FormExploreResourcesEstudiante()); // Abre el formulario hijo
                //SetActiveButton(btnExploreResources);
            };

            // Botón Favoritos
            btnFavorites.Click += (s, e) =>
            {
                if (SesionManager.EsInvitado)
                {
                    MessageBox.Show("Función no disponible en modo invitado.");
                    return;
                }
                OpenChildForm(new FormFavoritesEstudiante());
                //SetActiveButton(btnFavorites);
            };

            // Botón Evaluaciones
            btnEvaluations.Click += (s, e) =>
            {
                if (SesionManager.EsInvitado)
                {
                    MessageBox.Show("Función no disponible en modo invitado.");
                    return;
                }
                OpenChildForm(new FormEvaluationsEstudiante());
                //SetActiveButton(btnEvaluations);
            };

            // Botón Notas
            btnNotes.Click += (s, e) =>
            {
                if (SesionManager.EsInvitado)
                {
                    MessageBox.Show("Función no disponible en modo invitado.");
                    return;
                }
                OpenChildForm(new FormNotesEstudiante());
                //SetActiveButton(btnNotes);
            };
        }

        // Método para resaltar el botón activo en el sidebar
        private void SetActiveButton(Button activeBtn)
        {
            // Recorre todos los controles del panel lateral
            foreach (Control ctrl in panelSidebar.Controls)
            {
                if (ctrl is Button btn)
                {
                    // Restaura color normal de todos los botones
                    btn.BackColor = ColorTranslator.FromHtml("#34495e");
                    btn.ForeColor = ColorTranslator.FromHtml("#bdc3c7");
                }
            }

            // Cambia color del botón activo
            activeBtn.BackColor = ColorTranslator.FromHtml("#2980b9"); // Azul
            activeBtn.ForeColor = Color.White;
        }

        // Evento que se ejecuta cuando se carga el formulario principal
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Configura el color del panel lateral
            panelSidebar.BackColor = ColorTranslator.FromHtml("#2c3e50");

            // Configura color y texto de todos los botones
            foreach (Control ctrl in panelSidebar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = ColorTranslator.FromHtml("#34495e");
                    btn.ForeColor = ColorTranslator.FromHtml("#bdc3c7");
                }
            }

            // Configuración especial si el usuario es invitado
            if (SesionManager.EsInvitado)
            {
                labelNombreUsuario.Text = "Invitado"; // Muestra "Invitado"
                labelRolEstudiante.Text = "Modo exploración"; // Indica modo limitado

                // Opcional: deshabilitar o ocultar botones para invitados
                //btnFavorites.Enabled = false;
                //btnEvaluations.Enabled = false;
                //btnNotes.Enabled = false;

                //btnFavorites.Visible = false;
                //btnEvaluations.Visible = false;
                //btnNotes.Visible = false;

                // Cambia color de botones no disponibles
                btnDashboard.BackColor = Color.LightGray;
                btnFavorites.BackColor = Color.LightGray;
                btnEvaluations.BackColor = Color.LightGray;
                btnNotes.BackColor = Color.LightGray;
            }
            else
            {
                // Si es usuario registrado, muestra nombre y rol
                var usuario = SesionManager.UsuarioActual!;
                labelNombreUsuario.Text = usuario.Nombre;
                labelRolEstudiante.Text = "Estudiante";
            }
        }

        // Método para abrir un formulario hijo dentro del panel principal
        private void OpenChildForm(Form childForm)
        {
            // Si ya hay un formulario activo, se cierra
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm; // Asigna el nuevo formulario activo

            childForm.TopLevel = false; // No es formulario independiente
            childForm.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            childForm.Dock = DockStyle.Fill; // Ocupa todo el panel
            panelMainContent.Controls.Add(childForm); // Lo agrega al panel principal
            panelMainContent.Tag = childForm;
            childForm.BringToFront(); // Trae el formulario al frente
            childForm.Show(); // Muestra el formulario
        }

        // Evento para cerrar sesión
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            SesionManager.CerrarSesion(); // Cierra la sesión del usuario
            this.Close(); // Al cerrar, AppContext abrirá el login nuevamente
        }
    }
}
