using System;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;

namespace Tematika.Forms
{
    public partial class FormEvaluationsEstudiante : Form
    {
        // Servicios para acceder a datos de materias, temas, evaluaciones, preguntas e historial
        private readonly MateriaService materiaService = new MateriaService();
        private readonly TemaService temaService = new TemaService();
        private readonly EvaluacionService evaluacionService = new EvaluacionService();
        private readonly PreguntaService preguntaService = new PreguntaService();
        private readonly HistorialEvaluacionService historialService = new HistorialEvaluacionService();

        // Usuario actual en sesión
        private readonly Usuario? usuario = SesionManager.UsuarioActual;

        public FormEvaluationsEstudiante()
        {
            InitializeComponent();

            // Eventos de carga y acciones del formulario
            Load += FormEvaluationsEstudiante_Load;
            cmbMaterias.SelectedIndexChanged += cmbMaterias_SelectedIndexChanged;
            btnEmpezarEvaluacion.Click += btnEmpezarEvaluacion_Click;
            DGVHistorialEvaluaciones.CellContentClick += DGVHistorialEvaluaciones_CellContentClick;
        }

        // Se ejecuta al cargar el formulario
        private void FormEvaluationsEstudiante_Load(object sender, EventArgs e)
        {
            // Verifica que haya un usuario en sesión
            if (usuario == null)
            {
                MessageBox.Show("No hay sesión activa.");
                return;
            }

            // Carga las materias activas y las muestra en el ComboBox
            var materias = materiaService.ListarMaterias()
                .Where(m => !m.Eliminado)
                .OrderBy(m => m.Nombre)
                .ToList();

            cmbMaterias.DataSource = materias;
            cmbMaterias.DisplayMember = "Nombre";
            cmbMaterias.ValueMember = "IdMateria";
            cmbMaterias.SelectedIndex = -1;

            // Limpia el ComboBox de temas hasta que se seleccione una materia
            cmbTemas.DataSource = null;

            // Carga el historial de evaluaciones del usuario
            CargarHistorial();
        }

        // Se ejecuta cuando se selecciona una materia
        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaterias.SelectedItem is Materia materia)
            {
                // Carga los temas asociados a la materia seleccionada
                var temas = temaService.ListarTemas()
                    .Where(t => t.IdMateria == materia.IdMateria && !t.Eliminado)
                    .OrderBy(t => t.Nombre)
                    .ToList();

                cmbTemas.DataSource = temas;
                cmbTemas.DisplayMember = "Nombre";
                cmbTemas.ValueMember = "IdTema";
                cmbTemas.SelectedIndex = -1;
            }
        }

        // Se ejecuta al hacer clic en "Empezar Evaluación"
        private void btnEmpezarEvaluacion_Click(object sender, EventArgs e)
        {
            if (usuario == null) return;

            // Verifica que se haya seleccionado un tema
            if (cmbTemas.SelectedItem is not Tema tema)
            {
                MessageBox.Show("Debe seleccionar un tema.");
                return;
            }

            // Obtiene la evaluación asociada al tema
            var evaluacion = evaluacionService.ObtenerPorTema(tema.IdTema);
            if (evaluacion == null || evaluacion.Eliminado)
            {
                MessageBox.Show("Este tema no tiene una evaluación activa.");
                return;
            }

            // Obtiene las preguntas de la evaluación
            var preguntas = preguntaService.ListarPreguntas()
                .Where(p => p.IdEvaluacion == evaluacion.IdEvaluacion)
                .ToList();

            // Verifica que haya al menos 5 preguntas
            if (preguntas.Count < 5)
            {
                MessageBox.Show("Este tema no tiene suficientes preguntas (mínimo 5).");
                return;
            }

            // Selecciona 5 preguntas al azar
            var seleccionadas = preguntas.OrderBy(_ => Guid.NewGuid()).Take(5).ToList();

            // Crea un nuevo historial de evaluación
            var historialId = historialService.CrearHistorial(usuario.IdUsuario, evaluacion.IdEvaluacion);

            // Abre el formulario de evaluación
            var quiz = new FormQuizEstudiante(seleccionadas, tema.Nombre, historialId);
            quiz.Show();
        }

        // Carga el historial de evaluaciones del usuario en el DataGridView
        private void CargarHistorial()
        {
            var historial = historialService.ListarPorUsuario(usuario!.IdUsuario);
            var temas = temaService.ListarTemas();
            var materias = materiaService.ListarMaterias();

            DGVHistorialEvaluaciones.Rows.Clear();

            foreach (var h in historial)
            {
                // Obtiene la evaluación asociada al historial
                var evaluacion = evaluacionService.ObtenerEvaluacion(h.IdEvaluacion);
                if (evaluacion == null) continue;

                // Obtiene el tema y la materia correspondientes
                var tema = temas.FirstOrDefault(t => t.IdTema == evaluacion.IdTema);
                var materia = tema != null ? materias.FirstOrDefault(m => m.IdMateria == tema.IdMateria) : null;

                // Agrega una fila al DataGridView con los datos del historial
                int rowIndex = DGVHistorialEvaluaciones.Rows.Add(
                    h.FechaInicio.ToShortDateString(),
                    materia?.Nombre ?? "Sin materia",
                    tema?.Nombre ?? "Sin tema",
                    h.PuntajeTotal?.ToString() ?? "-"
                );

                // Asocia el objeto historial a la fila para recuperarlo luego
                DGVHistorialEvaluaciones.Rows[rowIndex].Tag = h;
            }
        }

        // Se ejecuta al hacer clic en una celda del DataGridView
        private void DGVHistorialEvaluaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var fila = DGVHistorialEvaluaciones.Rows[e.RowIndex];
            if (fila.Tag is not HistorialEvaluacion historial) return;

            // Obtiene los intentos registrados para el historial
            var intentos = new IntentoService().ListarPorHistorial(historial.IdHistorial);

            // Obtiene todas las preguntas y filtra las que fueron respondidas en este intento
            var preguntas = new PreguntaService().ListarPreguntas();
            var seleccionadas = preguntas
                .Where(p => intentos.Any(i => i.IdPregunta == p.IdPregunta))
                .ToList();

            // Obtiene el tema asociado a la evaluación
            var tema = new TemaService().ObtenerTema(
                new EvaluacionService().ObtenerEvaluacion(historial.IdEvaluacion)?.IdTema ?? 0
            );

            // Abre el formulario de evaluación en modo lectura
            var quiz = new FormQuizEstudiante(seleccionadas, tema?.Nombre ?? "Evaluación", historial.IdHistorial, modoLectura: true);
            quiz.Show();
        }
    }
}
