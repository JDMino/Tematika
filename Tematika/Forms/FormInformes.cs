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
    public partial class FormInformes : Form
    {
        public FormInformes()
        {
            InitializeComponent();
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {
            EstiloEncabezado.Aplicar(panelEncabezado, LTituloInformes);
            panel1.BackColor = ColorTranslator.FromHtml("#cfd8dc");
            tpRecursosConsultados.BackColor = ColorTranslator.FromHtml("#cfd8dc");
            tpInteraccionTema.BackColor = ColorTranslator.FromHtml("#cfd8dc");
            tpUsuariosActivos.BackColor = ColorTranslator.FromHtml("#cfd8dc");

        }

        private void DGVInformeRecursosConsultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
