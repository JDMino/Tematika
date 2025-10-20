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

namespace Tematika.Forms
{
    public partial class FormListaSuscriptos : Form
    {
        public FormListaSuscriptos()
        {
            InitializeComponent();
        }

        private void FormListaSuscriptos_Load(object sender, EventArgs e)
        {
            EstiloEncabezado.Aplicar(panelEncabezadoS, LTituloSuscripciones);
            panelSuscripcion.BackColor = ColorTranslator.FromHtml("#cfd8dc");

            var tarjetas = new[]
            {
        new DashboardUserControl1()
        {
            InfoCard = "100",
            TituloCard = "Total Suscriptos",
            CardBackColor = ColorTranslator.FromHtml("#34495e"),
            Dock = DockStyle.Fill,
            Margin = new Padding(10)
        },
        new DashboardUserControl1()
        {
            InfoCard = "85",
            TituloCard = "Mensual",
            CardBackColor = ColorTranslator.FromHtml("#34495e "),
            Dock = DockStyle.Fill,
            Margin = new Padding(10)
        },
        new DashboardUserControl1()
        {
            InfoCard = "15",
            TituloCard = "Semestral",
            CardBackColor = ColorTranslator.FromHtml("#34495e"),
            Dock = DockStyle.Fill,
            Margin = new Padding(10)
        },
          new DashboardUserControl1()
        {
            InfoCard = "35",
            TituloCard = "Anual",
            CardBackColor = ColorTranslator.FromHtml("#34495e"),
            Dock = DockStyle.Fill,
            Margin = new Padding(10)
        },
          new DashboardUserControl1()
        {
            InfoCard = "$5,000",
            TituloCard = "Ingresos Mensuales",
            CardBackColor = ColorTranslator.FromHtml("#34495e"),
            Dock = DockStyle.Fill,
            Margin = new Padding(10)
        },
            new DashboardUserControl1()
        {
            InfoCard = "$250,000",
            TituloCard = "Ingresos Anuales",
            CardBackColor = ColorTranslator.FromHtml("#34495e"),
            Dock = DockStyle.Fill,
            Margin = new Padding(10)
        }
        };

            int i = 0;
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    TBCardsSuscripciones.Controls.Add(tarjetas[i], col, row);
                    i++;
                }
            }
        }
    }
}

