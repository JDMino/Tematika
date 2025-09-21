using System;
using System.Drawing;
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
            this.Load += FormGestionTematica_Load;
        }

        private void FormGestionTematica_Load(object sender, EventArgs e)
        {
            // Colores de fondo por tab
            TBTemas.BackColor = ColorTranslator.FromHtml("#cfd8dc");
            TBRecursos.BackColor = ColorTranslator.FromHtml("#cfd8dc");
            TBPreguntas.BackColor = ColorTranslator.FromHtml("#cfd8dc");
            TBMaterias.BackColor = ColorTranslator.FromHtml("#cfd8dc");

            // Encabezados estilizados
            EstiloEncabezado.Aplicar(panelEncabezadoT, LTituloTemas);
            EstiloEncabezado.Aplicar(panelEncabezadoR, LTituloRecursos);
            EstiloEncabezado.Aplicar(panelEncabezadoP, LTituloPreguntas);
            EstiloEncabezado.Aplicar(panelEncabezadoM, LTituloMaterias);

            // Restricción por perfil docente
            var usuario = SesionManager.UsuarioActual;
            if (usuario != null && usuario.IdPerfil == 2)
            {
                TCGestionTematica.TabPages.Remove(TBMaterias); // Oculta el tab de materias
            }
        }

        // Eventos de selección en DataGridView
        private void DGVTemas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BGuardarTema.Visible = false;
                BModificarTema.Visible = true;
                BEliminarTema.Visible = true;
                BCancelarTema.Visible = true;
            }
        }

        private void DGVRecursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BGuardarRecurso.Visible = false;
                BModificarRecurso.Visible = true;
                BEliminarRecurso.Visible = true;
                BCancelarRecurso.Visible = true;
            }
        }

        private void DGVPreguntas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BGuardarPreg.Visible = false;
                BModificarPreg.Visible = true;
                BEliminarPreg.Visible = true;
                BCancelarPreg.Visible = true;
            }
        }

        private void DGVMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BGuardarMateria.Visible = false;
                BModificarMateria.Visible = true;
                BEliminarMateria.Visible = true;
                BCancelarMateria.Visible = true;
            }
        }

        // Validaciones de ingreso por teclado
        private void TBNombreTema_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        private void TBDescripcionTema_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        private void TBTituloRecurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        private void TBDescripcionRecurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        private void TBNombreMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        private void TBDescripcionMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        // Validaciones de campos obligatorios
        private void BGuardarTema_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposObligatorios(panelCamposTemas))
                return;
        }

        private void BGuardarRecurso_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposObligatorios(panelCamposRecursos))
                return;
        }

        private void BGuardarMateria_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposObligatorios(panelCamposMaterias))
                return;
        }
    }
}
