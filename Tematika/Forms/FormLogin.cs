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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            panelMainLogin.BackColor = ColorTranslator.FromHtml("#2c3e50");
            BIniciarSesion.BackColor = ColorTranslator.FromHtml("#34495e");
            BInvitado.BackColor = ColorTranslator.FromHtml("#34495e");

            BIniciarSesion.ForeColor = ColorTranslator.FromHtml("#bdc3c7");
            BInvitado.ForeColor = ColorTranslator.FromHtml("#bdc3c7");
        }
    }
}

