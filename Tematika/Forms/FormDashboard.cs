using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tematika.Forms.Cards;
using Tematika.Styles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Tematika.Forms
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            EstiloEncabezado.Aplicar(panelEncabezado, LDashboard);
            panel2.BackColor = ColorTranslator.FromHtml("#cfd8dc");
            TBActividadRec.BackColor = ColorTranslator.FromHtml("#cfd8dc");
            TBEstadisticas.BackColor = ColorTranslator.FromHtml("#cfd8dc");

            var tarjetas = new[]
            {
        new DashboardUserControl1()
        {
            InfoCard = "100",
            TituloCard = "Usuarios Registrados",
            CardBackColor = ColorTranslator.FromHtml("#3498db"),
            Dock = DockStyle.Fill,
            Margin = new Padding(10)
        },
        new DashboardUserControl1()
        {
            InfoCard = "85",
            TituloCard = "Usuarios Activos",
            CardBackColor = ColorTranslator.FromHtml("#2ecc71"),
            Dock = DockStyle.Fill,
            Margin = new Padding(10)
        },
        new DashboardUserControl1()
        {
            InfoCard = "15",
            TituloCard = "Materias",
            CardBackColor = ColorTranslator.FromHtml("#f39c12"),
            Dock = DockStyle.Fill,
            Margin = new Padding(10)
        },
        new DashboardUserControl1()
        {
            InfoCard = "250",
            TituloCard = "Recursos Educativos",
            CardBackColor = ColorTranslator.FromHtml("#e74c3c"),
            Dock = DockStyle.Fill,
            Margin = new Padding(10)
        }
    };

            int i = 0;
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    tlpTarjetas.Controls.Add(tarjetas[i], col, row);
                    i++;
                }
            }
        }
    }
}
