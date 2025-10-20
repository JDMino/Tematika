using System;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;

namespace Tematika.Forms
{
    public partial class FormNotesEstudiante : Form
    {
        private readonly MateriaService materiaService = new MateriaService();
        private readonly TemaService temaService = new TemaService();
        private readonly RecursoService recursoService = new RecursoService();
        private readonly NotaService notaService = new NotaService();
        private readonly Usuario? usuario = SesionManager.UsuarioActual;

        public FormNotesEstudiante()
        {
            InitializeComponent();
            Load += FormNotesEstudiante_Load;
            cmbAsignaturasMisNotas.SelectedIndexChanged += cmbAsignaturasMisNotas_SelectedIndexChanged;
            cmbTemasMisNotas.SelectedIndexChanged += cmbTemasMisNotas_SelectedIndexChanged;
            btnGuardarMisNotas.Click += btnGuardarMisNotas_Click;
            DGVMisNotas.CellContentClick += DGVMisNotas_CellContentClick;
        }

        private void FormNotesEstudiante_Load(object sender, EventArgs e)
        {
            if (usuario == null)
            {
                MessageBox.Show("No hay sesión activa.");
                return;
            }

            var materias = materiaService.ListarMaterias()
                .Where(m => !m.Eliminado)
                .OrderBy(m => m.Nombre)
                .ToList();

            cmbAsignaturasMisNotas.DataSource = materias;
            cmbAsignaturasMisNotas.DisplayMember = "Nombre";
            cmbAsignaturasMisNotas.ValueMember = "IdMateria";
            cmbAsignaturasMisNotas.SelectedIndex = -1;

            cmbTemasMisNotas.DataSource = null;
            cmbRecursosMisNotas.DataSource = null;

            CargarNotas();
        }

        private void cmbAsignaturasMisNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAsignaturasMisNotas.SelectedItem is Materia materia)
            {
                var temas = temaService.ListarTemas()
                    .Where(t => t.IdMateria == materia.IdMateria && !t.Eliminado)
                    .OrderBy(t => t.Nombre)
                    .ToList();

                cmbTemasMisNotas.DataSource = temas;
                cmbTemasMisNotas.DisplayMember = "Nombre";
                cmbTemasMisNotas.ValueMember = "IdTema";
                cmbTemasMisNotas.SelectedIndex = -1;

                cmbRecursosMisNotas.DataSource = null;
            }
        }

        private void cmbTemasMisNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTemasMisNotas.SelectedItem is Tema tema)
            {
                var recursos = recursoService.ListarRecursos()
                    .Where(r => r.IdTema == tema.IdTema && !r.Eliminado)
                    .OrderBy(r => r.Titulo)
                    .ToList();

                cmbRecursosMisNotas.DataSource = recursos;
                cmbRecursosMisNotas.DisplayMember = "Titulo";
                cmbRecursosMisNotas.ValueMember = "IdRecurso";
                cmbRecursosMisNotas.SelectedIndex = -1;
            }
        }

        private void btnGuardarMisNotas_Click(object sender, EventArgs e)
        {
            if (usuario == null) return;

            if (cmbRecursosMisNotas.SelectedItem is not Recurso recurso)
            {
                MessageBox.Show("Debe seleccionar un recurso.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TBContenidoMisNotas.Text))
            {
                MessageBox.Show("Debe ingresar contenido para la nota.");
                return;
            }

            var confirmacion = MessageBox.Show("¿Desea guardar esta nota?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes) return;

            var nota = new Nota
            {
                IdUsuario = usuario.IdUsuario,
                IdRecurso = recurso.IdRecurso,
                Texto = TBContenidoMisNotas.Text.Trim(),
                Fecha = DateTime.Now
            };

            var error = notaService.CrearNota(nota);
            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Nota guardada correctamente.");
            TBContenidoMisNotas.Clear();
            CargarNotas();
        }

        private void CargarNotas()
        {
            var notas = notaService.ListarPorUsuario(usuario!.IdUsuario);
            var recursos = recursoService.ListarRecursos();

            DGVMisNotas.Rows.Clear();

            foreach (var nota in notas)
            {
                var recurso = recursos.FirstOrDefault(r => r.IdRecurso == nota.IdRecurso);
                if (recurso == null) continue;

                int rowIndex = DGVMisNotas.Rows.Add(
                    recurso.Titulo,
                    nota.Texto,
                    "Ver",
                    "Eliminar"
                );

                DGVMisNotas.Rows[rowIndex].Tag = (nota, recurso);
            }
        }

        private void DGVMisNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var fila = DGVMisNotas.Rows[e.RowIndex];
            if (fila.Tag is not ValueTuple<Nota, Recurso> data) return;

            var (nota, recurso) = data;
            var columna = DGVMisNotas.Columns[e.ColumnIndex].Name;

            if (columna == "Acciones")
            {
                var visualizador = new FormVisualizadorRecurso(recurso);
                visualizador.Show();
            }
            else if (columna == "EliminarNota")
            {
                var confirmacion = MessageBox.Show("¿Desea eliminar esta nota?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    notaService.EliminarNota(nota.IdNota);
                    MessageBox.Show("Nota eliminada correctamente.");
                    CargarNotas();
                }
            }
        }
    }
}