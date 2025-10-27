using System;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;
using Tematika.Styles;
using Tematika.Utils;

namespace Tematika.Forms
{
    public partial class FormGestionTemas : Form
    {
        private readonly TemaService _temaService = new TemaService();
        private readonly MateriaService _materiaService = new MateriaService();
        private readonly DocenteMateriaService _docenteMateriaService = new DocenteMateriaService();
        private int? temaSeleccionadoId = null;
        private bool mostrarActivos = true;

        public FormGestionTemas()
        {
            InitializeComponent();
            Load += FormGestionTemas_Load;
            DGVTemas.CellClick += DGVTemas_CellClick;
            BGuardarTema.Click += BGuardarTema_Click;
            BModificarTema.Click += BModificarTema_Click;
            BEliminarTema.Click += BEliminarTema_Click;
            BCancelarTema.Click += BCancelarTema_Click;
            BTemasActivos.Click += BTemasActivos_Click;
            BTemasInactivos.Click += BTemasInactivos_Click;
            CBFiltroMaterias.SelectedIndexChanged += CBFiltroMaterias_SelectedIndexChanged;
            TBBuscadorTema.TextChanged += (s, e) =>
            {
                GridUtils.FiltrarFilasPorTexto(DGVTemas, TBBuscadorTema.Text);
            };

        }

        private void FormGestionTemas_Load(object sender, EventArgs e)
        {
            EstiloEncabezado.Aplicar(panelEncabezadoT, LTituloTemas);
            panelTema.BackColor = ColorTranslator.FromHtml("#cfd8dc");

            CBEliminado.Items.Clear();
            CBEliminado.Items.Add("No");
            CBEliminado.Items.Add("Sí");
            CBEliminado.SelectedIndex = 0;

            labelEliminado.Visible = false;
            CBEliminado.Visible = false;

            CargarMateriasCombo();
            CargarTemas();
        }

        private void CargarMateriasCombo()
        {
            var todasMaterias = _materiaService.ListarMaterias()
                .Where(m => !m.Eliminado)
                .OrderBy(m => m.Nombre)
                .ToList();

            if (SesionManager.SesionActiva && SesionManager.UsuarioActual!.IdPerfil == 2)
            {
                var asignaciones = _docenteMateriaService.ListarAsignaciones()
                    .Where(dm => dm.IdUsuario == SesionManager.UsuarioActual.IdUsuario)
                    .Select(dm => dm.IdMateria)
                    .Distinct()
                    .ToList();

                todasMaterias = todasMaterias
                    .Where(m => asignaciones.Contains(m.IdMateria))
                    .ToList();

                CBMaterias.Enabled = todasMaterias.Count > 1;
                CBFiltroMaterias.Enabled = todasMaterias.Count > 1;
            }

            CBMaterias.DisplayMember = "Nombre";
            CBMaterias.ValueMember = "IdMateria";
            CBMaterias.DataSource = todasMaterias;

            CBFiltroMaterias.DisplayMember = "Nombre";
            CBFiltroMaterias.ValueMember = "IdMateria";
            CBFiltroMaterias.DataSource = todasMaterias.ToList();
        }

        private void CargarTemas()
        {
            var temas = _temaService.ListarTemas()
                .Where(t => t.Eliminado != mostrarActivos)
                .ToList();

            if (SesionManager.SesionActiva && SesionManager.UsuarioActual!.IdPerfil == 2)
            {
                var asignaciones = _docenteMateriaService.ListarAsignaciones()
                    .Where(dm => dm.IdUsuario == SesionManager.UsuarioActual.IdUsuario)
                    .Select(dm => dm.IdMateria)
                    .Distinct()
                    .ToList();

                temas = temas.Where(t => asignaciones.Contains(t.IdMateria)).ToList();
            }

            DGVTemas.Rows.Clear();

            foreach (var t in temas)
            {
                var materia = _materiaService.ObtenerMateria(t.IdMateria);
                DGVTemas.Rows.Add(t.IdTema, t.Nombre, materia?.Nombre ?? "Sin materia");
            }

            BGuardarTema.Visible = true;
            BModificarTema.Visible = false;
            BEliminarTema.Visible = false;
            labelEliminado.Visible = false;
            CBEliminado.Visible = false;
        }

