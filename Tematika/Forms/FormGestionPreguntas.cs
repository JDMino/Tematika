using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tematika.Styles;

namespace Tematika.Forms
{
    public partial class FormGestionPreguntas : Form
    {
        public FormGestionPreguntas()
        {
            InitializeComponent();
        }

        private void panelEncabezadoP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormGestionPreguntas_Load(object sender, EventArgs e)
        {
            EstiloEncabezado.Aplicar(panelEncabezadoP, LTituloPreguntas);
            panelPreguntas.BackColor = ColorTranslator.FromHtml("#cfd8dc");
        }
    }
}
