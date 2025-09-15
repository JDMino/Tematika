namespace Tematika.Forms
{
    partial class FormEvaluationsEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelFiltroRecursos = new Panel();
            btnEmpezarEvaluacion = new Button();
            labelRealizarEvaluacion = new Label();
            cmbTemas = new ComboBox();
            cmbAsignaturas = new ComboBox();
            labelTema = new Label();
            labelAsignatura = new Label();
            panelHistorialEvaluaciones = new Panel();
            DGVHistorialEvaluaciones = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Asignatura = new DataGridViewTextBoxColumn();
            Tema = new DataGridViewTextBoxColumn();
            Puntuacion = new DataGridViewTextBoxColumn();
            labelHistorialEvaluaciones = new Label();
            panelFiltroRecursos.SuspendLayout();
            panelHistorialEvaluaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVHistorialEvaluaciones).BeginInit();
            SuspendLayout();
            // 
            // panelFiltroRecursos
            // 
            panelFiltroRecursos.BackColor = Color.Silver;
            panelFiltroRecursos.Controls.Add(btnEmpezarEvaluacion);
            panelFiltroRecursos.Controls.Add(labelRealizarEvaluacion);
            panelFiltroRecursos.Controls.Add(cmbTemas);
            panelFiltroRecursos.Controls.Add(cmbAsignaturas);
            panelFiltroRecursos.Controls.Add(labelTema);
            panelFiltroRecursos.Controls.Add(labelAsignatura);
            panelFiltroRecursos.Dock = DockStyle.Top;
            panelFiltroRecursos.Location = new Point(0, 0);
            panelFiltroRecursos.Name = "panelFiltroRecursos";
            panelFiltroRecursos.Size = new Size(772, 142);
            panelFiltroRecursos.TabIndex = 2;
            // 
            // btnEmpezarEvaluacion
            // 
            btnEmpezarEvaluacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEmpezarEvaluacion.Location = new Point(621, 112);
            btnEmpezarEvaluacion.Name = "btnEmpezarEvaluacion";
            btnEmpezarEvaluacion.Size = new Size(133, 23);
            btnEmpezarEvaluacion.TabIndex = 5;
            btnEmpezarEvaluacion.Text = "Empezar Evaluación";
            btnEmpezarEvaluacion.UseVisualStyleBackColor = true;
            btnEmpezarEvaluacion.Click += btnEmpezarEvaluacion_Click;
            // 
            // labelRealizarEvaluacion
            // 
            labelRealizarEvaluacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelRealizarEvaluacion.AutoSize = true;
            labelRealizarEvaluacion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRealizarEvaluacion.Location = new Point(288, 9);
            labelRealizarEvaluacion.Name = "labelRealizarEvaluacion";
            labelRealizarEvaluacion.Size = new Size(181, 25);
            labelRealizarEvaluacion.TabIndex = 4;
            labelRealizarEvaluacion.Text = "Realizar Evaluación";
            // 
            // cmbTemas
            // 
            cmbTemas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbTemas.FormattingEnabled = true;
            cmbTemas.Location = new Point(110, 77);
            cmbTemas.Name = "cmbTemas";
            cmbTemas.Size = new Size(644, 23);
            cmbTemas.TabIndex = 3;
            // 
            // cmbAsignaturas
            // 
            cmbAsignaturas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbAsignaturas.FormattingEnabled = true;
            cmbAsignaturas.Location = new Point(110, 47);
            cmbAsignaturas.Name = "cmbAsignaturas";
            cmbAsignaturas.Size = new Size(644, 23);
            cmbAsignaturas.TabIndex = 2;
            // 
            // labelTema
            // 
            labelTema.AutoSize = true;
            labelTema.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTema.Location = new Point(41, 72);
            labelTema.Name = "labelTema";
            labelTema.Size = new Size(63, 25);
            labelTema.TabIndex = 1;
            labelTema.Text = "Tema:";
            // 
            // labelAsignatura
            // 
            labelAsignatura.AutoSize = true;
            labelAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAsignatura.Location = new Point(0, 47);
            labelAsignatura.Name = "labelAsignatura";
            labelAsignatura.Size = new Size(114, 25);
            labelAsignatura.TabIndex = 0;
            labelAsignatura.Text = "Asignatura:";
            // 
            // panelHistorialEvaluaciones
            // 
            panelHistorialEvaluaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelHistorialEvaluaciones.BackColor = Color.SteelBlue;
            panelHistorialEvaluaciones.Controls.Add(DGVHistorialEvaluaciones);
            panelHistorialEvaluaciones.Controls.Add(labelHistorialEvaluaciones);
            panelHistorialEvaluaciones.Location = new Point(0, 141);
            panelHistorialEvaluaciones.Name = "panelHistorialEvaluaciones";
            panelHistorialEvaluaciones.Size = new Size(772, 301);
            panelHistorialEvaluaciones.TabIndex = 3;
            // 
            // DGVHistorialEvaluaciones
            // 
            DGVHistorialEvaluaciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGVHistorialEvaluaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVHistorialEvaluaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVHistorialEvaluaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVHistorialEvaluaciones.Columns.AddRange(new DataGridViewColumn[] { Fecha, Asignatura, Tema, Puntuacion });
            DGVHistorialEvaluaciones.Location = new Point(0, 44);
            DGVHistorialEvaluaciones.Name = "DGVHistorialEvaluaciones";
            DGVHistorialEvaluaciones.Size = new Size(772, 257);
            DGVHistorialEvaluaciones.TabIndex = 7;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Asignatura
            // 
            Asignatura.HeaderText = "Asignatura";
            Asignatura.Name = "Asignatura";
            Asignatura.ReadOnly = true;
            // 
            // Tema
            // 
            Tema.HeaderText = "Tema";
            Tema.Name = "Tema";
            Tema.ReadOnly = true;
            // 
            // Puntuacion
            // 
            Puntuacion.HeaderText = "Puntuación";
            Puntuacion.Name = "Puntuacion";
            // 
            // labelHistorialEvaluaciones
            // 
            labelHistorialEvaluaciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelHistorialEvaluaciones.AutoSize = true;
            labelHistorialEvaluaciones.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHistorialEvaluaciones.Location = new Point(278, 4);
            labelHistorialEvaluaciones.Name = "labelHistorialEvaluaciones";
            labelHistorialEvaluaciones.Size = new Size(205, 25);
            labelHistorialEvaluaciones.TabIndex = 6;
            labelHistorialEvaluaciones.Text = "Historial Evaluaciones";
            // 
            // FormEvaluationsEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(772, 441);
            Controls.Add(panelHistorialEvaluaciones);
            Controls.Add(panelFiltroRecursos);
            Name = "FormEvaluationsEstudiante";
            Text = "FormEvaluationsEstudiante";
            Load += FormEvaluationsEstudiante_Load;
            panelFiltroRecursos.ResumeLayout(false);
            panelFiltroRecursos.PerformLayout();
            panelHistorialEvaluaciones.ResumeLayout(false);
            panelHistorialEvaluaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVHistorialEvaluaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFiltroRecursos;
        private Label labelRealizarEvaluacion;
        private ComboBox cmbTemas;
        private ComboBox cmbAsignaturas;
        private Label labelTema;
        private Label labelAsignatura;
        private Panel panelHistorialEvaluaciones;
        private Button btnEmpezarEvaluacion;
        private Label labelHistorialEvaluaciones;
        private DataGridView DGVHistorialEvaluaciones;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Asignatura;
        private DataGridViewTextBoxColumn Tema;
        private DataGridViewTextBoxColumn Puntuacion;
    }
}