using System;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;

namespace Tematika.Forms
{
    // Formulario para que el estudiante gestione sus notas
    public partial class FormNotesEstudiante : Form
    {
        // Servicios para manejar la lógica de negocio
        private readonly MateriaService materiaService = new MateriaService();
        private readonly TemaService temaService = new TemaService();
        private readonly RecursoService recursoService = new RecursoService();
        private readonly NotaService notaService = new NotaService();

        // Usuario actualmente logueado
        private readonly Usuario? usuario = SesionManager.UsuarioActual;

        public FormNotesEstudiante()
        {
            InitializeComponent();

            // Eventos principales del formulario
            Load += FormNotesEstudiante_Load; // Al cargar el formulario
            cmbAsignaturasMisNotas.SelectedIndexChanged += cmbAsignaturasMisNotas_SelectedIndexChanged;
            cmbTemasMisNotas.SelectedIndexChanged += cmbTemasMisNotas_SelectedIndexChanged;
            btnGuardarMisNotas.Click += btnGuardarMisNotas_Click;
            DGVMisNotas.CellContentClick += DGVMisNotas_CellContentClick;
        }

        // Evento al cargar el formulario
        private void FormNotesEstudiante_Load(object sender, EventArgs e)
        {
            if (usuario == null)
            {
                MessageBox.Show("No hay sesión activa."); // Verifica si hay usuario logueado
                return;
            }

            // Cargar las materias disponibles y no eliminadas
            var materias = materiaService.ListarMaterias()
                .Where(m => !m.Eliminado)
                .OrderBy(m => m.Nombre)
                .ToList();

            // Configura el combo de asignaturas
            cmbAsignaturasMisNotas.DataSource = materias;
            cmbAsignaturasMisNotas.DisplayMember = "Nombre";
            cmbAsignaturasMisNotas.ValueMember = "IdMateria";
            cmbAsignaturasMisNotas.SelectedIndex = -1; // Inicializa sin seleccionar

            // Inicializa combos de temas y recursos vacíos
            cmbTemasMisNotas.DataSource = null;
            cmbRecursosMisNotas.DataSource = null;

            // Carga las notas existentes del usuario
            CargarNotas();
        }

        // Evento al cambiar la asignatura seleccionada
        private void cmbAsignaturasMisNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAsignaturasMisNotas.SelectedItem is Materia materia)
            {
                // Filtra los temas de la asignatura seleccionada
                var temas = temaService.ListarTemas()
                    .Where(t => t.IdMateria == materia.IdMateria && !t.Eliminado)
                    .OrderBy(t => t.Nombre)
                    .ToList();

                cmbTemasMisNotas.DataSource = temas;
                cmbTemasMisNotas.DisplayMember = "Nombre";
                cmbTemasMisNotas.ValueMember = "IdTema";
                cmbTemasMisNotas.SelectedIndex = -1; // Inicializa sin seleccionar

                // Reinicia el combo de recursos
                cmbRecursosMisNotas.DataSource = null;
            }
        }

        // Evento al cambiar el tema seleccionado
        private void cmbTemasMisNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTemasMisNotas.SelectedItem is Tema tema)
            {
                // Filtra los recursos del tema seleccionado
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

        // Evento al hacer clic en "Guardar nota"
        private void btnGuardarMisNotas_Click(object sender, EventArgs e)
        {
            if (usuario == null) return;

            // Verifica que haya un recurso seleccionado
            if (cmbRecursosMisNotas.SelectedItem is not Recurso recurso)
            {
                MessageBox.Show("Debe seleccionar un recurso.");
                return;
            }

            // Verifica que haya contenido en la nota
            if (string.IsNullOrWhiteSpace(TBContenidoMisNotas.Text))
            {
                MessageBox.Show("Debe ingresar contenido para la nota.");
                return;
            }

            // Confirmación del usuario
            var confirmacion = MessageBox.Show(
                "¿Desea guardar esta nota?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion != DialogResult.Yes) return;

            // Crear objeto Nota
            var nota = new Nota
            {
                IdUsuario = usuario.IdUsuario,
                IdRecurso = recurso.IdRecurso,
                Texto = TBContenidoMisNotas.Text.Trim(),
                Fecha = DateTime.Now
            };

            // Guardar nota usando el servicio
            var error = notaService.CrearNota(nota);
            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mensaje de éxito y limpieza de campos
            MessageBox.Show("Nota guardada correctamente.");
            TBContenidoMisNotas.Clear();
            CargarNotas(); // Actualiza la lista de notas
        }

        // Carga las notas del usuario en el DataGridView
        private void CargarNotas()
        {
            var notas = notaService.ListarPorUsuario(usuario!.IdUsuario);
            var recursos = recursoService.ListarRecursos();

            DGVMisNotas.Rows.Clear(); // Limpia el grid antes de cargar

            foreach (var nota in notas)
            {
                // Busca el recurso asociado a la nota
                var recurso = recursos.FirstOrDefault(r => r.IdRecurso == nota.IdRecurso);
                if (recurso == null) continue;

                // Agrega fila al DataGridView
                int rowIndex = DGVMisNotas.Rows.Add(
                    recurso.Titulo,
                    nota.Texto,
                    "Ver",      // Columna para ver el recurso
                    "Eliminar"  // Columna para eliminar la nota
                );

                // Almacena los datos completos en la fila
                DGVMisNotas.Rows[rowIndex].Tag = (nota, recurso);
            }
        }

        // Evento al hacer clic en una celda del DataGridView
        private void DGVMisNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var fila = DGVMisNotas.Rows[e.RowIndex];
            if (fila.Tag is not ValueTuple<Nota, Recurso> data) return;

            var (nota, recurso) = data;
            var columna = DGVMisNotas.Columns[e.ColumnIndex].Name;

            // Si clic en "Ver", abre visualizador de recurso
            if (columna == "Acciones")
            {
                var visualizador = new FormVisualizadorRecurso(recurso);
                visualizador.Show();
            }
            // Si clic en "Eliminar", confirma y elimina la nota
            else if (columna == "EliminarNota")
            {
                var confirmacion = MessageBox.Show(
                    "¿Desea eliminar esta nota?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );
                if (confirmacion == DialogResult.Yes)
                {
                    notaService.EliminarNota(nota.IdNota);
                    MessageBox.Show("Nota eliminada correctamente.");
                    CargarNotas(); // Actualiza el DataGridView
                }
            }
        }
    }
}
