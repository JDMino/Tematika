using System;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;
using Tematika.Styles;
using Tematika.Utils;

namespace Tematika.Forms
{
    public partial class FormGestionTemas : Form
    {
        // Servicios que interactúan con la capa de negocio
        private readonly TemaService _temaService = new TemaService();
        private readonly MateriaService _materiaService = new MateriaService();
        private readonly DocenteMateriaService _docenteMateriaService = new DocenteMateriaService();

        // ID del tema seleccionado actualmente en el DataGridView
        private int? temaSeleccionadoId = null;

        // Indica si se muestran temas activos (true) o inactivos/eliminados (false)
        private bool mostrarActivos = true;

        public FormGestionTemas()
        {
            InitializeComponent();

            // Suscripción de eventos
            Load += FormGestionTemas_Load;
            DGVTemas.CellClick += DGVTemas_CellClick;
            BGuardarTema.Click += BGuardarTema_Click;
            BModificarTema.Click += BModificarTema_Click;
            BEliminarTema.Click += BEliminarTema_Click;
            BCancelarTema.Click += BCancelarTema_Click;
            BTemasActivos.Click += BTemasActivos_Click;
            BTemasInactivos.Click += BTemasInactivos_Click;
            CBFiltroMaterias.SelectedIndexChanged += CBFiltroMaterias_SelectedIndexChanged;

            // Filtro dinámico al escribir en el buscador
            TBBuscadorTema.TextChanged += (s, e) =>
            {
                GridUtils.FiltrarFilasPorTexto(DGVTemas, TBBuscadorTema.Text);
            };

            // Validación para permitir solo letras en el nombre del tema
            TBNombreTema.KeyPress += (s, e) => Validaciones.ValidarSoloLetras(e);
        }

        // Evento que se ejecuta al cargar el formulario
        private void FormGestionTemas_Load(object sender, EventArgs e)
        {
            // Aplica estilo al encabezado del panel
            EstiloEncabezado.Aplicar(panelEncabezadoT, LTituloTemas);

            // Configura el color del panel de temas
            panelTema.BackColor = ColorTranslator.FromHtml("#cfd8dc");

            // Inicializa el combo de "Eliminado"
            CBEliminado.Items.Clear();
            CBEliminado.Items.Add("No");
            CBEliminado.Items.Add("Sí");
            CBEliminado.SelectedIndex = 0;

            // Inicialmente ocultamos la etiqueta y combo de "Eliminado"
            labelEliminado.Visible = false;
            CBEliminado.Visible = false;

            // Carga materias y temas en los combos y DataGridView
            CargarMateriasCombo();
            CargarTemas();
        }

        // Carga las materias disponibles en los combos CBMaterias y CBFiltroMaterias
        private void CargarMateriasCombo()
        {
            // Obtiene todas las materias que no están eliminadas
            var todasMaterias = _materiaService.ListarMaterias()
                .Where(m => !m.Eliminado)
                .OrderBy(m => m.Nombre)
                .ToList();

            // Si el usuario es docente, filtra solo las materias asignadas a él
            if (SesionManager.SesionActiva && SesionManager.UsuarioActual!.IdPerfil == 2)
            {
                var asignaciones = _docenteMateriaService.ListarAsignaciones()
                    .Where(dm => dm.IdUsuario == SesionManager.UsuarioActual.IdUsuario)
                    .Select(dm => dm.IdMateria)
                    .Distinct()
                    .ToList();

                todasMaterias = todasMaterias
                    .Where(m => asignaciones.Contains(m.IdMateria))
                    .ToList();

                // Solo habilita los combos si hay más de una materia asignada
                CBMaterias.Enabled = todasMaterias.Count > 1;
                CBFiltroMaterias.Enabled = todasMaterias.Count > 1;
            }

            // Configura los combos con la lista de materias
            CBMaterias.DisplayMember = "Nombre";
            CBMaterias.ValueMember = "IdMateria";
            CBMaterias.DataSource = todasMaterias;

            CBFiltroMaterias.DisplayMember = "Nombre";
            CBFiltroMaterias.ValueMember = "IdMateria";
            CBFiltroMaterias.DataSource = todasMaterias.ToList();
        }

        // Carga los temas en el DataGridView
        private void CargarTemas()
        {
            //Traer IDs de materias que no estan eliminadas
            var idMateriasNoEliminadas = _materiaService.ListarMaterias()
                .Where(m => !m.Eliminado)
                .Select(m => m.IdMateria);

            // Obtiene los temas según si se muestran activos o eliminados
            var temas = _temaService.ListarTemas()
                .Where(t => t.Eliminado != mostrarActivos &&
                            idMateriasNoEliminadas.Contains(t.IdMateria))
                .ToList();

            // Si es docente, filtra solo los temas de sus materias asignadas
            if (SesionManager.SesionActiva && SesionManager.UsuarioActual!.IdPerfil == 2)
            {
                var asignaciones = _docenteMateriaService.ListarAsignaciones()
                    .Where(dm => dm.IdUsuario == SesionManager.UsuarioActual.IdUsuario)
                    .Select(dm => dm.IdMateria)
                    .Distinct()
                    .ToList();

                temas = temas.Where(t => asignaciones.Contains(t.IdMateria)).ToList();
            }

            // Limpia el DataGridView antes de cargar los temas
            DGVTemas.Rows.Clear();

            // Agrega cada tema al DataGridView mostrando el nombre de la materia asociada
            foreach (var t in temas)
            {
                var materia = _materiaService.ObtenerMateria(t.IdMateria);
                DGVTemas.Rows.Add(t.IdTema, t.Nombre, materia?.Nombre ?? "Sin materia");
            }

            // Ajusta la visibilidad de botones y controles
            BGuardarTema.Visible = true;
            BModificarTema.Visible = false;
            BEliminarTema.Visible = false;
            labelEliminado.Visible = false;
            CBEliminado.Visible = false;
        }

