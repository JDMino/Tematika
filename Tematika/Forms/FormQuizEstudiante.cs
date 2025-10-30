using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;

namespace Tematika.Forms
{
    // Formulario que permite a un estudiante realizar un quiz o examen
    public partial class FormQuizEstudiante : Form
    {
        // Lista de preguntas que se van a mostrar en el quiz
        private readonly List<Pregunta> preguntas;

        // Nombre del tema del quiz (para mostrar en el título)
        private readonly string nombreTema;

        // Id del historial de evaluación, se usa para registrar intentos
        private readonly int idHistorial;

        // Indica si el formulario está en modo lectura (visualización de resultados)
        private readonly bool modoLectura;

        // Servicios para obtener opciones y registrar intentos
        private readonly OpcionPreguntaService opcionService = new OpcionPreguntaService();
        private readonly IntentoService intentoService = new IntentoService();

        public FormQuizEstudiante(List<Pregunta> preguntas, string nombreTema, int idHistorial, bool modoLectura = false)
        {
            InitializeComponent();

            this.preguntas = preguntas;
            this.nombreTema = nombreTema;
            this.idHistorial = idHistorial;
            this.modoLectura = modoLectura;

            // Eventos principales del formulario
            Load += FormQuizEstudiante_Load; // Al cargar el formulario
            btnEnviarEvaluacion.Click += btnEnviarEvaluacion_Click; // Al enviar el quiz
        }

        // Evento al cargar el formulario
        private void FormQuizEstudiante_Load(object sender, EventArgs e)
        {
            // Establece el título con el nombre del tema
            lblTituloQuiz.Text = $"Evaluación: {nombreTema}";

            // Agrupa los paneles de preguntas para recorrerlos fácilmente
            var paneles = new[] {
                panelPregunta1, panelPregunta2, panelPregunta3, panelPregunta4, panelPregunta5
            };

            // Lista de intentos si estamos en modo lectura (visualización de resultados)
            List<Intento> intentos = new();
            if (modoLectura)
            {
                // Obtenemos los intentos previamente registrados del historial
                intentos = intentoService.ListarPorHistorial(idHistorial);
            }

            // Recorremos las preguntas seleccionadas (máximo 5)
            for (int i = 0; i < preguntas.Count && i < 5; i++)
            {
                var pregunta = preguntas[i]; // Pregunta actual
                var panel = paneles[i];      // Panel donde se mostrará
                var label = panel.Controls.OfType<Label>().FirstOrDefault();       // Label para el enunciado
                var groupBox = panel.Controls.OfType<GroupBox>().FirstOrDefault(); // GroupBox que contiene RadioButtons
                var opciones = opcionService.ListarPorPregunta(pregunta.IdPregunta); // Opciones de la pregunta

                // Si encontramos el label, mostramos el enunciado
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

                            // Asignamos el texto al RadioButton
                            radios[j].Text = opcion.Texto;

                            // Guardamos la opción como Tag para acceder a sus propiedades después
                            radios[j].Tag = opcion;

                            // Deshabilitamos si estamos en modo lectura
                            radios[j].Enabled = !modoLectura;

                            // Si estamos en modo lectura y es la opción correcta, lo indicamos
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
                            // Ocultamos RadioButtons sobrantes si hay más de los necesarios
                            radios[j].Visible = false;
                        }
                    }
                }

                // Hacemos visible el panel de la pregunta
                panel.Visible = true;
            }

            // Mostramos u ocultamos el botón de envío según el modo
            btnEnviarEvaluacion.Visible = !modoLectura;
        }

        // Evento al hacer clic en "Enviar evaluación"
        private void btnEnviarEvaluacion_Click(object sender, EventArgs e)
        {
            // Verifica si hay sesión activa
            if (!SesionManager.SesionActiva || SesionManager.UsuarioActual == null)
            {
                MessageBox.Show("No hay sesión activa.");
                return;
            }

            int correctas = 0; // Contador de respuestas correctas

            var paneles = new[] {
                panelPregunta1, panelPregunta2, panelPregunta3, panelPregunta4, panelPregunta5
            };

            // Recorremos las preguntas para validar respuestas
            for (int i = 0; i < preguntas.Count && i < 5; i++)
            {
                var pregunta = preguntas[i];
                var panel = paneles[i];
                var groupBox = panel.Controls.OfType<GroupBox>().FirstOrDefault();
                if (groupBox == null) continue;

                // Obtenemos la opción seleccionada
                var seleccion = groupBox.Controls.OfType<RadioButton>()
                    .FirstOrDefault(rb => rb.Checked);

                if (seleccion == null)
                {
                    MessageBox.Show($"Debe responder la pregunta {i + 1}.");
                    return; // Si falta alguna respuesta, detenemos la evaluación
                }

                var opcion = seleccion.Tag as OpcionPregunta;
                if (opcion == null) continue;

                // Creamos un intento con los datos de la respuesta del usuario
                var intento = new Intento
                {
                    Fecha = DateTime.Now,
                    IdUsuario = SesionManager.UsuarioActual.IdUsuario,
                    IdPregunta = pregunta.IdPregunta,
                    IdOpcion = opcion.IdOpcion,
                    Correcta = opcion.EsCorrecta,
                    IdHistorial = idHistorial
                };

                // Registramos el intento en la base de datos
                intentoService.RegistrarIntento(intento);

                if (opcion.EsCorrecta)
                    correctas++; // Contamos las respuestas correctas
            }

            // Se aprueba si hay 3 o más respuestas correctas
            bool aprobado = correctas >= 3;

            // Finalizamos el historial de evaluación con resultados
            new HistorialEvaluacionService().FinalizarHistorial(idHistorial, correctas, aprobado);

            // Mostramos un mensaje con el resultado
            MessageBox.Show(
                $"Evaluación finalizada.\nRespuestas correctas: {correctas}/5\nResultado: {(aprobado ? "Aprobado" : "Desaprobado")}",
                "Resultado",
                MessageBoxButtons.OK,
                aprobado ? MessageBoxIcon.Information : MessageBoxIcon.Warning
            );

            // Cerramos el formulario actual
            Hide();
            Close();
        }
    }
}
