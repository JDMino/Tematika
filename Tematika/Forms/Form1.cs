using System;
using System.Drawing;
using System.Windows.Forms;
using Tematika.Forms;

namespace Tematika
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;
        public Form1()
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
                OpenChildForm(new Gestion_de_Usuarios());
                SetActiveButton(BUsuarios);
            };

            BMaterias.Click += (s, e) =>
            {
                OpenChildForm(new Gestion_de_Materias());
                SetActiveButton(BMaterias);
            };

            BRecursos.Click += (s, e) =>
            {
                OpenChildForm(new FormGestionRecursos());
                SetActiveButton(BRecursos);
            };

            BTemas.Click += (s, e) =>
            {
                OpenChildForm(new Gestion_de_Temas());
                SetActiveButton(BTemas);
            };

            BEvaluaciones.Click += (s, e) =>
            {
                OpenChildForm(new FormEvaluaciones());
                SetActiveButton(BEvaluaciones);
            };


            BInformes.Click += (s, e) =>
            {
                OpenChildForm(new FormInformes());
                SetActiveButton(BInformes);
            };

        }
        /*private void OpenChildForm(Form childForm)
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
        }*/

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close(); // Cierra el formulario activo actual
            activeForm = childForm; // Asigna el nuevo formulario como activo
            childForm.TopLevel = false; // Importante: indica que no es un formulario de nivel superior
            childForm.FormBorderStyle = FormBorderStyle.None; // Elimina el borde del formulario hijo
            childForm.Dock = DockStyle.Fill; // ¡Clave! Hace que el formulario hijo llene el panel contenedor

            //int paddingSize = 10; // Por ejemplo, 10 píxeles en todos los lados
            //childForm.Padding = new Padding(paddingSize);
            panelMain.Controls.Add(childForm); // Añade el formulario hijo a los controles del panel
            panelMain.Tag = childForm; // Opcional: guarda una referencia al formulario hijo en el Tag del panel
            childForm.BringToFront(); // Asegura que el formulario hijo esté al frente
            childForm.Show(); // Muestra el formulario hijo
        }

        private void SetActiveButton(Button activeBtn)
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sideBar.BackColor = ColorTranslator.FromHtml("#2c3e50");

            foreach (Control ctrl in sideBar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = ColorTranslator.FromHtml("#dee6ed");
                }


            }
        }
    }
}
