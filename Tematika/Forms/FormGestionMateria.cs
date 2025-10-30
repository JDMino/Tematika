using System;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;
using Tematika.Styles;
using Tematika.Utils;

namespace Tematika.Forms
{
    public partial class FormGestionMateria : Form
    {
        private readonly MateriaService _materiaService = new MateriaService();
        private int? materiaSeleccionadaId = null;
        private bool mostrarActivas = true;

        public FormGestionMateria()
        {
            InitializeComponent();
            Load += FormGestionMateria_Load;
            DGVMaterias.CellClick += DGVMaterias_CellClick;
            BGuardarMateria.Click += BGuardarMateria_Click;
            BModificarMateria.Click += BModificarMateria_Click;
            BEliminarMateria.Click += BEliminarMateria_Click;
            BCancelarMateria.Click += BCancelarMateria_Click;
            BMateriasActivas.Click += BMateriasActivas_Click;
            BMateriasInactivas.Click += BMateriasInactivas_Click;
            TBBuscadorMaterias.TextChanged += (s, e) =>
            {
                GridUtils.FiltrarFilasPorTexto(DGVMaterias, TBBuscadorMaterias.Text);
            };
            TBNombreMateria.KeyPress += (s, e) => Validaciones.ValidarSoloLetras(e);
            TBDescripcionMateria.KeyPress += (s, e) => Validaciones.ValidarSoloLetras(e);

        }

        private void FormGestionMateria_Load(object sender, EventArgs e)
        {
            EstiloEncabezado.Aplicar(panelEncabezadoM, LTituloMaterias);
            panelMateria.BackColor = ColorTranslator.FromHtml("#cfd8dc");
            CBNivelMateria.SelectedIndex = 0;

            comboBoxEliminado.Items.Clear();
            comboBoxEliminado.Items.Add("No");
            comboBoxEliminado.Items.Add("Sí");
            comboBoxEliminado.SelectedIndex = 0;

            labelEliminado.Visible = false;
            comboBoxEliminado.Visible = false;

            CargarMaterias();
        }

        private void CargarMaterias()
        {
            var materias = _materiaService.ListarMaterias()
                .Where(m => m.Eliminado != mostrarActivas)
                .ToList();

            DGVMaterias.Rows.Clear();

            foreach (var m in materias)
            {
                DGVMaterias.Rows.Add(m.IdMateria, m.Nombre, m.Nivel, m.Descripcion);
            }

            BGuardarMateria.Visible = true;
            BModificarMateria.Visible = false;
            BEliminarMateria.Visible = false;
            labelEliminado.Visible = false;
            comboBoxEliminado.Visible = false;
        }


        private void LimpiarCampos()
        {
            TBNombreMateria.Clear();
            TBDescripcionMateria.Clear();
            CBNivelMateria.SelectedIndex = 0;
            comboBoxEliminado.SelectedIndex = 0;
            materiaSeleccionadaId = null;

            BGuardarMateria.Visible = true;
            BModificarMateria.Visible = false;
            BEliminarMateria.Visible = false;
            labelEliminado.Visible = false;
            comboBoxEliminado.Visible = false;
        }

        private void BGuardarMateria_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposObligatorios(panelCamposMaterias))
                return;

            var materia = new Materia
            {
                Nombre = TBNombreMateria.Text,
                Nivel = CBNivelMateria.SelectedItem?.ToString(),
                Descripcion = TBDescripcionMateria.Text,
                Eliminado = comboBoxEliminado.SelectedItem?.ToString() == "Sí"
            };

            var error = _materiaService.CrearMateria(materia);
            if (error != null)
            {
                MessageBox.Show(error, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Materia guardada correctamente.");
            CargarMaterias();
            LimpiarCampos();
        }

        private void DGVMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = DGVMaterias.Rows[e.RowIndex];
            if (!DGVMaterias.Columns.Contains("idMateria") || fila.Cells["idMateria"].Value == null)
            {
                MessageBox.Show("La columna 'idMateria' no está disponible.");
                return;
            }

            materiaSeleccionadaId = Convert.ToInt32(fila.Cells["idMateria"].Value);
            var materia = _materiaService.ObtenerMateria(materiaSeleccionadaId.Value);
            if (materia == null) return;

            TBNombreMateria.Text = materia.Nombre;
            CBNivelMateria.SelectedItem = materia.Nivel;
            TBDescripcionMateria.Text = materia.Descripcion;
            comboBoxEliminado.SelectedItem = materia.Eliminado ? "Sí" : "No";

            BGuardarMateria.Visible = false;
            BModificarMateria.Visible = true;
            BEliminarMateria.Visible = true;
            labelEliminado.Visible = true;
            comboBoxEliminado.Visible = true;
        }

        private void BModificarMateria_Click(object sender, EventArgs e)
        {
            if (materiaSeleccionadaId == null) return;

            var materia = new Materia
            {
                IdMateria = materiaSeleccionadaId.Value,
                Nombre = TBNombreMateria.Text,
                Nivel = CBNivelMateria.SelectedItem?.ToString(),
                Descripcion = TBDescripcionMateria.Text,
                Eliminado = comboBoxEliminado.SelectedItem?.ToString() == "Sí"
            };

            var error = _materiaService.ActualizarMateria(materia);
            if (error != null)
            {
                MessageBox.Show(error, "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Materia modificada correctamente.");
            CargarMaterias();
            LimpiarCampos();
        }

        private void BEliminarMateria_Click(object sender, EventArgs e)
        {
            if (materiaSeleccionadaId == null)
            {
                MessageBox.Show("Debe seleccionar una materia para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar esta materia?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (confirmacion == DialogResult.Yes)
            {
                _materiaService.EliminarMateria(materiaSeleccionadaId.Value);
                MessageBox.Show("Materia eliminada correctamente.");
                CargarMaterias();
                LimpiarCampos();
            }
        }

        private void BCancelarMateria_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BMateriasActivas_Click(object sender, EventArgs e)
        {
            mostrarActivas = true;
            CargarMaterias();
        }

        private void BMateriasInactivas_Click(object sender, EventArgs e)
        {
            mostrarActivas = false;
            CargarMaterias();
        }
    }
}
