using System;
using System.Linq;
using System.Windows.Forms;
using Tematika.Models;
using Tematika.CapaDeNegocio;

namespace Tematika.Forms
{
    public partial class FormVisualizadorRecurso : Form
    {
        private readonly Recurso recurso;
        private readonly FavoritoService favoritoService = new FavoritoService();
        private readonly ValoracionService valoracionService = new ValoracionService();
        private readonly ComentarioService comentarioService = new ComentarioService();
        private readonly NotaService notaService = new NotaService();
        private readonly Usuario? usuario = SesionManager.UsuarioActual;

        public FormVisualizadorRecurso(Recurso recurso)
        {
            InitializeComponent();
            this.recurso = recurso;
            Load += FormVisualizadorRecurso_Load;
            btnMarcarFavorito.Click += btnMarcarFavorito_Click;
            btnGuardarValoracion.Click += btnGuardarValoracion_Click;
            btnGuardarNota.Click += btnGuardarNota_Click;
            button1.Click += buttonEnviarComentario_Click;
        }

        private void FormVisualizadorRecurso_Load(object sender, EventArgs e)
        {
            labelTituloVRecurso.Text = recurso.Titulo;

            if (!SesionManager.SesionActiva || usuario == null)
            {
                // Deshabilita interacción en modo invitado
                btnMarcarFavorito.Enabled = false;
                btnGuardarValoracion.Enabled = false;
                comboBox1.Enabled = false;
                btnGuardarNota.Enabled = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
                textBox2.Enabled = false;

                MessageBox.Show("Estás en modo invitado. Algunas funciones están deshabilitadas.", "Modo Invitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VisualizarContenido();
                return;
            }

            // Cargar favoritos y valoración propia
            var favoritos = favoritoService.ListarPorUsuario(usuario.IdUsuario);
            var favorito = favoritos.FirstOrDefault(f => f.IdRecurso == recurso.IdRecurso);
            btnMarcarFavorito.Text = favorito != null ? "Desmarcar como Favorito" : "Marcar como Favorito";

            var valoraciones = valoracionService.ListarPorRecurso(recurso.IdRecurso);
            var propia = valoraciones.FirstOrDefault(v => v.IdUsuario == usuario.IdUsuario);
            comboBox1.SelectedItem = propia?.Puntuacion.ToString();

            // Cargar comentarios con nombres
            ActualizarComentarios();
            VisualizarContenido();
        }

        private void ActualizarComentarios()
        {
            var comentarios = comentarioService.ListarPorRecurso(recurso.IdRecurso);
            var usuarios = new UsuarioService().ListarUsuarios();

            DGVComentariosRecursos.Rows.Clear();
            foreach (var c in comentarios)
            {
                var autor = usuarios.FirstOrDefault(u => u.IdUsuario == c.IdUsuario);
                var nombre = autor != null ? $"{autor.Nombre} {autor.Apellido}" : $"Usuario {c.IdUsuario}";
                DGVComentariosRecursos.Rows.Add(c.Fecha.ToShortDateString(), nombre, c.Texto);
            }
        }

        private void btnMarcarFavorito_Click(object sender, EventArgs e)
        {
            if (usuario == null) return;

            var favoritos = favoritoService.ListarPorUsuario(usuario.IdUsuario);
            var favorito = favoritos.FirstOrDefault(f => f.IdRecurso == recurso.IdRecurso);

            if (favorito != null)
            {
                favoritoService.EliminarFavorito(favorito.IdFavorito);
                btnMarcarFavorito.Text = "Marcar como Favorito";
                MessageBox.Show("Recurso desmarcado como favorito.");
            }
            else
            {
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

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            if (usuario == null) return;

            var nota = new Nota
            {
                IdUsuario = usuario.IdUsuario,
                IdRecurso = recurso.IdRecurso,
                Texto = textBox1.Text,
                Fecha = DateTime.Now
            };

            notaService.CrearNota(nota);
            MessageBox.Show("Nota guardada.");
        }

        private void buttonEnviarComentario_Click(object sender, EventArgs e)
        {
            if (usuario == null) return;

            var comentario = new Comentario
            {
                IdUsuario = usuario.IdUsuario,
                IdRecurso = recurso.IdRecurso,
                Texto = textBox2.Text,
                Fecha = DateTime.Now
            };

            var error = comentarioService.CrearComentario(comentario);
            if (error == null)
            {
                MessageBox.Show("Comentario enviado.");
                textBox2.Clear();
                ActualizarComentarios(); // 🔄 Refresca el DataGrid
            }
            else
            {
                MessageBox.Show(error, "Error al enviar comentario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void VisualizarContenido()
        {
            panelContenidoRecurso.Controls.Clear();

            if (!string.IsNullOrWhiteSpace(recurso.Texto))
            {
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
                // Reconstruir ruta absoluta desde ruta relativa
                string rutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                string rutaCompleta = Path.Combine(rutaProyecto, recurso.Ruta);

                var ext = Path.GetExtension(rutaCompleta).ToLower();

                if (ext == ".txt")
                {
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
                MostrarError("No hay contenido disponible.");
            }
        }

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


    }
}
