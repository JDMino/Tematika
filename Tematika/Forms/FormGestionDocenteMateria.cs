using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;
using Tematika.Styles;
using Tematika.Utils;

namespace Tematika.Forms
{
    public partial class FormGestionDocenteMateria : Form
    {
        // --- Servicios de la capa de negocio ---
        // Permiten interactuar con la base de datos o la lógica interna
        private readonly DocenteMateriaService _dmService = new DocenteMateriaService();
        private readonly UsuarioService _usuarioService = new UsuarioService();
        private readonly MateriaService _materiaService = new MateriaService();

        // Variable para guardar la asignación seleccionada en el DataGridView
        private int? seleccionActualId = null;

        // --- Constructor del formulario ---
        public FormGestionDocenteMateria()
        {
            InitializeComponent();

            // Asociar los eventos del formulario y los controles
            Load += FormGestionDocenteMateria_Load;
            BGuardarTema.Click += BGuardarTema_Click;
            BEliminarTema.Click += BEliminarTema_Click;
            BCancelarTema.Click += BCancelarTema_Click;
            DGVTemas.CellClick += DGVTemas_CellClick;

            // Filtro en tiempo real por texto para el DataGridView
            TBBuscadorDocente.TextChanged += (s, e) =>
            {
                GridUtils.FiltrarFilasPorTexto(DGVTemas, TBBuscadorDocente.Text);
            };
        }

        // --- Al cargar el formulario ---
        private void FormGestionDocenteMateria_Load(object sender, EventArgs e)
        {
            // Aplica un estilo visual al encabezado
            EstiloEncabezado.Aplicar(panelEncabezadoDM, LTituloDocenteMateria);
            panelDocenteMateria.BackColor = ColorTranslator.FromHtml("#cfd8dc");

            // Carga inicial de datos
            CargarDocentes();
            CargarMaterias();
            CargarAsignaciones();
        }

        // --- Carga la lista de docentes activos ---
        private void CargarDocentes()
        {
            var docentes = _usuarioService.ListarUsuarios()
                .Where(u => u.IdPerfil == 2 && !u.Eliminado) // Solo usuarios con perfil de docente
                .Select(u => new { u.IdUsuario, Nombre = $"{u.Apellido}, {u.Nombre}" })
                .ToList();

            // Enlaza la lista al ComboBox de docentes
            CBDocente.DisplayMember = "Nombre";
            CBDocente.ValueMember = "IdUsuario";
            CBDocente.DataSource = docentes;
        }

        // --- Carga la lista de materias disponibles ---
        private void CargarMaterias()
        {
            var materias = _materiaService.ListarMaterias()
                .Where(m => !m.Eliminado)
                .OrderBy(m => m.Nombre)
                .ToList();

            CBMaterias.DisplayMember = "Nombre";
            CBMaterias.ValueMember = "IdMateria";
            CBMaterias.DataSource = materias;
        }

        // --- Carga todas las asignaciones Docente–Materia ---
        private void CargarAsignaciones()
        {
            //Traer ids de usuarios no eliminados
            var idUsuariosNoEliminados = _usuarioService.ListarUsuarios()
                .Where(u => !u.Eliminado)
                .Select(u => u.IdUsuario);

            ////Traer IDs de materias que no estan eliminadas
            var idMateriasNoEliminadas = _materiaService.ListarMaterias()
                .Where(m => !m.Eliminado)
                .Select(m => m.IdMateria);

            var asignaciones = _dmService.ListarAsignaciones()
                .Where(a => (idUsuariosNoEliminados.Contains(a.IdUsuario))
                            &&
                            (idMateriasNoEliminadas.Contains(a.IdMateria)));
            

            DGVTemas.Rows.Clear();

            foreach (var dm in asignaciones)
            {
                var usuario = _usuarioService.ObtenerUsuario(dm.IdUsuario);
                var materia = _materiaService.ObtenerMateria(dm.IdMateria);

                // Verifica que tanto el usuario como la materia existan antes de mostrar la fila
                if (usuario != null && materia != null)
                {
                    DGVTemas.Rows.Add($"{usuario.Apellido}, {usuario.Nombre}", materia.Nombre);
                }
            }

            // Reinicia la selección y oculta el botón de eliminar
            BEliminarTema.Visible = false;
            seleccionActualId = null;
        }

        // --- Guarda una nueva asignación Docente–Materia ---
        private void BGuardarTema_Click(object sender, EventArgs e)
        {
            // Verifica que todos los campos obligatorios estén completos
            if (!Validaciones.ValidarCamposObligatorios(panelCamposTemas))
                return;

            // Toma los valores seleccionados de los ComboBox
            if (CBDocente.SelectedValue is int idUsuario && CBMaterias.SelectedValue is int idMateria)
            {
                var asignacion = new DocenteMateria
                {
                    IdUsuario = idUsuario,
                    IdMateria = idMateria
                };

                // Intenta registrar la asignación
                var error = _dmService.AsignarDocente(asignacion);
                if (error != null)
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Asignación guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAsignaciones();
            }
        }

        // --- Maneja el clic sobre una fila del DataGridView ---
        private void DGVTemas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = DGVTemas.Rows[e.RowIndex];
            var nombreDocente = fila.Cells["NombreDocente"].Value?.ToString();
            var nombreMateria = fila.Cells["IdMateria"].Value?.ToString();

            // Busca el docente y la materia seleccionados en las listas
            var usuario = _usuarioService.ListarUsuarios()
                .FirstOrDefault(u => $"{u.Apellido}, {u.Nombre}" == nombreDocente);

            var materia = _materiaService.ListarMaterias()
                .FirstOrDefault(m => m.Nombre == nombreMateria);

            // Si ambos existen, los muestra seleccionados en los ComboBox
            if (usuario != null && materia != null)
            {
                CBDocente.SelectedValue = usuario.IdUsuario;
                CBMaterias.SelectedValue = materia.IdMateria;

                // Busca la asignación actual y guarda su Id para posibles acciones (como eliminar)
                var asignacion = _dmService.ListarAsignaciones()
                    .FirstOrDefault(dm => dm.IdUsuario == usuario.IdUsuario && dm.IdMateria == materia.IdMateria);

                seleccionActualId = asignacion?.IdDocenteMateria;
                BEliminarTema.Visible = seleccionActualId != null;
            }
        }

        // --- Elimina la asignación seleccionada ---
        private void BEliminarTema_Click(object sender, EventArgs e)
        {
            if (seleccionActualId == null) return;

            var confirm = MessageBox.Show(
                "¿Eliminar esta asignación?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (confirm == DialogResult.Yes)
            {
                _dmService.EliminarAsignacion(seleccionActualId.Value);
                MessageBox.Show("Asignación eliminada correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAsignaciones();
            }
        }

        // --- Cancela la acción actual y limpia los campos ---
        private void BCancelarTema_Click(object sender, EventArgs e)
        {
            CBDocente.SelectedIndex = 0;
            CBMaterias.SelectedIndex = 0;
            seleccionActualId = null;
            BEliminarTema.Visible = false;
        }

        // --- Evento de pintura del panel (no utilizado, reservado para estilos visuales) ---
        private void panelDocenteMateria_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
