using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;
using Tematika.Styles;
using Tematika.Utils;

namespace Tematika.Forms
{
    public partial class FormGestionPreguntas : Form
    {
        // Servicios para manejar las operaciones de negocio
        private readonly OpcionPreguntaService _opcionService = new OpcionPreguntaService();
        private readonly PreguntaService _preguntaService = new PreguntaService();
        private readonly EvaluacionService _evaluacionService = new EvaluacionService();
        private readonly MateriaService _materiaService = new MateriaService();
        private readonly TemaService _temaService = new TemaService();

        // ID de la pregunta seleccionada y control para mostrar activas/inactivas
        private int? preguntaSeleccionadaId = null;
        private bool mostrarActivos = true;

        public FormGestionPreguntas()
        {
            InitializeComponent();

            // Asociar eventos a los controles del formulario
            Load += FormGestionPreguntas_Load; // Evento al cargar el formulario
            CBMateria.SelectedIndexChanged += CBMateria_SelectedIndexChanged;
            BGuardarPreg.Click += BGuardarPreg_Click;
            BModificarPreg.Click += BModificarPreg_Click;
            BEliminarEvaluacion.Click += BEliminarEvaluacion_Click;
            BCancelarPreg.Click += BCancelarPreg_Click;
            BPActivos.Click += BPActivos_Click;
            BPInactivos.Click += BPInactivos_Click;
            DGVPreguntas.CellClick += DGVPreguntas_CellClick;

            // Filtro en tiempo real al escribir en el buscador
            TBBuscador.TextChanged += (s, e) =>
            {
                GridUtils.FiltrarFilasPorTexto(DGVPreguntas, TBBuscador.Text);
            };

            // Validación de caracteres permitidos
            textBox5.KeyPress += (s, e) => Validaciones.ValidarTextoConCaracteresEspeciales(e);
        }

        private void FormGestionPreguntas_Load(object sender, EventArgs e)
        {
            // Aplicar estilo al encabezado y fondo del panel
            EstiloEncabezado.Aplicar(panelEncabezadoP, LTituloPreguntas);
            panelPreguntas.BackColor = ColorTranslator.FromHtml("#cfd8dc");

            // Inicializar comboBox para marcar eliminadas
            comboBox1.Items.Clear();
            comboBox1.Items.Add("No");
            comboBox1.Items.Add("Sí");
            comboBox1.SelectedIndex = 0;

            // Cargar datos iniciales
            CargarMaterias();
            CargarOpcionesCorrectas();
            CargarPreguntas();
        }

        private void CargarMaterias()
        {
            List<Materia> materias;

            if (SesionManager.SesionActiva && SesionManager.UsuarioActual!.IdPerfil == 2)
            {
                // Docente: solo se muestran las materias asignadas
                materias = _materiaService.ListarMateriasPorDocente(SesionManager.UsuarioActual.IdUsuario);
            }
            else
            {
                // Admin u otros perfiles: se muestran todas las materias activas
                materias = _materiaService.ListarMaterias()
                    .Where(m => !m.Eliminado)
                    .OrderBy(m => m.Nombre)
                    .ToList();
            }

            // Configurar ComboBox de materias
            CBMateria.DisplayMember = "Nombre";
            CBMateria.ValueMember = "IdMateria";
            CBMateria.DataSource = materias;

            // Limpiar ComboBox de temas al cambiar la materia
            CBTemas.DataSource = null;
        }

        private void CBMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Al cambiar la materia seleccionada, cargar los temas relacionados
            if (CBMateria.SelectedValue is int idMateria)
            {
                var temas = _temaService.ListarTemas()
                    .Where(t => t.IdMateria == idMateria && !t.Eliminado)
                    .OrderBy(t => t.Nombre)
                    .ToList();

                CBTemas.DisplayMember = "Nombre";
                CBTemas.ValueMember = "IdTema";
                CBTemas.DataSource = temas;
            }
        }

