using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tematika.Forms
{
    public partial class FormGestionContenidos : Form
    {
        public FormGestionContenidos()
        {
            InitializeComponent();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            FormGestionMateria gestionMaterias = new FormGestionMateria();
            gestionMaterias.Show();
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            FormGestionTemas gestionTemas = new FormGestionTemas();
            gestionTemas.Show();
        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            FormGestionRecursos gestionRecursos = new FormGestionRecursos();
            gestionRecursos.Show();
        }

        private void btnPreguntas_Click(object sender, EventArgs e)
        {
            FormGestionPreguntas gestionPreguntas = new FormGestionPreguntas();
            gestionPreguntas.Show();
        }
    }
}
