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

namespace Tematika.Forms
{
    public partial class FormExploreResourcesEstudiante : Form
    {
        public FormExploreResourcesEstudiante()
        {
            InitializeComponent();
        }

        private void FormExploreResourcesEstudiante_Load(object sender, EventArgs e)
        {
            flpRecursos.Controls.Add(new RecursoCard());
            flpRecursos.Controls.Add(new RecursoCard());
            flpRecursos.Controls.Add(new RecursoCard());
            flpRecursos.Controls.Add(new RecursoCard());
            flpRecursos.Controls.Add(new RecursoCard());
            flpRecursos.Controls.Add(new RecursoCard());
            flpRecursos.Controls.Add(new RecursoCard());
            flpRecursos.Controls.Add(new RecursoCard());
            flpRecursos.Controls.Add(new RecursoCard());
            flpRecursos.Controls.Add(new RecursoCard());
            flpRecursos.Controls.Add(new RecursoCard());
            flpRecursos.Controls.Add(new RecursoCard());
        }

    }
}
