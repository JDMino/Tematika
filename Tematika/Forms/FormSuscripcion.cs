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
    public partial class FormSuscripcion : Form
    {
        public FormSuscripcion()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Form mostrarFactura = new FormFactura();
            mostrarFactura.Show();
            this.Close();
        }
    }
}