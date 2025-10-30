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
        // --- Servicios de la capa de negocio utilizados para acceder a datos ---
        private readonly SuscripcionService suscripcionService = new SuscripcionService();
        private readonly FacturaService facturaService = new FacturaService();
        private readonly DetalleFacturaService detalleService = new DetalleFacturaService();
        private readonly UsuarioService usuarioService = new UsuarioService();

        public FormDashboardEstudiante()
        {
            InitializeComponent();

            // --- Suscripción de eventos ---
            Load += FormDashboardEstudiante_Load;          // Se ejecuta al cargar el formulario
            BUModificar.Click += BUModificar_Click;        // Botón para modificar datos del estudiante
            //btnSuscribirse.Click += btnSuscribirse_Click; // Botón de suscripción (actualmente deshabilitado)
            dataGridView1.CellContentClick += dataGridView1_CellContentClick; // Clic en las celdas del historial
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;     // Formato visual de las celdas

            // Validaciones de entrada de texto
            TBNombreUsuario.KeyPress += (s, e) => Validaciones.ValidarSoloLetras(e);
            TBApellidoUsuario.KeyPress += (s, e) => Validaciones.ValidarSoloLetras(e);
            TBDNIUsuario.KeyPress += (s, e) => Validaciones.ValidarSoloNumeros(e);
        }

        // --- Evento Load: se ejecuta al iniciar el formulario ---
        private void FormDashboardEstudiante_Load(object sender, EventArgs e)
        {
            // Obtiene el usuario logueado desde el gestor de sesión
            var usuario = SesionManager.UsuarioActual;

            // Solo los usuarios con perfil de estudiante (IdPerfil == 3) pueden acceder
            if (usuario == null || usuario.IdPerfil != 3)
            {
                MessageBox.Show("Acceso no autorizado.");
                Close();
                return;
            }

            // Carga los datos del usuario en los campos de texto
            TBNombreUsuario.Text = usuario.Nombre;
            TBApellidoUsuario.Text = usuario.Apellido;
            TBEmailUsuario.Text = usuario.Correo;
            TBDNIUsuario.Text = usuario.Dni.ToString();
            TBContraseñaUsuario.Text = "";
            RBHombre.Checked = usuario.Sexo == 'm';
            RBMujer.Checked = usuario.Sexo == 'f';

            // Carga el historial de suscripciones en el DataGridView
            CargarHistorialSuscripciones();

            // Habilita o deshabilita el botón de suscripción según el estado actual
            //btnSuscribirse.Enabled = !TieneSuscripcionActiva();
        }

        // --- Carga el historial de suscripciones del estudiante ---
        private void CargarHistorialSuscripciones()
        {
            var usuario = SesionManager.UsuarioActual!;

            // Obtiene las suscripciones del usuario, ordenadas de la más reciente a la más antigua
            var suscripciones = suscripcionService.ObtenerPorUsuario(usuario.IdUsuario)
                .OrderByDescending(s => s.FechaInicio)
                .ToList();

            // Limpia las filas previas del DataGridView
            dataGridView1.Rows.Clear();

            // Agrega cada suscripción a la tabla
            foreach (var s in suscripciones)
            {
                dataGridView1.Rows.Add(
                    s.IdSuscripcion,                           // ID de la suscripción
                    s.Activa ? "Sí" : "No",                   // Estado (activa o no)
                    s.Tipo?.Nombre ?? "",                     // Tipo de suscripción
                    s.FechaInicio.ToString("dd/MM/yyyy"),     // Fecha de inicio
                    s.FechaFin?.ToString("dd/MM/yyyy") ?? "-",// Fecha de fin (o guion si no tiene)
                    "Ver factura"                             // Botón de acción
                );
            }
        }

        // --- Da formato visual a las celdas del DataGridView ---
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Cambia el color de fondo según si la suscripción está activa o no
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Activa" && e.Value != null)
            {
                string estado = e.Value.ToString()?.Trim().ToLower();

                if (estado == "sí")
                {
                    e.CellStyle.BackColor = Color.LightGreen;  // Verde para activas
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (estado == "no")
                {
                    e.CellStyle.BackColor = Color.LightCoral;  // Rojo para inactivas
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }

        // --- Verifica si el estudiante tiene una suscripción activa ---
        private bool TieneSuscripcionActiva()
        {
            var usuario = SesionManager.UsuarioActual!;
            var suscripciones = suscripcionService.ObtenerPorUsuario(usuario.IdUsuario);
            return suscripciones.Any(s => s.Activa); // Retorna true si existe una activa
        }

        // --- Evento para el botón "Suscribirse" (actualmente comentado) ---
        private void btnSuscribirse_Click(object sender, EventArgs e)
        {
            if (TieneSuscripcionActiva())
            {
                MessageBox.Show("Ya tenés una suscripción activa. No es posible suscribirse nuevamente.");
                return;
            }

            // Abre el formulario de suscripción
            var form = new FormSuscripcion();
            form.Show();
        }

        // --- Modificar datos del estudiante ---
        private void BUModificar_Click(object sender, EventArgs e)
        {
            // Obtiene todos los controles de texto dentro del panel de datos (excepto contraseña)
            var controles = panelDatosEstudiante.Controls
                .OfType<Control>()
                .Where(c => c.Name != "TBContraseñaUsuario")
                .ToList();

            // Verifica que los campos obligatorios estén completos
            if (!Validaciones.ValidarControlesObligatorios(controles))
                return;

            // Valida el formato del correo electrónico
            if (!Validaciones.ValidarEmail(TBEmailUsuario.Text))
            {
                MessageBox.Show("El correo electrónico ingresado no tiene un formato válido.");
                TBEmailUsuario.Focus();
                return;
            }

            // Obtiene el usuario actual desde la sesión
            var usuarioActual = SesionManager.UsuarioActual;
            if (usuarioActual == null)
                return;

            // Actualiza los datos del usuario con los valores del formulario
            usuarioActual.Nombre = TBNombreUsuario.Text;
            usuarioActual.Apellido = TBApellidoUsuario.Text;
            usuarioActual.Correo = TBEmailUsuario.Text;
            usuarioActual.Dni = int.Parse(TBDNIUsuario.Text);
            usuarioActual.Sexo = RBHombre.Checked ? 'm' : 'f';

            // Si se ingresó una nueva contraseña, se envía; de lo contrario, se mantiene la actual
            var nuevaContrasena = TBContraseñaUsuario.Text;
            var mensajeError = usuarioService.ActualizarUsuario(
                usuarioActual,
                string.IsNullOrWhiteSpace(nuevaContrasena) ? null : nuevaContrasena
            );

            // Si hubo un error en la actualización, se muestra el mensaje
            if (mensajeError != null)
            {
                MessageBox.Show(mensajeError, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Tus datos han sido actualizados correctamente.");
        }

        // --- Maneja el clic sobre la celda "Ver factura" del historial ---
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignora clics fuera del rango válido o en otras columnas
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridView1.Columns["VerFactura"].Index)
                return;

            // Obtiene el ID de la suscripción seleccionada
            int idSuscripcion = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdSuscripcion"].Value);

            // Recupera la factura y sus detalles desde los servicios
            var factura = facturaService.ObtenerPorSuscripcion(idSuscripcion);
            var detalle = detalleService.ObtenerPorFactura(factura.IdFactura);
            var usuarioDueño = usuarioService.ObtenerUsuario(factura.IdUsuario);

            // Verifica que todos los datos existan
            if (factura == null || detalle == null || usuarioDueño == null)
            {
                MessageBox.Show("No se encontró la factura o el usuario asociado.");
                return;
            }

            // Muestra el formulario de factura con los datos obtenidos
            var formFactura = new FormFactura(factura, detalle, usuarioDueño);
            formFactura.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
