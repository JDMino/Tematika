namespace Tematika.Forms
{
    partial class FormInformes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelEncabezado = new FlowLayoutPanel();
            LTituloInformes = new Label();
            panel1 = new Panel();
            tabControlInformes = new TabControl();
            tpRecursosConsultados = new TabPage();
            tpInteraccionTema = new TabPage();
            tpSuscripciones = new TabPage();

            // Recursos
            chartRecursos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnAlternarGraficoRecursos = new Button();
            btnExportarPDFRecursos = new Button();
            btnReiniciarFiltroRecurso = new Button();
            dtInicioRecursos = new DateTimePicker();
            dtFinRecursos = new DateTimePicker();

            // Interacción
            chartInteraccion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnAlternarGraficoInteraccion = new Button();
            btnExportarPDFInteraccion = new Button();
            btnReiniciarFiltroInteraccionTema = new Button();
            dtInicioInteraccion = new DateTimePicker();
            dtFinInteraccion = new DateTimePicker();

            // Suscripciones
            chartSuscripciones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnAlternarGraficoSuscripciones = new Button();
            btnExportarPDFSuscripciones = new Button();
            btnReiniciarFiltroSuscripcion = new Button();
            dtInicioSuscripciones = new DateTimePicker();
            dtFinSuscripciones = new DateTimePicker();

            // Panel encabezado
            panelEncabezado.Controls.Add(LTituloInformes);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Size = new Size(1037, 46);

            LTituloInformes.AutoSize = true;
            LTituloInformes.Font = new Font("Ebrima", 16.2F, FontStyle.Bold);
            LTituloInformes.Text = "Informes y Análisis";

            // Panel principal
            panel1.Dock = DockStyle.Fill;
            panel1.Controls.Add(tabControlInformes);

            // TabControl
            tabControlInformes.Dock = DockStyle.Fill;
            tabControlInformes.Controls.Add(tpRecursosConsultados);
            tabControlInformes.Controls.Add(tpInteraccionTema);
            tabControlInformes.Controls.Add(tpSuscripciones);

            // Tab Recursos
            tpRecursosConsultados.Text = "Recursos más consultados";
            tpRecursosConsultados.Controls.Add(chartRecursos);
            tpRecursosConsultados.Controls.Add(btnAlternarGraficoRecursos);
            tpRecursosConsultados.Controls.Add(btnExportarPDFRecursos);
            tpRecursosConsultados.Controls.Add(btnReiniciarFiltroRecurso);
            tpRecursosConsultados.Controls.Add(dtInicioRecursos);
            tpRecursosConsultados.Controls.Add(dtFinRecursos);

            chartRecursos.Dock = DockStyle.Bottom;
            chartRecursos.Height = 300;

            btnAlternarGraficoRecursos.Text = "Alternar gráfico";
            btnAlternarGraficoRecursos.Location = new Point(20, 20);

            btnExportarPDFRecursos.Text = "Exportar PDF";
            btnExportarPDFRecursos.Location = new Point(150, 20);

            btnReiniciarFiltroRecurso.Text = "Reiniciar filtros";
            btnReiniciarFiltroRecurso.Location = new Point(280, 20);

            dtInicioRecursos.Location = new Point(420, 20);
            dtFinRecursos.Location = new Point(620, 20);

            // Tab Interacción
            tpInteraccionTema.Text = "Interacción por tema";
            tpInteraccionTema.Controls.Add(chartInteraccion);
            tpInteraccionTema.Controls.Add(btnAlternarGraficoInteraccion);
            tpInteraccionTema.Controls.Add(btnExportarPDFInteraccion);
            tpInteraccionTema.Controls.Add(btnReiniciarFiltroInteraccionTema);
            tpInteraccionTema.Controls.Add(dtInicioInteraccion);
            tpInteraccionTema.Controls.Add(dtFinInteraccion);

            chartInteraccion.Dock = DockStyle.Bottom;
            chartInteraccion.Height = 300;

            btnAlternarGraficoInteraccion.Text = "Alternar gráfico";
            btnAlternarGraficoInteraccion.Location = new Point(20, 20);

            btnExportarPDFInteraccion.Text = "Exportar PDF";
            btnExportarPDFInteraccion.Location = new Point(150, 20);

            btnReiniciarFiltroInteraccionTema.Text = "Reiniciar filtros";
            btnReiniciarFiltroInteraccionTema.Location = new Point(280, 20);

            dtInicioInteraccion.Location = new Point(420, 20);
            dtFinInteraccion.Location = new Point(620, 20);

            // Tab Suscripciones
            tpSuscripciones.Text = "Suscripciones";
            tpSuscripciones.Controls.Add(chartSuscripciones);
            tpSuscripciones.Controls.Add(btnAlternarGraficoSuscripciones);
            tpSuscripciones.Controls.Add(btnExportarPDFSuscripciones);
            tpSuscripciones.Controls.Add(btnReiniciarFiltroSuscripcion);
            tpSuscripciones.Controls.Add(dtInicioSuscripciones);
            tpSuscripciones.Controls.Add(dtFinSuscripciones);

            chartSuscripciones.Dock = DockStyle.Bottom;
            chartSuscripciones.Height = 300;

            btnAlternarGraficoSuscripciones.Text = "Alternar gráfico";
            btnAlternarGraficoSuscripciones.Location = new Point(20, 20);

            btnExportarPDFSuscripciones.Text = "Exportar PDF";
            btnExportarPDFSuscripciones.Location = new Point(150, 20);

            btnReiniciarFiltroSuscripcion.Text = "Reiniciar filtros";
            btnReiniciarFiltroSuscripcion.Location = new Point(280, 20);

            dtInicioSuscripciones.Location = new Point(420, 20);
            dtFinSuscripciones.Location = new Point(620, 20);

            // Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 550);
            Controls.Add(panel1);
            Controls.Add(panelEncabezado);
            Name = "FormInformes";
            Text = "Informes";
        }

        #endregion

        private FlowLayoutPanel panelEncabezado;
        private Label LTituloInformes;
        private Panel panel1;
        private TabControl tabControlInformes;
        private TabPage tpRecursosConsultados;
        private TabPage tpInteraccionTema;
        private TabPage tpSuscripciones;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRecursos;
        private Button btnAlternarGraficoRecursos;
        private Button btnExportarPDFRecursos;
        private Button btnReiniciarFiltroRecurso;
        private DateTimePicker dtInicioRecursos;
        private DateTimePicker dtFinRecursos;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartInteraccion;
        private Button btnAlternarGraficoInteraccion;
        private Button btnExportarPDFInteraccion;
        private Button btnReiniciarFiltroInteraccionTema;
        private DateTimePicker dtInicioInteraccion;
        private DateTimePicker dtFinInteraccion;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSuscripciones;
        private Button btnAlternarGraficoSuscripciones;
        private Button btnExportarPDFSuscripciones;
        private Button btnReiniciarFiltroSuscripcion;
        private DateTimePicker dtInicioSuscripciones;
        private DateTimePicker dtFinSuscripciones;
    }
}
