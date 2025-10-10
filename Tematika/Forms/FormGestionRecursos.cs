using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;
using Tematika.Styles;
using Tematika.Utils;

namespace Tematika.Forms
{
    public partial class FormGestionRecursos : Form
    {
        private readonly RecursoService _recursoService = new RecursoService();
        private readonly TemaService _temaService = new TemaService();
        private readonly MateriaService _materiaService = new MateriaService();
        private int? recursoSeleccionadoId = null;
        private bool mostrarActivos = true;

        public FormGestionRecursos()
        {
            InitializeComponent();
            Load += FormGestionRecursos_Load;
            DGVRecursos.CellClick += DGVRecursos_CellClick;
            BGuardarRecurso.Click += BGuardarRecurso_Click;
            BModificarRecurso.Click += BModificarRecurso_Click;
            BEliminarRecurso.Click += BEliminarRecurso_Click;
            BCancelarRecurso.Click += BCancelarRecurso_Click;
            BRecursosActivos.Click += BRecursosActivos_Click;
            BRecursosInactivos.Click += BRecursosInactivos_Click;
            CBMateriaRecurso.SelectedIndexChanged += CBMateriaRecurso_SelectedIndexChanged;
            CBFiltrarTema.SelectedIndexChanged += CBFiltrarTema_SelectedIndexChanged;
            BRuta.Click += BRuta_Click;
        }

        private void FormGestionRecursos_Load(object sender, EventArgs e)
        {
            EstiloEncabezado.Aplicar(panelEncabezadoR, LTituloRecursos);
            panelRecurso.BackColor = ColorTranslator.FromHtml("#cfd8dc");

            CBEliminado.Items.Clear();
            CBEliminado.Items.Add("No");
            CBEliminado.Items.Add("Sí");
            CBEliminado.SelectedIndex = 0;

            labelEliminado.Visible = false;
            CBEliminado.Visible = false;

            CBTipoRecurso.SelectedIndex = 0;

            CargarMateriasCombo();
            CBTemaRecurso.DataSource = null;
            CargarTemasFiltrables();
            CargarRecursos();
        }

        private void CargarMateriasCombo()
        {
            var materias = _materiaService.ListarMaterias()
                .Where(m => !m.Eliminado)
                .OrderBy(m => m.Nombre)
                .ToList();

            CBMateriaRecurso.DisplayMember = "Nombre";
            CBMateriaRecurso.ValueMember = "IdMateria";
            CBMateriaRecurso.DataSource = materias;
        }

        private void CargarTemasFiltrables()
        {
            var temas = _temaService.ListarTemas()
                .Where(t => !t.Eliminado)
                .OrderBy(t => t.Nombre)
                .ToList();

            CBFiltrarTema.DisplayMember = "Nombre";
            CBFiltrarTema.ValueMember = "IdTema";
            CBFiltrarTema.DataSource = temas;
        }

