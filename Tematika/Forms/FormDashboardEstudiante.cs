using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;
using Tematika.Utils;

namespace Tematika.Forms
{
    public partial class FormDashboardEstudiante : Form
    {
        private readonly SuscripcionService suscripcionService = new SuscripcionService();
        private readonly FacturaService facturaService = new FacturaService();
        private readonly DetalleFacturaService detalleService = new DetalleFacturaService();
        private readonly UsuarioService usuarioService = new UsuarioService();

        public FormDashboardEstudiante()
        {
            InitializeComponent();
            Load += FormDashboardEstudiante_Load;
            BUModificar.Click += BUModificar_Click;
            //btnSuscribirse.Click += btnSuscribirse_Click;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void FormDashboardEstudiante_Load(object sender, EventArgs e)
        {
            var usuario = SesionManager.UsuarioActual;
            if (usuario == null || usuario.IdPerfil != 3)
            {
                MessageBox.Show("Acceso no autorizado.");
                Close();
                return;
            }

            TBNombreUsuario.Text = usuario.Nombre;
            TBApellidoUsuario.Text = usuario.Apellido;
            TBEmailUsuario.Text = usuario.Correo;
            TBDNIUsuario.Text = usuario.Dni.ToString();
            TBContraseñaUsuario.Text = "";
            RBHombre.Checked = usuario.Sexo == 'm';
            RBMujer.Checked = usuario.Sexo == 'f';

            CargarHistorialSuscripciones();
            //btnSuscribirse.Enabled = !TieneSuscripcionActiva();
        }

        private void CargarHistorialSuscripciones()
        {
            var usuario = SesionManager.UsuarioActual!;
            var suscripciones = suscripcionService.ObtenerPorUsuario(usuario.IdUsuario)
                .OrderByDescending(s => s.FechaInicio)
                .ToList();

            dataGridView1.Rows.Clear();

            foreach (var s in suscripciones)
            {
                dataGridView1.Rows.Add(
                    s.IdSuscripcion,
                    s.Activa ? "Sí" : "No",
                    s.Tipo?.Nombre ?? "",
                    s.FechaInicio.ToString("dd/MM/yyyy"),
                    s.FechaFin?.ToString("dd/MM/yyyy") ?? "-",
                    "Ver factura"
                );
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Activa" && e.Value != null)
            {
                string estado = e.Value.ToString()?.Trim().ToLower();

                if (estado == "sí")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (estado == "no")
                {
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }

        private bool TieneSuscripcionActiva()
        {
            var usuario = SesionManager.UsuarioActual!;
            var suscripciones = suscripcionService.ObtenerPorUsuario(usuario.IdUsuario);
            return suscripciones.Any(s => s.Activa);
        }

        private void btnSuscribirse_Click(object sender, EventArgs e)
        {
            if (TieneSuscripcionActiva())
            {
                MessageBox.Show("Ya tenés una suscripción activa. No es posible suscribirse nuevamente.");
                return;
            }

            var form = new FormSuscripcion();
            form.Show();
        }

        private void BUModificar_Click(object sender, EventArgs e)
        {
            var controles = panelDatosEstudiante.Controls
                .OfType<Control>()
                .Where(c => c.Name != "TBContraseñaUsuario")
                .ToList();

            if (!Validaciones.ValidarControlesObligatorios(controles))
                return;

            var usuarioActual = SesionManager.UsuarioActual;
            if (usuarioActual == null)
                return;

            usuarioActual.Nombre = TBNombreUsuario.Text;
            usuarioActual.Apellido = TBApellidoUsuario.Text;
            usuarioActual.Correo = TBEmailUsuario.Text;
            usuarioActual.Dni = int.Parse(TBDNIUsuario.Text);
            usuarioActual.Sexo = RBHombre.Checked ? 'm' : 'f';

            var nuevaContrasena = TBContraseñaUsuario.Text;
            var mensajeError = usuarioService.ActualizarUsuario(usuarioActual, string.IsNullOrWhiteSpace(nuevaContrasena) ? null : nuevaContrasena);

            if (mensajeError != null)
            {
                MessageBox.Show(mensajeError, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Tus datos han sido actualizados correctamente.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridView1.Columns["VerFactura"].Index)
                return;

            int idSuscripcion = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdSuscripcion"].Value);

            var factura = facturaService.ObtenerPorSuscripcion(idSuscripcion);
            var detalle = detalleService.ObtenerPorFactura(factura.IdFactura);
            var usuarioDueño = usuarioService.ObtenerUsuario(factura.IdUsuario);

            if (factura == null || detalle == null || usuarioDueño == null)
            {
                MessageBox.Show("No se encontró la factura o el usuario asociado.");
                return;
            }

            var formFactura = new FormFactura(factura, detalle, usuarioDueño);
            formFactura.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
