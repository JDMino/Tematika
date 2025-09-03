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
    public partial class Gestion_de_Materias : Form
    {
        public Gestion_de_Materias()
        {
            InitializeComponent();
        }

        private void DGVMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Ocultar botón de nueva materia
                BGuardarMateria.Visible = false;

                // Mostrar botones de edición
                BModificarMateria.Visible = true;
                BEliminarMateria.Visible = true;
                //btnCancelarMateria.Visible = true;

                // Cargar datos en los campos
                DataGridViewRow fila = DGVMaterias.Rows[e.RowIndex];
                TBNombreMateria.Text = fila.Cells["NombreMateria"].Value?.ToString();
                TBNivelMateria.Text = fila.Cells["NivelMateria"].Value?.ToString();
                TBDescripcionMateria.Text = fila.Cells["DescripcionMateria"].Value?.ToString();
            }

        }

        private void DGVMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gestion_de_Materias_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
