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
    public partial class Gestion_de_Temas : Form
    {
        public Gestion_de_Temas()
        {
            InitializeComponent();
        }

        private void DGVTemas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            if (e.RowIndex >= 0)
            {
                // Ocultar botón de nuevo tema
                BGuardarTema.Visible = false;

                // Mostrar botones de edición
                BModificarTema.Visible = true;
                BEliminarTema.Visible = true;
                BCancelarTema.Visible = true;

                // Cargar datos en los campos
                DataGridViewRow fila = DGVTemas.Rows[e.RowIndex];
                TBNombreTema.Text = fila.Cells["Nombre del Tema"].Value?.ToString();
                TBDescripcionTema.Text = fila.Cells["Descripcion del Tema"].Value?.ToString();
                CBMaterias.SelectedItem = fila.Cells["Materia"].Value?.ToString();
            }
        }

    }
}

