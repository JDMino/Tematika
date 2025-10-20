using System;
using System.Drawing;
using System.Windows.Forms;
using Tematika.Forms;
using Tematika.Utils;

namespace Tematika
{
    public partial class FormAdmin : Form
    {
        private Form activeForm = null;
        public FormAdmin()
        {
            InitializeComponent();

            BDashboard.Click += (s, e) =>
            {
                OpenChildForm(new FormDashboard());
                SetActiveButton(BDashboard);
            };

            BBackUp.Click += (s, e) =>
            {
                OpenChildForm(new Back_Up());
                SetActiveButton(BBackUp);
            };

            BUsuarios.Click += (s, e) =>
            {
                OpenChildForm(new FormGestionUsuarios());
                SetActiveButton(BUsuarios);
            };

            BGestionTematica.Click += (s, e) =>
            {
                OpenChildForm(new FormGestionContenidos());
                SetActiveButton(BGestionTematica);
            };


            BInformes.Click += (s, e) =>
            {
                OpenChildForm(new FormInformes());
                SetActiveButton(BInformes);
            };

            BSuscripciones.Click += (s, e) =>
            {
                OpenChildForm(new FormListaSuscriptos());
                SetActiveButton(BSuscripciones);
            };


        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /*private void SetActiveButton(Button activeBtn)
        {
            foreach (Control ctrl in sideBar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(44, 62, 80); // Color normal
                    btn.ForeColor = Color.FromArgb(189, 195, 199);
                }
            }
            activeBtn.BackColor = Color.FromArgb(52, 152, 219); // Color activo
            activeBtn.ForeColor = Color.White;
        }*/

        private void SetActiveButton(Button activeBtn)
        {
            foreach (Control ctrl in sideBar.Controls)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            sideBar.BackColor = ColorTranslator.FromHtml("#2c3e50");


            foreach (Control ctrl in sideBar.Controls)
            {
                if (ctrl is Button btn)
                {
                    //btn.BackColor = ColorTranslator.FromHtml("#dee6ed");
                    btn.BackColor = ColorTranslator.FromHtml("#34495e");
                    btn.ForeColor = ColorTranslator.FromHtml("#bdc3c7");

                }


            }

            var usuario = SesionManager.UsuarioActual;

            if (usuario !=null && usuario.IdPerfil == 1)
            {
                BBackUp.Visible = false;
            }    

            if (usuario != null && usuario.IdPerfil == 2) // Docente
            {
                BDashboard.Visible = false;
                BBackUp.Visible = false;
                BUsuarios.Visible = false;
                //BInformes.Visible = false;
                LRol.Text = "Docente";
            }
            else if (usuario != null)
            {
                LRol.Text = "Administrador";
            }

            if (usuario != null)
            {
                LNombreUsuario.Text = usuario.Nombre;
            }

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            SesionManager.CerrarSesion();
            this.Close(); // Al cerrarse, AppContext crea un nuevo login
            }
        }
}
