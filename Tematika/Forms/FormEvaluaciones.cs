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
    public partial class FormEvaluaciones : Form
    {
        public FormEvaluaciones()
        {
            InitializeComponent();
        }


        private void DGVPreguntas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVPreguntas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Ocultar botón de guardar
                BGuardarPreg.Visible = false;

                // Mostrar botones de edición
                BModificarPreg.Visible = true;
                BEliminarPreg.Visible = true;
                BCancelar.Visible = true;

                // Cargar datos en los campos
                DataGridViewRow fila = DGVPreguntas.Rows[e.RowIndex];
                LEnunciado.Text = fila.Cells["Enunciado"].Value?.ToString();
                CBTemas.SelectedItem = fila.Cells["Tema"].Value?.ToString();
                CBMateria.SelectedItem = fila.Cells["Materia"].Value?.ToString();
                //cmbTipoPregunta.SelectedItem = fila.Cells["Tipo"].Value?.ToString();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

