using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tematika.Styles
{
    internal class EstiloEncabezado
    {
        public static void Aplicar(Panel panel, Label titulo)
        {
            panel.BackColor = ColorTranslator.FromHtml("#34495e");
            titulo.ForeColor = Color.White;
            //titulo.Text = titulo.Text.ToUpper();
            titulo.Font = new Font("Ebrima", 14, FontStyle.Bold);
            titulo.Padding = new Padding(10);
            titulo.TextAlign = ContentAlignment.MiddleLeft;
        }
    }
}
