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
        private readonly Usuario usuario = SesionManager.UsuarioActual!;

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

            // Favorito
            var favoritos = favoritoService.ListarPorUsuario(usuario.IdUsuario);
            var favorito = favoritos.FirstOrDefault(f => f.IdRecurso == recurso.IdRecurso);
            btnMarcarFavorito.Text = favorito != null ? "Desmarcar como Favorito" : "Marcar como Favorito";

            // Valoración
            var valoraciones = valoracionService.ListarPorRecurso(recurso.IdRecurso);
            var propia = valoraciones.FirstOrDefault(v => v.IdUsuario == usuario.IdUsuario);
            comboBox1.SelectedItem = propia?.Puntuacion.ToString();

            // Comentarios
            var comentarios = comentarioService.ListarPorRecurso(recurso.IdRecurso);
            DGVComentariosRecursos.Rows.Clear();
            foreach (var c in comentarios)
            {
                var nombre = "Usuario " + c.IdUsuario; // O usar UsuarioService si querés mostrar nombre real
                DGVComentariosRecursos.Rows.Add(c.Fecha.ToShortDateString(), nombre, c.Texto);
            }
        }

        private void btnMarcarFavorito_Click(object sender, EventArgs e)
        {
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
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una puntuación.");
                return;
            }

            int puntuacion = int.Parse(comboBox1.SelectedItem.ToString()!);
            var valoraciones = valoracionService.ListarPorRecurso(recurso.IdRecurso);
            var propia = valoraciones.FirstOrDefault(v => v.IdUsuario == usuario.IdUsuario);

            if (propia != null)
            {
                propia.Puntuacion = puntuacion;
                propia.Fecha = DateTime.Now;
                valoracionService.RegistrarValoracion(propia);
                MessageBox.Show("Valoración actualizada.");
            }
            else
            {
                var nueva = new Valoracion
                {
                    IdUsuario = usuario.IdUsuario,
                    IdRecurso = recurso.IdRecurso,
                    Puntuacion = puntuacion,
                    Fecha = DateTime.Now
                };
                valoracionService.RegistrarValoracion(nueva);
                MessageBox.Show("Valoración registrada.");
            }
        }

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
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
            var comentario = new Comentario
            {
                IdUsuario = usuario.IdUsuario,
                IdRecurso = recurso.IdRecurso,
                Texto = textBox2.Text,
                Fecha = DateTime.Now
            };

            comentarioService.CrearComentario(comentario);
            MessageBox.Show("Comentario enviado.");
        }
    }
}
