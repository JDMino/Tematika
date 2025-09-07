using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tematika.Styles;
namespace Tematika.Forms
{
    public partial class FormGestionUsuarios : Form
    {
        public FormGestionUsuarios()
        {
            InitializeComponent();
        }

        private void DGVUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Validación básica para evitar errores si se hace clic en el encabezado
            if (e.RowIndex >= 0)
            {
                // Ocultar botón Guardar
                BGuardar.Visible = false;

                // Mostrar botones Modificar y Eliminar
                BUModificar.Visible = true;
                BUEliminar.Visible = true;

                // Cancelar permanece visible
                BCancelar.Visible = true;

                // Opcional: podés cargar los datos de la fila seleccionada en los campos
                DataGridViewRow fila = DGVUsuarios.Rows[e.RowIndex];
                TBNombreUsuario.Text = fila.Cells["Nombre"].Value?.ToString();
                //TBEmailUsuario.Text = fila.Cells["Email"].Value?.ToString();
                // etc.
            }
        }

        private void FormGestionUsuarios_Load(object sender, EventArgs e)
        {
            EstiloEncabezado.Aplicar(panelEncabezado, LTituloUsuarios);
            panelMain.BackColor = ColorTranslator.FromHtml("#cfd8dc");
        }

        private void panelCamposUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
