using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;

namespace Tematika.Forms
{
    public partial class FormFavoritesEstudiante : Form
    {
        private readonly FavoritoService favoritoService = new FavoritoService();
        private readonly RecursoService recursoService = new RecursoService();
        private readonly TemaService temaService = new TemaService();
        private readonly Usuario? usuario = SesionManager.UsuarioActual;

        public FormFavoritesEstudiante()
        {
            InitializeComponent();
            Load += FormFavoritesEstudiante_Load;
            DGVFavoritos.CellContentClick += DGVFavoritos_CellContentClick;
        }

        private void FormFavoritesEstudiante_Load(object sender, EventArgs e)
        {
            if (usuario == null)
            {
                MessageBox.Show("No hay sesión activa.");
                return;
            }

            var favoritos = favoritoService.ListarPorUsuario(usuario.IdUsuario);
            var recursos = recursoService.ListarRecursos();
            var temas = temaService.ListarTemas();

            DGVFavoritos.Rows.Clear();

            foreach (var fav in favoritos)
            {
                var recurso = recursos.FirstOrDefault(r => r.IdRecurso == fav.IdRecurso && !r.Eliminado);
                if (recurso == null) continue;

                var tema = temas.FirstOrDefault(t => t.IdTema == recurso.IdTema);
                string nombreTema = tema?.Nombre ?? "Sin tema";

                int rowIndex = DGVFavoritos.Rows.Add(
                    recurso.Titulo,
                    recurso.Tipo,
                    nombreTema,
                    fav.FechaMarcado.ToShortDateString(),
                    "Ver",
                    "Eliminar"
                );

                DGVFavoritos.Rows[rowIndex].Tag = fav; // Guardar favorito para referencia
            }
        }

        private void DGVFavoritos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var fila = DGVFavoritos.Rows[e.RowIndex];
            var favorito = fila.Tag as Favorito;
            if (favorito == null) return;

            var recurso = recursoService.ObtenerRecurso(favorito.IdRecurso);
            if (recurso == null) return;

            var columna = DGVFavoritos.Columns[e.ColumnIndex].Name;

            if (columna == "VerRecurso")
            {
                var visualizador = new FormVisualizadorRecurso(recurso);

                if (!SesionManager.SesionActiva || SesionManager.UsuarioActual == null)
                {
                    MessageBox.Show("Estás en modo invitado. La visita no será registrada.", "Modo Invitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    visualizador.Show();
                    return;
                }

                var visitaService = new VisitaRecursoService();
                var visita = new VisitaRecurso
                {
                    IdUsuario = SesionManager.UsuarioActual.IdUsuario,
                    IdRecurso = recurso.IdRecurso,
                    FechaHora = DateTime.Now
                };

                var error = visitaService.RegistrarVisita(visita);
                if (error != null)
                    MessageBox.Show(error, "Error al registrar visita", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                visualizador.Show();
            }
            else if (columna == "EliminarFavorito")
            {
                var confirmacion = MessageBox.Show(
                    "¿Estás seguro de que querés eliminar este recurso de tus favoritos?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    favoritoService.EliminarFavorito(favorito.IdFavorito);
                    MessageBox.Show("Recurso desmarcado como favorito.");
                    FormFavoritesEstudiante_Load(null!, null!); // Recargar
                }
            }
        }
    }
}