        private void LimpiarCampos()
        {
            TBNombreTema.Clear();
            CBMaterias.SelectedIndex = 0;
            CBEliminado.SelectedIndex = 0;
            temaSeleccionadoId = null;

            BGuardarTema.Visible = true;
            BModificarTema.Visible = false;
            BEliminarTema.Visible = false;
            labelEliminado.Visible = false;
            CBEliminado.Visible = false;
        }

        private void BGuardarTema_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposObligatorios(panelCamposTemas))
                return;

            var tema = new Tema
            {
                Nombre = TBNombreTema.Text,
                IdMateria = (int)CBMaterias.SelectedValue,
                Eliminado = CBEliminado.SelectedItem?.ToString() == "Sí"
            };

            var error = _temaService.CrearTema(tema);
            if (error != null)
            {
                MessageBox.Show(error, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Tema guardado correctamente.");
            CargarTemas();
            LimpiarCampos();
        }

        private void DGVTemas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = DGVTemas.Rows[e.RowIndex];
            temaSeleccionadoId = Convert.ToInt32(fila.Cells["idTema"].Value);

            var tema = _temaService.ObtenerTema(temaSeleccionadoId.Value);
            if (tema == null) return;

            TBNombreTema.Text = tema.Nombre;
            CBMaterias.SelectedValue = tema.IdMateria;
            CBEliminado.SelectedItem = tema.Eliminado ? "Sí" : "No";

            BGuardarTema.Visible = false;
            BModificarTema.Visible = true;
            BEliminarTema.Visible = true;
            labelEliminado.Visible = true;
            CBEliminado.Visible = true;

            if (tema.Eliminado)
            {
                BEliminarTema.Visible = false;
            }
        }

        private void BModificarTema_Click(object sender, EventArgs e)
        {
            if (temaSeleccionadoId == null) return;

            var tema = new Tema
            {
                IdTema = temaSeleccionadoId.Value,
                Nombre = TBNombreTema.Text,
                IdMateria = (int)CBMaterias.SelectedValue,
                Eliminado = CBEliminado.SelectedItem?.ToString() == "Sí"
            };

            var error = _temaService.ActualizarTema(tema);
            if (error != null)
            {
                MessageBox.Show(error, "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Tema modificado correctamente.");
            CargarTemas();
            LimpiarCampos();
        }

        private void BEliminarTema_Click(object sender, EventArgs e)
        {
            if (temaSeleccionadoId == null)
            {
                MessageBox.Show("Debe seleccionar un tema para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este tema?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                _temaService.EliminarTema(temaSeleccionadoId.Value);
                MessageBox.Show("Tema eliminado correctamente.");
                CargarTemas();
                LimpiarCampos();
            }
        }

        private void BCancelarTema_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BTemasActivos_Click(object sender, EventArgs e)
        {
            mostrarActivos = true;
            CargarTemas();
        }

        private void BTemasInactivos_Click(object sender, EventArgs e)
        {
            mostrarActivos = false;
            CargarTemas();
        }

        private void CBFiltroMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFiltroMaterias.SelectedValue is int idMateria)
            {
                var temas = _temaService.ListarTemas()
                    .Where(t => t.IdMateria == idMateria && t.Eliminado != mostrarActivos)
                    .ToList();

                DGVTemas.Rows.Clear();

                foreach (var t in temas)
                {
                    var materia = _materiaService.ObtenerMateria(t.IdMateria);
                    DGVTemas.Rows.Add(t.IdTema, t.Nombre, materia?.Nombre ?? "Sin materia");
                }
            }
        }
    }
}
