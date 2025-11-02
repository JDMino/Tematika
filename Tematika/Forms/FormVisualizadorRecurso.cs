using System;
using System.Linq;
using System.Windows.Forms;
using Tematika.Models;
using Tematika.CapaDeNegocio;

namespace Tematika.Forms
{
    // Formulario para visualizar un recurso, interactuar con favoritos, valoraciones, notas y comentarios
    public partial class FormVisualizadorRecurso : Form
    {
        private readonly SuscripcionService suscripcionService = new SuscripcionService();
        private readonly Recurso recurso; // Recurso que se va a visualizar
        private readonly FavoritoService favoritoService = new FavoritoService(); // Servicio para manejar favoritos
        private readonly ValoracionService valoracionService = new ValoracionService(); // Servicio de valoraciones
        private readonly ComentarioService comentarioService = new ComentarioService(); // Servicio de comentarios
        private readonly NotaService notaService = new NotaService(); // Servicio de notas
        private readonly Usuario? usuario = SesionManager.UsuarioActual; // Usuario logueado (puede ser null si es invitado)

        // Constructor del formulario
        public FormVisualizadorRecurso(Recurso recurso)
        {
            InitializeComponent();
            this.recurso = recurso;

            // Eventos
            Load += FormVisualizadorRecurso_Load;
            btnMarcarFavorito.Click += btnMarcarFavorito_Click;
            btnGuardarValoracion.Click += btnGuardarValoracion_Click;
            btnGuardarNota.Click += btnGuardarNota_Click;
            button1.Click += buttonEnviarComentario_Click; // Botón para enviar comentarios
        }

        // Evento al cargar el formulario
        private void FormVisualizadorRecurso_Load(object sender, EventArgs e)
        {
            // Mostrar título del recurso
            labelTituloVRecurso.Text = recurso.Titulo;

            // Modo invitado: deshabilitar interacción
            if (!SesionManager.SesionActiva || usuario == null)
            {
                btnMarcarFavorito.Enabled = false;
                btnGuardarValoracion.Enabled = false;
                comboBox1.Enabled = false;
                btnGuardarNota.Enabled = false;
                TBNota.Enabled = false;
                button1.Enabled = false;
                TBComentario.Enabled = false;

                MessageBox.Show("Estás en modo invitado. Algunas funciones están deshabilitadas.", "Modo Invitado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Solo mostrar contenido del recurso
                VisualizarContenido();
                return;
            }

            // Cargar estado de favoritos del usuario
            var favoritos = favoritoService.ListarPorUsuario(usuario.IdUsuario);
            var favorito = favoritos.FirstOrDefault(f => f.IdRecurso == recurso.IdRecurso);
            btnMarcarFavorito.Text = favorito != null ? "Desmarcar como Favorito" : "Marcar como Favorito";

            // Cargar valoración propia del usuario
            var valoraciones = valoracionService.ListarPorRecurso(recurso.IdRecurso);
            var propia = valoraciones.FirstOrDefault(v => v.IdUsuario == usuario.IdUsuario);
            comboBox1.SelectedItem = propia?.Puntuacion.ToString();

            // Cargar comentarios en el DataGridView
            ActualizarComentarios();

            // Mostrar el contenido del recurso
            VisualizarContenido();
        }

        // Actualiza el DataGridView con los comentarios del recurso
        private void ActualizarComentarios()
        {
            var comentarios = comentarioService.ListarPorRecurso(recurso.IdRecurso);
            var usuarios = new UsuarioService().ListarUsuarios(); // Para mostrar nombres

            DGVComentariosRecursos.Rows.Clear();
            foreach (var c in comentarios)
            {
                // Obtener nombre del autor
                var autor = usuarios.FirstOrDefault(u => u.IdUsuario == c.IdUsuario);
                var nombre = autor != null ? $"{autor.Nombre} {autor.Apellido}" : $"Usuario {c.IdUsuario}";

                // Añadir fila con fecha, autor y texto
                DGVComentariosRecursos.Rows.Add(c.Fecha.ToShortDateString(), nombre, c.Texto);
            }
        }

        // Marcar o desmarcar como favorito
        private void btnMarcarFavorito_Click(object sender, EventArgs e)
        {
            if (usuario == null) return;

            int cantidadFavoritosMarcados = favoritoService.ListarPorUsuario(usuario.IdUsuario).Count();

            if (cantidadFavoritosMarcados >= 2 && !TieneSuscripcionActiva())
            {
                MessageBox.Show("Debe tener una suscripción activa para marcar más de 2 favoritos");
                return;
            }

            var favoritos = favoritoService.ListarPorUsuario(usuario.IdUsuario);
            var favorito = favoritos.FirstOrDefault(f => f.IdRecurso == recurso.IdRecurso);

            if (favorito != null)
            {
                // Desmarcar favorito
                favoritoService.EliminarFavorito(favorito.IdFavorito);
                btnMarcarFavorito.Text = "Marcar como Favorito";
                MessageBox.Show("Recurso desmarcado como favorito.");
            }
            else
            {
                // Marcar como favorito
                var nuevo = new Favorito
                {
                    IdUsuario = usuario.IdUsuario,
                    IdRecurso = recurso.IdRecurso,
                    FechaMarcado = DateTime.Now
                };
                favoritoService.MarcarFavorito(nuevo);
                btnMarcarFavorito.Text = "Desmarcar como Favorito";
                MessageBox.Show("Recurso marcado como favorito.");
            }
        }

        // Guardar valoración del recurso
        private void btnGuardarValoracion_Click(object sender, EventArgs e)
        {
            if (usuario == null) return;

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una puntuación.");
                return;
            }

            int puntuacion = int.Parse(comboBox1.SelectedItem.ToString()!);
            var valoracion = new Valoracion
            {
                IdUsuario = usuario.IdUsuario,
                IdRecurso = recurso.IdRecurso,
                Puntuacion = puntuacion,
                Fecha = DateTime.Now
            };

            var error = valoracionService.RegistrarValoracion(valoracion);
            if (error == null)
                MessageBox.Show("Valoración registrada.");
            else
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Guardar nota personal del recurso
        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            if (usuario == null) return;

            //Verificar si es suscripto o no, y limite de notas

            int cantidadNotasHechas = notaService.ListarPorUsuario(usuario.IdUsuario).Count;

            if (cantidadNotasHechas >= 5 && !TieneSuscripcionActiva())
            {
                MessageBox.Show("Debe tener una suscripción activa para realizar más de 5 notas");
                TBNota.Clear();
                return;
            }

            // Verifica que haya contenido en la nota
            if (string.IsNullOrWhiteSpace(TBNota.Text))
            {
                MessageBox.Show("Debe ingresar contenido para la nota.");
                return;
            }

            var nota = new Nota
            {
                IdUsuario = usuario.IdUsuario,
                IdRecurso = recurso.IdRecurso,
                Texto = TBNota.Text,
                Fecha = DateTime.Now
            };

            notaService.CrearNota(nota);
            MessageBox.Show("Nota guardada.");
        }

