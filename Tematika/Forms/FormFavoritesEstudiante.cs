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
        // --- Servicios para acceder a los datos del sistema ---
        private readonly FavoritoService favoritoService = new FavoritoService();  // Maneja las operaciones relacionadas con los recursos marcados como favoritos
        private readonly RecursoService recursoService = new RecursoService();     // Permite obtener información de los recursos educativos
        private readonly TemaService temaService = new TemaService();              // Permite obtener información de los temas de cada materia
        private readonly Usuario? usuario = SesionManager.UsuarioActual;           // Obtiene el usuario actualmente logueado en la sesión

        // --- Constructor del formulario ---
        public FormFavoritesEstudiante()
        {
            InitializeComponent();

            // Asignar eventos a los manejadores correspondientes
            Load += FormFavoritesEstudiante_Load;             // Evento que se ejecuta al cargar el formulario
            DGVFavoritos.CellContentClick += DGVFavoritos_CellContentClick;  // Evento que maneja los clics dentro de la tabla
            DGVFavoritos.ReadOnly = true;
        }

        // --- Evento que se ejecuta cuando el formulario se carga ---
        private void FormFavoritesEstudiante_Load(object sender, EventArgs e)
        {
            // Si no hay un usuario logueado, no se puede continuar
            if (usuario == null)
            {
                MessageBox.Show("No hay sesión activa.");
                return;
            }

            // Obtener listas desde los servicios
            var favoritos = favoritoService.ListarPorUsuario(usuario.IdUsuario);  // Todos los recursos favoritos del usuario
            var recursos = recursoService.ListarRecursos();                       // Lista completa de recursos
            var temas = temaService.ListarTemas();                                // Lista completa de temas

            // Limpiar la tabla antes de cargar los nuevos datos
            DGVFavoritos.Rows.Clear();

            // Recorrer todos los favoritos del usuario
            foreach (var fav in favoritos)
            {
                // Buscar el recurso asociado al favorito
                var recurso = recursos.FirstOrDefault(r => r.IdRecurso == fav.IdRecurso && !r.Eliminado);
                if (recurso == null) continue;  // Si el recurso fue eliminado o no existe, se ignora

                // Obtener el tema al que pertenece el recurso
                var tema = temas.FirstOrDefault(t => t.IdTema == recurso.IdTema);
                string nombreTema = tema?.Nombre ?? "Sin tema";

                // Agregar una nueva fila al DataGridView con los datos del recurso favorito
                int rowIndex = DGVFavoritos.Rows.Add(
                    recurso.Titulo,                           // Título del recurso
                    recurso.Tipo,                             // Tipo de recurso (video, documento, etc.)
                    nombreTema,                               // Tema al que pertenece
                    fav.FechaMarcado.ToShortDateString(),     // Fecha en que se marcó como favorito
                    "Ver",                                   // Botón para visualizar el recurso
                    "Eliminar"                               // Botón para eliminar de favoritos
                );

                // Guardar el objeto Favorito dentro de la fila para poder acceder a él más adelante
                DGVFavoritos.Rows[rowIndex].Tag = fav;
            }
        }

        // --- Evento que se ejecuta cuando se hace clic en una celda del DataGridView ---
        private void DGVFavoritos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que el clic sea dentro de una fila y columna válida
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Obtener la fila seleccionada
            var fila = DGVFavoritos.Rows[e.RowIndex];

            // Recuperar el objeto Favorito almacenado en la propiedad Tag
            var favorito = fila.Tag as Favorito;
            if (favorito == null) return;

            // Obtener el recurso asociado al favorito
            var recurso = recursoService.ObtenerRecurso(favorito.IdRecurso);
            if (recurso == null) return;

            // Determinar qué columna se ha clickeado (Ver o Eliminar)
            var columna = DGVFavoritos.Columns[e.ColumnIndex].Name;

            // --- Si el usuario presionó "Ver" ---
            if (columna == "VerRecurso")
            {
                // Crear y mostrar un formulario visualizador del recurso
                var visualizador = new FormVisualizadorRecurso(recurso);

                // Si el usuario no está logueado, no se registra la visita
                if (!SesionManager.SesionActiva || SesionManager.UsuarioActual == null)
                {
                    MessageBox.Show(
                        "Estás en modo invitado. La visita no será registrada.",
                        "Modo Invitado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    visualizador.Show();
                    return;
                }

                // Registrar la visita del recurso en el historial del usuario
                var visitaService = new VisitaRecursoService();
                var visita = new VisitaRecurso
                {
                    IdUsuario = SesionManager.UsuarioActual.IdUsuario,
                    IdRecurso = recurso.IdRecurso,
                    FechaHora = DateTime.Now
                };

                // Llamar al servicio para registrar la visita y mostrar mensaje si hay error
                var error = visitaService.RegistrarVisita(visita);
                if (error != null)
                    MessageBox.Show(error, "Error al registrar visita", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Mostrar el recurso
                visualizador.Show();
            }
            // --- Si el usuario presionó "Eliminar" ---
            else if (columna == "EliminarFavorito")
            {
                // Confirmar la eliminación antes de proceder
                var confirmacion = MessageBox.Show(
                    "¿Estás seguro de que querés eliminar este recurso de tus favoritos?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

                // Si confirma, eliminar el favorito
                if (confirmacion == DialogResult.Yes)
                {
                    favoritoService.EliminarFavorito(favorito.IdFavorito);
                    MessageBox.Show("Recurso desmarcado como favorito.");

                    // Recargar la lista actualizada de favoritos
                    FormFavoritesEstudiante_Load(null!, null!);
                }
            }
        }
    }
}
