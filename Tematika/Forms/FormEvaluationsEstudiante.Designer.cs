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
            cmbMaterias = new ComboBox();
            labelTema = new Label();
            labelMateria = new Label();
            panelHistorialEvaluaciones = new Panel();
            bActualizarHistorial = new Button();
            DGVHistorialEvaluaciones = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            Tema = new DataGridViewTextBoxColumn();
            Puntuacion = new DataGridViewTextBoxColumn();
            Ver = new DataGridViewButtonColumn();
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
            panelFiltroRecursos.Controls.Add(cmbMaterias);
            panelFiltroRecursos.Controls.Add(labelTema);
            panelFiltroRecursos.Controls.Add(labelMateria);
            panelFiltroRecursos.Dock = DockStyle.Top;
            panelFiltroRecursos.Location = new Point(0, 0);
            panelFiltroRecursos.Margin = new Padding(3, 4, 3, 4);
            panelFiltroRecursos.Name = "panelFiltroRecursos";
            panelFiltroRecursos.Size = new Size(882, 189);
            panelFiltroRecursos.TabIndex = 2;
            // 
            // btnEmpezarEvaluacion
            // 
            btnEmpezarEvaluacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEmpezarEvaluacion.BackColor = Color.RoyalBlue;
            btnEmpezarEvaluacion.FlatAppearance.BorderSize = 0;
            btnEmpezarEvaluacion.FlatStyle = FlatStyle.Flat;
            btnEmpezarEvaluacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpezarEvaluacion.ForeColor = SystemColors.ButtonHighlight;
            btnEmpezarEvaluacion.Location = new Point(688, 149);
            btnEmpezarEvaluacion.Margin = new Padding(3, 4, 3, 4);
            btnEmpezarEvaluacion.Name = "btnEmpezarEvaluacion";
            btnEmpezarEvaluacion.Size = new Size(174, 31);
            btnEmpezarEvaluacion.TabIndex = 5;
            btnEmpezarEvaluacion.Text = "Empezar Evaluación";
            btnEmpezarEvaluacion.UseVisualStyleBackColor = false;
            // 
            // labelRealizarEvaluacion
            // 
            labelRealizarEvaluacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelRealizarEvaluacion.AutoSize = true;
            labelRealizarEvaluacion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRealizarEvaluacion.Location = new Point(329, 12);
            labelRealizarEvaluacion.Name = "labelRealizarEvaluacion";
            labelRealizarEvaluacion.Size = new Size(234, 32);
            labelRealizarEvaluacion.TabIndex = 4;
            labelRealizarEvaluacion.Text = "Realizar Evaluación";
            // 
            // cmbTemas
            // 
            cmbTemas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbTemas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTemas.FormattingEnabled = true;
            cmbTemas.Location = new Point(147, 103);
            cmbTemas.Margin = new Padding(3, 4, 3, 4);
            cmbTemas.Name = "cmbTemas";
            cmbTemas.Size = new Size(714, 28);
            cmbTemas.TabIndex = 3;
            // 
            // cmbMaterias
            // 
            cmbMaterias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(147, 63);
            cmbMaterias.Margin = new Padding(3, 4, 3, 4);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(714, 28);
            cmbMaterias.TabIndex = 2;
            // 
            // labelTema
            // 
            labelTema.AutoSize = true;
            labelTema.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTema.Location = new Point(47, 96);
            labelTema.Name = "labelTema";
            labelTema.Size = new Size(81, 32);
            labelTema.TabIndex = 1;
            labelTema.Text = "Tema:";
            // 
            // labelMateria
            // 
            labelMateria.AutoSize = true;
            labelMateria.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMateria.Location = new Point(22, 63);
            labelMateria.Name = "labelMateria";
            labelMateria.Size = new Size(109, 32);
            labelMateria.TabIndex = 0;
            labelMateria.Text = "Materia:";
            // 
            // panelHistorialEvaluaciones
            // 
            panelHistorialEvaluaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelHistorialEvaluaciones.BackColor = SystemColors.ActiveCaption;
            panelHistorialEvaluaciones.Controls.Add(bActualizarHistorial);
            panelHistorialEvaluaciones.Controls.Add(DGVHistorialEvaluaciones);
            panelHistorialEvaluaciones.Controls.Add(labelHistorialEvaluaciones);
            panelHistorialEvaluaciones.Location = new Point(0, 188);
            panelHistorialEvaluaciones.Margin = new Padding(3, 4, 3, 4);
            panelHistorialEvaluaciones.Name = "panelHistorialEvaluaciones";
            panelHistorialEvaluaciones.Size = new Size(882, 401);
            panelHistorialEvaluaciones.TabIndex = 3;
            // 
            // bActualizarHistorial
            // 
            bActualizarHistorial.BackColor = Color.RoyalBlue;
            bActualizarHistorial.FlatAppearance.BorderSize = 0;
            bActualizarHistorial.FlatStyle = FlatStyle.Flat;
            bActualizarHistorial.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bActualizarHistorial.ForeColor = SystemColors.ButtonHighlight;
            bActualizarHistorial.Location = new Point(11, 47);
            bActualizarHistorial.Name = "bActualizarHistorial";
            bActualizarHistorial.Size = new Size(163, 29);
            bActualizarHistorial.TabIndex = 8;
            bActualizarHistorial.Text = "Actualizar Historial";
            bActualizarHistorial.UseVisualStyleBackColor = false;
            bActualizarHistorial.Click += bActualizarHistorial_Click;
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
            DGVHistorialEvaluaciones.Columns.AddRange(new DataGridViewColumn[] { Fecha, Materia, Tema, Puntuacion, Ver });
            DGVHistorialEvaluaciones.Location = new Point(0, 95);
            DGVHistorialEvaluaciones.Margin = new Padding(3, 4, 3, 4);
            DGVHistorialEvaluaciones.Name = "DGVHistorialEvaluaciones";
            DGVHistorialEvaluaciones.ReadOnly = true;
            DGVHistorialEvaluaciones.RowHeadersWidth = 51;
            DGVHistorialEvaluaciones.Size = new Size(882, 307);
            DGVHistorialEvaluaciones.TabIndex = 7;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Materia
            // 
            Materia.HeaderText = "Materia";
            Materia.MinimumWidth = 6;
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            // 
            // Tema
            // 
            Tema.HeaderText = "Tema";
            Tema.MinimumWidth = 6;
            Tema.Name = "Tema";
            Tema.ReadOnly = true;
            // 
            // Puntuacion
            // 
            Puntuacion.HeaderText = "Puntuación";
            Puntuacion.MinimumWidth = 6;
            Puntuacion.Name = "Puntuacion";
            Puntuacion.ReadOnly = true;
            // 
            // Ver
            // 
            Ver.HeaderText = "Ver";
            Ver.MinimumWidth = 6;
            Ver.Name = "Ver";
            Ver.ReadOnly = true;
            Ver.Text = "Ver";
            Ver.UseColumnTextForButtonValue = true;
            // 
            // labelHistorialEvaluaciones
            // 
            labelHistorialEvaluaciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelHistorialEvaluaciones.AutoSize = true;
            labelHistorialEvaluaciones.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHistorialEvaluaciones.Location = new Point(318, 5);
            labelHistorialEvaluaciones.Name = "labelHistorialEvaluaciones";
            labelHistorialEvaluaciones.Size = new Size(265, 32);
            labelHistorialEvaluaciones.TabIndex = 6;
            labelHistorialEvaluaciones.Text = "Historial Evaluaciones";
            // 
            // FormEvaluationsEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 588);
            Controls.Add(panelHistorialEvaluaciones);
            Controls.Add(panelFiltroRecursos);
            Margin = new Padding(3, 4, 3, 4);
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
        private ComboBox cmbMaterias;
        private Label labelTema;
        private Label labelMateria;
        private Panel panelHistorialEvaluaciones;
        private Button btnEmpezarEvaluacion;
        private Label labelHistorialEvaluaciones;
        private DataGridView DGVHistorialEvaluaciones;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewTextBoxColumn Tema;
        private DataGridViewTextBoxColumn Puntuacion;
        private DataGridViewButtonColumn Ver;
        private Button bActualizarHistorial;
    }
}