        // Enviar comentario público sobre el recurso
        private void buttonEnviarComentario_Click(object sender, EventArgs e)
        {
            if (usuario == null) return;

            bool noDocente = usuario.IdPerfil != 2;

            if (!TieneSuscripcionActiva() && noDocente)
            {
                MessageBox.Show("Debe tener una suscripción activa para hacer comentarios públicos");
                TBComentario.Clear();
                return;
            }

            // Verifica que haya contenido en la nota
            if (string.IsNullOrWhiteSpace(TBComentario.Text))
            {
                MessageBox.Show("Debe ingresar contenido para el comentario.");
                return;
            }

            var comentario = new Comentario
            {
                IdUsuario = usuario.IdUsuario,
                IdRecurso = recurso.IdRecurso,
                Texto = TBComentario.Text,
                Fecha = DateTime.Now
            };

            var error = comentarioService.CrearComentario(comentario);
            if (error == null)
            {
                MessageBox.Show("Comentario enviado.");
                TBComentario.Clear();
                ActualizarComentarios(); // 🔄 Refresca la lista de comentarios
            }
            else
            {
                MessageBox.Show(error, "Error al enviar comentario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Visualiza el contenido del recurso: texto, URL o archivo (imagen/texto)
        private void VisualizarContenido()
        {
            panelContenidoRecurso.Controls.Clear();

            if (!string.IsNullOrWhiteSpace(recurso.Texto))
            {
                // Mostrar texto en un TextBox
                var tb = new TextBox
                {
                    Multiline = true,
                    ReadOnly = true,
                    ScrollBars = ScrollBars.Vertical,
                    Dock = DockStyle.Fill,
                    Text = recurso.Texto
                };
                panelContenidoRecurso.Controls.Add(tb);
                return;
            }

            if (!string.IsNullOrWhiteSpace(recurso.Url))
            {
                // Mostrar URL como LinkLabel
                var link = new LinkLabel
                {
                    Text = recurso.Url,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                link.Click += (s, e) => System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = recurso.Url,
                    UseShellExecute = true
                });
                panelContenidoRecurso.Controls.Add(link);
                return;
            }

            if (!string.IsNullOrWhiteSpace(recurso.Ruta))
            {
                // Construir ruta absoluta del archivo
                string rutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                string rutaCompleta = Path.Combine(rutaProyecto, recurso.Ruta);

                var ext = Path.GetExtension(rutaCompleta).ToLower();

                if (ext == ".txt")
                {
                    // Mostrar contenido de archivo de texto
                    if (File.Exists(rutaCompleta))
                    {
                        var contenido = File.ReadAllText(rutaCompleta);
                        var tb = new TextBox
                        {
                            Multiline = true,
                            ReadOnly = true,
                            ScrollBars = ScrollBars.Vertical,
                            Dock = DockStyle.Fill,
                            Text = contenido
                        };
                        panelContenidoRecurso.Controls.Add(tb);
                    }
                    else
                    {
                        MostrarError("No se encontró el archivo de texto.");
                    }
                }
                else if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif")
                {
                    // Mostrar imagen
                    if (File.Exists(rutaCompleta))
                    {
                        var pb = new PictureBox
                        {
                            Image = Image.FromFile(rutaCompleta),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Dock = DockStyle.Fill
                        };
                        panelContenidoRecurso.Controls.Add(pb);
                    }
                    else
                    {
                        MostrarError("No se encontró la imagen.");
                    }
                }
                else
                {
                    MostrarError("Tipo de archivo no soportado.");
                }
            }
            else
            {
                // Si no hay contenido disponible
                MostrarError("No hay contenido disponible.");
            }
        }

        // Muestra mensaje de error en el panel de contenido
        private void MostrarError(string mensaje)
        {
            var label = new Label
            {
                Text = mensaje,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.DarkRed,
                Font = new Font("Segoe UI", 12, FontStyle.Italic)
            };
            panelContenidoRecurso.Controls.Add(label);
        }


        // --- Verifica si el estudiante tiene una suscripción activa ---
        private bool TieneSuscripcionActiva()
        {
            var usuario = SesionManager.UsuarioActual!;
            var suscripciones = suscripcionService.ObtenerPorUsuario(usuario.IdUsuario);
            return suscripciones.Any(s => s.Activa); // Retorna true si existe una activa
        }
    }
}
