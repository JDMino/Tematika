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
        private readonly OpcionPreguntaService _opcionService = new OpcionPreguntaService();
        private readonly PreguntaService _preguntaService = new PreguntaService();
        private readonly EvaluacionService _evaluacionService = new EvaluacionService();
        private readonly MateriaService _materiaService = new MateriaService();
        private readonly TemaService _temaService = new TemaService();

        private int? preguntaSeleccionadaId = null;
        private bool mostrarActivos = true;

        public FormGestionPreguntas()
        {
            InitializeComponent();
            Load += FormGestionPreguntas_Load;
            CBMateria.SelectedIndexChanged += CBMateria_SelectedIndexChanged;
            BGuardarPreg.Click += BGuardarPreg_Click;
            BModificarPreg.Click += BModificarPreg_Click;
            BEliminarEvaluacion.Click += BEliminarEvaluacion_Click;
            BCancelarPreg.Click += BCancelarPreg_Click;
            BPActivos.Click += BPActivos_Click;
            BPInactivos.Click += BPInactivos_Click;
            DGVPreguntas.CellClick += DGVPreguntas_CellClick;
        }

        private void FormGestionPreguntas_Load(object sender, EventArgs e)
        {
            EstiloEncabezado.Aplicar(panelEncabezadoP, LTituloPreguntas);
            panelPreguntas.BackColor = ColorTranslator.FromHtml("#cfd8dc");

            comboBox1.Items.Clear();
            comboBox1.Items.Add("No");
            comboBox1.Items.Add("Sí");
            comboBox1.SelectedIndex = 0;

            CargarMaterias();
            CargarOpcionesCorrectas();
            CargarPreguntas();
        }

        private void CargarMaterias()
        {
            List<Materia> materias;

            if (SesionManager.SesionActiva && SesionManager.UsuarioActual!.IdPerfil == 2)
            {
                // Docente: solo sus materias
                materias = _materiaService.ListarMateriasPorDocente(SesionManager.UsuarioActual.IdUsuario);
            }
            else
            {
                // Admin u otro perfil: todas las materias
                materias = _materiaService.ListarMaterias()
                    .Where(m => !m.Eliminado)
                    .OrderBy(m => m.Nombre)
                    .ToList();
            }

            CBMateria.DisplayMember = "Nombre";
            CBMateria.ValueMember = "IdMateria";
            CBMateria.DataSource = materias;

            CBTemas.DataSource = null;
        }


        private void CBMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            CBOpcionCorrecta.Items.Clear();
            CBOpcionCorrecta.Items.Add("Opción 1");
            CBOpcionCorrecta.Items.Add("Opción 2");
            CBOpcionCorrecta.Items.Add("Opción 3");
            CBOpcionCorrecta.SelectedIndex = 0;
        }

        private void CargarPreguntas()
        {
            var preguntas = _preguntaService.ListarPreguntas();
            var materiasPermitidas = new List<int>();

            if (SesionManager.SesionActiva && SesionManager.UsuarioActual!.IdPerfil == 2)
            {
                materiasPermitidas = new DocenteMateriaService().ListarAsignaciones()
                    .Where(dm => dm.IdUsuario == SesionManager.UsuarioActual.IdUsuario)
                    .Select(dm => dm.IdMateria)
                    .ToList();
            }

            DGVPreguntas.Rows.Clear();

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

            BGuardarPreg.Visible = true;
            BModificarPreg.Visible = false;
            BEliminarEvaluacion.Visible = false;
        }


        private void LimpiarCampos()
        {
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
            if (!Validaciones.ValidarCamposObligatorios(panelCamposPreguntas))
                return;

            if (CBTemas.SelectedValue is not int idTema)
            {
                MessageBox.Show("Debe seleccionar un tema válido.");
                return;
            }

            // Verificar si ya existe una evaluación para el tema
            var evaluacion = _evaluacionService.ObtenerPorTema(idTema);
            if (evaluacion == null)
            {
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
                var opciones = new List<OpcionPregunta>
        {
            new OpcionPregunta { Texto = TBOp1.Text, EsCorrecta = CBOpcionCorrecta.SelectedItem?.ToString() == "Opción 1", IdPregunta = preguntaGuardada.IdPregunta },
            new OpcionPregunta { Texto = TBOp2.Text, EsCorrecta = CBOpcionCorrecta.SelectedItem?.ToString() == "Opción 2", IdPregunta = preguntaGuardada.IdPregunta },
            new OpcionPregunta { Texto = TBOp3.Text, EsCorrecta = CBOpcionCorrecta.SelectedItem?.ToString() == "Opción 3", IdPregunta = preguntaGuardada.IdPregunta }
        };

                foreach (var op in opciones)
                    _opcionService.CrearOpcion(op);
            }

            MessageBox.Show("Pregunta guardada correctamente.");
            CargarPreguntas();
            LimpiarCampos();
        }


        private void DGVPreguntas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = DGVPreguntas.Rows[e.RowIndex];
            preguntaSeleccionadaId = Convert.ToInt32(fila.Cells["IDPreg"].Value);

            var pregunta = _preguntaService.ListarPreguntas()
                .FirstOrDefault(p => p.IdPregunta == preguntaSeleccionadaId);

            if (pregunta == null) return;

            var evaluacion = _evaluacionService.ObtenerEvaluacion(pregunta.IdEvaluacion);
            var tema = evaluacion != null ? _temaService.ObtenerTema(evaluacion.IdTema) : null;
            var materia = tema != null ? _materiaService.ObtenerMateria(tema.IdMateria) : null;

            if (materia != null)
            {
                CBMateria.SelectedValue = materia.IdMateria;

                var temas = _temaService.ListarTemas()
                    .Where(t => t.IdMateria == materia.IdMateria && !t.Eliminado)
                    .OrderBy(t => t.Nombre)
                    .ToList();

                CBTemas.DisplayMember = "Nombre";
                CBTemas.ValueMember = "IdTema";
                CBTemas.DataSource = temas;
                CBTemas.SelectedValue = tema?.IdTema ?? 0;
            }

            textBox5.Text = pregunta.Enunciado;
            comboBox1.SelectedItem = evaluacion?.Eliminado == true ? "Sí" : "No";

            var opciones = _opcionService.ListarPorPregunta(pregunta.IdPregunta);

            TBOp1.Text = opciones.ElementAtOrDefault(0)?.Texto ?? "";
            TBOp2.Text = opciones.ElementAtOrDefault(1)?.Texto ?? "";
            TBOp3.Text = opciones.ElementAtOrDefault(2)?.Texto ?? "";

            var correcta = opciones.FirstOrDefault(o => o.EsCorrecta);
            if (correcta != null)
            {
                if (correcta.Texto == TBOp1.Text) CBOpcionCorrecta.SelectedItem = "Opción 1";
                else if (correcta.Texto == TBOp2.Text) CBOpcionCorrecta.SelectedItem = "Opción 2";
                else if (correcta.Texto == TBOp3.Text) CBOpcionCorrecta.SelectedItem = "Opción 3";
            }

            BGuardarPreg.Visible = false;
            BModificarPreg.Visible = true;
            BEliminarEvaluacion.Visible = true;
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

            // Recuperar la pregunta original
            var preguntaOriginal = _preguntaService.ListarPreguntas()
                .FirstOrDefault(p => p.IdPregunta == preguntaSeleccionadaId.Value);

            if (preguntaOriginal == null)
            {
                MessageBox.Show("No se encontró la pregunta original.");
                return;
            }

            // Recuperar evaluación asociada
            var evaluacion = _evaluacionService.ObtenerEvaluacion(preguntaOriginal.IdEvaluacion);
            if (evaluacion == null)
            {
                MessageBox.Show("No se encontró la evaluación asociada.");
                return;
            }

            // Actualizar evaluación existente
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

            // Actualizar opciones
            _opcionService.EliminarOpcionesDePregunta(preguntaSeleccionadaId.Value);

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

            foreach (var op in nuevasOpciones)
                _opcionService.CrearOpcion(op);

            MessageBox.Show("Pregunta modificada correctamente.");
            CargarPreguntas();
            LimpiarCampos();
        }



        private void BEliminarEvaluacion_Click(object sender, EventArgs e)
        {
            if (preguntaSeleccionadaId == null)
            {
                MessageBox.Show("Debe seleccionar una pregunta para eliminar.");
                return;
            }

            var pregunta = _preguntaService.ListarPreguntas()
                .FirstOrDefault(p => p.IdPregunta == preguntaSeleccionadaId.Value);

            if (pregunta == null)
            {
                MessageBox.Show("No se encontró la pregunta seleccionada.");
                return;
            }

            var evaluacion = _evaluacionService.ObtenerEvaluacion(pregunta.IdEvaluacion);
            if (evaluacion == null)
            {
                MessageBox.Show("No se encontró la evaluación asociada.");
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro de marcar como eliminada la evaluación asociada a esta pregunta?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _evaluacionService.EliminarEvaluacion(evaluacion.IdEvaluacion);

                MessageBox.Show("Evaluación marcada como eliminada.");
                CargarPreguntas();
                LimpiarCampos();
            }
        }


        private void BCancelarPreg_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BPActivos_Click(object sender, EventArgs e)
        {
            mostrarActivos = true;
            CargarPreguntas();
        }

        private void BPInactivos_Click(object sender, EventArgs e)
        {
            mostrarActivos = false;
            CargarPreguntas();
        }
    }
}