        private void CargarOpcionesCorrectas()
        {
            // Configurar ComboBox de opciones correctas
            CBOpcionCorrecta.Items.Clear();
            CBOpcionCorrecta.Items.Add("Opción 1");
            CBOpcionCorrecta.Items.Add("Opción 2");
            CBOpcionCorrecta.Items.Add("Opción 3");
            CBOpcionCorrecta.SelectedIndex = 0;
        }

        private void CargarPreguntas()
        {
            //Traer ids de materias no eliminados
            var idMateriasNoEliminadas = _materiaService.ListarMaterias()
                .Where(m => !m.Eliminado)
                .Select(m => m.IdMateria);

            //Traer ids de temas no eliminados
            var idTemasNoEliminados = _temaService.ListarTemas()
                .Where(t => !t.Eliminado &&
                        idMateriasNoEliminadas.Contains(t.IdMateria))
                .Select(t => t.IdTema);

            //Traer ids de evaluaciones no eliminadas
            //esto depende en realidad supongo
            var idEvaluacionesNoEliminadas = _evaluacionService.ListarEvaluaciones()
                .Where(e => e.Eliminado != mostrarActivos &&
                        idTemasNoEliminados.Contains(e.IdTema))
                .Select(e => e.IdEvaluacion);

            // Obtener todas las preguntas
            var preguntas = _preguntaService.ListarPreguntas()
                .Where(p => idEvaluacionesNoEliminadas.Contains(p.IdEvaluacion));
            
            var materiasPermitidas = new List<int>();

            // Si es docente, limitar preguntas a sus materias
            if (SesionManager.SesionActiva && SesionManager.UsuarioActual!.IdPerfil == 2)
            {
                materiasPermitidas = new DocenteMateriaService().ListarAsignaciones()
                    .Where(dm => dm.IdUsuario == SesionManager.UsuarioActual.IdUsuario)
                    .Select(dm => dm.IdMateria)
                    .ToList();
            }

            DGVPreguntas.Rows.Clear();

            // Llenar el DataGridView con las preguntas filtradas
            foreach (var p in preguntas)
            {
                var evaluacion = _evaluacionService.ObtenerEvaluacion(p.IdEvaluacion);
                var tema = evaluacion != null ? _temaService.ObtenerTema(evaluacion.IdTema) : null;
                var materia = tema != null ? _materiaService.ObtenerMateria(tema.IdMateria) : null;

                if (evaluacion != null && tema != null && materia != null && evaluacion.Eliminado != mostrarActivos)
                {
                    if (materiasPermitidas.Count == 0 || materiasPermitidas.Contains(materia.IdMateria))
                    {
                        DGVPreguntas.Rows.Add(p.IdEvaluacion, materia.Nombre, tema.Nombre, p.IdPregunta, p.Enunciado);
                    }
                }
            }

            // Ajustar visibilidad de botones
            BGuardarPreg.Visible = true;
            BModificarPreg.Visible = false;
            BEliminarEvaluacion.Visible = false;
        }

        private void LimpiarCampos()
        {
            // Limpiar todos los campos del formulario
            textBox5.Clear();
            TBOp1.Clear();
            TBOp2.Clear();
            TBOp3.Clear();
            CBMateria.SelectedIndex = 0;
            CBTemas.DataSource = null;
            CargarOpcionesCorrectas();
            comboBox1.SelectedIndex = 0;
            preguntaSeleccionadaId = null;

            BGuardarPreg.Visible = true;
            BModificarPreg.Visible = false;
            BEliminarEvaluacion.Visible = false;
        }

        private void BGuardarPreg_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (!Validaciones.ValidarCamposObligatorios(panelCamposPreguntas))
                return;

            // Verificar que se haya seleccionado un tema válido
            if (CBTemas.SelectedValue is not int idTema)
            {
                MessageBox.Show("Debe seleccionar un tema válido.");
                return;
            }

