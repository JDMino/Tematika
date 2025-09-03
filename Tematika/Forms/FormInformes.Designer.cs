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
            panel1 = new Panel();
            label2 = new Label();
            tabControlInformes = new TabControl();
            tpRecursosConsultados = new TabPage();
            DGVInformeRecursosConsultados = new DataGridView();
            colTituloRecurso = new DataGridViewTextBoxColumn();
            colTema = new DataGridViewTextBoxColumn();
            colMateria = new DataGridViewTextBoxColumn();
            colVisitas = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            tpInteraccionTema = new TabPage();
            DGVInformeInteraccion = new DataGridView();
            colTemaInteraccion = new DataGridViewTextBoxColumn();
            colMateriaInteraccion = new DataGridViewTextBoxColumn();
            colNotasInteraccion = new DataGridViewTextBoxColumn();
            colFavoritos = new DataGridViewTextBoxColumn();
            colComentarios = new DataGridViewTextBoxColumn();
            CBInteraccionMateria = new ComboBox();
            LFiltroMateria2 = new Label();
            LInteraccionTema = new Label();
            tpUsuariosActivos = new TabPage();
            DGVInformeUsuariosActivos = new DataGridView();
            colNombreUsuarios = new DataGridViewTextBoxColumn();
            colPerfil = new DataGridViewTextBoxColumn();
            colRecursosVistos = new DataGridViewTextBoxColumn();
            colNotasCreadas = new DataGridViewTextBoxColumn();
            colEvaluaciones = new DataGridViewTextBoxColumn();
            CBRoles = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            tabControlInformes.SuspendLayout();
            tpRecursosConsultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInformeRecursosConsultados).BeginInit();
            tpInteraccionTema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInformeInteraccion).BeginInit();
            tpUsuariosActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInformeUsuariosActivos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 57);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(736, 9);
            label2.Name = "label2";
            label2.Size = new Size(266, 38);
            label2.TabIndex = 0;
            label2.Text = "Informes y Analisis";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControlInformes
            // 
            tabControlInformes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlInformes.Controls.Add(tpRecursosConsultados);
            tabControlInformes.Controls.Add(tpInteraccionTema);
            tabControlInformes.Controls.Add(tpUsuariosActivos);
            tabControlInformes.Location = new Point(0, 57);
            tabControlInformes.Name = "tabControlInformes";
            tabControlInformes.SelectedIndex = 0;
            tabControlInformes.Size = new Size(1035, 417);
            tabControlInformes.TabIndex = 1;
            // 
            // tpRecursosConsultados
            // 
            tpRecursosConsultados.Controls.Add(DGVInformeRecursosConsultados);
            tpRecursosConsultados.Controls.Add(comboBox1);
            tpRecursosConsultados.Controls.Add(label3);
            tpRecursosConsultados.Controls.Add(label1);
            tpRecursosConsultados.Location = new Point(4, 29);
            tpRecursosConsultados.Name = "tpRecursosConsultados";
            tpRecursosConsultados.Padding = new Padding(3);
            tpRecursosConsultados.Size = new Size(1027, 384);
            tpRecursosConsultados.TabIndex = 0;
            tpRecursosConsultados.Text = "Recursos mas consultados";
            tpRecursosConsultados.UseVisualStyleBackColor = true;
            // 
            // DGVInformeRecursosConsultados
            // 
            DGVInformeRecursosConsultados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVInformeRecursosConsultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVInformeRecursosConsultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVInformeRecursosConsultados.Columns.AddRange(new DataGridViewColumn[] { colTituloRecurso, colTema, colMateria, colVisitas });
            DGVInformeRecursosConsultados.Location = new Point(160, 120);
            DGVInformeRecursosConsultados.Name = "DGVInformeRecursosConsultados";
            DGVInformeRecursosConsultados.RowHeadersWidth = 51;
            DGVInformeRecursosConsultados.Size = new Size(782, 212);
            DGVInformeRecursosConsultados.TabIndex = 3;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(218, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(226, 28);
            comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 56);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 1;
            label3.Text = "Filtrar por Materia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 13);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 0;
            label1.Text = "Recursos mas Consultados";
            // 
            // tpInteraccionTema
            // 
            tpInteraccionTema.Controls.Add(DGVInformeInteraccion);
            tpInteraccionTema.Controls.Add(CBInteraccionMateria);
            tpInteraccionTema.Controls.Add(LFiltroMateria2);
            tpInteraccionTema.Controls.Add(LInteraccionTema);
            tpInteraccionTema.Location = new Point(4, 29);
            tpInteraccionTema.Name = "tpInteraccionTema";
            tpInteraccionTema.Padding = new Padding(3);
            tpInteraccionTema.Size = new Size(792, 360);
            tpInteraccionTema.TabIndex = 1;
            tpInteraccionTema.Text = "Interaccion por tema";
            tpInteraccionTema.UseVisualStyleBackColor = true;
            // 
            // DGVInformeInteraccion
            // 
            DGVInformeInteraccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVInformeInteraccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVInformeInteraccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVInformeInteraccion.Columns.AddRange(new DataGridViewColumn[] { colTemaInteraccion, colMateriaInteraccion, colNotasInteraccion, colFavoritos, colComentarios });
            DGVInformeInteraccion.Location = new Point(68, 149);
            DGVInformeInteraccion.Name = "DGVInformeInteraccion";
            DGVInformeInteraccion.RowHeadersWidth = 51;
            DGVInformeInteraccion.Size = new Size(682, 188);
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
            // CBInteraccionMateria
            // 
            CBInteraccionMateria.FormattingEnabled = true;
            CBInteraccionMateria.Location = new Point(275, 62);
            CBInteraccionMateria.Name = "CBInteraccionMateria";
            CBInteraccionMateria.Size = new Size(151, 28);
            CBInteraccionMateria.TabIndex = 2;
            // 
            // LFiltroMateria2
            // 
            LFiltroMateria2.AutoSize = true;
            LFiltroMateria2.Location = new Point(107, 62);
            LFiltroMateria2.Name = "LFiltroMateria2";
            LFiltroMateria2.Size = new Size(129, 20);
            LFiltroMateria2.TabIndex = 1;
            LFiltroMateria2.Text = "Filtrar por Materia";
            // 
            // LInteraccionTema
            // 
            LInteraccionTema.AutoSize = true;
            LInteraccionTema.Location = new Point(107, 22);
            LInteraccionTema.Name = "LInteraccionTema";
            LInteraccionTema.Size = new Size(149, 20);
            LInteraccionTema.TabIndex = 0;
            LInteraccionTema.Text = "Interaccion por Tema";
            // 
            // tpUsuariosActivos
            // 
            tpUsuariosActivos.Controls.Add(DGVInformeUsuariosActivos);
            tpUsuariosActivos.Controls.Add(CBRoles);
            tpUsuariosActivos.Controls.Add(label5);
            tpUsuariosActivos.Controls.Add(label4);
            tpUsuariosActivos.Location = new Point(4, 29);
            tpUsuariosActivos.Name = "tpUsuariosActivos";
            tpUsuariosActivos.Size = new Size(792, 360);
            tpUsuariosActivos.TabIndex = 2;
            tpUsuariosActivos.Text = "Usuarios activos";
            tpUsuariosActivos.UseVisualStyleBackColor = true;
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
            DGVInformeUsuariosActivos.Size = new Size(676, 188);
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
            // CBRoles
            // 
            CBRoles.FormattingEnabled = true;
            CBRoles.Location = new Point(265, 66);
            CBRoles.Name = "CBRoles";
            CBRoles.Size = new Size(151, 28);
            CBRoles.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 66);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 1;
            label5.Text = "Filtrar por Rol";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 31);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 0;
            label4.Text = "Usuarios mas activos";
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 474);
            Controls.Add(tabControlInformes);
            Controls.Add(panel1);
            Name = "FormInformes";
            Text = "p";
            Load += FormInformes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControlInformes.ResumeLayout(false);
            tpRecursosConsultados.ResumeLayout(false);
            tpRecursosConsultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInformeRecursosConsultados).EndInit();
            tpInteraccionTema.ResumeLayout(false);
            tpInteraccionTema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInformeInteraccion).EndInit();
            tpUsuariosActivos.ResumeLayout(false);
            tpUsuariosActivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInformeUsuariosActivos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControlInformes;
        private TabPage tpRecursosConsultados;
        private TabPage tpInteraccionTema;
        private TabPage tpUsuariosActivos;
        private Label label2;
        private Label label1;
        private DataGridView DGVInformeRecursosConsultados;
        private ComboBox comboBox1;
        private Label label3;
        private DataGridViewTextBoxColumn colTituloRecurso;
        private DataGridViewTextBoxColumn colTema;
        private DataGridViewTextBoxColumn colMateria;
        private DataGridViewTextBoxColumn colVisitas;
        private Label LFiltroMateria2;
        private Label LInteraccionTema;
        private DataGridView DGVInformeInteraccion;
        private DataGridViewTextBoxColumn colTemaInteraccion;
        private DataGridViewTextBoxColumn colMateriaInteraccion;
        private DataGridViewTextBoxColumn colNotasInteraccion;
        private DataGridViewTextBoxColumn colFavoritos;
        private DataGridViewTextBoxColumn colComentarios;
        private ComboBox CBInteraccionMateria;
        private ComboBox CBRoles;
        private Label label5;
        private Label label4;
        private DataGridView DGVInformeUsuariosActivos;
        private DataGridViewTextBoxColumn colNombreUsuarios;
        private DataGridViewTextBoxColumn colPerfil;
        private DataGridViewTextBoxColumn colRecursosVistos;
        private DataGridViewTextBoxColumn colNotasCreadas;
        private DataGridViewTextBoxColumn colEvaluaciones;
    }
}