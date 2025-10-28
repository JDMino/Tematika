using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;
using Tematika.Forms.Cards;
using Tematika.Styles;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System.IO;


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
            var total = suscripciones.Count(s => s.Activa != false );
            var mensuales = suscripciones.Count(s => s.Tipo?.Nombre == "Mensual");
            var semestrales = suscripciones.Count(s => s.Tipo?.Nombre == "Semestral");
            var anuales = suscripciones.Count(s => s.Tipo?.Nombre == "Anual");

            var fechaHoy = DateTime.Now;

            // Rango del último mes completo
            var primerDiaUltimoMes = DateTime.Today.AddMonths(-1);
            var ultimoDiaUltimoMes = primerDiaUltimoMes.AddMonths(1).AddDays(-1);

            // Rango del último año completo
            var primerDiaUltimoAnio = DateTime.Today.AddYears(-1);
            var ultimoDiaUltimoAnio = primerDiaUltimoAnio.AddYears(1).AddDays(-1);

            // Ingresos del último mes (solo suscripciones mensuales)
            var ingresosMensuales = suscripciones
                .Where(s => s.Tipo != null
                         && s.Tipo.Nombre == "Mensual"
                         && s.FechaInicio >= primerDiaUltimoMes
                         && s.FechaInicio <= ultimoDiaUltimoMes)
                .Sum(s => s.Tipo!.Precio);

            // Ingresos del último año (todas las suscripciones)
            var ingresosAnuales = suscripciones
                .Where(s => s.Tipo != null
                         && s.FechaInicio >= primerDiaUltimoAnio
                         && s.FechaInicio <= ultimoDiaUltimoAnio)
                .Sum(s => s.Tipo!.Precio);



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

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            using var saveDialog = new SaveFileDialog
            {
                Filter = "Archivo PDF (*.pdf)|*.pdf",
                Title = "Guardar informe de suscripciones",
                FileName = "Suscripciones.pdf"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            var document = new PdfDocument();
            var page = document.AddPage();
            page.Size = PdfSharpCore.PageSize.A4;
            var gfx = XGraphics.FromPdfPage(page);
            var font = new XFont("Verdana", 10, XFontStyle.Regular);
            var boldFont = new XFont("Verdana", 10, XFontStyle.Bold);
            var titleFont = new XFont("Verdana", 14, XFontStyle.Bold);

            double margin = 40;
            double y = margin;
            double lineHeight = 20;
            double pageHeight = page.Height - margin;

            // Título
            gfx.DrawString("Informe de Suscripciones", titleFont, XBrushes.Black, new XRect(0, y, page.Width, lineHeight), XStringFormats.TopCenter);
            y += lineHeight;

            // Fecha de generación
            gfx.DrawString($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm}", font, XBrushes.Black, new XRect(0, y, page.Width, lineHeight), XStringFormats.TopCenter);
            y += lineHeight + 10;

            // Tarjetas resumen
            gfx.DrawString("Resumen de suscripciones:", boldFont, XBrushes.Black, new XPoint(margin, y));
            y += lineHeight;

            int rows = TBCardsSuscripciones.RowCount;
            int cols = TBCardsSuscripciones.ColumnCount;
            double cellWidth = (page.Width - 2 * margin) / cols;

            for (int row = 0; row < rows; row++)
            {
                double xCard = margin;
                for (int col = 0; col < cols; col++)
                {
                    var control = TBCardsSuscripciones.GetControlFromPosition(col, row);
                    if (control is DashboardUserControl1 card)
                    {
                        string titulo = card.TituloCard;
                        string valor = card.InfoCard;

                        gfx.DrawRectangle(XPens.Black, xCard, y, cellWidth, lineHeight * 2);
                        gfx.DrawString(titulo, font, XBrushes.Black, new XRect(xCard + 5, y + 2, cellWidth - 10, lineHeight), XStringFormats.TopLeft);
                        gfx.DrawString(valor, boldFont, XBrushes.Black, new XRect(xCard + 5, y + lineHeight, cellWidth - 10, lineHeight), XStringFormats.TopLeft);
                    }
                    xCard += cellWidth;
                }
                y += lineHeight * 2;

                if (y + lineHeight * 2 > pageHeight)
                {
                    page = document.AddPage();
                    page.Size = PdfSharpCore.PageSize.A4;
                    gfx = XGraphics.FromPdfPage(page);
                    y = margin;
                }
            }

            y += 10;

            // Tabla de suscripciones
            gfx.DrawString("Detalle de suscripciones:", boldFont, XBrushes.Black, new XPoint(margin, y));
            y += lineHeight;

            string[] headers = { "ID", "Usuario", "Activa", "Inicio", "Fin", "Tipo", "Precio" };
            double[] columnWidths = { 40, 120, 50, 70, 70, 80, 60 };
            double xStart = margin;

            // Encabezados
            double xHeader = xStart;
            for (int i = 0; i < headers.Length; i++)
            {
                gfx.DrawRectangle(XPens.Black, xHeader, y, columnWidths[i], lineHeight);
                gfx.DrawString(headers[i], boldFont, XBrushes.Black, new XRect(xHeader + 2, y + 2, columnWidths[i], lineHeight), XStringFormats.TopLeft);
                xHeader += columnWidths[i];
            }

            y += lineHeight;

            // Filas
            foreach (DataGridViewRow row in DGVGestionSuscripciones.Rows)
            {
                if (row.IsNewRow) continue;

                double xRow = xStart;
                string[] values = new string[]
                {
            row.Cells["id_suscripcion"].Value?.ToString() ?? "",
            row.Cells["usuario"].Value?.ToString() ?? "",
            row.Cells["activa"].Value?.ToString() ?? "",
            row.Cells["fecha_inicio"].Value?.ToString() ?? "",
            row.Cells["fecha_fin"].Value?.ToString() ?? "",
            row.Cells["tipo"].Value?.ToString() ?? "",
            row.Cells["Precio"].Value?.ToString() ?? ""
                };

                for (int i = 0; i < values.Length; i++)
                {
                    gfx.DrawRectangle(XPens.Black, xRow, y, columnWidths[i], lineHeight);
                    gfx.DrawString(values[i], font, XBrushes.Black, new XRect(xRow + 2, y + 2, columnWidths[i], lineHeight), XStringFormats.TopLeft);
                    xRow += columnWidths[i];
                }

                y += lineHeight;

                if (y + lineHeight > pageHeight)
                {
                    page = document.AddPage();
                    page.Size = PdfSharpCore.PageSize.A4;
                    gfx = XGraphics.FromPdfPage(page);
                    y = margin;
                }
            }

            using var stream = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write);
            document.Save(stream);
            MessageBox.Show("PDF exportado correctamente.", "Exportación finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
