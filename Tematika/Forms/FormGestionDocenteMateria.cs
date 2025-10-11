using System;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;

namespace Tematika.Forms
{
    public partial class FormGestionDocenteMateria : Form
    {
        private readonly DocenteMateriaService _dmService = new DocenteMateriaService();
        private readonly UsuarioService _usuarioService = new UsuarioService();
        private readonly MateriaService _materiaService = new MateriaService();
        private int? seleccionActualId = null;

        public FormGestionDocenteMateria()
        {
            InitializeComponent();
            Load += FormGestionDocenteMateria_Load;
            BGuardarTema.Click += BGuardarTema_Click;
            BEliminarTema.Click += BEliminarTema_Click;
            BCancelarTema.Click += BCancelarTema_Click;
            DGVTemas.CellClick += DGVTemas_CellClick;
        }

        private void FormGestionDocenteMateria_Load(object sender, EventArgs e)
        {
            CargarDocentes();
            CargarMaterias();
            CargarAsignaciones();
        }

        private void CargarDocentes()
        {
            var docentes = _usuarioService.ListarUsuarios()
                .Where(u => u.IdPerfil == 2 && !u.Eliminado)
                .Select(u => new { u.IdUsuario, Nombre = $"{u.Apellido}, {u.Nombre}" })
                .ToList();

            CBDocente.DisplayMember = "Nombre";
            CBDocente.ValueMember = "IdUsuario";
            CBDocente.DataSource = docentes;
        }

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

        private void CargarAsignaciones()
        {
            var asignaciones = _dmService.ListarAsignaciones();
            DGVTemas.Rows.Clear();

            foreach (var dm in asignaciones)
            {
                var usuario = _usuarioService.ObtenerUsuario(dm.IdUsuario);
                var materia = _materiaService.ObtenerMateria(dm.IdMateria);

                if (usuario != null && materia != null)
                {
                    DGVTemas.Rows.Add($"{usuario.Apellido}, {usuario.Nombre}", materia.Nombre);
                }
            }

            BEliminarTema.Visible = false;
            seleccionActualId = null;
        }

        private void BGuardarTema_Click(object sender, EventArgs e)
        {
            if (CBDocente.SelectedValue is int idUsuario && CBMaterias.SelectedValue is int idMateria)
            {
                var asignacion = new DocenteMateria
                {
                    IdUsuario = idUsuario,
                    IdMateria = idMateria
                };

                var error = _dmService.AsignarDocente(asignacion);
                if (error != null)
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Asignación guardada correctamente.");
                CargarAsignaciones();
            }
        }

        private void DGVTemas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = DGVTemas.Rows[e.RowIndex];
            var nombreDocente = fila.Cells["NombreDocente"].Value?.ToString();
            var nombreMateria = fila.Cells["IdMateria"].Value?.ToString();

            var usuario = _usuarioService.ListarUsuarios()
                .FirstOrDefault(u => $"{u.Apellido}, {u.Nombre}" == nombreDocente);

            var materia = _materiaService.ListarMaterias()
                .FirstOrDefault(m => m.Nombre == nombreMateria);

            if (usuario != null && materia != null)
            {
                CBDocente.SelectedValue = usuario.IdUsuario;
                CBMaterias.SelectedValue = materia.IdMateria;

                var asignacion = _dmService.ListarAsignaciones()
                    .FirstOrDefault(dm => dm.IdUsuario == usuario.IdUsuario && dm.IdMateria == materia.IdMateria);

                seleccionActualId = asignacion?.IdDocenteMateria;
                BEliminarTema.Visible = seleccionActualId != null;
            }
        }

        private void BEliminarTema_Click(object sender, EventArgs e)
        {
            if (seleccionActualId == null) return;

            var confirm = MessageBox.Show("¿Eliminar esta asignación?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _dmService.EliminarAsignacion(seleccionActualId.Value);
                MessageBox.Show("Asignación eliminada.");
                CargarAsignaciones();
            }
        }

        private void BCancelarTema_Click(object sender, EventArgs e)
        {
            CBDocente.SelectedIndex = 0;
            CBMaterias.SelectedIndex = 0;
            seleccionActualId = null;
            BEliminarTema.Visible = false;
        }

        private void panelDocenteMateria_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

