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
             Size cardSize = new Size(200, 180);
             int spacing = 10;

             var card1 = new DashboardUserControl1()
             {
                 InfoCard = "100",
                 TituloCard = "Usuarios Registrados",
                 CardBackColor = ColorTranslator.FromHtml("#3498db"),
                 Size = cardSize
             }
             ;
             card1.Location = new Point(spacing, spacing);

             var card2 = new DashboardUserControl1()
             {
                 InfoCard = "85",
                 TituloCard = "Usuarios Activos",
                 CardBackColor = ColorTranslator.FromHtml("#2ecc71"),
                 Size = cardSize
             }
             ;
             card2.Location = new Point(card1.Right + spacing, spacing);

             var card3 = new DashboardUserControl1()
             {
                 InfoCard = "15",
                 TituloCard = "Materias",
                 CardBackColor = ColorTranslator.FromHtml("#f39c12"),
                 Size = cardSize
             }
             ;
             card3.Location = new Point(spacing, card1.Bottom + spacing);

             var card4 = new DashboardUserControl1()
             {
                 InfoCard = "250",
                 TituloCard = "Recursos Educativos",
                 CardBackColor = ColorTranslator.FromHtml("#e74c3c"),
                 Size = cardSize
             }
             ;
             card4.Location = new Point(card3.Right + spacing, card2.Bottom + spacing);

            TBEstadisticas.SuspendLayout();
            TBEstadisticas.Controls.Add(card1);
            TBEstadisticas.Controls.Add(card2);
            TBEstadisticas.Controls.Add(card3);
            TBEstadisticas.Controls.Add(card4);
            TBEstadisticas.ResumeLayout();
            MessageBox.Show("Cards agregados: " + TBEstadisticas.Controls.Count);

        }

    }
}
