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
        private readonly MateriaService _materiaService = new MateriaService();
        private readonly TemaService _temaService = new TemaService();
        private readonly RecursoService _recursoService = new RecursoService();
        private readonly ValoracionService _valoracionService = new ValoracionService();
        private readonly VisitaRecursoService _visitaService = new VisitaRecursoService();

        public FormExploreResourcesEstudiante()
        {
            InitializeComponent();
        }

        private void FormExploreResourcesEstudiante_Load(object sender, EventArgs e)
        {
            CBMateria.SelectedIndexChanged += CBMateria_SelectedIndexChanged;
            CBTema.SelectedIndexChanged += CBTema_SelectedIndexChanged;

            CargarMaterias();
            CargarRecursos();
        }

        private void CargarMaterias()
        {
            var materias = _materiaService.ListarMaterias()
                .Where(m => !m.Eliminado)
                .OrderBy(m => m.Nombre)
                .ToList();

            CBMateria.DisplayMember = "Nombre";
            CBMateria.ValueMember = "IdMateria";
            CBMateria.DataSource = materias;

            CBMateria.SelectedIndex = -1;
            CBMateria.Text = "Seleccionar materia...";
            CBTema.DataSource = null;
            CBTema.Text = "Seleccionar tema...";
        }

        private void CBMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBMateria.SelectedValue is int idMateria)
            {
                var temas = _temaService.ListarTemas()
                    .Where(t => t.IdMateria == idMateria && !t.Eliminado)
                    .OrderBy(t => t.Nombre)
                    .ToList();

                CBTema.DisplayMember = "Nombre";
                CBTema.ValueMember = "IdTema";
                CBTema.DataSource = temas;
                CBTema.SelectedIndex = -1;
                CBTema.Text = "Seleccionar tema...";
            }

            CargarRecursos();
        }

        private void CBTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarRecursos();
        }

        private void CargarRecursos()
        {
            flpRecursos.Controls.Clear();

            var recursos = _recursoService.ListarRecursos()
                .Where(r => !r.Eliminado)
                .ToList();

            if (CBMateria.SelectedValue is int idMateria && CBTema.SelectedValue is int idTema)
            {
                recursos = recursos.Where(r => r.IdTema == idTema).ToList();
            }

            foreach (var recurso in recursos)
            {
                int cantidadVisitas = _visitaService.ContarVisitas(recurso.IdRecurso);
                var valoraciones = _valoracionService.ListarPorRecurso(recurso.IdRecurso);
                var promedio = valoraciones.Any() ? valoraciones.Average(v => v.Puntuacion) : (double?)null;

                var card = new RecursoCard();
                card.SetDatos(recurso, cantidadVisitas, promedio);
                flpRecursos.Controls.Add(card);
            }
        }

    }
}
