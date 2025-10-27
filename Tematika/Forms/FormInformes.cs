using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using Tematika.CapaDeNegocio;

namespace Tematika.Forms
{
    public partial class FormInformes : Form
    {
        private bool esTortaRecursos = false;
        private bool esTortaInteraccion = false;
        private bool esTortaSuscripciones = false;

        private readonly RecursoService recursoService = new RecursoService();
        private readonly VisitaRecursoService visitaService = new VisitaRecursoService();
        private readonly TemaService temaService = new TemaService();
        private readonly ComentarioService comentarioService = new ComentarioService();
        private readonly NotaService notaService = new NotaService();
        private readonly ValoracionService valoracionService = new ValoracionService();
        private readonly SuscripcionService suscripcionService = new SuscripcionService();

        public FormInformes()
        {
            InitializeComponent();
            Load += FormInformes_Load;
            tabControlInformes.SelectedIndexChanged += TabControlInformes_SelectedIndexChanged;

            btnAlternarGraficoRecursos.Click += (s, e) => { esTortaRecursos = !esTortaRecursos; CargarGraficoRecursos(); };
            btnReiniciarFiltroRecurso.Click += (s, e) => CargarGraficoRecursos();
            btnExportarPDFRecursos.Click += (s, e) => ExportarPDF(chartRecursos, dtInicioRecursos.Value, dtFinRecursos.Value);

            btnAlternarGraficoInteraccion.Click += (s, e) => { esTortaInteraccion = !esTortaInteraccion; CargarGraficoInteraccion(); };
            btnReiniciarFiltroInteraccionTema.Click += (s, e) => CargarGraficoInteraccion();
            btnExportarPDFInteraccion.Click += (s, e) => ExportarPDF(chartInteraccion, dtInicioInteraccion.Value, dtFinInteraccion.Value);

            btnAlternarGraficoSuscripciones.Click += (s, e) => { esTortaSuscripciones = !esTortaSuscripciones; CargarGraficoSuscripciones(); };
            btnReiniciarFiltroSuscripcion.Click += (s, e) => CargarGraficoSuscripciones();
            btnExportarPDFSuscripciones.Click += (s, e) => ExportarPDF(chartSuscripciones, dtInicioSuscripciones.Value, dtFinSuscripciones.Value);
        }


        private void FormInformes_Load(object sender, EventArgs e)
        {
            AplicarEstiloEncabezado(panelEncabezado, LTituloInformes);
            panel1.BackColor = ColorTranslator.FromHtml("#cfd8dc");

            var haceUnAño = DateTime.Now.AddYears(-1);

            dtInicioRecursos.Value = haceUnAño;
            dtFinRecursos.Value = DateTime.Now;

            dtInicioInteraccion.Value = haceUnAño;
            dtFinInteraccion.Value = DateTime.Now;

            dtInicioSuscripciones.Value = haceUnAño;
            dtFinSuscripciones.Value = DateTime.Now;

            esTortaRecursos = false;
            esTortaInteraccion = false;
            esTortaSuscripciones = false;

            CargarGraficoRecursos();
            CargarGraficoInteraccion();
            CargarGraficoSuscripciones();
        }

        private void AplicarEstiloEncabezado(Control contenedor, Label titulo)
        {
            contenedor.BackColor = Color.SteelBlue;
            titulo.ForeColor = Color.White;
            titulo.Font = new Font("Ebrima", 16F, FontStyle.Bold);
            titulo.TextAlign = ContentAlignment.MiddleLeft;
            titulo.Dock = DockStyle.Fill;
        }

