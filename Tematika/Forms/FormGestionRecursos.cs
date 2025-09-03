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
    public partial class FormGestionRecursos : Form
    {
        public FormGestionRecursos()
        {
            InitializeComponent();
        }

        private void DGVRecursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0)
            {
                // Ocultar botón de guardar
                BGuardarRecurso.Visible = false;

                // Mostrar botones de edición
                BModificarRecurso.Visible = true;
                BEliminarRecurso.Visible = true;
                BCancelarRecurso.Visible = true;

                // Cargar datos en los campos
                DataGridViewRow fila = DGVRecursos.Rows[e.RowIndex];
                LNombreRecurso.Text = fila.Cells["tituloRecurso"].Value?.ToString();
                CBTipoRecurso.SelectedItem = fila.Cells["Tipo"].Value?.ToString();
                CBMateriaRecurso.SelectedItem = fila.Cells["Materia"].Value?.ToString();
                CBTemaRecurso.SelectedItem = fila.Cells["Tema"].Value?.ToString();
                LDescripcionRecurso.Text = fila.Cells["Descripción"].Value?.ToString();
                LURLRecurso.Text = fila.Cells["URL"].Value?.ToString();
            }
        }

    }
}

