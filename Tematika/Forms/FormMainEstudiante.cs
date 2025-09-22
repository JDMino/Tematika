using System;
using System.Drawing;
using System.Windows.Forms;
using Tematika.Forms;
using Tematika.Utils;

namespace Tematika
{
    public partial class FormMainEstudiante : Form
    {
        private Form activeForm = null;

        public FormMainEstudiante()
        {
            InitializeComponent();
            // panelSidebar.BackColor = ColorTranslator.FromHtml("#2c3e50");

            //Botones del panel
            btnDashboard.Click += (s, e) =>
            {
                if (SesionManager.EsInvitado)
                {
                    MessageBox.Show("Función no disponible en modo invitado.");
                    return;
                }
                OpenChildForm(new FormDashboardEstudiante());
                //SetActiveButton(btnDashboard);
            };

            btnExploreResources.Click += (s, e) =>
            {
                OpenChildForm(new FormExploreResourcesEstudiante());
                //SetActiveButton(btnExploreResources);
            };

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

        private void SetActiveButton(Button activeBtn)
        {
            foreach (Control ctrl in panelSidebar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = ColorTranslator.FromHtml("#34495e"); // Fondo normal
                    btn.ForeColor = ColorTranslator.FromHtml("#bdc3c7"); // Texto normal
                }
            }
            activeBtn.BackColor = ColorTranslator.FromHtml("#2980b9"); // Fondo activo
            activeBtn.ForeColor = Color.White; // Texto activo
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelSidebar.BackColor = ColorTranslator.FromHtml("#2c3e50");

            foreach (Control ctrl in panelSidebar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = ColorTranslator.FromHtml("#34495e");
                    btn.ForeColor = ColorTranslator.FromHtml("#bdc3c7");
                }
            }

            if (SesionManager.EsInvitado)
            {
                labelNombreUsuario.Text = "Invitado";
                labelRolEstudiante.Text = "Modo exploración";

                //btnFavorites.Enabled = false;
                //btnEvaluations.Enabled = false;
                //btnNotes.Enabled = false;

                //btnFavorites.Visible = false;
                //btnEvaluations.Visible = false;
                //btnNotes.Visible = false;

                btnDashboard.BackColor = Color.LightGray;
                btnFavorites.BackColor = Color.LightGray;
                btnEvaluations.BackColor = Color.LightGray;
                btnNotes.BackColor = Color.LightGray;
            }
            else
            {
                var usuario = SesionManager.UsuarioActual!;
                labelNombreUsuario.Text = usuario.Nombre;
                labelRolEstudiante.Text = "Estudiante";
            }
        }


        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(childForm);
            panelMainContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            SesionManager.CerrarSesion();
            this.Close(); // Al cerrarse, AppContext crea un nuevo login
        }
    }
}
