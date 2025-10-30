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
        // Servicio que maneja las operaciones relacionadas con Materias
        private readonly MateriaService _materiaService = new MateriaService();
        // Almacena la ID de la materia actualmente seleccionada en la grilla
        private int? materiaSeleccionadaId = null;
        // Indica si se deben mostrar materias activas o inactivas
        private bool mostrarActivas = true;

        public FormGestionMateria()
        {
            InitializeComponent();

            // Vincular eventos del formulario con sus respectivos métodos
            Load += FormGestionMateria_Load;
            DGVMaterias.CellClick += DGVMaterias_CellClick;
            BGuardarMateria.Click += BGuardarMateria_Click;
            BModificarMateria.Click += BModificarMateria_Click;
            BEliminarMateria.Click += BEliminarMateria_Click;
            BCancelarMateria.Click += BCancelarMateria_Click;
            BMateriasActivas.Click += BMateriasActivas_Click;
            BMateriasInactivas.Click += BMateriasInactivas_Click;

            // Filtro de búsqueda en tiempo real para el DataGridView
            TBBuscadorMaterias.TextChanged += (s, e) =>
            {
                GridUtils.FiltrarFilasPorTexto(DGVMaterias, TBBuscadorMaterias.Text);
            };

            // Validación de solo letras para los campos de texto
            TBNombreMateria.KeyPress += (s, e) => Validaciones.ValidarSoloLetras(e);
            TBDescripcionMateria.KeyPress += (s, e) => Validaciones.ValidarSoloLetras(e);
        }

        private void FormGestionMateria_Load(object sender, EventArgs e)
        {
            // Aplicar estilo al encabezado del formulario
            EstiloEncabezado.Aplicar(panelEncabezadoM, LTituloMaterias);

            // Configurar color del panel principal
            panelMateria.BackColor = ColorTranslator.FromHtml("#cfd8dc");

            // Inicializar comboBox de niveles de materia
            CBNivelMateria.SelectedIndex = 0;

            // Configurar opciones de eliminado (Sí/No)
            comboBoxEliminado.Items.Clear();
            comboBoxEliminado.Items.Add("No");
            comboBoxEliminado.Items.Add("Sí");
            comboBoxEliminado.SelectedIndex = 0;

            // Ocultar elementos relacionados con eliminado hasta que se seleccione una materia
            labelEliminado.Visible = false;
            comboBoxEliminado.Visible = false;

            // Cargar materias en la grilla
            CargarMaterias();
        }

        // Cargar las materias en el DataGridView según su estado (activo/inactivo)
        private void CargarMaterias()
        {
            var materias = _materiaService.ListarMaterias()
                .Where(m => m.Eliminado != mostrarActivas) // Filtrar según el estado actual
                .ToList();

            DGVMaterias.Rows.Clear();

            // Agregar cada materia a la grilla
            foreach (var m in materias)
            {
                DGVMaterias.Rows.Add(m.IdMateria, m.Nombre, m.Nivel, m.Descripcion);
            }

            // Configurar visibilidad de botones según el estado inicial
            BGuardarMateria.Visible = true;
            BModificarMateria.Visible = false;
            BEliminarMateria.Visible = false;
            labelEliminado.Visible = false;
            comboBoxEliminado.Visible = false;
        }

        // Limpiar los campos del formulario y restablecer botones
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

        // Evento para guardar una nueva materia
        private void BGuardarMateria_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (!Validaciones.ValidarCamposObligatorios(panelCamposMaterias))
                return;

            // Crear objeto Materia con los datos del formulario
            var materia = new Materia
            {
                Nombre = TBNombreMateria.Text,
                Nivel = CBNivelMateria.SelectedItem?.ToString(),
                Descripcion = TBDescripcionMateria.Text,
                Eliminado = comboBoxEliminado.SelectedItem?.ToString() == "Sí"
            };

            // Guardar la materia usando el servicio
            var error = _materiaService.CrearMateria(materia);
            if (error != null)
            {
                MessageBox.Show(error, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Materia guardada correctamente.");

            // Recargar grilla y limpiar campos
            CargarMaterias();
            LimpiarCampos();
        }

        // Evento que se dispara al hacer clic en una fila del DataGridView
        private void DGVMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignorar clics fuera de filas válidas

            var fila = DGVMaterias.Rows[e.RowIndex];

            // Validar que la columna 'idMateria' exista y tenga valor
            if (!DGVMaterias.Columns.Contains("idMateria") || fila.Cells["idMateria"].Value == null)
            {
                MessageBox.Show("La columna 'idMateria' no está disponible.");
                return;
            }

            // Guardar la ID de la materia seleccionada
            materiaSeleccionadaId = Convert.ToInt32(fila.Cells["idMateria"].Value);

            // Obtener la materia del servicio
            var materia = _materiaService.ObtenerMateria(materiaSeleccionadaId.Value);
            if (materia == null) return;

            // Rellenar campos del formulario con los datos de la materia seleccionada
            TBNombreMateria.Text = materia.Nombre;
            CBNivelMateria.SelectedItem = materia.Nivel;
            TBDescripcionMateria.Text = materia.Descripcion;
            comboBoxEliminado.SelectedItem = materia.Eliminado ? "Sí" : "No";

            // Ajustar visibilidad de botones para edición
            BGuardarMateria.Visible = false;
            BModificarMateria.Visible = true;
            BEliminarMateria.Visible = true;
            labelEliminado.Visible = true;
            comboBoxEliminado.Visible = true;

            if (materia.Eliminado)
            {
                BEliminarMateria.Visible = false;
            }
        }

        // Modificar la materia seleccionada
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

        // Eliminar la materia seleccionada
        private void BEliminarMateria_Click(object sender, EventArgs e)
        {
            if (materiaSeleccionadaId == null)
            {
                MessageBox.Show("Debe seleccionar una materia para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar esta materia?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (confirmacion == DialogResult.Yes)
            {
                _materiaService.EliminarMateria(materiaSeleccionadaId.Value);
                MessageBox.Show("Materia eliminada correctamente.");
                CargarMaterias();
                LimpiarCampos();
            }
        }

        // Cancelar la edición y limpiar campos
        private void BCancelarMateria_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Mostrar solo materias activas
        private void BMateriasActivas_Click(object sender, EventArgs e)
        {
            mostrarActivas = true;
            CargarMaterias();
        }

        // Mostrar solo materias inactivas
        private void BMateriasInactivas_Click(object sender, EventArgs e)
        {
            mostrarActivas = false;
            CargarMaterias();
        }
    }
}