        private void TabControlInformes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlInformes.SelectedTab.Name)
            {
                case "tpRecursosConsultados": CargarGraficoRecursos(); break;
                case "tpInteraccionTema": CargarGraficoInteraccion(); break;
                case "tpSuscripciones": CargarGraficoSuscripciones(); break;
            }
        }

        private void CargarGraficoRecursos()
        {
            if (chartRecursos == null)
            {
                MessageBox.Show("chartRecursos no fue inicializado.");
                return;
            }

            chartRecursos.Series.Clear();
            chartRecursos.ChartAreas.Clear();
            chartRecursos.Titles.Clear();
            chartRecursos.Legends.Clear();

            chartRecursos.ChartAreas.Add(new ChartArea());
            chartRecursos.Legends.Add(new Legend("Leyenda")
            {
                Docking = Docking.Right,
                Font = new Font("Ebrima", 10, FontStyle.Regular),
                IsDockedInsideChartArea = false
            });

            var recursos = recursoService.ListarRecursos();
            var visitas = visitaService.ListarTodas()
                .Where(v => v.FechaHora >= dtInicioRecursos.Value && v.FechaHora <= dtFinRecursos.Value)
                .GroupBy(v => v.IdRecurso)
                .ToDictionary(g => g.Key, g => g.Count());

            var datos = recursos
                .Where(r => visitas.ContainsKey(r.IdRecurso))
                .Select(r => new { r.Titulo, Cantidad = visitas[r.IdRecurso] })
                .OrderByDescending(v => v.Cantidad)
                .ToList();

            if (!datos.Any())
            {
                MessageBox.Show("No hay visitas registradas en el período seleccionado.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var serie = new Series("Visitas")
            {
                ChartType = esTortaRecursos ? SeriesChartType.Pie : SeriesChartType.Bar
            };

            foreach (var v in datos)
            {
                int index = serie.Points.AddXY(v.Titulo, v.Cantidad);
                if (esTortaRecursos)
                {
                    serie.Points[index].Label = "#PERCENT{P0}";
                    serie.Points[index].LegendText = v.Titulo;
                }
            }

            chartRecursos.Series.Add(serie);
            chartRecursos.Titles.Add(new Title("Recursos más consultados", Docking.Top, new Font("Ebrima", 14, FontStyle.Bold), Color.Black));

            if (!esTortaRecursos)
            {
                chartRecursos.ChartAreas[0].AxisY.Title = "Cantidad de visitas";
                chartRecursos.ChartAreas[0].AxisX.Title = "Recursos";
                chartRecursos.ChartAreas[0].AxisY.Maximum = datos.Max(v => v.Cantidad) * 1.2;
            }
        }



        private void CargarGraficoInteraccion()
        {
            if (chartInteraccion == null)
            {
                MessageBox.Show("chartRecursos no fue inicializado.");
                return;
            }

            chartInteraccion.Series.Clear();
            chartInteraccion.ChartAreas.Clear();
            chartInteraccion.Titles.Clear();
            chartInteraccion.Legends.Clear();

            chartInteraccion.ChartAreas.Add(new ChartArea());
            chartInteraccion.Legends.Add(new Legend("Leyenda")
            {
                Docking = Docking.Right,
                Font = new Font("Ebrima", 10, FontStyle.Regular),
                IsDockedInsideChartArea = false
            });

            var temas = temaService.ListarTemas();
            var recursos = recursoService.ListarRecursos();

            var interacciones = temas.Select(t =>
            {
                var ids = recursos.Where(r => r.IdTema == t.IdTema).Select(r => r.IdRecurso).ToList();
                int comentarios = ids.Sum(id => comentarioService.ListarPorRecurso(id)
                    .Count(c => c.Fecha >= dtInicioInteraccion.Value && c.Fecha <= dtFinInteraccion.Value));
                int notas = notaService.ListarPorUsuario(0)
                    .Where(n => ids.Contains(n.IdRecurso) &&
                                n.Fecha >= dtInicioInteraccion.Value &&
                                n.Fecha <= dtFinInteraccion.Value).Count();
                int valoraciones = ids.Sum(id => valoracionService.ListarPorRecurso(id)
                    .Count(v => v.Fecha >= dtInicioInteraccion.Value && v.Fecha <= dtFinInteraccion.Value));

                return new { Tema = t.Nombre, Total = comentarios + notas + valoraciones };
            }).Where(i => i.Total > 0).ToList();

            if (!interacciones.Any())
            {
                MessageBox.Show("No hay interacciones registradas en el período seleccionado.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var serie = new Series("Interacciones")
            {
                ChartType = esTortaInteraccion ? SeriesChartType.Pie : SeriesChartType.Bar
            };

            foreach (var i in interacciones)
            {
                int index = serie.Points.AddXY(i.Tema, i.Total);
                if (esTortaInteraccion)
                {
                    serie.Points[index].Label = "#PERCENT{P0}";
                    serie.Points[index].LegendText = i.Tema;
                }
            }

            chartInteraccion.Series.Add(serie);
            chartInteraccion.Titles.Add(new Title("Interacción por tema", Docking.Top, new Font("Ebrima", 14, FontStyle.Bold), Color.Black));

            if (!esTortaInteraccion)
            {
                chartInteraccion.ChartAreas[0].AxisY.Title = "Cantidad de interacciones";
                chartInteraccion.ChartAreas[0].AxisX.Title = "Temas";
                chartInteraccion.ChartAreas[0].AxisY.Maximum = interacciones.Max(i => i.Total) * 1.2;
            }
        }



        private void CargarGraficoSuscripciones()
        {
            if (chartSuscripciones == null)
            {
                MessageBox.Show("chartRecursos no fue inicializado.");
                return;
            }

            chartSuscripciones.Series.Clear();
            chartSuscripciones.ChartAreas.Clear();
            chartSuscripciones.Titles.Clear();
            chartSuscripciones.Legends.Clear();

            chartSuscripciones.ChartAreas.Add(new ChartArea());
            chartSuscripciones.Legends.Add(new Legend("Leyenda")
            {
                Docking = Docking.Right,
                Font = new Font("Ebrima", 10, FontStyle.Regular),
                IsDockedInsideChartArea = false
            });

            var suscripciones = suscripcionService.ObtenerTodas()
                .Where(s => s.FechaInicio >= dtInicioSuscripciones.Value &&
                            s.FechaInicio <= dtFinSuscripciones.Value)
                .ToList();

            var agrupadas = suscripciones
                .GroupBy(s => s.Tipo?.Nombre)
                .Select(g => new { Tipo = g.Key ?? "Desconocido", Cantidad = g.Count() })
                .ToList();

            if (!agrupadas.Any())
            {
                MessageBox.Show("No hay suscripciones registradas en el período seleccionado.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var serie = new Series("Suscripciones")
            {
                ChartType = esTortaSuscripciones ? SeriesChartType.Pie : SeriesChartType.Bar
            };

            foreach (var g in agrupadas)
            {
                int index = serie.Points.AddXY(g.Tipo, g.Cantidad);
                if (esTortaSuscripciones)
                {
                    serie.Points[index].Label = "#PERCENT{P0}";
                    serie.Points[index].LegendText = g.Tipo;
                }
            }

            chartSuscripciones.Series.Add(serie);
            chartSuscripciones.Titles.Add(new Title("Suscripciones por tipo", Docking.Top, new Font("Ebrima", 14, FontStyle.Bold), Color.Black));

            if (!esTortaSuscripciones)
            {
                chartSuscripciones.ChartAreas[0].AxisY.Title = "Cantidad";
                chartSuscripciones.ChartAreas[0].AxisX.Title = "Tipo de suscripción";
                chartSuscripciones.ChartAreas[0].AxisY.Maximum = agrupadas.Max(g => g.Cantidad) * 1.2;
            }
        }


        private void ExportarPDF(Chart chart, DateTime desde, DateTime hasta)
        {
            using var dialog = new SaveFileDialog
            {
                Filter = "Archivo PDF (*.pdf)|*.pdf",
                Title = "Exportar informe a PDF"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            using var bmp = new Bitmap(chart.Width, chart.Height);
            chart.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            using var ms = new System.IO.MemoryStream();
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            ms.Position = 0;

            using var doc = new PdfDocument();
            var page = doc.AddPage();
            page.Width = XUnit.FromPoint(bmp.Width);
            page.Height = XUnit.FromPoint(bmp.Height + 40); // espacio para encabezado

            using var gfx = XGraphics.FromPdfPage(page);
            var img = XImage.FromStream(() => ms);

            // Encabezado con fechas
            var rango = $"Período: {desde:dd/MM/yyyy} al {hasta:dd/MM/yyyy}";
            gfx.DrawString(rango, new XFont("Ebrima", 12, XFontStyle.Bold), XBrushes.Black,
                new XRect(0, 10, page.Width, 20), XStringFormats.TopCenter);

            // Imagen del gráfico
            gfx.DrawImage(img, 0, 40, page.Width, page.Height - 40);

            doc.Save(dialog.FileName);
            MessageBox.Show("Informe exportado correctamente.", "Exportación PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panelSuperiorInteraccion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

