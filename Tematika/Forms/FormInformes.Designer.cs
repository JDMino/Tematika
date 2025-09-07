namespace Tematika.Forms
{
    partial class FormInformes
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
            panelEncabezado = new FlowLayoutPanel();
            LTituloInformes = new Label();
            panel1 = new Panel();
            tabControlInformes = new TabControl();
            tpRecursosConsultados = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            DGVInformeRecursosConsultados = new DataGridView();
            colTituloRecurso = new DataGridViewTextBoxColumn();
            colTema = new DataGridViewTextBoxColumn();
            colMateria = new DataGridViewTextBoxColumn();
            colVisitas = new DataGridViewTextBoxColumn();
            tpInteraccionTema = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            LInteraccionTema = new Label();
            LFiltroMateria2 = new Label();
            CBInteraccionMateria = new ComboBox();
            DGVInformeInteraccion = new DataGridView();
            colTemaInteraccion = new DataGridViewTextBoxColumn();
            colMateriaInteraccion = new DataGridViewTextBoxColumn();
            colNotasInteraccion = new DataGridViewTextBoxColumn();
            colFavoritos = new DataGridViewTextBoxColumn();
            colComentarios = new DataGridViewTextBoxColumn();
            tpUsuariosActivos = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            CBRoles = new ComboBox();
            DGVInformeUsuariosActivos = new DataGridView();
            colNombreUsuarios = new DataGridViewTextBoxColumn();
            colPerfil = new DataGridViewTextBoxColumn();
            colRecursosVistos = new DataGridViewTextBoxColumn();
            colNotasCreadas = new DataGridViewTextBoxColumn();
            colEvaluaciones = new DataGridViewTextBoxColumn();
            panelEncabezado.SuspendLayout();
            panel1.SuspendLayout();
            tabControlInformes.SuspendLayout();
            tpRecursosConsultados.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInformeRecursosConsultados).BeginInit();
            tpInteraccionTema.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInformeInteraccion).BeginInit();
            tpUsuariosActivos.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInformeUsuariosActivos).BeginInit();
            SuspendLayout();
            // 
            // panelEncabezado
            // 
            panelEncabezado.Controls.Add(LTituloInformes);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(1185, 62);
            panelEncabezado.TabIndex = 2;
            // 
            // LTituloInformes
            // 
            LTituloInformes.AutoSize = true;
            LTituloInformes.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloInformes.Location = new Point(3, 0);
            LTituloInformes.Name = "LTituloInformes";
            LTituloInformes.Size = new Size(266, 38);
            LTituloInformes.TabIndex = 0;
            LTituloInformes.Text = "Informes y Analisis";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(tabControlInformes);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 672);
            panel1.TabIndex = 3;
            // 
            // tabControlInformes
            // 
            tabControlInformes.Controls.Add(tpRecursosConsultados);
            tabControlInformes.Controls.Add(tpInteraccionTema);
            tabControlInformes.Controls.Add(tpUsuariosActivos);
            tabControlInformes.Dock = DockStyle.Fill;
            tabControlInformes.Location = new Point(0, 0);
            tabControlInformes.Name = "tabControlInformes";
            tabControlInformes.SelectedIndex = 0;
            tabControlInformes.Size = new Size(1185, 672);
            tabControlInformes.TabIndex = 3;
            // 
            // tpRecursosConsultados
            // 
            tpRecursosConsultados.Controls.Add(tableLayoutPanel3);
            tpRecursosConsultados.Controls.Add(DGVInformeRecursosConsultados);
            tpRecursosConsultados.Location = new Point(4, 29);
            tpRecursosConsultados.Name = "tpRecursosConsultados";
            tpRecursosConsultados.Padding = new Padding(3);
            tpRecursosConsultados.Size = new Size(1177, 639);
            tpRecursosConsultados.TabIndex = 0;
            tpRecursosConsultados.Text = "Recursos mas consultados";
            tpRecursosConsultados.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.5454559F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.4545441F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(comboBox1, 1, 2);
            tableLayoutPanel3.Location = new Point(60, 25);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(509, 125);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(259, 28);
            label1.TabIndex = 0;
            label1.Text = "Recursos mas consultados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 48);
            label3.Name = "label3";
            label3.Size = new Size(147, 23);
            label3.TabIndex = 1;
            label3.Text = "Filtrar por Materia";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(280, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(226, 28);
            comboBox1.TabIndex = 2;
            // 
            // DGVInformeRecursosConsultados
            // 
            DGVInformeRecursosConsultados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVInformeRecursosConsultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVInformeRecursosConsultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVInformeRecursosConsultados.Columns.AddRange(new DataGridViewColumn[] { colTituloRecurso, colTema, colMateria, colVisitas });
            DGVInformeRecursosConsultados.Location = new Point(60, 175);
            DGVInformeRecursosConsultados.Name = "DGVInformeRecursosConsultados";
            DGVInformeRecursosConsultados.RowHeadersWidth = 51;
            DGVInformeRecursosConsultados.Size = new Size(2417, 865);
            DGVInformeRecursosConsultados.TabIndex = 3;
            DGVInformeRecursosConsultados.CellContentClick += DGVInformeRecursosConsultados_CellContentClick;
            // 
            // colTituloRecurso
            // 
            colTituloRecurso.HeaderText = "Titulo del Recurso";
            colTituloRecurso.MinimumWidth = 6;
            colTituloRecurso.Name = "colTituloRecurso";
            // 
            // colTema
            // 
            colTema.HeaderText = "Tema";
            colTema.MinimumWidth = 6;
            colTema.Name = "colTema";
            // 
            // colMateria
            // 
            colMateria.HeaderText = "Materia";
            colMateria.MinimumWidth = 6;
            colMateria.Name = "colMateria";
            // 
            // colVisitas
            // 
            colVisitas.HeaderText = "Visitas";
            colVisitas.MinimumWidth = 6;
            colVisitas.Name = "colVisitas";
            // 
            // tpInteraccionTema
            // 
            tpInteraccionTema.Controls.Add(tableLayoutPanel2);
            tpInteraccionTema.Controls.Add(DGVInformeInteraccion);
            tpInteraccionTema.Location = new Point(4, 29);
            tpInteraccionTema.Name = "tpInteraccionTema";
            tpInteraccionTema.Padding = new Padding(3);
            tpInteraccionTema.Size = new Size(1177, 639);
            tpInteraccionTema.TabIndex = 1;
            tpInteraccionTema.Text = "Interaccion por tema";
            tpInteraccionTema.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(LInteraccionTema, 0, 0);
            tableLayoutPanel2.Controls.Add(LFiltroMateria2, 0, 2);
            tableLayoutPanel2.Controls.Add(CBInteraccionMateria, 1, 2);
            tableLayoutPanel2.Location = new Point(74, 24);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(640, 86);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // LInteraccionTema
            // 
            LInteraccionTema.AutoSize = true;
            LInteraccionTema.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LInteraccionTema.Location = new Point(3, 0);
            LInteraccionTema.Name = "LInteraccionTema";
            LInteraccionTema.Size = new Size(214, 28);
            LInteraccionTema.TabIndex = 0;
            LInteraccionTema.Text = "Interaccion por Tema";
            // 
            // LFiltroMateria2
            // 
            LFiltroMateria2.AutoSize = true;
            LFiltroMateria2.Font = new Font("Segoe UI", 10F);
            LFiltroMateria2.Location = new Point(3, 48);
            LFiltroMateria2.Name = "LFiltroMateria2";
            LFiltroMateria2.Size = new Size(147, 23);
            LFiltroMateria2.TabIndex = 1;
            LFiltroMateria2.Text = "Filtrar por Materia";
            // 
            // CBInteraccionMateria
            // 
            CBInteraccionMateria.FormattingEnabled = true;
            CBInteraccionMateria.Location = new Point(323, 51);
            CBInteraccionMateria.Name = "CBInteraccionMateria";
            CBInteraccionMateria.Size = new Size(151, 28);
            CBInteraccionMateria.TabIndex = 2;
            // 
            // DGVInformeInteraccion
            // 
            DGVInformeInteraccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVInformeInteraccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVInformeInteraccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVInformeInteraccion.Columns.AddRange(new DataGridViewColumn[] { colTemaInteraccion, colMateriaInteraccion, colNotasInteraccion, colFavoritos, colComentarios });
            DGVInformeInteraccion.Location = new Point(74, 155);
            DGVInformeInteraccion.Name = "DGVInformeInteraccion";
            DGVInformeInteraccion.RowHeadersWidth = 51;
            DGVInformeInteraccion.Size = new Size(2474, 1268);
            DGVInformeInteraccion.TabIndex = 3;
            // 
            // colTemaInteraccion
            // 
            colTemaInteraccion.HeaderText = "Tema";
            colTemaInteraccion.MinimumWidth = 6;
            colTemaInteraccion.Name = "colTemaInteraccion";
            // 
            // colMateriaInteraccion
            // 
            colMateriaInteraccion.HeaderText = "Materia";
            colMateriaInteraccion.MinimumWidth = 6;
            colMateriaInteraccion.Name = "colMateriaInteraccion";
            // 
            // colNotasInteraccion
            // 
            colNotasInteraccion.HeaderText = "Notas privadas";
            colNotasInteraccion.MinimumWidth = 6;
            colNotasInteraccion.Name = "colNotasInteraccion";
            // 
            // colFavoritos
            // 
            colFavoritos.HeaderText = "Favoritos";
            colFavoritos.MinimumWidth = 6;
            colFavoritos.Name = "colFavoritos";
            // 
            // colComentarios
            // 
            colComentarios.HeaderText = "Comentarios";
            colComentarios.MinimumWidth = 6;
            colComentarios.Name = "colComentarios";
            // 
            // tpUsuariosActivos
            // 
            tpUsuariosActivos.Controls.Add(tableLayoutPanel1);
            tpUsuariosActivos.Controls.Add(DGVInformeUsuariosActivos);
            tpUsuariosActivos.Location = new Point(4, 29);
            tpUsuariosActivos.Name = "tpUsuariosActivos";
            tpUsuariosActivos.Size = new Size(1177, 639);
            tpUsuariosActivos.TabIndex = 2;
            tpUsuariosActivos.Text = "Usuarios activos";
            tpUsuariosActivos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(CBRoles, 1, 2);
            tableLayoutPanel1.Location = new Point(57, 15);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(674, 92);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(210, 28);
            label4.TabIndex = 0;
            label4.Text = "Usuarios mas activos";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(3, 48);
            label5.Name = "label5";
            label5.Size = new Size(113, 23);
            label5.TabIndex = 1;
            label5.Text = "Filtrar por Rol";
            // 
            // CBRoles
            // 
            CBRoles.FormattingEnabled = true;
            CBRoles.Location = new Point(340, 51);
            CBRoles.Name = "CBRoles";
            CBRoles.Size = new Size(151, 28);
            CBRoles.TabIndex = 2;
            // 
            // DGVInformeUsuariosActivos
            // 
            DGVInformeUsuariosActivos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVInformeUsuariosActivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVInformeUsuariosActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVInformeUsuariosActivos.Columns.AddRange(new DataGridViewColumn[] { colNombreUsuarios, colPerfil, colRecursosVistos, colNotasCreadas, colEvaluaciones });
            DGVInformeUsuariosActivos.Location = new Point(57, 146);
            DGVInformeUsuariosActivos.Name = "DGVInformeUsuariosActivos";
            DGVInformeUsuariosActivos.RowHeadersWidth = 51;
            DGVInformeUsuariosActivos.Size = new Size(2480, 1238);
            DGVInformeUsuariosActivos.TabIndex = 3;
            // 
            // colNombreUsuarios
            // 
            colNombreUsuarios.HeaderText = "Nombre";
            colNombreUsuarios.MinimumWidth = 6;
            colNombreUsuarios.Name = "colNombreUsuarios";
            // 
            // colPerfil
            // 
            colPerfil.HeaderText = "Perfil";
            colPerfil.MinimumWidth = 6;
            colPerfil.Name = "colPerfil";
            // 
            // colRecursosVistos
            // 
            colRecursosVistos.HeaderText = "Recursos vistos";
            colRecursosVistos.MinimumWidth = 6;
            colRecursosVistos.Name = "colRecursosVistos";
            // 
            // colNotasCreadas
            // 
            colNotasCreadas.HeaderText = "Notas creadas";
            colNotasCreadas.MinimumWidth = 6;
            colNotasCreadas.Name = "colNotasCreadas";
            // 
            // colEvaluaciones
            // 
            colEvaluaciones.HeaderText = "Evaluaciones";
            colEvaluaciones.MinimumWidth = 6;
            colEvaluaciones.Name = "colEvaluaciones";
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 734);
            Controls.Add(panel1);
            Controls.Add(panelEncabezado);
            Name = "FormInformes";
            Text = "Informes";
            Load += FormInformes_Load;
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            panel1.ResumeLayout(false);
            tabControlInformes.ResumeLayout(false);
            tpRecursosConsultados.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInformeRecursosConsultados).EndInit();
            tpInteraccionTema.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInformeInteraccion).EndInit();
            tpUsuariosActivos.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInformeUsuariosActivos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel panelEncabezado;
        private Label LTituloInformes;
        private Panel panel1;
        private TabControl tabControlInformes;
        private TabPage tpRecursosConsultados;
        private DataGridView DGVInformeRecursosConsultados;
        private DataGridViewTextBoxColumn colTituloRecurso;
        private DataGridViewTextBoxColumn colTema;
        private DataGridViewTextBoxColumn colMateria;
        private DataGridViewTextBoxColumn colVisitas;
        private ComboBox comboBox1;
        private Label label3;
        private Label label1;
        private TabPage tpInteraccionTema;
        private DataGridView DGVInformeInteraccion;
        private DataGridViewTextBoxColumn colTemaInteraccion;
        private DataGridViewTextBoxColumn colMateriaInteraccion;
        private DataGridViewTextBoxColumn colNotasInteraccion;
        private DataGridViewTextBoxColumn colFavoritos;
        private DataGridViewTextBoxColumn colComentarios;
        private ComboBox CBInteraccionMateria;
        private Label LFiltroMateria2;
        private Label LInteraccionTema;
        private TabPage tpUsuariosActivos;
        private DataGridView DGVInformeUsuariosActivos;
        private DataGridViewTextBoxColumn colNombreUsuarios;
        private DataGridViewTextBoxColumn colPerfil;
        private DataGridViewTextBoxColumn colRecursosVistos;
        private DataGridViewTextBoxColumn colNotasCreadas;
        private DataGridViewTextBoxColumn colEvaluaciones;
        private ComboBox CBRoles;
        private Label label5;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}