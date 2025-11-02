using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;
using Tematika.Forms.Cards;

namespace Tematika.Forms
{
    public partial class FormExploreResourcesEstudiante : Form
    {
        //Instancias de servicios de la capa de negocio
        // Cada servicio maneja una entidad diferente (Materia, Tema, Recurso, etc.)
        private readonly MateriaService _materiaService = new MateriaService();
        private readonly TemaService _temaService = new TemaService();
        private readonly RecursoService _recursoService = new RecursoService();
        private readonly ValoracionService _valoracionService = new ValoracionService();
        private readonly VisitaRecursoService _visitaService = new VisitaRecursoService();

        public FormExploreResourcesEstudiante()
        {
            InitializeComponent();
        }

        //Evento que se ejecuta al cargar el formulario
        private void FormExploreResourcesEstudiante_Load(object sender, EventArgs e)
        {
            // Se asocian los eventos de los ComboBox para detectar cuando cambian
            CBMateria.SelectedIndexChanged += CBMateria_SelectedIndexChanged;
            CBTema.SelectedIndexChanged += CBTema_SelectedIndexChanged;

            // Carga inicial de las materias y de los recursos
            CargarMaterias();
            CargarRecursos();
        }

        //Carga las materias disponibles en el ComboBox
        private void CargarMaterias()
        {
            // Obtiene todas las materias activas (no eliminadas)
            var materias = _materiaService.ListarMaterias()
                .Where(m => !m.Eliminado)
                .OrderBy(m => m.Nombre)
                .ToList();

            // Configura el ComboBox de materias
            CBMateria.DisplayMember = "Nombre";   // Propiedad que se muestra
            CBMateria.ValueMember = "IdMateria";  // Valor interno (clave)
            CBMateria.DataSource = materias;      // Fuente de datos

            // Establece un estado inicial del ComboBox (sin selección)
            CBMateria.SelectedIndex = -1;
            CBMateria.Text = "Seleccionar materia...";

            // Limpia el ComboBox de temas hasta que se seleccione una materia
            CBTema.DataSource = null;
            CBTema.Text = "Seleccionar tema...";
        }

        //Evento que se dispara cuando cambia la materia seleccionada
        private void CBMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si hay una materia seleccionada, se cargan sus temas asociados
            if (CBMateria.SelectedValue is int idMateria)
            {
                // Filtra los temas por materia y excluye los eliminados
                var temas = _temaService.ListarTemas()
                    .Where(t => t.IdMateria == idMateria && !t.Eliminado)
                    .OrderBy(t => t.Nombre)
                    .ToList();

                // Configura el ComboBox de temas
                CBTema.DisplayMember = "Nombre";
                CBTema.ValueMember = "IdTema";
                CBTema.DataSource = temas;

                CBTema.SelectedIndex = -1;
                CBTema.Text = "Seleccionar tema...";
            }

            // Cada vez que cambia la materia, se recargan los recursos mostrados
            CargarRecursos();
        }

        //Evento que se dispara cuando cambia el tema seleccionado
        private void CBTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Recarga los recursos al cambiar de tema
            CargarRecursos();
        }

        //Carga los recursos educativos en el contenedor (FlowLayoutPanel)
        private void CargarRecursos()
        {
            // Limpia todos los recursos mostrados previamente
            flpRecursos.Controls.Clear();

            //Traer ids de materias no eliminados
            var idMateriasNoEliminadas = _materiaService.ListarMaterias()
                .Where(m => !m.Eliminado)
                .Select(m => m.IdMateria);

            //Traer ids de temas no eliminados
            var idTemasNoEliminados = _temaService.ListarTemas()
                .Where(t => !t.Eliminado &&
                        idMateriasNoEliminadas.Contains(t.IdMateria))
                .Select(t => t.IdTema);

            // Obtiene la lista de recursos activos (no eliminados)
            var recursos = _recursoService.ListarRecursos()
                .Where(r => !r.Eliminado &&
                        idTemasNoEliminados.Contains(r.IdTema))
                .ToList();

            // Si hay una materia y un tema seleccionados, filtra los recursos
            if (CBMateria.SelectedValue is int idMateria && CBTema.SelectedValue is int idTema)
            {
                recursos = recursos
                    .Where(r => r.IdTema == idTema) // Filtra por tema seleccionado
                    .ToList();
            }

            // Recorre cada recurso para crear su "tarjeta" visual
            foreach (var recurso in recursos)
            {
                //Obtiene información complementaria
                int cantidadVisitas = _visitaService.ContarVisitas(recurso.IdRecurso); // Cuántas veces fue visto
                var valoraciones = _valoracionService.ListarPorRecurso(recurso.IdRecurso); // Valoraciones de usuarios
                var promedio = valoraciones.Any() ? valoraciones.Average(v => v.Puntuacion) : (double?)null;

                //Crea y configura la tarjeta visual del recurso
                var card = new RecursoCard();
                card.SetDatos(recurso, cantidadVisitas, promedio); // Asigna los datos al control

                // Agrega la tarjeta al contenedor de recursos
                flpRecursos.Controls.Add(card);
            }
        }
    }
}
