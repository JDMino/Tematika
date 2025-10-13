using System;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Forms;
using Tematika.Models;

namespace Tematika.Forms.Cards
{
    public partial class RecursoCard : UserControl
    {
        private Recurso? recursoActual;

        public RecursoCard()
        {
            InitializeComponent();
        }

        private void RecursoCard_Load(object sender, EventArgs e)
        {
            // Estilos opcionales
        }

        public void SetDatos(Recurso recurso, int cantidadVisitas, double? promedioValoracion)
        {
            recursoActual = recurso;

            labelTituloCard.Text = recurso.Titulo;
            labelTipoRecurso.Text = recurso.Tipo;
            labelTemaRecurso.Text = $"Tema: {recurso.IdTema}";
            labelVisitasRecurso.Text = $"Visitas: {(cantidadVisitas > 0 ? cantidadVisitas.ToString() : "Sin datos")}";
            labelValoracionRecurso.Text = $"Valoración: {(promedioValoracion.HasValue ? promedioValoracion.Value.ToString("0.0") : "Sin datos")}";
        }

        private void buttonVerRecurso_Click(object sender, EventArgs e)
        {
            if (recursoActual == null) return;

            var visualizador = new FormVisualizadorRecurso(recursoActual);

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
                IdRecurso = recursoActual.IdRecurso,
                FechaHora = DateTime.Now
            };

            var error = visitaService.RegistrarVisita(visita);
            if (error != null)
            {
                MessageBox.Show(error, "Error al registrar visita", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            visualizador.Show();
        }
    }
}