        private void CBMateriaRecurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBMateriaRecurso.SelectedValue is int idMateria)
            {
                var temas = _temaService.ListarTemas()
                    .Where(t => t.IdMateria == idMateria && !t.Eliminado)
                    .OrderBy(t => t.Nombre)
                    .ToList();

                CBTemaRecurso.DisplayMember = "Nombre";
                CBTemaRecurso.ValueMember = "IdTema";
                CBTemaRecurso.DataSource = temas;
            }
        }

        private void CBFiltrarTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFiltrarTema.SelectedValue is int idTema)
            {
                var recursos = _recursoService.ListarRecursos()
                    .Where(r => r.IdTema == idTema && r.Eliminado != mostrarActivos)
                    .ToList();

                DGVRecursos.Rows.Clear();

                foreach (var r in recursos)
                {
                    var tema = _temaService.ObtenerTema(r.IdTema);
                    DGVRecursos.Rows.Add(r.IdRecurso, r.Titulo, r.Texto, r.Ruta, r.Url, r.Tipo, tema?.Nombre ?? "Sin tema");
                }
            }
        }

        private void CargarRecursos()
        {
            var recursos = _recursoService.ListarRecursos()
                .Where(r => r.Eliminado != mostrarActivos)
                .ToList();

            DGVRecursos.Rows.Clear();

            foreach (var r in recursos)
            {
                var tema = _temaService.ObtenerTema(r.IdTema);
                DGVRecursos.Rows.Add(r.IdRecurso, r.Titulo, r.Texto, r.Ruta, r.Url, r.Tipo, tema?.Nombre ?? "Sin tema");
            }

            BGuardarRecurso.Visible = true;
            BModificarRecurso.Visible = false;
            BEliminarRecurso.Visible = false;
            labelEliminado.Visible = false;
            CBEliminado.Visible = false;
        }

        private void LimpiarCampos()
        {
            TBTituloRecurso.Clear();
            TBTexto.Clear();
            TBRuta.Clear();
            TBUrl.Clear();
            CBTipoRecurso.SelectedIndex = 0;
            CBMateriaRecurso.SelectedIndex = 0;
            CBTemaRecurso.DataSource = null;
            CBEliminado.SelectedIndex = 0;
            recursoSeleccionadoId = null;

            BGuardarRecurso.Visible = true;
            BModificarRecurso.Visible = false;
            BEliminarRecurso.Visible = false;
            labelEliminado.Visible = false;
            CBEliminado.Visible = false;
        }

        private void BGuardarRecurso_Click(object sender, EventArgs e)
        {
            var controlesObligatorios = new List<Control> { TBTituloRecurso, CBTipoRecurso, CBTemaRecurso };

            if (!Validaciones.ValidarControlesObligatorios(controlesObligatorios))
                return;

            var recurso = new Recurso
            {
                Titulo = TBTituloRecurso.Text,
                Tipo = CBTipoRecurso.SelectedItem?.ToString() ?? "",
                IdTema = (int)CBTemaRecurso.SelectedValue,
                Texto = string.IsNullOrWhiteSpace(TBTexto.Text) ? null : TBTexto.Text,
                Ruta = string.IsNullOrWhiteSpace(TBRuta.Text) ? null : TBRuta.Text,
                Url = string.IsNullOrWhiteSpace(TBUrl.Text) ? null : TBUrl.Text,
                Eliminado = CBEliminado.SelectedItem?.ToString() == "Sí"
            };

            var error = _recursoService.CrearRecurso(recurso);
            if (error != null)
            {
                MessageBox.Show(error, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Recurso guardado correctamente.");
            CargarRecursos();
            LimpiarCampos();
        }

        private void DGVRecursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = DGVRecursos.Rows[e.RowIndex];
            recursoSeleccionadoId = Convert.ToInt32(fila.Cells["IdRecurso"].Value);

            var recurso = _recursoService.ObtenerRecurso(recursoSeleccionadoId.Value);
            if (recurso == null) return;

            TBTituloRecurso.Text = recurso.Titulo;
            TBTexto.Text = recurso.Texto;
            TBRuta.Text = recurso.Ruta;
            TBUrl.Text = recurso.Url;
            CBTipoRecurso.SelectedItem = recurso.Tipo;

            var tema = _temaService.ObtenerTema(recurso.IdTema);
            if (tema != null)
            {
                CBMateriaRecurso.SelectedValue = tema.IdMateria;

                var temas = _temaService.ListarTemas()
                    .Where(t => t.IdMateria == tema.IdMateria && !t.Eliminado)
                    .OrderBy(t => t.Nombre)
                    .ToList();

                CBTemaRecurso.DisplayMember = "Nombre";
                CBTemaRecurso.ValueMember = "IdTema";
                CBTemaRecurso.DataSource = temas;
                CBTemaRecurso.SelectedValue = recurso.IdTema;
            }

            CBEliminado.SelectedItem = recurso.Eliminado ? "Sí" : "No";

            BGuardarRecurso.Visible = false;
            BModificarRecurso.Visible = true;
            BEliminarRecurso.Visible = true;
            labelEliminado.Visible = true;
            CBEliminado.Visible = true;
        }

        private void BModificarRecurso_Click(object sender, EventArgs e)
        {
            if (recursoSeleccionadoId == null) return;

            var controlesObligatorios = new List<Control> { TBTituloRecurso, CBTipoRecurso, CBTemaRecurso };

            if (!Validaciones.ValidarControlesObligatorios(controlesObligatorios))
                return;

            var recurso = new Recurso
            {
                IdRecurso = recursoSeleccionadoId.Value,
                Titulo = TBTituloRecurso.Text,
                Tipo = CBTipoRecurso.SelectedItem?.ToString() ?? "",
                IdTema = (int)CBTemaRecurso.SelectedValue,
                Texto = string.IsNullOrWhiteSpace(TBTexto.Text) ? null : TBTexto.Text,
                Ruta = string.IsNullOrWhiteSpace(TBRuta.Text) ? null : TBRuta.Text,
                Url = string.IsNullOrWhiteSpace(TBUrl.Text) ? null : TBUrl.Text,
                Eliminado = CBEliminado.SelectedItem?.ToString() == "Sí"
            };

            var error = _recursoService.ActualizarRecurso(recurso);
            if (error != null)
            {
                MessageBox.Show(error, "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Recurso modificado correctamente.");
            CargarRecursos();
            LimpiarCampos();
        }

        private void BEliminarRecurso_Click(object sender, EventArgs e)
        {
            if (recursoSeleccionadoId == null)
            {
                MessageBox.Show("Debe seleccionar un recurso para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este recurso?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                _recursoService.EliminarRecurso(recursoSeleccionadoId.Value);
                MessageBox.Show("Recurso eliminado correctamente.");
                CargarRecursos();
                LimpiarCampos();
            }
        }

        private void BCancelarRecurso_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BRecursosActivos_Click(object sender, EventArgs e)
        {
            mostrarActivos = true;
            CargarRecursos();
        }

        private void BRecursosInactivos_Click(object sender, EventArgs e)
        {
            mostrarActivos = false;
            CargarRecursos();
        }

        private void BRuta_Click(object sender, EventArgs e)
        {
            using var dialogo = new OpenFileDialog();
            dialogo.Filter = "Archivos permitidos|*.pdf;*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.txt";
            dialogo.Title = "Seleccionar archivo de recurso";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                TBRuta.Text = dialogo.FileName;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento para CBMateriaRecurso en el diseñador, no utilizado directamente
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento para LMateriaRecurso en el diseñador, no utilizado directamente
        }
    }
}
