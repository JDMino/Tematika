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
    public partial class Gestion_de_Usuarios : Form
    {


        /*  private void label2_Click(object sender, EventArgs e)
          {

          }*/

        private void DGVUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Validación básica para evitar errores si se hace clic en el encabezado
            if (e.RowIndex >= 0)
            {
                // Ocultar botón Guardar
                BGuardarUsuario.Visible = false;

                // Mostrar botones Modificar y Eliminar
                BUModificar.Visible = true;
                BUEliminar.Visible = true;

                // Cancelar permanece visible
                BCancelar.Visible = true;

                // Opcional: podés cargar los datos de la fila seleccionada en los campos
                DataGridViewRow fila = DGVUsuarios.Rows[e.RowIndex];
                TBNombreUsuario.Text = fila.Cells["Nombre"].Value?.ToString();
                TBEmailUsuario.Text = fila.Cells["Email"].Value?.ToString();
                // etc.
            }
        }
    }
}
