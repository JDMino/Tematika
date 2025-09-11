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
using Tematika.Utils;

namespace Tematika.Forms
{
    public partial class FormGestionTematica : Form
    {
        public FormGestionTematica()
        {
            InitializeComponent();
        }

        private void FormGestionTematica_Load(object sender, EventArgs e)
        {
            TBTemas.BackColor = ColorTranslator.FromHtml("#cfd8dc");
            TBRecursos.BackColor = ColorTranslator.FromHtml("#cfd8dc");
            TBPreguntas.BackColor = ColorTranslator.FromHtml("#cfd8dc");
            TBMaterias.BackColor = ColorTranslator.FromHtml("#cfd8dc");
            EstiloEncabezado.Aplicar(panelEncabezadoT, LTituloTemas);
            EstiloEncabezado.Aplicar(panelEncabezadoR, LTituloRecursos);
            EstiloEncabezado.Aplicar(panelEncabezadoP, LTituloPreguntas);
            EstiloEncabezado.Aplicar(panelEncabezadoM, LTituloMaterias);

        }

        private void DGVTemas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Ocultar botón Guardar
                BGuardarTema.Visible = false;

                // Mostrar botones Modificar y Eliminar
                BModificarTema.Visible = true;
                BEliminarTema.Visible = true;

                // Cancelar permanece visible
                BCancelarTema.Visible = true;
            }
        }

        private void DGVRecursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Ocultar botón Guardar
                BGuardarRecurso.Visible = false;

                // Mostrar botones Modificar y Eliminar
                BModificarRecurso.Visible = true;
                BEliminarRecurso.Visible = true;

                // Cancelar permanece visible
                BCancelarRecurso.Visible = true;
            }

        }

        private void DGVPreguntas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Ocultar botón Guardar
                BGuardarPreg.Visible = false;

                // Mostrar botones Modificar y Eliminar
                BModificarPreg.Visible = true;
                BEliminarPreg.Visible = true;

                // Cancelar permanece visible
                BCancelarPreg.Visible = true;
            }
        }

        private void DGVMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Ocultar botón Guardar
                BGuardarMateria.Visible = false;

                // Mostrar botones Modificar y Eliminar
                BModificarMateria.Visible = true;
                BEliminarMateria.Visible = true;

                // Cancelar permanece visible
                BCancelarMateria.Visible = true;
            }
        }

        //Gestion de Temas
        private void TBNombreTema_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        private void TBDescripcionTema_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        private void BGuardarTema_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposObligatorios(panelCamposTemas))
                return;
        }

        //Gestion de Recursos
        private void TBTituloRecurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        private void TBDescripcionRecurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        private void BGuardarRecurso_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposObligatorios(panelCamposRecursos))
                return;
        }

        //Gestion de Materias
        private void TBNombreMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        private void TBDescripcionMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        private void BGuardarMateria_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposObligatorios(panelCamposMaterias))
                return;
        }
    }
}
