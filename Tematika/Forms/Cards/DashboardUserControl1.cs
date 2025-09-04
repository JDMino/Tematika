using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tematika.Forms.Cards
{
    public partial class DashboardUserControl1 : UserControl
    {
        public DashboardUserControl1()
        {
            InitializeComponent();
        }

        public string InfoCard
        {
            get => LInfoCard.Text;
            set => LInfoCard.Text = value;
        }
        public string TituloCard
        {
            get => LTituloCard.Text;
            set => LTituloCard.Text = value;
        }

        public Color CardBackColor
        {
            get => this.BackColor;
            set => this.BackColor = value;
        }

        private void DashboardUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void LInfoCard_Click(object sender, EventArgs e)
        {

        }
    }
}
