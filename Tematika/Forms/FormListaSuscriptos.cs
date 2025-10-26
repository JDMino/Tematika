using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;
using Tematika.Forms.Cards;
using Tematika.Styles;

namespace Tematika.Forms
{
    public partial class FormListaSuscriptos : Form
    {
        private readonly SuscripcionService suscripcionService = new SuscripcionService();
        private readonly UsuarioService usuarioService = new UsuarioService();
        private readonly FacturaService facturaService = new FacturaService();
        private readonly DetalleFacturaService detalleService = new DetalleFacturaService();

        public FormListaSuscriptos()
        {
            InitializeComponent();
            Load += FormListaSuscriptos_Load;
            DGVGestionSuscripciones.CellContentClick += DGVGestionSuscripciones_CellContentClick;
            DGVGestionSuscripciones.CellFormatting += DGVGestionSuscripciones_CellFormatting;
        }

        private void FormListaSuscriptos_Load(object sender, EventArgs e)
        {
            EstiloEncabezado.Aplicar(panelEncabezadoS, LTituloSuscripciones);
            panelSuscripcion.BackColor = ColorTranslator.FromHtml("#cfd8dc");

            CargarTarjetas();
            CargarSuscripciones();
        }

        private void CargarTarjetas()
        {
            var suscripciones = suscripcionService.ObtenerTodas();
            var total = suscripciones.Count;
            var mensuales = suscripciones.Count(s => s.Tipo?.Nombre == "Mensual");
            var semestrales = suscripciones.Count(s => s.Tipo?.Nombre == "Semestral");
            var anuales = suscripciones.Count(s => s.Tipo?.Nombre == "Anual");

            var ingresosMensuales = suscripciones
                .Where(s => s.Tipo?.Nombre == "Mensual")
                .Sum(s => s.Tipo?.Precio ?? 0);

            var ingresosAnuales = suscripciones
                .Sum(s => s.Tipo?.Precio ?? 0);

            var tarjetas = new[]
            {
                new DashboardUserControl1 { InfoCard = total.ToString(), TituloCard = "Total Suscripciones", CardBackColor = ColorTranslator.FromHtml("#34495e"), Dock = DockStyle.Fill, Margin = new Padding(10) },
                new DashboardUserControl1 { InfoCard = mensuales.ToString(), TituloCard = "Mensual", CardBackColor = ColorTranslator.FromHtml("#34495e"), Dock = DockStyle.Fill, Margin = new Padding(10) },
                new DashboardUserControl1 { InfoCard = semestrales.ToString(), TituloCard = "Semestral", CardBackColor = ColorTranslator.FromHtml("#34495e"), Dock = DockStyle.Fill, Margin = new Padding(10) },
                new DashboardUserControl1 { InfoCard = anuales.ToString(), TituloCard = "Anual", CardBackColor = ColorTranslator.FromHtml("#34495e"), Dock = DockStyle.Fill, Margin = new Padding(10) },
                new DashboardUserControl1 { InfoCard = $"${ingresosMensuales:0.00}", TituloCard = "Ingresos Mensuales", CardBackColor = ColorTranslator.FromHtml("#34495e"), Dock = DockStyle.Fill, Margin = new Padding(10) },
                new DashboardUserControl1 { InfoCard = $"${ingresosAnuales:0.00}", TituloCard = "Ingresos Anuales", CardBackColor = ColorTranslator.FromHtml("#34495e"), Dock = DockStyle.Fill, Margin = new Padding(10) }
            };

            TBCardsSuscripciones.Controls.Clear();
            int i = 0;
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    TBCardsSuscripciones.Controls.Add(tarjetas[i], col, row);
                    i++;
                }
            }
        }

        private void CargarSuscripciones()
        {
            var suscripciones = suscripcionService.ObtenerTodas()
                .OrderByDescending(s => s.FechaInicio)
                .ToList();

            var usuarios = usuarioService.ListarUsuarios();

            DGVGestionSuscripciones.Rows.Clear();

            foreach (var s in suscripciones)
            {
                var usuario = usuarios.FirstOrDefault(u => u.IdUsuario == s.IdUsuario);
                string nombreCompleto = usuario != null ? $"{usuario.Nombre} {usuario.Apellido}" : "Desconocido";

                DGVGestionSuscripciones.Rows.Add(
                    s.IdSuscripcion,
                    nombreCompleto,
                    s.Activa ? "Sí" : "No",
                    s.FechaInicio.ToString("dd/MM/yyyy"),
                    s.FechaFin?.ToString("dd/MM/yyyy") ?? "-",
                    s.Tipo?.Nombre ?? "",
                    s.Tipo?.Precio.ToString("0.00") ?? "0.00",
                    "Ver factura",
                    "Dar de Baja"
                );
            }
        }

        private void DGVGestionSuscripciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var grid = DGVGestionSuscripciones;
            int idSuscripcion = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["id_suscripcion"].Value);
            string estado = grid.Rows[e.RowIndex].Cells["activa"].Value?.ToString()?.Trim().ToLower() ?? "";
            var usuarioDueño = usuarioService.ObtenerUsuarioPorSuscripcion(idSuscripcion);
            string email = usuarioDueño?.Correo ?? "desconocido@correo.com";

            if (grid.Columns[e.ColumnIndex].Name == "verFactura")
            {
                var factura = facturaService.ObtenerPorSuscripcion(idSuscripcion);
                var detalle = detalleService.ObtenerPorFactura(factura.IdFactura);

                if (usuarioDueño == null)
                {
                    MessageBox.Show("No se encontró el usuario asociado.");
                    return;
                }

                var formFactura = new FormFactura(factura, detalle, usuarioDueño);
                formFactura.Show();
            }

            if (grid.Columns[e.ColumnIndex].Name == "darDeBaja")
            {
                if (estado == "no")
                {
                    MessageBox.Show("La suscripción ya fue dada de baja previamente.", "Operación inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var motivo = PromptMotivoBaja();
                if (motivo == null) return;

                suscripcionService.DarDeBaja(idSuscripcion);
                MessageBox.Show($"La suscripción fue dada de baja.\nSe notificó al usuario por correo: {email}", "Suscripción cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSuscripciones();
            }
        }

        private string? PromptMotivoBaja()
        {
            var prompt = new Form
            {
                Width = 400,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Motivo de baja",
                StartPosition = FormStartPosition.CenterScreen
            };

            var label = new Label { Left = 20, Top = 20, Text = "Ingrese el motivo de baja:", Width = 350 };
            var textBox = new TextBox { Left = 20, Top = 50, Width = 350 };
            var confirm = new Button { Text = "Confirmar", Left = 270, Width = 100, Top = 90, DialogResult = DialogResult.OK };
            prompt.Controls.Add(label);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirm);
            prompt.AcceptButton = confirm;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }

        private void DGVGestionSuscripciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DGVGestionSuscripciones.Columns[e.ColumnIndex].Name == "activa" && e.Value != null)
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
    }
}
