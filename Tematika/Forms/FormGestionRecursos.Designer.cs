namespace Tematika.Forms
{
    partial class FormGestionRecursos
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
            panelCamposRecursos = new TableLayoutPanel();
            LNombreRecurso = new Label();
            TBTituloRecurso = new TextBox();
            LTipoRecurso = new Label();
            CBTipoRecurso = new ComboBox();
            CBTemaRecurso = new ComboBox();
            LDescripcionRecurso = new Label();
            LTemaRecurso = new Label();
            CBMateriaRecurso = new ComboBox();
            TBDescripcionRecurso = new TextBox();
            TBUrl = new TextBox();
            LMateriaRecurso = new Label();
            LURLRecurso = new Label();
            BFoto = new Button();
            TBFoto = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            TBBuscadorRecurso = new TextBox();
            BRecursosActivos = new Button();
            BRecursosInactivos = new Button();
            CBFiltrarTema = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            BGuardarRecurso = new Button();
            BEliminarRecurso = new Button();
            BCancelarRecurso = new Button();
            BModificarRecurso = new Button();
            DGVRecursos = new DataGridView();
            panelEncabezadoR = new FlowLayoutPanel();
            LTituloRecursos = new Label();
            IdRecurso = new DataGridViewTextBoxColumn();
            titulo = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            url = new DataGridViewTextBoxColumn();
            idMateria = new DataGridViewTextBoxColumn();
            idTema = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panelCamposRecursos.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVRecursos).BeginInit();
            panelEncabezadoR.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(panelCamposRecursos);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(DGVRecursos);
            panel1.Controls.Add(panelEncabezadoR);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panelCamposRecursos
            // 
            panelCamposRecursos.ColumnCount = 4;
            panelCamposRecursos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelCamposRecursos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelCamposRecursos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelCamposRecursos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelCamposRecursos.Controls.Add(LNombreRecurso, 0, 0);
            panelCamposRecursos.Controls.Add(TBTituloRecurso, 1, 0);
            panelCamposRecursos.Controls.Add(LTipoRecurso, 0, 1);
            panelCamposRecursos.Controls.Add(CBTipoRecurso, 1, 1);
            panelCamposRecursos.Controls.Add(CBTemaRecurso, 3, 2);
            panelCamposRecursos.Controls.Add(LDescripcionRecurso, 0, 2);
            panelCamposRecursos.Controls.Add(LTemaRecurso, 2, 2);
            panelCamposRecursos.Controls.Add(CBMateriaRecurso, 3, 1);
            panelCamposRecursos.Controls.Add(TBDescripcionRecurso, 1, 2);
            panelCamposRecursos.Controls.Add(TBUrl, 3, 0);
            panelCamposRecursos.Controls.Add(LMateriaRecurso, 2, 1);
            panelCamposRecursos.Controls.Add(LURLRecurso, 2, 0);
            panelCamposRecursos.Controls.Add(BFoto, 0, 3);
            panelCamposRecursos.Controls.Add(TBFoto, 1, 3);
            panelCamposRecursos.Location = new Point(65, 52);
            panelCamposRecursos.Margin = new Padding(3, 2, 3, 2);
            panelCamposRecursos.Name = "panelCamposRecursos";
            panelCamposRecursos.RowCount = 4;
            panelCamposRecursos.RowStyles.Add(new RowStyle(SizeType.Percent, 21.3486843F));
            panelCamposRecursos.RowStyles.Add(new RowStyle(SizeType.Percent, 21.3486843F));
            panelCamposRecursos.RowStyles.Add(new RowStyle(SizeType.Percent, 25.25135F));
            panelCamposRecursos.RowStyles.Add(new RowStyle(SizeType.Percent, 32.0512848F));
            panelCamposRecursos.Size = new Size(654, 126);
            panelCamposRecursos.TabIndex = 101;
            // 
            // LNombreRecurso
            // 
            LNombreRecurso.AutoSize = true;
            LNombreRecurso.Location = new Point(3, 0);
            LNombreRecurso.Name = "LNombreRecurso";
            LNombreRecurso.Size = new Size(37, 15);
            LNombreRecurso.TabIndex = 22;
            LNombreRecurso.Text = "Titulo";
            // 
            // TBTituloRecurso
            // 
            TBTituloRecurso.Location = new Point(166, 2);
            TBTituloRecurso.Margin = new Padding(3, 2, 3, 2);
            TBTituloRecurso.Name = "TBTituloRecurso";
            TBTituloRecurso.Size = new Size(110, 23);
            TBTituloRecurso.TabIndex = 28;
            // 
            // LTipoRecurso
            // 
            LTipoRecurso.AutoSize = true;
            LTipoRecurso.Location = new Point(3, 26);
            LTipoRecurso.Name = "LTipoRecurso";
            LTipoRecurso.Size = new Size(91, 15);
            LTipoRecurso.TabIndex = 23;
            LTipoRecurso.Text = "Tipo de Recurso";
            // 
            // CBTipoRecurso
            // 
            CBTipoRecurso.FormattingEnabled = true;
            CBTipoRecurso.Location = new Point(166, 28);
            CBTipoRecurso.Margin = new Padding(3, 2, 3, 2);
            CBTipoRecurso.Name = "CBTipoRecurso";
            CBTipoRecurso.Size = new Size(133, 23);
            CBTipoRecurso.TabIndex = 39;
            // 
            // CBTemaRecurso
            // 
            CBTemaRecurso.FormattingEnabled = true;
            CBTemaRecurso.Location = new Point(492, 54);
            CBTemaRecurso.Margin = new Padding(3, 2, 3, 2);
            CBTemaRecurso.Name = "CBTemaRecurso";
            CBTemaRecurso.Size = new Size(133, 23);
            CBTemaRecurso.TabIndex = 32;
            // 
            // LDescripcionRecurso
            // 
            LDescripcionRecurso.AutoSize = true;
            LDescripcionRecurso.Location = new Point(3, 52);
            LDescripcionRecurso.Name = "LDescripcionRecurso";
            LDescripcionRecurso.Size = new Size(69, 15);
            LDescripcionRecurso.TabIndex = 26;
            LDescripcionRecurso.Text = "Descripcion";
            // 
            // LTemaRecurso
            // 
            LTemaRecurso.AutoSize = true;
            LTemaRecurso.Location = new Point(329, 52);
            LTemaRecurso.Name = "LTemaRecurso";
            LTemaRecurso.Size = new Size(35, 15);
            LTemaRecurso.TabIndex = 25;
            LTemaRecurso.Text = "Tema";
            // 
            // CBMateriaRecurso
            // 
            CBMateriaRecurso.FormattingEnabled = true;
            CBMateriaRecurso.Location = new Point(492, 28);
            CBMateriaRecurso.Margin = new Padding(3, 2, 3, 2);
            CBMateriaRecurso.Name = "CBMateriaRecurso";
            CBMateriaRecurso.Size = new Size(133, 23);
            CBMateriaRecurso.TabIndex = 31;
            // 
            // TBDescripcionRecurso
            // 
            TBDescripcionRecurso.Location = new Point(166, 54);
            TBDescripcionRecurso.Margin = new Padding(3, 2, 3, 2);
            TBDescripcionRecurso.Multiline = true;
            TBDescripcionRecurso.Name = "TBDescripcionRecurso";
            TBDescripcionRecurso.Size = new Size(157, 23);
            TBDescripcionRecurso.TabIndex = 29;
            // 
            // TBUrl
            // 
            TBUrl.Location = new Point(492, 2);
            TBUrl.Margin = new Padding(3, 2, 3, 2);
            TBUrl.Name = "TBUrl";
            TBUrl.Size = new Size(110, 23);
            TBUrl.TabIndex = 30;
            // 
            // LMateriaRecurso
            // 
            LMateriaRecurso.AutoSize = true;
            LMateriaRecurso.Location = new Point(329, 26);
            LMateriaRecurso.Name = "LMateriaRecurso";
            LMateriaRecurso.Size = new Size(47, 15);
            LMateriaRecurso.TabIndex = 24;
            LMateriaRecurso.Text = "Materia";
            // 
            // LURLRecurso
            // 
            LURLRecurso.AutoSize = true;
            LURLRecurso.Location = new Point(329, 0);
            LURLRecurso.Name = "LURLRecurso";
            LURLRecurso.Size = new Size(28, 15);
            LURLRecurso.TabIndex = 27;
            LURLRecurso.Text = "URL";
            // 
            // BFoto
            // 
            BFoto.BackColor = Color.Gray;
            BFoto.FlatAppearance.BorderSize = 0;
            BFoto.FlatStyle = FlatStyle.Flat;
            BFoto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BFoto.ForeColor = SystemColors.ButtonHighlight;
            BFoto.Location = new Point(3, 85);
            BFoto.Margin = new Padding(3, 2, 3, 2);
            BFoto.Name = "BFoto";
            BFoto.Size = new Size(82, 22);
            BFoto.TabIndex = 40;
            BFoto.Text = "Foto";
            BFoto.UseVisualStyleBackColor = false;
            // 
            // TBFoto
            // 
            TBFoto.Location = new Point(166, 85);
            TBFoto.Margin = new Padding(3, 2, 3, 2);
            TBFoto.Name = "TBFoto";
            TBFoto.Size = new Size(157, 23);
            TBFoto.TabIndex = 41;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(TBBuscadorRecurso, 0, 0);
            tableLayoutPanel2.Controls.Add(BRecursosActivos, 1, 0);
            tableLayoutPanel2.Controls.Add(BRecursosInactivos, 2, 0);
            tableLayoutPanel2.Controls.Add(CBFiltrarTema, 0, 1);
            tableLayoutPanel2.Location = new Point(62, 278);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(710, 77);
            tableLayoutPanel2.TabIndex = 100;
            // 
            // TBBuscadorRecurso
            // 
            TBBuscadorRecurso.Location = new Point(3, 2);
            TBBuscadorRecurso.Margin = new Padding(3, 2, 3, 2);
            TBBuscadorRecurso.Name = "TBBuscadorRecurso";
            TBBuscadorRecurso.PlaceholderText = "Buscar recurso..";
            TBBuscadorRecurso.Size = new Size(207, 23);
            TBBuscadorRecurso.TabIndex = 62;
            // 
            // BRecursosActivos
            // 
            BRecursosActivos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BRecursosActivos.BackColor = SystemColors.Highlight;
            BRecursosActivos.FlatAppearance.BorderSize = 0;
            BRecursosActivos.FlatStyle = FlatStyle.Flat;
            BRecursosActivos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BRecursosActivos.ForeColor = SystemColors.ButtonHighlight;
            BRecursosActivos.Location = new Point(537, 2);
            BRecursosActivos.Margin = new Padding(3, 2, 3, 2);
            BRecursosActivos.Name = "BRecursosActivos";
            BRecursosActivos.Size = new Size(82, 22);
            BRecursosActivos.TabIndex = 63;
            BRecursosActivos.Text = "Activos";
            BRecursosActivos.UseVisualStyleBackColor = false;
            // 
            // BRecursosInactivos
            // 
            BRecursosInactivos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BRecursosInactivos.BackColor = Color.Gray;
            BRecursosInactivos.FlatAppearance.BorderSize = 0;
            BRecursosInactivos.FlatStyle = FlatStyle.Flat;
            BRecursosInactivos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BRecursosInactivos.ForeColor = SystemColors.ButtonHighlight;
            BRecursosInactivos.Location = new Point(625, 2);
            BRecursosInactivos.Margin = new Padding(3, 2, 3, 2);
            BRecursosInactivos.Name = "BRecursosInactivos";
            BRecursosInactivos.Size = new Size(82, 22);
            BRecursosInactivos.TabIndex = 64;
            BRecursosInactivos.Text = "Inactivos";
            BRecursosInactivos.UseVisualStyleBackColor = false;
            // 
            // CBFiltrarTema
            // 
            CBFiltrarTema.FormattingEnabled = true;
            CBFiltrarTema.Location = new Point(3, 52);
            CBFiltrarTema.Margin = new Padding(3, 2, 3, 2);
            CBFiltrarTema.Name = "CBFiltrarTema";
            CBFiltrarTema.Size = new Size(159, 23);
            CBFiltrarTema.TabIndex = 28;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(BGuardarRecurso, 0, 0);
            tableLayoutPanel1.Controls.Add(BEliminarRecurso, 3, 0);
            tableLayoutPanel1.Controls.Add(BCancelarRecurso, 1, 0);
            tableLayoutPanel1.Controls.Add(BModificarRecurso, 2, 0);
            tableLayoutPanel1.Location = new Point(406, 192);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.Size = new Size(368, 38);
            tableLayoutPanel1.TabIndex = 99;
            // 
            // BGuardarRecurso
            // 
            BGuardarRecurso.BackColor = Color.ForestGreen;
            BGuardarRecurso.FlatAppearance.BorderSize = 0;
            BGuardarRecurso.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 125, 50);
            BGuardarRecurso.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 160, 71);
            BGuardarRecurso.FlatStyle = FlatStyle.Flat;
            BGuardarRecurso.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BGuardarRecurso.ForeColor = SystemColors.ButtonHighlight;
            BGuardarRecurso.Location = new Point(3, 2);
            BGuardarRecurso.Margin = new Padding(3, 2, 3, 2);
            BGuardarRecurso.Name = "BGuardarRecurso";
            BGuardarRecurso.Size = new Size(82, 22);
            BGuardarRecurso.TabIndex = 88;
            BGuardarRecurso.Text = "Guardar";
            BGuardarRecurso.UseVisualStyleBackColor = false;
            // 
            // BEliminarRecurso
            // 
            BEliminarRecurso.BackColor = Color.OrangeRed;
            BEliminarRecurso.FlatAppearance.BorderSize = 0;
            BEliminarRecurso.FlatStyle = FlatStyle.Flat;
            BEliminarRecurso.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BEliminarRecurso.ForeColor = SystemColors.ButtonHighlight;
            BEliminarRecurso.Location = new Point(269, 2);
            BEliminarRecurso.Margin = new Padding(3, 2, 3, 2);
            BEliminarRecurso.Name = "BEliminarRecurso";
            BEliminarRecurso.Size = new Size(82, 22);
            BEliminarRecurso.TabIndex = 91;
            BEliminarRecurso.Text = "Eliminar";
            BEliminarRecurso.UseVisualStyleBackColor = false;
            BEliminarRecurso.Visible = false;
            // 
            // BCancelarRecurso
            // 
            BCancelarRecurso.BackColor = Color.Gray;
            BCancelarRecurso.FlatAppearance.BorderSize = 0;
            BCancelarRecurso.FlatStyle = FlatStyle.Flat;
            BCancelarRecurso.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BCancelarRecurso.ForeColor = SystemColors.ButtonHighlight;
            BCancelarRecurso.Location = new Point(91, 2);
            BCancelarRecurso.Margin = new Padding(3, 2, 3, 2);
            BCancelarRecurso.Name = "BCancelarRecurso";
            BCancelarRecurso.Size = new Size(82, 22);
            BCancelarRecurso.TabIndex = 89;
            BCancelarRecurso.Text = "Cancelar";
            BCancelarRecurso.UseVisualStyleBackColor = false;
            // 
            // BModificarRecurso
            // 
            BModificarRecurso.BackColor = SystemColors.Highlight;
            BModificarRecurso.FlatAppearance.BorderSize = 0;
            BModificarRecurso.FlatStyle = FlatStyle.Flat;
            BModificarRecurso.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BModificarRecurso.ForeColor = SystemColors.ButtonHighlight;
            BModificarRecurso.Location = new Point(179, 2);
            BModificarRecurso.Margin = new Padding(3, 2, 3, 2);
            BModificarRecurso.Name = "BModificarRecurso";
            BModificarRecurso.Size = new Size(84, 22);
            BModificarRecurso.TabIndex = 90;
            BModificarRecurso.Text = "Modificar";
            BModificarRecurso.UseVisualStyleBackColor = false;
            BModificarRecurso.Visible = false;
            // 
            // DGVRecursos
            // 
            DGVRecursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVRecursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVRecursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVRecursos.Columns.AddRange(new DataGridViewColumn[] { IdRecurso, titulo, Tipo, descripcion, url, idMateria, idTema, colAcciones });
            DGVRecursos.Location = new Point(62, 366);
            DGVRecursos.Margin = new Padding(3, 2, 3, 2);
            DGVRecursos.Name = "DGVRecursos";
            DGVRecursos.RowHeadersWidth = 51;
            DGVRecursos.Size = new Size(712, 88);
            DGVRecursos.TabIndex = 98;
            // 
            // panelEncabezadoR
            // 
            panelEncabezadoR.Controls.Add(LTituloRecursos);
            panelEncabezadoR.Dock = DockStyle.Top;
            panelEncabezadoR.Location = new Point(0, 0);
            panelEncabezadoR.Margin = new Padding(3, 2, 3, 2);
            panelEncabezadoR.Name = "panelEncabezadoR";
            panelEncabezadoR.Size = new Size(800, 50);
            panelEncabezadoR.TabIndex = 97;
            // 
            // LTituloRecursos
            // 
            LTituloRecursos.AutoSize = true;
            LTituloRecursos.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloRecursos.Location = new Point(3, 0);
            LTituloRecursos.Name = "LTituloRecursos";
            LTituloRecursos.Size = new Size(222, 30);
            LTituloRecursos.TabIndex = 1;
            LTituloRecursos.Text = "Gestion de Recursos";
            // 
            // IdRecurso
            // 
            IdRecurso.HeaderText = "ID";
            IdRecurso.MinimumWidth = 6;
            IdRecurso.Name = "IdRecurso";
            // 
            // titulo
            // 
            titulo.HeaderText = "Titulo";
            titulo.MinimumWidth = 6;
            titulo.Name = "titulo";
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo de Recurso";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            // 
            // url
            // 
            url.HeaderText = "URL";
            url.MinimumWidth = 6;
            url.Name = "url";
            // 
            // idMateria
            // 
            idMateria.HeaderText = "Materia";
            idMateria.MinimumWidth = 6;
            idMateria.Name = "idMateria";
            // 
            // idTema
            // 
            idTema.HeaderText = "Tema";
            idTema.MinimumWidth = 6;
            idTema.Name = "idTema";
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "Acciones";
            colAcciones.MinimumWidth = 6;
            colAcciones.Name = "colAcciones";
            colAcciones.Text = "Ver ";
            colAcciones.UseColumnTextForButtonValue = true;
            // 
            // FormGestionRecursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormGestionRecursos";
            Text = "FormGestionRecursos";
            panel1.ResumeLayout(false);
            panelCamposRecursos.ResumeLayout(false);
            panelCamposRecursos.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVRecursos).EndInit();
            panelEncabezadoR.ResumeLayout(false);
            panelEncabezadoR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel panelCamposRecursos;
        private Label LNombreRecurso;
        private TextBox TBTituloRecurso;
        private Label LTipoRecurso;
        private ComboBox CBTipoRecurso;
        private ComboBox CBTemaRecurso;
        private Label LDescripcionRecurso;
        private Label LTemaRecurso;
        private ComboBox CBMateriaRecurso;
        private TextBox TBDescripcionRecurso;
        private TextBox TBUrl;
        private Label LMateriaRecurso;
        private Label LURLRecurso;
        private Button BFoto;
        private TextBox TBFoto;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox TBBuscadorRecurso;
        private Button BRecursosActivos;
        private Button BRecursosInactivos;
        private ComboBox CBFiltrarTema;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BGuardarRecurso;
        private Button BEliminarRecurso;
        private Button BCancelarRecurso;
        private Button BModificarRecurso;
        private DataGridView DGVRecursos;
        private FlowLayoutPanel panelEncabezadoR;
        private Label LTituloRecursos;
        private DataGridViewTextBoxColumn IdRecurso;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn url;
        private DataGridViewTextBoxColumn idMateria;
        private DataGridViewTextBoxColumn idTema;
        private DataGridViewButtonColumn colAcciones;
    }
}