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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelRecurso = new Panel();
            panelCamposRecursos = new TableLayoutPanel();
            CBMateriaRecurso = new ComboBox();
            TBRuta = new TextBox();
            TBUrl = new TextBox();
            LMateriaRecurso = new Label();
            TBTexto = new TextBox();
            LTexto = new Label();
            LNombreRecurso = new Label();
            TBTituloRecurso = new TextBox();
            LTipoRecurso = new Label();
            CBTipoRecurso = new ComboBox();
            LURL = new Label();
            BRuta = new Button();
            labelEliminado = new Label();
            CBEliminado = new ComboBox();
            LTemaRecurso = new Label();
            CBTemaRecurso = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            CBFiltrarMateria = new ComboBox();
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
            IdRecurso = new DataGridViewTextBoxColumn();
            titulo = new DataGridViewTextBoxColumn();
            texto = new DataGridViewTextBoxColumn();
            Ruta = new DataGridViewTextBoxColumn();
            url = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            idTema = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            panelEncabezadoR = new FlowLayoutPanel();
            LTituloRecursos = new Label();
            panelRecurso.SuspendLayout();
            panelCamposRecursos.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVRecursos).BeginInit();
            panelEncabezadoR.SuspendLayout();
            SuspendLayout();
            // 
            // panelRecurso
            // 
            panelRecurso.BackColor = Color.PowderBlue;
            panelRecurso.Controls.Add(panelCamposRecursos);
            panelRecurso.Controls.Add(tableLayoutPanel2);
            panelRecurso.Controls.Add(tableLayoutPanel1);
            panelRecurso.Controls.Add(DGVRecursos);
            panelRecurso.Controls.Add(panelEncabezadoR);
            panelRecurso.Dock = DockStyle.Fill;
            panelRecurso.Location = new Point(0, 0);
            panelRecurso.Margin = new Padding(3, 4, 3, 4);
            panelRecurso.Name = "panelRecurso";
            panelRecurso.Size = new Size(914, 656);
            panelRecurso.TabIndex = 0;
            // 
            // panelCamposRecursos
            // 
            panelCamposRecursos.ColumnCount = 4;
            panelCamposRecursos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            panelCamposRecursos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            panelCamposRecursos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            panelCamposRecursos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            panelCamposRecursos.Controls.Add(CBMateriaRecurso, 3, 1);
            panelCamposRecursos.Controls.Add(TBRuta, 1, 3);
            panelCamposRecursos.Controls.Add(TBUrl, 3, 0);
            panelCamposRecursos.Controls.Add(LMateriaRecurso, 2, 1);
            panelCamposRecursos.Controls.Add(TBTexto, 1, 2);
            panelCamposRecursos.Controls.Add(LTexto, 0, 2);
            panelCamposRecursos.Controls.Add(LNombreRecurso, 0, 0);
            panelCamposRecursos.Controls.Add(TBTituloRecurso, 1, 0);
            panelCamposRecursos.Controls.Add(LTipoRecurso, 0, 1);
            panelCamposRecursos.Controls.Add(CBTipoRecurso, 1, 1);
            panelCamposRecursos.Controls.Add(LURL, 2, 0);
            panelCamposRecursos.Controls.Add(BRuta, 0, 3);
            panelCamposRecursos.Controls.Add(labelEliminado, 2, 3);
            panelCamposRecursos.Controls.Add(CBEliminado, 3, 3);
            panelCamposRecursos.Controls.Add(LTemaRecurso, 2, 2);
            panelCamposRecursos.Controls.Add(CBTemaRecurso, 3, 2);
            panelCamposRecursos.Location = new Point(74, 73);
            panelCamposRecursos.Name = "panelCamposRecursos";
            panelCamposRecursos.RowCount = 4;
            panelCamposRecursos.RowStyles.Add(new RowStyle(SizeType.Percent, 21.34868F));
            panelCamposRecursos.RowStyles.Add(new RowStyle(SizeType.Percent, 21.3486843F));
            panelCamposRecursos.RowStyles.Add(new RowStyle(SizeType.Percent, 25.25135F));
            panelCamposRecursos.RowStyles.Add(new RowStyle(SizeType.Percent, 32.05128F));
            panelCamposRecursos.Size = new Size(811, 179);
            panelCamposRecursos.TabIndex = 101;
            // 
            // CBMateriaRecurso
            // 
            CBMateriaRecurso.DropDownStyle = ComboBoxStyle.DropDownList;
            CBMateriaRecurso.FormattingEnabled = true;
            CBMateriaRecurso.Location = new Point(570, 41);
            CBMateriaRecurso.Name = "CBMateriaRecurso";
            CBMateriaRecurso.Size = new Size(179, 28);
            CBMateriaRecurso.TabIndex = 50;
            CBMateriaRecurso.Tag = "Materia";
            CBMateriaRecurso.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // TBRuta
            // 
            TBRuta.Location = new Point(165, 124);
            TBRuta.Name = "TBRuta";
            TBRuta.Size = new Size(156, 27);
            TBRuta.TabIndex = 48;
            TBRuta.Tag = "Ruta";
            // 
            // TBUrl
            // 
            TBUrl.Location = new Point(570, 3);
            TBUrl.Name = "TBUrl";
            TBUrl.Size = new Size(179, 27);
            TBUrl.TabIndex = 46;
            TBUrl.Tag = "URL";
            // 
            // LMateriaRecurso
            // 
            LMateriaRecurso.AutoSize = true;
            LMateriaRecurso.Location = new Point(408, 38);
            LMateriaRecurso.Name = "LMateriaRecurso";
            LMateriaRecurso.Size = new Size(60, 20);
            LMateriaRecurso.TabIndex = 49;
            LMateriaRecurso.Text = "Materia";
            LMateriaRecurso.Click += label1_Click;
            // 
            // TBTexto
            // 
            TBTexto.Location = new Point(165, 79);
            TBTexto.Name = "TBTexto";
            TBTexto.Size = new Size(156, 27);
            TBTexto.TabIndex = 43;
            TBTexto.Tag = "Texto";
            // 
            // LTexto
            // 
            LTexto.AutoSize = true;
            LTexto.Location = new Point(3, 76);
            LTexto.Name = "LTexto";
            LTexto.Size = new Size(45, 20);
            LTexto.TabIndex = 42;
            LTexto.Text = "Texto";
            // 
            // LNombreRecurso
            // 
            LNombreRecurso.AutoSize = true;
            LNombreRecurso.Location = new Point(3, 0);
            LNombreRecurso.Name = "LNombreRecurso";
            LNombreRecurso.Size = new Size(47, 20);
            LNombreRecurso.TabIndex = 22;
            LNombreRecurso.Text = "Titulo";
            // 
            // TBTituloRecurso
            // 
            TBTituloRecurso.Location = new Point(165, 3);
            TBTituloRecurso.Name = "TBTituloRecurso";
            TBTituloRecurso.Size = new Size(156, 27);
            TBTituloRecurso.TabIndex = 28;
            TBTituloRecurso.Tag = "Titulo";
            // 
            // LTipoRecurso
            // 
            LTipoRecurso.AutoSize = true;
            LTipoRecurso.Location = new Point(3, 38);
            LTipoRecurso.Name = "LTipoRecurso";
            LTipoRecurso.Size = new Size(116, 20);
            LTipoRecurso.TabIndex = 23;
            LTipoRecurso.Text = "Tipo de Recurso";
            // 
            // CBTipoRecurso
            // 
            CBTipoRecurso.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTipoRecurso.FormattingEnabled = true;
            CBTipoRecurso.Items.AddRange(new object[] { "Texto", "Imagen", "Recurso Web" });
            CBTipoRecurso.Location = new Point(165, 41);
            CBTipoRecurso.Name = "CBTipoRecurso";
            CBTipoRecurso.Size = new Size(156, 28);
            CBTipoRecurso.TabIndex = 39;
            CBTipoRecurso.Tag = "TipoRecurso";
            // 
            // LURL
            // 
            LURL.AutoSize = true;
            LURL.Location = new Point(408, 0);
            LURL.Name = "LURL";
            LURL.Size = new Size(35, 20);
            LURL.TabIndex = 24;
            LURL.Text = "URL";
            // 
            // BRuta
            // 
            BRuta.BackColor = SystemColors.MenuHighlight;
            BRuta.FlatAppearance.BorderSize = 0;
            BRuta.FlatStyle = FlatStyle.Flat;
            BRuta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BRuta.ForeColor = SystemColors.ButtonHighlight;
            BRuta.Location = new Point(3, 125);
            BRuta.Margin = new Padding(3, 4, 3, 4);
            BRuta.Name = "BRuta";
            BRuta.Size = new Size(130, 37);
            BRuta.TabIndex = 47;
            BRuta.Text = "Ruta Archivo:";
            BRuta.UseVisualStyleBackColor = false;
            // 
            // labelEliminado
            // 
            labelEliminado.AutoSize = true;
            labelEliminado.Location = new Point(408, 121);
            labelEliminado.Name = "labelEliminado";
            labelEliminado.Size = new Size(76, 20);
            labelEliminado.TabIndex = 44;
            labelEliminado.Text = "Eliminado";
            // 
            // CBEliminado
            // 
            CBEliminado.DropDownStyle = ComboBoxStyle.DropDownList;
            CBEliminado.FormattingEnabled = true;
            CBEliminado.Location = new Point(570, 124);
            CBEliminado.Name = "CBEliminado";
            CBEliminado.Size = new Size(151, 28);
            CBEliminado.TabIndex = 45;
            CBEliminado.Tag = "Eliminado";
            // 
            // LTemaRecurso
            // 
            LTemaRecurso.AutoSize = true;
            LTemaRecurso.Location = new Point(408, 76);
            LTemaRecurso.Name = "LTemaRecurso";
            LTemaRecurso.Size = new Size(45, 20);
            LTemaRecurso.TabIndex = 25;
            LTemaRecurso.Text = "Tema";
            // 
            // CBTemaRecurso
            // 
            CBTemaRecurso.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTemaRecurso.FormattingEnabled = true;
            CBTemaRecurso.Location = new Point(570, 79);
            CBTemaRecurso.Name = "CBTemaRecurso";
            CBTemaRecurso.Size = new Size(179, 28);
            CBTemaRecurso.TabIndex = 32;
            CBTemaRecurso.Tag = "Tema";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(CBFiltrarMateria, 0, 1);
            tableLayoutPanel2.Controls.Add(TBBuscadorRecurso, 0, 0);
            tableLayoutPanel2.Controls.Add(BRecursosActivos, 1, 0);
            tableLayoutPanel2.Controls.Add(BRecursosInactivos, 2, 0);
            tableLayoutPanel2.Controls.Add(CBFiltrarTema, 0, 2);
            tableLayoutPanel2.Location = new Point(71, 371);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(811, 139);
            tableLayoutPanel2.TabIndex = 100;
            // 
            // CBFiltrarMateria
            // 
            CBFiltrarMateria.FormattingEnabled = true;
            CBFiltrarMateria.Location = new Point(3, 49);
            CBFiltrarMateria.Name = "CBFiltrarMateria";
            CBFiltrarMateria.Size = new Size(236, 28);
            CBFiltrarMateria.TabIndex = 51;
            CBFiltrarMateria.Text = "Filtrar por Materia...";
            // 
            // TBBuscadorRecurso
            // 
            TBBuscadorRecurso.Location = new Point(3, 3);
            TBBuscadorRecurso.Name = "TBBuscadorRecurso";
            TBBuscadorRecurso.PlaceholderText = "Buscar recurso..";
            TBBuscadorRecurso.Size = new Size(236, 27);
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
            BRecursosActivos.Location = new Point(614, 3);
            BRecursosActivos.Name = "BRecursosActivos";
            BRecursosActivos.Size = new Size(94, 29);
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
            BRecursosInactivos.Location = new Point(714, 3);
            BRecursosInactivos.Name = "BRecursosInactivos";
            BRecursosInactivos.Size = new Size(94, 29);
            BRecursosInactivos.TabIndex = 64;
            BRecursosInactivos.Text = "Inactivos";
            BRecursosInactivos.UseVisualStyleBackColor = false;
            // 
            // CBFiltrarTema
            // 
            CBFiltrarTema.FormattingEnabled = true;
            CBFiltrarTema.Location = new Point(3, 95);
            CBFiltrarTema.Name = "CBFiltrarTema";
            CBFiltrarTema.Size = new Size(236, 28);
            CBFiltrarTema.TabIndex = 28;
            CBFiltrarTema.Text = "Filtrar por Tema...";
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
            tableLayoutPanel1.Location = new Point(464, 267);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.Size = new Size(421, 51);
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
            BGuardarRecurso.Location = new Point(3, 3);
            BGuardarRecurso.Name = "BGuardarRecurso";
            BGuardarRecurso.Size = new Size(94, 29);
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
            BEliminarRecurso.Location = new Point(305, 3);
            BEliminarRecurso.Name = "BEliminarRecurso";
            BEliminarRecurso.Size = new Size(94, 29);
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
            BCancelarRecurso.Location = new Point(103, 3);
            BCancelarRecurso.Name = "BCancelarRecurso";
            BCancelarRecurso.Size = new Size(94, 29);
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
            BModificarRecurso.Location = new Point(203, 3);
            BModificarRecurso.Name = "BModificarRecurso";
            BModificarRecurso.Size = new Size(96, 29);
            BModificarRecurso.TabIndex = 90;
            BModificarRecurso.Text = "Modificar";
            BModificarRecurso.UseVisualStyleBackColor = false;
            BModificarRecurso.Visible = false;
            // 
            // DGVRecursos
            // 
            DGVRecursos.AllowUserToAddRows = false;
            DGVRecursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVRecursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVRecursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVRecursos.Columns.AddRange(new DataGridViewColumn[] { IdRecurso, titulo, texto, Ruta, url, Tipo, idTema, colAcciones });
            DGVRecursos.Location = new Point(69, 515);
            DGVRecursos.Name = "DGVRecursos";
            DGVRecursos.ReadOnly = true;
            DGVRecursos.RowHeadersWidth = 51;
            DGVRecursos.Size = new Size(814, 101);
            DGVRecursos.TabIndex = 98;
            // 
            // IdRecurso
            // 
            IdRecurso.HeaderText = "ID";
            IdRecurso.MinimumWidth = 6;
            IdRecurso.Name = "IdRecurso";
            IdRecurso.ReadOnly = true;
            // 
            // titulo
            // 
            titulo.HeaderText = "Titulo";
            titulo.MinimumWidth = 6;
            titulo.Name = "titulo";
            titulo.ReadOnly = true;
            // 
            // texto
            // 
            texto.HeaderText = "Texto";
            texto.MinimumWidth = 6;
            texto.Name = "texto";
            texto.ReadOnly = true;
            // 
            // Ruta
            // 
            Ruta.HeaderText = "Ruta";
            Ruta.MinimumWidth = 6;
            Ruta.Name = "Ruta";
            Ruta.ReadOnly = true;
            // 
            // url
            // 
            url.HeaderText = "URL";
            url.MinimumWidth = 6;
            url.Name = "url";
            url.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo de Recurso";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // idTema
            // 
            idTema.HeaderText = "Tema";
            idTema.MinimumWidth = 6;
            idTema.Name = "idTema";
            idTema.ReadOnly = true;
            // 
            // colAcciones
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SlateGray;
            colAcciones.DefaultCellStyle = dataGridViewCellStyle1;
            colAcciones.FlatStyle = FlatStyle.Flat;
            colAcciones.HeaderText = "Acciones";
            colAcciones.MinimumWidth = 6;
            colAcciones.Name = "colAcciones";
            colAcciones.ReadOnly = true;
            colAcciones.Text = "Ver ";
            colAcciones.UseColumnTextForButtonValue = true;
            // 
            // panelEncabezadoR
            // 
            panelEncabezadoR.Controls.Add(LTituloRecursos);
            panelEncabezadoR.Dock = DockStyle.Top;
            panelEncabezadoR.Location = new Point(0, 0);
            panelEncabezadoR.Name = "panelEncabezadoR";
            panelEncabezadoR.Size = new Size(914, 67);
            panelEncabezadoR.TabIndex = 97;
            // 
            // LTituloRecursos
            // 
            LTituloRecursos.AutoSize = true;
            LTituloRecursos.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloRecursos.Location = new Point(3, 0);
            LTituloRecursos.Name = "LTituloRecursos";
            LTituloRecursos.Size = new Size(280, 38);
            LTituloRecursos.TabIndex = 1;
            LTituloRecursos.Text = "Gestion de Recursos";
            // 
            // FormGestionRecursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 656);
            Controls.Add(panelRecurso);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionRecursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGestionRecursos";
            panelRecurso.ResumeLayout(false);
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

        private Panel panelRecurso;
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
        private Label LURL;
        private Label LURLRecurso;
        private Button BURL;
        //private TextBox //this.BRuta;
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
        private ComboBox CBEliminado;
        private Label labelEliminado;
        private TextBox TBTexto;
        private Label LTexto;
        private TextBox TBUrl;
        private TextBox TBRuta;
        private Button BRuta;
        private DataGridViewTextBoxColumn IdRecurso;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn texto;
        private DataGridViewTextBoxColumn Ruta;
        private DataGridViewTextBoxColumn url;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn idTema;
        private DataGridViewButtonColumn colAcciones;
        //private ComboBox CBMateriaRecurso;
        private Label LMateriaRecurso;
        private ComboBox CBFiltrarMateria;
    }
}