            // Verificar si existe una evaluación para el tema
            var evaluacion = _evaluacionService.ObtenerPorTema(idTema);
            if (evaluacion == null)
            {
                // Crear nueva evaluación si no existe
                var nuevaEvaluacion = new Evaluacion
                {
                    IdTema = idTema,
                    Eliminado = comboBox1.SelectedItem?.ToString() == "Sí"
                };

                var errorEval = _evaluacionService.CrearEvaluacion(nuevaEvaluacion);
                if (errorEval != null)
                {
                    MessageBox.Show(errorEval, "Error al crear evaluación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                evaluacion = _evaluacionService.ObtenerPorTema(idTema);
            }

            // Validar que no exista una pregunta con el mismo enunciado en esta evaluación
            if (_preguntaService.ListarPreguntas()
                .Any(p => p.IdEvaluacion == evaluacion.IdEvaluacion &&
                          p.Enunciado.Trim().ToLower() == textBox5.Text.Trim().ToLower()))
            {
                MessageBox.Show("Ya existe una pregunta con ese enunciado en esta evaluación.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear la pregunta
            var pregunta = new Pregunta
            {
                Enunciado = textBox5.Text,
                OpcionCorrecta = CBOpcionCorrecta.SelectedItem?.ToString() ?? "",
                IdEvaluacion = evaluacion!.IdEvaluacion
            };

            var error = _preguntaService.CrearPregunta(pregunta);
            if (error != null)
            {
                MessageBox.Show(error, "Error al guardar pregunta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la pregunta recién creada
            var preguntaGuardada = _preguntaService.ListarPreguntas()
                .LastOrDefault(p => p.Enunciado == pregunta.Enunciado && p.IdEvaluacion == pregunta.IdEvaluacion);

            if (preguntaGuardada != null)
            {
                // Crear las opciones de la pregunta
                var opciones = new List<OpcionPregunta>
        {
            new OpcionPregunta { Texto = TBOp1.Text, EsCorrecta = CBOpcionCorrecta.SelectedItem?.ToString() == "Opción 1", IdPregunta = preguntaGuardada.IdPregunta },
            new OpcionPregunta { Texto = TBOp2.Text, EsCorrecta = CBOpcionCorrecta.SelectedItem?.ToString() == "Opción 2", IdPregunta = preguntaGuardada.IdPregunta },
            new OpcionPregunta { Texto = TBOp3.Text, EsCorrecta = CBOpcionCorrecta.SelectedItem?.ToString() == "Opción 3", IdPregunta = preguntaGuardada.IdPregunta }
        };

                foreach (var op in opciones)
                {
                    var errorOp = _opcionService.CrearOpcion(op);
                    if (errorOp != null)
                    {
                        MessageBox.Show(errorOp, "Error al crear opción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            MessageBox.Show("Pregunta guardada correctamente.");
            CargarPreguntas();
            LimpiarCampos();
        }


        private void DGVPreguntas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si se hace clic fuera de las filas válidas, salir
            if (e.RowIndex < 0) return;

            // Obtener la fila seleccionada
            var fila = DGVPreguntas.Rows[e.RowIndex];

            // Guardar el ID de la pregunta seleccionada
            preguntaSeleccionadaId = Convert.ToInt32(fila.Cells["IDPreg"].Value);

            // Buscar la pregunta completa en el servicio
            var pregunta = _preguntaService.ListarPreguntas()
                .FirstOrDefault(p => p.IdPregunta == preguntaSeleccionadaId);

            if (pregunta == null) return; // Salir si no se encuentra la pregunta

            // Obtener la evaluación, tema y materia asociados
            var evaluacion = _evaluacionService.ObtenerEvaluacion(pregunta.IdEvaluacion);
            var tema = evaluacion != null ? _temaService.ObtenerTema(evaluacion.IdTema) : null;
            var materia = tema != null ? _materiaService.ObtenerMateria(tema.IdMateria) : null;


            // Configurar ComboBoxes según la materia y tema
            if (materia != null)
            {
                CBMateria.SelectedValue = materia.IdMateria;

                var temas = _temaService.ListarTemas()
                    .Where(t => t.IdMateria == materia.IdMateria && !t.Eliminado) // solo temas activos
                    .OrderBy(t => t.Nombre)
                    .ToList();

                CBTemas.DisplayMember = "Nombre";
                CBTemas.ValueMember = "IdTema";
                CBTemas.DataSource = temas;
                CBTemas.SelectedValue = tema?.IdTema ?? 0; // Seleccionar el tema correspondiente
            }

            // Rellenar el enunciado de la pregunta
            textBox5.Text = pregunta.Enunciado;

            // Mostrar si la evaluación está eliminada
            comboBox1.SelectedItem = evaluacion?.Eliminado == true ? "Sí" : "No";

            // Obtener opciones de la pregunta
            var opciones = _opcionService.ListarPorPregunta(pregunta.IdPregunta);

            // Rellenar los TextBoxes con las opciones
            TBOp1.Text = opciones.ElementAtOrDefault(0)?.Texto ?? "";
            TBOp2.Text = opciones.ElementAtOrDefault(1)?.Texto ?? "";
            TBOp3.Text = opciones.ElementAtOrDefault(2)?.Texto ?? "";

            // Determinar cuál opción es correcta
            var correcta = opciones.FirstOrDefault(o => o.EsCorrecta);
            if (correcta != null)
            {
                if (correcta.Texto == TBOp1.Text) CBOpcionCorrecta.SelectedItem = "Opción 1";
                else if (correcta.Texto == TBOp2.Text) CBOpcionCorrecta.SelectedItem = "Opción 2";
                else if (correcta.Texto == TBOp3.Text) CBOpcionCorrecta.SelectedItem = "Opción 3";
            }

            // Ajustar botones: deshabilitar guardar, habilitar modificar y eliminar
            BGuardarPreg.Visible = false;
            BModificarPreg.Visible = true;
            BEliminarEvaluacion.Visible = true;


            if (evaluacion.Eliminado)
            {
                BEliminarEvaluacion.Visible = false;
            }
        }

        private void BModificarPreg_Click(object sender, EventArgs e)
        {
            if (preguntaSeleccionadaId == null)
            {
                MessageBox.Show("Debe seleccionar una pregunta para modificar.");
                return;
            }

            if (!Validaciones.ValidarCamposObligatorios(panelCamposPreguntas))
                return;

            if (CBTemas.SelectedValue is not int idTema)
            {
                MessageBox.Show("Debe seleccionar un tema válido.");
                return;
            }

            var preguntaOriginal = _preguntaService.ListarPreguntas()
                .FirstOrDefault(p => p.IdPregunta == preguntaSeleccionadaId.Value);

            if (preguntaOriginal == null)
            {
                MessageBox.Show("No se encontró la pregunta original.");
                return;
            }

            var evaluacion = _evaluacionService.ObtenerEvaluacion(preguntaOriginal.IdEvaluacion);
            if (evaluacion == null)
            {
                MessageBox.Show("No se encontró la evaluación asociada.");
                return;
            }

            // Validar enunciado duplicado reutilizando el método del servicio
            if (_preguntaService.ExisteEnunciadoEnEvaluacion(textBox5.Text, evaluacion.IdEvaluacion, preguntaSeleccionadaId))
            {
                MessageBox.Show("Ya existe otra pregunta con ese enunciado en esta evaluación.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar evaluación
            evaluacion.IdTema = idTema;
            evaluacion.Eliminado = comboBox1.SelectedItem?.ToString() == "Sí";

            var errorEval = _evaluacionService.ActualizarEvaluacion(evaluacion);
            if (errorEval != null)
            {
                MessageBox.Show(errorEval, "Error al actualizar evaluación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar pregunta
            var pregunta = new Pregunta
            {
                IdPregunta = preguntaSeleccionadaId.Value,
                Enunciado = textBox5.Text,
                OpcionCorrecta = CBOpcionCorrecta.SelectedItem?.ToString() ?? "",
                IdEvaluacion = evaluacion.IdEvaluacion
            };

            var error = _preguntaService.ActualizarPregunta(pregunta);
            if (error != null)
            {
                MessageBox.Show(error, "Error al modificar pregunta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener opciones existentes
            var opcionesExistentes = _opcionService.ListarPorPregunta(preguntaSeleccionadaId.Value);

            // Preparar nuevas opciones
            var nuevasOpciones = new List<OpcionPregunta>
            {
                new OpcionPregunta
                {
                    Texto = TBOp1.Text,
                    EsCorrecta = CBOpcionCorrecta.SelectedItem?.ToString() == "Opción 1",
                    IdPregunta = preguntaSeleccionadaId.Value
                },
                new OpcionPregunta
                {
                    Texto = TBOp2.Text,
                    EsCorrecta = CBOpcionCorrecta.SelectedItem?.ToString() == "Opción 2",
                    IdPregunta = preguntaSeleccionadaId.Value
                },
                new OpcionPregunta
                {
                    Texto = TBOp3.Text,
                    EsCorrecta = CBOpcionCorrecta.SelectedItem?.ToString() == "Opción 3",
                    IdPregunta = preguntaSeleccionadaId.Value
                }
            };

            // Actualizar o crear opciones
            for (int i = 0; i < nuevasOpciones.Count; i++)
            {
                if (i < opcionesExistentes.Count)
                {
                    nuevasOpciones[i].IdOpcion = opcionesExistentes[i].IdOpcion;
                    _opcionService.ActualizarOpcion(nuevasOpciones[i]);
                }
                else
                {
                    _opcionService.CrearOpcion(nuevasOpciones[i]);
                }
            }

            MessageBox.Show("Pregunta modificada correctamente.");
            CargarPreguntas();
            LimpiarCampos();
        }




        private void BEliminarEvaluacion_Click(object sender, EventArgs e)
        {
            // Verificar que haya una pregunta seleccionada
            if (preguntaSeleccionadaId == null)
            {
                MessageBox.Show("Debe seleccionar una pregunta para eliminar.");
                return;
            }

            // Obtener la pregunta seleccionada
            var pregunta = _preguntaService.ListarPreguntas()
                .FirstOrDefault(p => p.IdPregunta == preguntaSeleccionadaId.Value);

            if (pregunta == null)
            {
                MessageBox.Show("No se encontró la pregunta seleccionada.");
                return;
            }

            // Obtener la evaluación asociada
            var evaluacion = _evaluacionService.ObtenerEvaluacion(pregunta.IdEvaluacion);
            if (evaluacion == null)
            {
                MessageBox.Show("No se encontró la evaluación asociada.");
                return;
            }

            // Confirmar eliminación con el usuario
            var confirm = MessageBox.Show(
                "¿Está seguro de marcar como eliminada la evaluación asociada a esta pregunta?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (confirm == DialogResult.Yes)
            {
                // Marcar la evaluación como eliminada
                _evaluacionService.EliminarEvaluacion(evaluacion.IdEvaluacion);

                MessageBox.Show("Evaluación marcada como eliminada.");

                // Recargar preguntas y limpiar campos
                CargarPreguntas();
                LimpiarCampos();
            }
        }

        private void BCancelarPreg_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos del formulario y resetear botones
            LimpiarCampos();
        }

        private void BPActivos_Click(object sender, EventArgs e)
        {
            // Mostrar solo preguntas/evaluaciones activas
            mostrarActivos = true;
            CargarPreguntas();
        }

        private void BPInactivos_Click(object sender, EventArgs e)
        {
            // Mostrar solo preguntas/evaluaciones eliminadas
            mostrarActivos = false;
            CargarPreguntas();
        }
    }
}
