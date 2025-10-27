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
            panelEncabezado = new FlowLayoutPanel();
            LTituloInformes = new Label();
            panel1 = new Panel();
            tabControlInformes = new TabControl();
            tpRecursosConsultados = new TabPage();
            panelInferiorRecursos = new Panel();
            chartRecursos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelSuperiorRecursos = new Panel();
            btnAlternarGraficoRecursos = new Button();
            btnExportarPDFRecursos = new Button();
            btnReiniciarFiltroRecurso = new Button();
            lblInicioRecursos = new Label();
            dtInicioRecursos = new DateTimePicker();
            lblFinRecursos = new Label();
            dtFinRecursos = new DateTimePicker();
            lblDescripcionRecursos = new Label();
            tpInteraccionTema = new TabPage();
            panelInferiorInteraccion = new Panel();
            chartInteraccion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelSuperiorInteraccion = new Panel();
            btnAlternarGraficoInteraccion = new Button();
            btnExportarPDFInteraccion = new Button();
            btnReiniciarFiltroInteraccionTema = new Button();
            lblInicioInteraccion = new Label();
            dtInicioInteraccion = new DateTimePicker();
            lblFinInteraccion = new Label();
            dtFinInteraccion = new DateTimePicker();
            lblDescripcionInteraccion = new Label();
            tpSuscripciones = new TabPage();
            panelInferiorSuscripciones = new Panel();
            chartSuscripciones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelSuperiorSuscripciones = new Panel();
            btnAlternarGraficoSuscripciones = new Button();
            btnExportarPDFSuscripciones = new Button();
            btnReiniciarFiltroSuscripcion = new Button();
            lblInicioSuscripciones = new Label();
            dtInicioSuscripciones = new DateTimePicker();
            lblFinSuscripciones = new Label();
            dtFinSuscripciones = new DateTimePicker();
            lblDescripcionSuscripciones = new Label();
            panelEncabezado.SuspendLayout();
            panel1.SuspendLayout();
            tabControlInformes.SuspendLayout();
            tpRecursosConsultados.SuspendLayout();
            panelSuperiorRecursos.SuspendLayout();
            tpInteraccionTema.SuspendLayout();
            panelSuperiorInteraccion.SuspendLayout();
            tpSuscripciones.SuspendLayout();
            panelSuperiorSuscripciones.SuspendLayout();
            SuspendLayout();
            // 
            // panelEncabezado
            // 
            panelEncabezado.Controls.Add(LTituloInformes);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(1037, 46);
            panelEncabezado.TabIndex = 1;
            // 
            // LTituloInformes
            // 
            LTituloInformes.AutoSize = true;
            LTituloInformes.Font = new Font("Ebrima", 16.2F, FontStyle.Bold);
            LTituloInformes.Location = new Point(3, 0);
            LTituloInformes.Name = "LTituloInformes";
            LTituloInformes.Size = new Size(207, 30);
            LTituloInformes.TabIndex = 0;
            LTituloInformes.Text = "Informes y Análisis";
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControlInformes);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 504);
            panel1.TabIndex = 0;
            // 
            // tabControlInformes
            // 
            tabControlInformes.Controls.Add(tpRecursosConsultados);
            tabControlInformes.Controls.Add(tpInteraccionTema);
            tabControlInformes.Controls.Add(tpSuscripciones);
            tabControlInformes.Dock = DockStyle.Fill;
            tabControlInformes.Location = new Point(0, 0);
            tabControlInformes.Name = "tabControlInformes";
            tabControlInformes.SelectedIndex = 0;
            tabControlInformes.Size = new Size(1037, 504);
            tabControlInformes.TabIndex = 0;
            // 
            // tpRecursosConsultados
            // 
            tpRecursosConsultados.Controls.Add(panelInferiorRecursos);
            tpRecursosConsultados.Controls.Add(panelSuperiorRecursos);
            tpRecursosConsultados.Location = new Point(4, 24);
            tpRecursosConsultados.Name = "tpRecursosConsultados";
            tpRecursosConsultados.Size = new Size(1029, 476);
            tpRecursosConsultados.TabIndex = 0;
            tpRecursosConsultados.Text = "Recursos más consultados";
            // 
            // panelInferiorRecursos
            // 
            panelInferiorRecursos.Dock = DockStyle.Fill;
            chartRecursos.Dock = DockStyle.Fill;
            panelInferiorRecursos.Controls.Add(chartRecursos);

            panelInferiorRecursos.Location = new Point(0, 120);
            panelInferiorRecursos.Name = "panelInferiorRecursos";
            panelInferiorRecursos.Size = new Size(1029, 356);
            panelInferiorRecursos.TabIndex = 0;
            // 
            // panelSuperiorRecursos
            // 
            panelSuperiorRecursos.Controls.Add(btnAlternarGraficoRecursos);
            panelSuperiorRecursos.Controls.Add(btnExportarPDFRecursos);
            panelSuperiorRecursos.Controls.Add(btnReiniciarFiltroRecurso);
            panelSuperiorRecursos.Controls.Add(lblInicioRecursos);
            panelSuperiorRecursos.Controls.Add(dtInicioRecursos);
            panelSuperiorRecursos.Controls.Add(lblFinRecursos);
            panelSuperiorRecursos.Controls.Add(dtFinRecursos);
            panelSuperiorRecursos.Controls.Add(lblDescripcionRecursos);
            panelSuperiorRecursos.Dock = DockStyle.Top;
            panelSuperiorRecursos.Location = new Point(0, 0);
            panelSuperiorRecursos.Name = "panelSuperiorRecursos";
            panelSuperiorRecursos.Size = new Size(1029, 120);
            panelSuperiorRecursos.TabIndex = 1;
            // 
            // btnAlternarGraficoRecursos
            // 
            btnAlternarGraficoRecursos.Location = new Point(20, 10);
            btnAlternarGraficoRecursos.Name = "btnAlternarGraficoRecursos";
            btnAlternarGraficoRecursos.Size = new Size(130, 35);
            btnAlternarGraficoRecursos.TabIndex = 0;
            btnAlternarGraficoRecursos.Text = "Alternar gráfico";
            // 
            // btnExportarPDFRecursos
            // 
            btnExportarPDFRecursos.Location = new Point(160, 10);
            btnExportarPDFRecursos.Name = "btnExportarPDFRecursos";
            btnExportarPDFRecursos.Size = new Size(130, 35);
            btnExportarPDFRecursos.TabIndex = 1;
            btnExportarPDFRecursos.Text = "Exportar PDF";
            // 
            // btnReiniciarFiltroRecurso
            // 
            btnReiniciarFiltroRecurso.Location = new Point(300, 10);
            btnReiniciarFiltroRecurso.Name = "btnReiniciarFiltroRecurso";
            btnReiniciarFiltroRecurso.Size = new Size(130, 35);
            btnReiniciarFiltroRecurso.TabIndex = 2;
            btnReiniciarFiltroRecurso.Text = "Reiniciar filtros";
            // 
            // lblInicioRecursos
            // 
            lblInicioRecursos.Location = new Point(20, 55);
            lblInicioRecursos.Name = "lblInicioRecursos";
            lblInicioRecursos.Size = new Size(100, 20);
            lblInicioRecursos.TabIndex = 3;
            lblInicioRecursos.Text = "Fecha inicio:";
            // 
            // dtInicioRecursos
            // 
            dtInicioRecursos.Location = new Point(120, 50);
            dtInicioRecursos.Name = "dtInicioRecursos";
            dtInicioRecursos.Size = new Size(200, 23);
            dtInicioRecursos.TabIndex = 4;
            // 
            // lblFinRecursos
            // 
            lblFinRecursos.Location = new Point(340, 55);
            lblFinRecursos.Name = "lblFinRecursos";
            lblFinRecursos.Size = new Size(100, 20);
            lblFinRecursos.TabIndex = 5;
            lblFinRecursos.Text = "Fecha fin:";
            // 
            // dtFinRecursos
            // 
            dtFinRecursos.Location = new Point(440, 50);
            dtFinRecursos.Name = "dtFinRecursos";
            dtFinRecursos.Size = new Size(200, 23);
            dtFinRecursos.TabIndex = 6;
            // 
            // lblDescripcionRecursos
            // 
            lblDescripcionRecursos.Location = new Point(20, 85);
            lblDescripcionRecursos.Name = "lblDescripcionRecursos";
            lblDescripcionRecursos.Size = new Size(800, 30);
            lblDescripcionRecursos.TabIndex = 7;
            lblDescripcionRecursos.Text = "Este gráfico muestra la cantidad total de visitas por recurso en el período seleccionado.";
            // 
            // tpInteraccionTema
            // 
            tpInteraccionTema.Controls.Add(panelInferiorInteraccion);
            tpInteraccionTema.Controls.Add(panelSuperiorInteraccion);
            tpInteraccionTema.Location = new Point(4, 24);
            tpInteraccionTema.Name = "tpInteraccionTema";
            tpInteraccionTema.Size = new Size(1029, 476);
            tpInteraccionTema.TabIndex = 1;
            tpInteraccionTema.Text = "Interacción por tema";
            // 
            // panelInferiorInteraccion
            // 
            panelInferiorInteraccion.Dock = DockStyle.Fill;
            chartInteraccion.Dock = DockStyle.Fill;
            panelInferiorInteraccion.Controls.Add(chartInteraccion);

            panelInferiorInteraccion.Location = new Point(0, 120);
            panelInferiorInteraccion.Name = "panelInferiorInteraccion";
            panelInferiorInteraccion.Size = new Size(1029, 356);
            panelInferiorInteraccion.TabIndex = 0;
            // 
            // panelSuperiorInteraccion
            // 
            panelSuperiorInteraccion.Controls.Add(btnAlternarGraficoInteraccion);
            panelSuperiorInteraccion.Controls.Add(btnExportarPDFInteraccion);
            panelSuperiorInteraccion.Controls.Add(btnReiniciarFiltroInteraccionTema);
            panelSuperiorInteraccion.Controls.Add(lblInicioInteraccion);
            panelSuperiorInteraccion.Controls.Add(dtInicioInteraccion);
            panelSuperiorInteraccion.Controls.Add(lblFinInteraccion);
            panelSuperiorInteraccion.Controls.Add(dtFinInteraccion);
            panelSuperiorInteraccion.Controls.Add(lblDescripcionInteraccion);
            panelSuperiorInteraccion.Dock = DockStyle.Top;
            panelSuperiorInteraccion.Location = new Point(0, 0);
            panelSuperiorInteraccion.Name = "panelSuperiorInteraccion";
            panelSuperiorInteraccion.Size = new Size(1029, 120);
            panelSuperiorInteraccion.TabIndex = 1;
            // 
            // btnAlternarGraficoInteraccion
            // 
            btnAlternarGraficoInteraccion.Location = new Point(20, 10);
            btnAlternarGraficoInteraccion.Name = "btnAlternarGraficoInteraccion";
            btnAlternarGraficoInteraccion.Size = new Size(130, 35);
            btnAlternarGraficoInteraccion.TabIndex = 0;
            btnAlternarGraficoInteraccion.Text = "Alternar gráfico";
            // 
            // btnExportarPDFInteraccion
            // 
            btnExportarPDFInteraccion.Location = new Point(160, 10);
            btnExportarPDFInteraccion.Name = "btnExportarPDFInteraccion";
            btnExportarPDFInteraccion.Size = new Size(130, 35);
            btnExportarPDFInteraccion.TabIndex = 1;
            btnExportarPDFInteraccion.Text = "Exportar PDF";
            // 
            // btnReiniciarFiltroInteraccionTema
            // 
            btnReiniciarFiltroInteraccionTema.Location = new Point(300, 10);
            btnReiniciarFiltroInteraccionTema.Name = "btnReiniciarFiltroInteraccionTema";
            btnReiniciarFiltroInteraccionTema.Size = new Size(130, 35);
            btnReiniciarFiltroInteraccionTema.TabIndex = 2;
            btnReiniciarFiltroInteraccionTema.Text = "Reiniciar filtros";
            // 
            // lblInicioInteraccion
            // 
            lblInicioInteraccion.Location = new Point(20, 55);
            lblInicioInteraccion.Name = "lblInicioInteraccion";
            lblInicioInteraccion.Size = new Size(100, 20);
            lblInicioInteraccion.TabIndex = 3;
            lblInicioInteraccion.Text = "Fecha inicio:";
            // 
            // dtInicioInteraccion
            // 
            dtInicioInteraccion.Location = new Point(120, 50);
            dtInicioInteraccion.Name = "dtInicioInteraccion";
            dtInicioInteraccion.Size = new Size(200, 23);
            dtInicioInteraccion.TabIndex = 4;
            // 
            // lblFinInteraccion
            // 
            lblFinInteraccion.Location = new Point(340, 55);
            lblFinInteraccion.Name = "lblFinInteraccion";
            lblFinInteraccion.Size = new Size(100, 20);
            lblFinInteraccion.TabIndex = 5;
            lblFinInteraccion.Text = "Fecha fin:";
            // 
            // dtFinInteraccion
            // 
            dtFinInteraccion.Location = new Point(440, 50);
            dtFinInteraccion.Name = "dtFinInteraccion";
            dtFinInteraccion.Size = new Size(200, 23);
            dtFinInteraccion.TabIndex = 6;
            // 
            // lblDescripcionInteraccion
            // 
            lblDescripcionInteraccion.Location = new Point(20, 85);
            lblDescripcionInteraccion.Name = "lblDescripcionInteraccion";
            lblDescripcionInteraccion.Size = new Size(800, 30);
            lblDescripcionInteraccion.TabIndex = 7;
            lblDescripcionInteraccion.Text = "Este gráfico muestra la suma de interacciones (comentarios, notas, valoraciones) agrupadas por tema.";
            // 
            // tpSuscripciones
            // 
            tpSuscripciones.Controls.Add(panelInferiorSuscripciones);
            tpSuscripciones.Controls.Add(panelSuperiorSuscripciones);
            tpSuscripciones.Location = new Point(4, 24);
            tpSuscripciones.Name = "tpSuscripciones";
            tpSuscripciones.Size = new Size(1029, 476);
            tpSuscripciones.TabIndex = 2;
            tpSuscripciones.Text = "Suscripciones";
            // 
            // panelInferiorSuscripciones
            // 
            panelInferiorSuscripciones.Dock = DockStyle.Fill;
            chartSuscripciones.Dock = DockStyle.Fill;
            panelInferiorSuscripciones.Controls.Add(chartSuscripciones);

            panelInferiorSuscripciones.Location = new Point(0, 120);
            panelInferiorSuscripciones.Name = "panelInferiorSuscripciones";
            panelInferiorSuscripciones.Size = new Size(1029, 356);
            panelInferiorSuscripciones.TabIndex = 0;
            // 
            // panelSuperiorSuscripciones
            // 
            panelSuperiorSuscripciones.Controls.Add(btnAlternarGraficoSuscripciones);
            panelSuperiorSuscripciones.Controls.Add(btnExportarPDFSuscripciones);
            panelSuperiorSuscripciones.Controls.Add(btnReiniciarFiltroSuscripcion);
            panelSuperiorSuscripciones.Controls.Add(lblInicioSuscripciones);
            panelSuperiorSuscripciones.Controls.Add(dtInicioSuscripciones);
            panelSuperiorSuscripciones.Controls.Add(lblFinSuscripciones);
            panelSuperiorSuscripciones.Controls.Add(dtFinSuscripciones);
            panelSuperiorSuscripciones.Controls.Add(lblDescripcionSuscripciones);
            panelSuperiorSuscripciones.Dock = DockStyle.Top;
            panelSuperiorSuscripciones.Location = new Point(0, 0);
            panelSuperiorSuscripciones.Name = "panelSuperiorSuscripciones";
            panelSuperiorSuscripciones.Size = new Size(1029, 120);
            panelSuperiorSuscripciones.TabIndex = 1;
            // 
            // btnAlternarGraficoSuscripciones
            // 
            btnAlternarGraficoSuscripciones.Location = new Point(20, 10);
            btnAlternarGraficoSuscripciones.Name = "btnAlternarGraficoSuscripciones";
            btnAlternarGraficoSuscripciones.Size = new Size(130, 35);
            btnAlternarGraficoSuscripciones.TabIndex = 0;
            btnAlternarGraficoSuscripciones.Text = "Alternar gráfico";
            // 
            // btnExportarPDFSuscripciones
            // 
            btnExportarPDFSuscripciones.Location = new Point(160, 10);
            btnExportarPDFSuscripciones.Name = "btnExportarPDFSuscripciones";
            btnExportarPDFSuscripciones.Size = new Size(130, 35);
            btnExportarPDFSuscripciones.TabIndex = 1;
            btnExportarPDFSuscripciones.Text = "Exportar PDF";
            // 
            // btnReiniciarFiltroSuscripcion
            // 
            btnReiniciarFiltroSuscripcion.Location = new Point(300, 10);
            btnReiniciarFiltroSuscripcion.Name = "btnReiniciarFiltroSuscripcion";
            btnReiniciarFiltroSuscripcion.Size = new Size(130, 35);
            btnReiniciarFiltroSuscripcion.TabIndex = 2;
            btnReiniciarFiltroSuscripcion.Text = "Reiniciar filtros";
            // 
            // lblInicioSuscripciones
            // 
            lblInicioSuscripciones.Location = new Point(20, 55);
            lblInicioSuscripciones.Name = "lblInicioSuscripciones";
            lblInicioSuscripciones.Size = new Size(100, 20);
            lblInicioSuscripciones.TabIndex = 3;
            lblInicioSuscripciones.Text = "Fecha inicio:";
            // 
            // dtInicioSuscripciones
            // 
            dtInicioSuscripciones.Location = new Point(120, 50);
            dtInicioSuscripciones.Name = "dtInicioSuscripciones";
            dtInicioSuscripciones.Size = new Size(200, 23);
            dtInicioSuscripciones.TabIndex = 4;
            // 
            // lblFinSuscripciones
            // 
            lblFinSuscripciones.Location = new Point(340, 55);
            lblFinSuscripciones.Name = "lblFinSuscripciones";
            lblFinSuscripciones.Size = new Size(100, 20);
            lblFinSuscripciones.TabIndex = 5;
            lblFinSuscripciones.Text = "Fecha fin:";
            // 
            // dtFinSuscripciones
            // 
            dtFinSuscripciones.Location = new Point(440, 50);
            dtFinSuscripciones.Name = "dtFinSuscripciones";
            dtFinSuscripciones.Size = new Size(200, 23);
            dtFinSuscripciones.TabIndex = 6;
            // 
            // lblDescripcionSuscripciones
            // 
            lblDescripcionSuscripciones.Location = new Point(20, 85);
            lblDescripcionSuscripciones.Name = "lblDescripcionSuscripciones";
            lblDescripcionSuscripciones.Size = new Size(800, 30);
            lblDescripcionSuscripciones.TabIndex = 7;
            lblDescripcionSuscripciones.Text = "Este gráfico muestra la cantidad de suscripciones activas agrupadas por tipo en el período seleccionado.";
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 550);
            Controls.Add(panel1);
            Controls.Add(panelEncabezado);
            Name = "FormInformes";
            Text = "Informes";
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            panel1.ResumeLayout(false);
            tabControlInformes.ResumeLayout(false);
            tpRecursosConsultados.ResumeLayout(false);
            panelSuperiorRecursos.ResumeLayout(false);
            tpInteraccionTema.ResumeLayout(false);
            panelSuperiorInteraccion.ResumeLayout(false);
            tpSuscripciones.ResumeLayout(false);
            panelSuperiorSuscripciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelEncabezado;
        private Label LTituloInformes;
        private Panel panel1;
        private TabControl tabControlInformes;
        private TabPage tpRecursosConsultados;
        private TabPage tpInteraccionTema;
        private TabPage tpSuscripciones;

        private Panel panelSuperiorRecursos;
        private Panel panelInferiorRecursos;
        private Panel panelSuperiorInteraccion;
        private Panel panelInferiorInteraccion;
        private Panel panelSuperiorSuscripciones;
        private Panel panelInferiorSuscripciones;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRecursos;
        private Button btnAlternarGraficoRecursos;
        private Button btnExportarPDFRecursos;
        private Button btnReiniciarFiltroRecurso;
        private DateTimePicker dtInicioRecursos;
        private DateTimePicker dtFinRecursos;
        private Label lblInicioRecursos;
        private Label lblFinRecursos;
        private Label lblDescripcionRecursos;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartInteraccion;
        private Button btnAlternarGraficoInteraccion;
        private Button btnExportarPDFInteraccion;
        private Button btnReiniciarFiltroInteraccionTema;
        private DateTimePicker dtInicioInteraccion;
        private DateTimePicker dtFinInteraccion;
        private Label lblInicioInteraccion;
        private Label lblFinInteraccion;
        private Label lblDescripcionInteraccion;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSuscripciones;
        private Button btnAlternarGraficoSuscripciones;
        private Button btnExportarPDFSuscripciones;
        private Button btnReiniciarFiltroSuscripcion;
        private DateTimePicker dtInicioSuscripciones;
        private DateTimePicker dtFinSuscripciones;
        private Label lblInicioSuscripciones;
        private Label lblFinSuscripciones;
        private Label lblDescripcionSuscripciones;
    }
}
