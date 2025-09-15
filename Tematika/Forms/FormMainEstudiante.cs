using System;
using System.Drawing;
using System.Windows.Forms;
using Tematika.Forms;

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
                OpenChildForm(new FormDashboardEstudiante());
                SetActiveButton(btnDashboard);
            };

            btnExploreResources.Click += (s, e) =>
            {
                OpenChildForm(new FormExploreResourcesEstudiante());
                SetActiveButton(btnExploreResources);
            };

            btnFavorites.Click += (s, e) =>
            {
                OpenChildForm(new FormFavoritesEstudiante());
                SetActiveButton(btnFavorites);
            };

            btnEvaluations.Click += (s, e) =>
            {
                OpenChildForm(new FormEvaluationsEstudiante());
                SetActiveButton(btnEvaluations);
            };

            btnNotes.Click += (s, e) =>
            {
                OpenChildForm(new FormNotesEstudiante());
                SetActiveButton(btnNotes);
            };

        }

        private void SetActiveButton(Button activeBtn)
        {
            foreach (Control ctrl in panelSidebar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(44, 62, 80); // Color normal
                    btn.ForeColor = Color.FromArgb(189, 195, 199);
                }
            }
            activeBtn.BackColor = Color.FromArgb(52, 152, 219); // Color activo
            activeBtn.ForeColor = Color.White;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Cambia el color de fondo del panel al color hexadecimal deseado
            panelSidebar.BackColor = ColorTranslator.FromHtml("#2c3e50");

            //Aplica colores a botones (revisar SetActiveButton())
            foreach (Control ctrl in panelSidebar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = ColorTranslator.FromHtml("#dee6ed");
                }
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

    }
}
