using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;

namespace Tematika.Forms
{
    public partial class FormQuizEstudiante : Form
    {
        private readonly List<Pregunta> preguntas;
        private readonly string nombreTema;
        private readonly int idHistorial;
        private readonly bool modoLectura;

        private readonly OpcionPreguntaService opcionService = new OpcionPreguntaService();
        private readonly IntentoService intentoService = new IntentoService();

        public FormQuizEstudiante(List<Pregunta> preguntas, string nombreTema, int idHistorial, bool modoLectura = false)
        {
            InitializeComponent();
            this.preguntas = preguntas;
            this.nombreTema = nombreTema;
            this.idHistorial = idHistorial;
            this.modoLectura = modoLectura;
            Load += FormQuizEstudiante_Load;
            btnEnviarEvaluacion.Click += btnEnviarEvaluacion_Click;
        }

        private void FormQuizEstudiante_Load(object sender, EventArgs e)
        {
            // Establece el título del formulario con el nombre del tema
            lblTituloQuiz.Text = $"Evaluación: {nombreTema}";

            // Agrupa los paneles de preguntas en un array para recorrerlos fácilmente
            var paneles = new[] {
                panelPregunta1, panelPregunta2, panelPregunta3, panelPregunta4, panelPregunta5
            };

            // Lista que almacenará los intentos del usuario si estamos en modo lectura
            List<Intento> intentos = new();
            if (modoLectura)
            {
                // Si estamos visualizando un examen ya hecho, obtenemos los intentos registrados
                intentos = intentoService.ListarPorHistorial(idHistorial);
            }

            // Recorremos las preguntas seleccionadas para esta evaluación (máximo 5)
            for (int i = 0; i < preguntas.Count && i < 5; i++)
            {
                var pregunta = preguntas[i]; // Pregunta actual
                var panel = paneles[i];      // Panel correspondiente a la pregunta
                var label = panel.Controls.OfType<Label>().FirstOrDefault();       // Label donde se muestra el enunciado
                var groupBox = panel.Controls.OfType<GroupBox>().FirstOrDefault(); // GroupBox que contiene los RadioButtons
                var opciones = opcionService.ListarPorPregunta(pregunta.IdPregunta); // Opciones de respuesta para esta pregunta

                // Si encontramos el label, mostramos el enunciado de la pregunta
                if (label != null)
                    label.Text = $"Pregunta {i + 1}: {pregunta.Enunciado}";

                // Si encontramos el groupBox, configuramos los RadioButtons
                if (groupBox != null)
                {
                    var radios = groupBox.Controls.OfType<RadioButton>().ToList(); // Obtenemos los RadioButtons

                    for (int j = 0; j < radios.Count; j++)
                    {
                        if (j < opciones.Count)
                        {
                            var opcion = opciones[j]; // Opción actual

                            // Asignamos el texto de la opción al RadioButton
                            radios[j].Text = opcion.Texto;

                            // Guardamos la opción como Tag para poder acceder a sus propiedades luego
                            radios[j].Tag = opcion;

                            // Deshabilitamos el RadioButton si estamos en modo lectura
                            radios[j].Enabled = !modoLectura;

                            // Si estamos en modo lectura y esta opción es la correcta, agregamos el texto indicativo
                            if (modoLectura && opcion.EsCorrecta)
                            {
                                radios[j].Text += "  ← OPCIÓN CORRECTA";
                            }

                            // Si estamos en modo lectura, marcamos la opción que el usuario eligió
                            if (modoLectura)
                            {
                                var intento = intentos.FirstOrDefault(it => it.IdPregunta == pregunta.IdPregunta);
                                if (intento != null && intento.IdOpcion == opcion.IdOpcion)
                                {
                                    radios[j].Checked = true;
                                }
                            }
                        }
                        else
                        {
                            // Si hay más RadioButtons que opciones, ocultamos los sobrantes
                            radios[j].Visible = false;
                        }
                    }
                }

                // Mostramos el panel de la pregunta
                panel.Visible = true;
            }

            // Mostramos u ocultamos el botón de envío según el modo
            btnEnviarEvaluacion.Visible = !modoLectura;
        }


        private void btnEnviarEvaluacion_Click(object sender, EventArgs e)
        {
            if (!SesionManager.SesionActiva || SesionManager.UsuarioActual == null)
            {
                MessageBox.Show("No hay sesión activa.");
                return;
            }

            int correctas = 0;

            var paneles = new[] {
                panelPregunta1, panelPregunta2, panelPregunta3, panelPregunta4, panelPregunta5
            };

            for (int i = 0; i < preguntas.Count && i < 5; i++)
            {
                var pregunta = preguntas[i];
                var panel = paneles[i];
                var groupBox = panel.Controls.OfType<GroupBox>().FirstOrDefault();
                if (groupBox == null) continue;

                var seleccion = groupBox.Controls.OfType<RadioButton>()
                    .FirstOrDefault(rb => rb.Checked);

                if (seleccion == null)
                {
                    MessageBox.Show($"Debe responder la pregunta {i + 1}.");
                    return;
                }

                var opcion = seleccion.Tag as OpcionPregunta;
                if (opcion == null) continue;

                var intento = new Intento
                {
                    Fecha = DateTime.Now,
                    IdUsuario = SesionManager.UsuarioActual.IdUsuario,
                    IdPregunta = pregunta.IdPregunta,
                    IdOpcion = opcion.IdOpcion,
                    Correcta = opcion.EsCorrecta,
                    IdHistorial = idHistorial
                };

                intentoService.RegistrarIntento(intento);

                if (opcion.EsCorrecta)
                    correctas++;
            }

            bool aprobado = correctas >= 3;

            new HistorialEvaluacionService().FinalizarHistorial(idHistorial, correctas, aprobado);

            MessageBox.Show(
                $"Evaluación finalizada.\nRespuestas correctas: {correctas}/5\nResultado: {(aprobado ? "Aprobado" : "Desaprobado")}",
                "Resultado",
                MessageBoxButtons.OK,
                aprobado ? MessageBoxIcon.Information : MessageBoxIcon.Warning
            );

            Hide();
            //var evaluaciones = new FormEvaluationsEstudiante();
            //evaluaciones.Show();
            Close();
        }
    }
}