        // Limpia los campos del formulario y reinicia botones/combos
        private void LimpiarCampos()
        {
            TBNombreTema.Clear();
            CBMaterias.SelectedIndex = 0;
            CBEliminado.SelectedIndex = 0;
            temaSeleccionadoId = null;

            BGuardarTema.Visible = true;
            BModificarTema.Visible = false;
            BEliminarTema.Visible = false;
            labelEliminado.Visible = false;
            CBEliminado.Visible = false;
        }

        // Evento para guardar un nuevo tema
        private void BGuardarTema_Click(object sender, EventArgs e)
        {
            // Valida que los campos obligatorios estén completos
            if (!Validaciones.ValidarCamposObligatorios(panelCamposTemas))
                return;

            // Crea el objeto Tema con los datos ingresados
            var tema = new Tema
            {
                Nombre = TBNombreTema.Text,
                IdMateria = (int)CBMaterias.SelectedValue,
                Eliminado = CBEliminado.SelectedItem?.ToString() == "Sí"
            };

            // Intenta guardar el tema y muestra error si falla
            var error = _temaService.CrearTema(tema);
            if (error != null)
            {
                MessageBox.Show(error, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mensaje de éxito y recarga de datos
            MessageBox.Show("Tema guardado correctamente.");
            CargarTemas();
            LimpiarCampos();
        }

        // Evento que se ejecuta al hacer clic en una fila del DataGridView
        private void DGVTemas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora clicks en el encabezado

            var fila = DGVTemas.Rows[e.RowIndex];
            temaSeleccionadoId = Convert.ToInt32(fila.Cells["idTema"].Value); // Obtiene el ID del tema seleccionado

            // Obtiene los datos completos del tema seleccionado
            var tema = _temaService.ObtenerTema(temaSeleccionadoId.Value);
            if (tema == null) return;

            // Carga los datos en los controles del formulario
            TBNombreTema.Text = tema.Nombre;
            CBMaterias.SelectedValue = tema.IdMateria;
            CBEliminado.SelectedItem = tema.Eliminado ? "Sí" : "No";

            // Ajusta la visibilidad de botones según el estado
            BGuardarTema.Visible = false;
            BModificarTema.Visible = true;
            BEliminarTema.Visible = true;
            labelEliminado.Visible = true;
            CBEliminado.Visible = true;

            // Si el tema ya está eliminado, oculta el botón de eliminar
            if (tema.Eliminado)
            {
                BEliminarTema.Visible = false;
            }
        }

        // Evento para modificar un tema existente
        private void BModificarTema_Click(object sender, EventArgs e)
        {

            if (temaSeleccionadoId == null) return;

            // Valida que los campos obligatorios estén completos
            if (!Validaciones.ValidarCamposObligatorios(panelCamposTemas))
                return;

            var tema = new Tema
            {
                IdTema = temaSeleccionadoId.Value,
                Nombre = TBNombreTema.Text,
                IdMateria = (int)CBMaterias.SelectedValue,
                Eliminado = CBEliminado.SelectedItem?.ToString() == "Sí"
            };

            // Intenta actualizar el tema y muestra error si falla
            var error = _temaService.ActualizarTema(tema);
            if (error != null)
            {
                MessageBox.Show(error, "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Tema modificado correctamente.");
            CargarTemas();
            LimpiarCampos();
        }

        // Evento para eliminar un tema
        private void BEliminarTema_Click(object sender, EventArgs e)
        {
            if (temaSeleccionadoId == null)
            {
                MessageBox.Show("Debe seleccionar un tema para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación de eliminación
            var confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este tema?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (confirmacion == DialogResult.Yes)
            {
                _temaService.EliminarTema(temaSeleccionadoId.Value);
                MessageBox.Show("Tema eliminado correctamente.");
                CargarTemas();
                LimpiarCampos();
            }
        }

        // Evento para cancelar la edición o creación de un tema
        private void BCancelarTema_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Mostrar solo temas activos
        private void BTemasActivos_Click(object sender, EventArgs e)
        {
            mostrarActivos = true;
            CargarTemas();
        }

        // Mostrar solo temas inactivos/eliminados
        private void BTemasInactivos_Click(object sender, EventArgs e)
        {
            mostrarActivos = false;
            CargarTemas();
        }

        // Filtra los temas según la materia seleccionada en el combo de filtro
        private void CBFiltroMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFiltroMaterias.SelectedValue is int idMateria)
            {
                var temas = _temaService.ListarTemas()
                    .Where(t => t.IdMateria == idMateria && t.Eliminado != mostrarActivos)
                    .ToList();

                DGVTemas.Rows.Clear();

                foreach (var t in temas)
                {
                    var materia = _materiaService.ObtenerMateria(t.IdMateria);
                    DGVTemas.Rows.Add(t.IdTema, t.Nombre, materia?.Nombre ?? "Sin materia");
                }
            }
        }
    }
}
