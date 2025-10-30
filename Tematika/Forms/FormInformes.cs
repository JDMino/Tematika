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
        // Variables para controlar si los gráficos se muestran como torta o barra
        private bool esTortaRecursos = false;
        private bool esTortaInteraccion = false;
        private bool esTortaSuscripciones = false;

        // Servicios para obtener datos de la base de datos o negocio
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

            // Evento que se ejecuta al cargar el formulario
            Load += FormInformes_Load;

            // Evento al cambiar de pestaña
            tabControlInformes.SelectedIndexChanged += TabControlInformes_SelectedIndexChanged;

            // Configuración de botones de alternar gráfico (barra/torta) y exportación
            btnAlternarGraficoRecursos.Click += (s, e) => { esTortaRecursos = !esTortaRecursos; CargarGraficoRecursos(); };
            btnReiniciarFiltroRecurso.Click += reiniciarFiltros;
            btnExportarPDFRecursos.Click += (s, e) => ExportarPDF(chartRecursos, dtInicioRecursos.Value, dtFinRecursos.Value);

            btnAlternarGraficoInteraccion.Click += (s, e) => { esTortaInteraccion = !esTortaInteraccion; CargarGraficoInteraccion(); };
            btnReiniciarFiltroInteraccionTema.Click += reiniciarFiltros;
            btnExportarPDFInteraccion.Click += (s, e) => ExportarPDF(chartInteraccion, dtInicioInteraccion.Value, dtFinInteraccion.Value);

            btnAlternarGraficoSuscripciones.Click += (s, e) => { esTortaSuscripciones = !esTortaSuscripciones; CargarGraficoSuscripciones(); };
            btnReiniciarFiltroSuscripcion.Click += reiniciarFiltros;
            btnExportarPDFSuscripciones.Click += (s, e) => ExportarPDF(chartSuscripciones, dtInicioSuscripciones.Value, dtFinSuscripciones.Value);

            // Eventos para actualizar gráficos al cerrar los DateTimePickers
            dtInicioRecursos.CloseUp += dtInicioRecursos_CloseUp;
            dtFinRecursos.CloseUp += dtFinRecursos_CloseUp;

            dtInicioInteraccion.CloseUp += dtInicioInteraccion_CloseUp;
            dtFinInteraccion.CloseUp += dtFinInteraccion_CloseUp;

            dtInicioSuscripciones.CloseUp += dtInicioSuscripciones_CloseUp;
            dtFinSuscripciones.CloseUp += dtFinSuscripciones_CloseUp;
        }

        // Evento al cargar el formulario
        private void FormInformes_Load(object sender, EventArgs e)
        {
            // Aplica estilo personalizado al encabezado
            AplicarEstiloEncabezado(panelEncabezado, LTituloInformes);

            // Color de fondo del panel
            panel1.BackColor = ColorTranslator.FromHtml("#cfd8dc");

            // Reinicia filtros y carga gráficos
            reiniciarFiltros(null, null);
        }

        // Método para estilizar encabezados de panel
        private void AplicarEstiloEncabezado(Control contenedor, Label titulo)
        {
            contenedor.BackColor = Color.SteelBlue;
            titulo.ForeColor = Color.White;
            titulo.Font = new Font("Ebrima", 16F, FontStyle.Bold);
            titulo.TextAlign = ContentAlignment.MiddleLeft;
            titulo.Dock = DockStyle.Fill;
        }

        // Evento que detecta cambio de pestaña y carga el gráfico correspondiente
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
            // Verifica que las fechas sean válidas
            if (!ComprobarFecha(dtInicioRecursos, dtFinRecursos))
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de fin.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica que el chart esté inicializado
            if (chartRecursos == null)
            {
                MessageBox.Show("chartRecursos no fue inicializado.");
                return;
            }

            // Limpia datos previos del gráfico
            chartRecursos.Series.Clear();
            chartRecursos.ChartAreas.Clear();
            chartRecursos.Titles.Clear();
            chartRecursos.Legends.Clear();

            // Crea un área de gráfico
            chartRecursos.ChartAreas.Add(new ChartArea());

            // Agrega la leyenda al costado derecho
            chartRecursos.Legends.Add(new Legend("Leyenda")
            {
                Docking = Docking.Right,
                Font = new Font("Ebrima", 10, FontStyle.Regular),
                IsDockedInsideChartArea = false
            });

            // Obtiene la lista de recursos
            var recursos = recursoService.ListarRecursos();

            // Obtiene las visitas dentro del rango de fechas y las agrupa por IdRecurso
            var visitas = visitaService.ListarTodas()
                .Where(v => v.FechaHora >= dtInicioRecursos.Value && v.FechaHora <= dtFinRecursos.Value)
                .GroupBy(v => v.IdRecurso)
                .ToDictionary(g => g.Key, g => g.Count());

            // Une los recursos con las visitas, tomando el top 10
            var datos = recursos
                .Where(r => visitas.ContainsKey(r.IdRecurso))
                .Select(r => new { r.Titulo, Cantidad = visitas[r.IdRecurso] })
                .OrderByDescending(v => v.Cantidad)
                .ToList()
                .Take(10);

            // Si no hay datos, muestra mensaje
            if (!datos.Any())
            {
                MessageBox.Show("No hay visitas registradas en el período seleccionado.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crea la serie de datos (barras o torta)
            var serie = new Series("Visitas")
            {
                ChartType = esTortaRecursos ? SeriesChartType.Pie : SeriesChartType.Bar
            };

            // Agrega los puntos al gráfico
            foreach (var v in datos)
            {
                int index = serie.Points.AddXY(v.Titulo, v.Cantidad);
                if (esTortaRecursos)
                {
                    // Muestra porcentaje y texto de leyenda en el gráfico de torta
                    serie.Points[index].Label = "#PERCENT{P0}";
                    serie.Points[index].LegendText = v.Titulo;
                }
            }

            // Agrega la serie al gráfico
            chartRecursos.Series.Add(serie);

            // Agrega el título principal
            chartRecursos.Titles.Add(new Title("TOP 10 - Recursos más consultados", Docking.Top, new Font("Ebrima", 14, FontStyle.Bold), Color.Black));

            // Si no es torta, agrega títulos a los ejes
            if (!esTortaRecursos)
            {
                chartRecursos.ChartAreas[0].AxisY.Title = "Cantidad de visitas";
                chartRecursos.ChartAreas[0].AxisX.Title = "Recursos";
                chartRecursos.ChartAreas[0].AxisY.Maximum = datos.Max(v => v.Cantidad) * 1.2; // deja margen superior
            }
        }



        private void CargarGraficoInteraccion()
        {
            if (!ComprobarFecha(dtInicioInteraccion, dtFinInteraccion))
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de fin.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chartInteraccion == null)
            {
                MessageBox.Show("chartRecursos no fue inicializado.");
                return;
            }

            // Limpieza de componentes del gráfico
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

            // Obtiene temas y recursos
            var temas = temaService.ListarTemas();
            var recursos = recursoService.ListarRecursos();

            // Calcula interacciones por tema
            var interacciones = temas.Select(t =>
            {
                // Obtiene IDs de recursos asociados al tema
                var ids = recursos.Where(r => r.IdTema == t.IdTema).Select(r => r.IdRecurso).ToList();

                // Cuenta comentarios, notas y valoraciones en el rango de fechas
                int comentarios = ids.Sum(id => comentarioService.ListarPorRecurso(id)
                    .Count(c => c.Fecha >= dtInicioInteraccion.Value && c.Fecha <= dtFinInteraccion.Value));
                int notas = notaService.ListarTodas()
                .Where(n => ids.Contains(n.IdRecurso) && n.Fecha >= dtInicioInteraccion.Value && n.Fecha <= dtFinInteraccion.Value)
                .Count();
                int valoraciones = ids.Sum(id => valoracionService.ListarPorRecurso(id)
                    .Count(v => v.Fecha >= dtInicioInteraccion.Value && v.Fecha <= dtFinInteraccion.Value));

                // Devuelve el total por tema
                return new { Tema = t.Nombre, Total = comentarios + notas + valoraciones };
            }).Where(i => i.Total > 0)
            .OrderByDescending(i => i.Total)
            .Take(10)
            .ToList();

            // Si no hay datos, muestra mensaje
            if (!interacciones.Any())
            {
                MessageBox.Show("No hay interacciones registradas en el período seleccionado.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crea serie de gráfico
            var serie = new Series("Interacciones")
            {
                ChartType = esTortaInteraccion ? SeriesChartType.Pie : SeriesChartType.Bar
            };

            // Agrega datos al gráfico
            foreach (var i in interacciones)
            {
                int index = serie.Points.AddXY(i.Tema, i.Total);
                if (esTortaInteraccion)
                {
                    serie.Points[index].Label = "#PERCENT{P0}";
                    serie.Points[index].LegendText = i.Tema;
                }
            }

            // Agrega serie y título
            chartInteraccion.Series.Add(serie);
            chartInteraccion.Titles.Add(new Title("TOP 10 - Interacción por tema", Docking.Top, new Font("Ebrima", 14, FontStyle.Bold), Color.Black));

            // Configura ejes si es gráfico de barras
            if (!esTortaInteraccion)
            {
                chartInteraccion.ChartAreas[0].AxisY.Title = "Cantidad de interacciones";
                chartInteraccion.ChartAreas[0].AxisX.Title = "Temas";
                chartInteraccion.ChartAreas[0].AxisY.Maximum = interacciones.Max(i => i.Total) * 1.2;
            }
        }



        private void CargarGraficoSuscripciones()
        {
            if (!ComprobarFecha(dtInicioSuscripciones, dtFinSuscripciones))
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de fin.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chartSuscripciones == null)
            {
                MessageBox.Show("chartRecursos no fue inicializado.");
                return;
            }

            // Limpieza del gráfico
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

            // Obtiene las suscripciones en el rango de fechas
            var suscripciones = suscripcionService.ObtenerTodas()
                .Where(s => s.FechaInicio >= dtInicioSuscripciones.Value && s.FechaInicio <= dtFinSuscripciones.Value)
                .ToList();

            // Agrupa las suscripciones por tipo
            var agrupadas = suscripciones
                .GroupBy(s => s.Tipo?.Nombre)
                .Select(g => new { Tipo = g.Key ?? "Desconocido", Cantidad = g.Count() })
                .ToList();

            // Si no hay datos
            if (!agrupadas.Any())
            {
                MessageBox.Show("No hay suscripciones registradas en el período seleccionado.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crea la serie de datos
            var serie = new Series("Suscripciones")
            {
                ChartType = esTortaSuscripciones ? SeriesChartType.Pie : SeriesChartType.Bar
            };

            // Agrega los puntos
            foreach (var g in agrupadas)
            {
                int index = serie.Points.AddXY(g.Tipo, g.Cantidad);
                if (esTortaSuscripciones)
                {
                    serie.Points[index].Label = "#PERCENT{P0}";
                    serie.Points[index].LegendText = g.Tipo;
                }
            }

            // Agrega serie y título
            chartSuscripciones.Series.Add(serie);
            chartSuscripciones.Titles.Add(new Title("Suscripciones por tipo", Docking.Top, new Font("Ebrima", 14, FontStyle.Bold), Color.Black));

            // Configura ejes si no es torta
            if (!esTortaSuscripciones)
            {
                chartSuscripciones.ChartAreas[0].AxisY.Title = "Cantidad";
                chartSuscripciones.ChartAreas[0].AxisX.Title = "Tipo de suscripción";
                chartSuscripciones.ChartAreas[0].AxisY.Maximum = agrupadas.Max(g => g.Cantidad) * 1.2;
            }
        }


        private void ExportarPDF(Chart chart, DateTime desde, DateTime hasta)
        {
            // Cuadro de diálogo para guardar PDF
            using var dialog = new SaveFileDialog
            {
                Filter = "Archivo PDF (*.pdf)|*.pdf",
                Title = "Exportar informe a PDF"
            };

            // Si el usuario cancela, se sale
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            // Convierte el gráfico en una imagen
            using var bmp = new Bitmap(chart.Width, chart.Height);
            chart.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            // Guarda la imagen en memoria
            using var ms = new System.IO.MemoryStream();
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            ms.Position = 0;

            // Crea documento PDF
            using var doc = new PdfDocument();
            var page = doc.AddPage();

            // Define tamaño de página según el gráfico
            page.Width = XUnit.FromPoint(bmp.Width);
            page.Height = XUnit.FromPoint(bmp.Height + 40);

            using var gfx = XGraphics.FromPdfPage(page);
            var img = XImage.FromStream(() => ms);

            // Dibuja encabezado con rango de fechas
            var rango = $"Período: {desde:dd/MM/yyyy} al {hasta:dd/MM/yyyy}";
            gfx.DrawString(rango, new XFont("Ebrima", 12, XFontStyle.Bold), XBrushes.Black, new XRect(0, 10, page.Width, 20), XStringFormats.TopCenter);

            // Dibuja la imagen del gráfico
            gfx.DrawImage(img, 0, 40, page.Width, page.Height - 40);

            // Guarda el PDF
            doc.Save(dialog.FileName);

            MessageBox.Show("Informe exportado correctamente.", "Exportación PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panelSuperiorInteraccion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void reiniciarFiltros(object sender, EventArgs e)
        {
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


        private void dtInicioRecursos_CloseUp(object sender, EventArgs e)
        {
            CargarGraficoRecursos();
        }

        private void dtFinRecursos_CloseUp(object sender, EventArgs e)
        {
            CargarGraficoRecursos();
        }

        private void dtInicioInteraccion_CloseUp(object sender, EventArgs e)
        {
            CargarGraficoInteraccion();
        }

        private void dtFinInteraccion_CloseUp(object sender, EventArgs e)
        {
            CargarGraficoInteraccion();
        }

        private void dtInicioSuscripciones_CloseUp(object sender, EventArgs e)
        {
            CargarGraficoSuscripciones();
        }

        private void dtFinSuscripciones_CloseUp(object sender, EventArgs e)
        {
            CargarGraficoSuscripciones();
        }

        private bool ComprobarFecha(DateTimePicker fechaInicio, DateTimePicker fechaFin)
        {
            return fechaInicio.Value <= fechaFin.Value;
        }
    }
}

