namespace Tematika.Forms
{
    partial class FormGestionPreguntas
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
            panelPreguntas = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            TBBuscador = new TextBox();
            BPActivos = new Button();
            BPInactivos = new Button();
            panelCamposPreguntas = new TableLayoutPanel();
            LPregunta = new Label();
            LEnunciado = new Label();
            textBox5 = new TextBox();
            CBMateria = new ComboBox();
            LOpcion3 = new Label();
            TBOp3 = new TextBox();
            LOpcion2 = new Label();
            LMateria = new Label();
            LOpcion1 = new Label();
            TBOp2 = new TextBox();
            TBOp1 = new TextBox();
            LOpcionCorrecta = new Label();
            CBOpcionCorrecta = new ComboBox();
            LEliminado = new Label();
            comboBox1 = new ComboBox();
            LTemasPreg = new Label();
            CBTemas = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            BGuardarPreg = new Button();
            BEliminarEvaluacion = new Button();
            BCancelarPreg = new Button();
            BModificarPreg = new Button();
            DGVPreguntas = new DataGridView();
            panelEncabezadoP = new FlowLayoutPanel();
            LTituloPreguntas = new Label();
            idEvaluacion = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            TemaPreg = new DataGridViewTextBoxColumn();
            IDPreg = new DataGridViewTextBoxColumn();
            EnunciadoPreg = new DataGridViewTextBoxColumn();
            panelPreguntas.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panelCamposPreguntas.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVPreguntas).BeginInit();
            panelEncabezadoP.SuspendLayout();
            SuspendLayout();
            // 
            // panelPreguntas
            // 
            panelPreguntas.BackColor = Color.IndianRed;
            panelPreguntas.Controls.Add(tableLayoutPanel4);
            panelPreguntas.Controls.Add(panelCamposPreguntas);
            panelPreguntas.Controls.Add(tableLayoutPanel3);
            panelPreguntas.Controls.Add(DGVPreguntas);
            panelPreguntas.Controls.Add(panelEncabezadoP);
            panelPreguntas.Dock = DockStyle.Fill;
            panelPreguntas.Location = new Point(0, 0);
            panelPreguntas.Name = "panelPreguntas";
            panelPreguntas.Size = new Size(800, 450);
            panelPreguntas.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.Controls.Add(TBBuscador, 0, 0);
            tableLayoutPanel4.Controls.Add(BPActivos, 1, 0);
            tableLayoutPanel4.Controls.Add(BPInactivos, 2, 0);
            tableLayoutPanel4.Location = new Point(49, 311);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(710, 30);
            tableLayoutPanel4.TabIndex = 101;
            // 
            // TBBuscador
            // 
            TBBuscador.Location = new Point(3, 2);
            TBBuscador.Margin = new Padding(3, 2, 3, 2);
            TBBuscador.Name = "TBBuscador";
            TBBuscador.PlaceholderText = "Buscar pregunta..";
            TBBuscador.Size = new Size(207, 23);
            TBBuscador.TabIndex = 62;
            // 
            // BPActivos
            // 
            BPActivos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BPActivos.BackColor = SystemColors.Highlight;
            BPActivos.FlatAppearance.BorderSize = 0;
            BPActivos.FlatStyle = FlatStyle.Flat;
            BPActivos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BPActivos.ForeColor = SystemColors.ButtonHighlight;
            BPActivos.Location = new Point(537, 2);
            BPActivos.Margin = new Padding(3, 2, 3, 2);
            BPActivos.Name = "BPActivos";
            BPActivos.Size = new Size(82, 22);
            BPActivos.TabIndex = 63;
            BPActivos.Text = "Activos";
            BPActivos.UseVisualStyleBackColor = false;
            // 
            // BPInactivos
            // 
            BPInactivos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BPInactivos.BackColor = Color.Gray;
            BPInactivos.FlatAppearance.BorderSize = 0;
            BPInactivos.FlatStyle = FlatStyle.Flat;
            BPInactivos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BPInactivos.ForeColor = SystemColors.ButtonHighlight;
            BPInactivos.Location = new Point(625, 2);
            BPInactivos.Margin = new Padding(3, 2, 3, 2);
            BPInactivos.Name = "BPInactivos";
            BPInactivos.Size = new Size(82, 22);
            BPInactivos.TabIndex = 64;
            BPInactivos.Text = "Inactivos";
            BPInactivos.UseVisualStyleBackColor = false;
            // 
            // panelCamposPreguntas
            // 
            panelCamposPreguntas.ColumnCount = 4;
            panelCamposPreguntas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.22222F));
            panelCamposPreguntas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222233F));
            panelCamposPreguntas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222233F));
            panelCamposPreguntas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            panelCamposPreguntas.Controls.Add(LPregunta, 0, 0);
            panelCamposPreguntas.Controls.Add(LEnunciado, 0, 1);
            panelCamposPreguntas.Controls.Add(textBox5, 1, 1);
            panelCamposPreguntas.Controls.Add(CBMateria, 1, 2);
            panelCamposPreguntas.Controls.Add(LOpcion3, 2, 4);
            panelCamposPreguntas.Controls.Add(TBOp3, 3, 4);
            panelCamposPreguntas.Controls.Add(LOpcion2, 2, 3);
            panelCamposPreguntas.Controls.Add(LMateria, 0, 2);
            panelCamposPreguntas.Controls.Add(LOpcion1, 2, 2);
            panelCamposPreguntas.Controls.Add(TBOp2, 3, 3);
            panelCamposPreguntas.Controls.Add(TBOp1, 3, 2);
            panelCamposPreguntas.Controls.Add(LOpcionCorrecta, 2, 1);
            panelCamposPreguntas.Controls.Add(CBOpcionCorrecta, 3, 1);
            panelCamposPreguntas.Controls.Add(LEliminado, 0, 4);
            panelCamposPreguntas.Controls.Add(comboBox1, 1, 4);
            panelCamposPreguntas.Controls.Add(LTemasPreg, 0, 3);
            panelCamposPreguntas.Controls.Add(CBTemas, 1, 3);
            panelCamposPreguntas.Location = new Point(50, 66);
            panelCamposPreguntas.Margin = new Padding(3, 2, 3, 2);
            panelCamposPreguntas.Name = "panelCamposPreguntas";
            panelCamposPreguntas.RowCount = 5;
            panelCamposPreguntas.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            panelCamposPreguntas.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelCamposPreguntas.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelCamposPreguntas.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelCamposPreguntas.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelCamposPreguntas.Size = new Size(747, 172);
            panelCamposPreguntas.TabIndex = 102;
            // 
            // LPregunta
            // 
            LPregunta.AutoSize = true;
            LPregunta.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LPregunta.Location = new Point(3, 0);
            LPregunta.Name = "LPregunta";
            LPregunta.Size = new Size(134, 21);
            LPregunta.TabIndex = 22;
            LPregunta.Text = "Nueva Pregunta";
            // 
            // LEnunciado
            // 
            LEnunciado.AutoSize = true;
            LEnunciado.Location = new Point(3, 30);
            LEnunciado.Name = "LEnunciado";
            LEnunciado.Size = new Size(142, 15);
            LEnunciado.TabIndex = 23;
            LEnunciado.Text = "Enunciado de la Pregunta";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(168, 32);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(152, 31);
            textBox5.TabIndex = 34;
            // 
            // CBMateria
            // 
            CBMateria.FormattingEnabled = true;
            CBMateria.Location = new Point(168, 67);
            CBMateria.Margin = new Padding(3, 2, 3, 2);
            CBMateria.Name = "CBMateria";
            CBMateria.Size = new Size(133, 23);
            CBMateria.TabIndex = 42;
            // 
            // LOpcion3
            // 
            LOpcion3.AutoSize = true;
            LOpcion3.Location = new Point(334, 135);
            LOpcion3.Name = "LOpcion3";
            LOpcion3.Size = new Size(55, 15);
            LOpcion3.TabIndex = 29;
            LOpcion3.Text = "Opcion 3";
            // 
            // TBOp3
            // 
            TBOp3.Location = new Point(500, 137);
            TBOp3.Margin = new Padding(3, 2, 3, 2);
            TBOp3.Name = "TBOp3";
            TBOp3.Size = new Size(244, 23);
            TBOp3.TabIndex = 33;
            // 
            // LOpcion2
            // 
            LOpcion2.AutoSize = true;
            LOpcion2.Location = new Point(334, 100);
            LOpcion2.Name = "LOpcion2";
            LOpcion2.Size = new Size(55, 15);
            LOpcion2.TabIndex = 28;
            LOpcion2.Text = "Opcion 2";
            // 
            // LMateria
            // 
            LMateria.AutoSize = true;
            LMateria.Location = new Point(3, 65);
            LMateria.Name = "LMateria";
            LMateria.Size = new Size(47, 15);
            LMateria.TabIndex = 41;
            LMateria.Text = "Materia";
            // 
            // LOpcion1
            // 
            LOpcion1.AutoSize = true;
            LOpcion1.Location = new Point(334, 65);
            LOpcion1.Name = "LOpcion1";
            LOpcion1.Size = new Size(55, 15);
            LOpcion1.TabIndex = 27;
            LOpcion1.Text = "Opcion 1";
            // 
            // TBOp2
            // 
            TBOp2.Location = new Point(500, 102);
            TBOp2.Margin = new Padding(3, 2, 3, 2);
            TBOp2.Name = "TBOp2";
            TBOp2.Size = new Size(244, 23);
            TBOp2.TabIndex = 32;
            // 
            // TBOp1
            // 
            TBOp1.Location = new Point(500, 67);
            TBOp1.Margin = new Padding(3, 2, 3, 2);
            TBOp1.Name = "TBOp1";
            TBOp1.Size = new Size(244, 23);
            TBOp1.TabIndex = 31;
            // 
            // LOpcionCorrecta
            // 
            LOpcionCorrecta.AutoSize = true;
            LOpcionCorrecta.Location = new Point(334, 30);
            LOpcionCorrecta.Name = "LOpcionCorrecta";
            LOpcionCorrecta.Size = new Size(94, 15);
            LOpcionCorrecta.TabIndex = 26;
            LOpcionCorrecta.Text = "Opcion Correcta";
            // 
            // CBOpcionCorrecta
            // 
            CBOpcionCorrecta.FormattingEnabled = true;
            CBOpcionCorrecta.Location = new Point(500, 32);
            CBOpcionCorrecta.Margin = new Padding(3, 2, 3, 2);
            CBOpcionCorrecta.Name = "CBOpcionCorrecta";
            CBOpcionCorrecta.Size = new Size(133, 23);
            CBOpcionCorrecta.TabIndex = 43;
            // 
            // LEliminado
            // 
            LEliminado.AutoSize = true;
            LEliminado.Location = new Point(3, 135);
            LEliminado.Name = "LEliminado";
            LEliminado.Size = new Size(128, 15);
            LEliminado.TabIndex = 44;
            LEliminado.Text = "Eliminado (Evaluación)";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(168, 137);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 45;
            // 
            // LTemasPreg
            // 
            LTemasPreg.AutoSize = true;
            LTemasPreg.Location = new Point(3, 100);
            LTemasPreg.Name = "LTemasPreg";
            LTemasPreg.Size = new Size(35, 15);
            LTemasPreg.TabIndex = 24;
            LTemasPreg.Text = "Tema";
            // 
            // CBTemas
            // 
            CBTemas.FormattingEnabled = true;
            CBTemas.Location = new Point(168, 102);
            CBTemas.Margin = new Padding(3, 2, 3, 2);
            CBTemas.Name = "CBTemas";
            CBTemas.Size = new Size(133, 23);
            CBTemas.TabIndex = 25;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(BGuardarPreg, 0, 0);
            tableLayoutPanel3.Controls.Add(BEliminarEvaluacion, 3, 0);
            tableLayoutPanel3.Controls.Add(BCancelarPreg, 1, 0);
            tableLayoutPanel3.Controls.Add(BModificarPreg, 2, 0);
            tableLayoutPanel3.Location = new Point(402, 261);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(358, 40);
            tableLayoutPanel3.TabIndex = 100;
            // 
            // BGuardarPreg
            // 
            BGuardarPreg.BackColor = Color.ForestGreen;
            BGuardarPreg.FlatAppearance.BorderSize = 0;
            BGuardarPreg.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 125, 50);
            BGuardarPreg.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 160, 71);
            BGuardarPreg.FlatStyle = FlatStyle.Flat;
            BGuardarPreg.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BGuardarPreg.ForeColor = SystemColors.ButtonHighlight;
            BGuardarPreg.Location = new Point(3, 2);
            BGuardarPreg.Margin = new Padding(3, 2, 3, 2);
            BGuardarPreg.Name = "BGuardarPreg";
            BGuardarPreg.Size = new Size(82, 22);
            BGuardarPreg.TabIndex = 88;
            BGuardarPreg.Text = "Guardar";
            BGuardarPreg.UseVisualStyleBackColor = false;
            // 
            // BEliminarEvaluacion
            // 
            BEliminarEvaluacion.BackColor = Color.OrangeRed;
            BEliminarEvaluacion.FlatAppearance.BorderSize = 0;
            BEliminarEvaluacion.FlatStyle = FlatStyle.Flat;
            BEliminarEvaluacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BEliminarEvaluacion.ForeColor = SystemColors.ButtonHighlight;
            BEliminarEvaluacion.Location = new Point(275, 2);
            BEliminarEvaluacion.Margin = new Padding(3, 2, 3, 2);
            BEliminarEvaluacion.Name = "BEliminarEvaluacion";
            BEliminarEvaluacion.Size = new Size(82, 22);
            BEliminarEvaluacion.TabIndex = 91;
            BEliminarEvaluacion.Text = "Eliminar";
            BEliminarEvaluacion.UseVisualStyleBackColor = false;
            BEliminarEvaluacion.Visible = false;
            // 
            // BCancelarPreg
            // 
            BCancelarPreg.BackColor = Color.Gray;
            BCancelarPreg.FlatAppearance.BorderSize = 0;
            BCancelarPreg.FlatStyle = FlatStyle.Flat;
            BCancelarPreg.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BCancelarPreg.ForeColor = SystemColors.ButtonHighlight;
            BCancelarPreg.Location = new Point(91, 2);
            BCancelarPreg.Margin = new Padding(3, 2, 3, 2);
            BCancelarPreg.Name = "BCancelarPreg";
            BCancelarPreg.Size = new Size(82, 22);
            BCancelarPreg.TabIndex = 89;
            BCancelarPreg.Text = "Cancelar";
            BCancelarPreg.UseVisualStyleBackColor = false;
            // 
            // BModificarPreg
            // 
            BModificarPreg.BackColor = SystemColors.Highlight;
            BModificarPreg.FlatAppearance.BorderSize = 0;
            BModificarPreg.FlatStyle = FlatStyle.Flat;
            BModificarPreg.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BModificarPreg.ForeColor = SystemColors.ButtonHighlight;
            BModificarPreg.Location = new Point(179, 2);
            BModificarPreg.Margin = new Padding(3, 2, 3, 2);
            BModificarPreg.Name = "BModificarPreg";
            BModificarPreg.Size = new Size(90, 22);
            BModificarPreg.TabIndex = 90;
            BModificarPreg.Text = "Modificar";
            BModificarPreg.UseVisualStyleBackColor = false;
            BModificarPreg.Visible = false;
            // 
            // DGVPreguntas
            // 
            DGVPreguntas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVPreguntas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVPreguntas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPreguntas.Columns.AddRange(new DataGridViewColumn[] { idEvaluacion, dataGridViewTextBoxColumn1, TemaPreg, IDPreg, EnunciadoPreg });
            DGVPreguntas.Location = new Point(49, 361);
            DGVPreguntas.Margin = new Padding(3, 2, 3, 2);
            DGVPreguntas.Name = "DGVPreguntas";
            DGVPreguntas.RowHeadersWidth = 51;
            DGVPreguntas.Size = new Size(710, 90);
            DGVPreguntas.TabIndex = 99;
            // 
            // panelEncabezadoP
            // 
            panelEncabezadoP.Controls.Add(LTituloPreguntas);
            panelEncabezadoP.Dock = DockStyle.Top;
            panelEncabezadoP.Location = new Point(0, 0);
            panelEncabezadoP.Margin = new Padding(3, 2, 3, 2);
            panelEncabezadoP.Name = "panelEncabezadoP";
            panelEncabezadoP.Size = new Size(800, 52);
            panelEncabezadoP.TabIndex = 98;
            // 
            // LTituloPreguntas
            // 
            LTituloPreguntas.AutoSize = true;
            LTituloPreguntas.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloPreguntas.Location = new Point(3, 0);
            LTituloPreguntas.Name = "LTituloPreguntas";
            LTituloPreguntas.Size = new Size(262, 30);
            LTituloPreguntas.TabIndex = 1;
            LTituloPreguntas.Text = "Gestion de Evaluaciones";
            LTituloPreguntas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // idEvaluacion
            // 
            idEvaluacion.HeaderText = "ID_Evaluación";
            idEvaluacion.Name = "idEvaluacion";
            idEvaluacion.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Materia";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // TemaPreg
            // 
            TemaPreg.HeaderText = "Tema";
            TemaPreg.MinimumWidth = 6;
            TemaPreg.Name = "TemaPreg";
            // 
            // IDPreg
            // 
            IDPreg.HeaderText = "ID_Pregunta";
            IDPreg.MinimumWidth = 6;
            IDPreg.Name = "IDPreg";
            // 
            // EnunciadoPreg
            // 
            EnunciadoPreg.HeaderText = "Enunciado";
            EnunciadoPreg.MinimumWidth = 6;
            EnunciadoPreg.Name = "EnunciadoPreg";
            // 
            // FormGestionPreguntas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPreguntas);
            Name = "FormGestionPreguntas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGestionPreguntas";
            Load += FormGestionPreguntas_Load;
            panelPreguntas.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panelCamposPreguntas.ResumeLayout(false);
            panelCamposPreguntas.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVPreguntas).EndInit();
            panelEncabezadoP.ResumeLayout(false);
            panelEncabezadoP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPreguntas;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox TBBuscador;
        private Button BPActivos;
        private Button BPInactivos;
        private TableLayoutPanel panelCamposPreguntas;
        private Label LPregunta;
        private Label LEnunciado;
        private TextBox textBox5;
        private ComboBox CBMateria;
        private Label LOpcion3;
        private TextBox TBOp3;
        private Label LOpcion2;
        private Label LTemasPreg;
        private Label LOpcion1;
        private TextBox TBOp2;
        private Label LMateria;
        private TextBox TBOp1;
        private ComboBox CBTemas;
        private Label LOpcionCorrecta;
        private TableLayoutPanel tableLayoutPanel3;
        private Button BGuardarPreg;
        private Button BEliminarEvaluacion;
        private Button BCancelarPreg;
        private Button BModificarPreg;
        private DataGridView DGVPreguntas;
        private FlowLayoutPanel panelEncabezadoP;
        private Label LTituloPreguntas;
        private ComboBox CBOpcionCorrecta;
        private Label LEliminado;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn idEvaluacion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn TemaPreg;
        private DataGridViewTextBoxColumn IDPreg;
        private DataGridViewTextBoxColumn EnunciadoPreg;
    }
}