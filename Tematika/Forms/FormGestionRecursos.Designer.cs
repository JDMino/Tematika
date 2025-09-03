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
            panelMainRecursos = new Panel();
            BInactivosRecursos = new Button();
            BActivosRecursos = new Button();
            CBTipoRecurso = new ComboBox();
            BEliminarRecurso = new Button();
            BModificarRecurso = new Button();
            BCancelarRecurso = new Button();
            BGuardarRecurso = new Button();
            TBBuscadorRecursos = new TextBox();
            DGVRecursos = new DataGridView();
            id_recurso = new DataGridViewTextBoxColumn();
            tituloRecurso = new DataGridViewTextBoxColumn();
            TipoRecurso = new DataGridViewTextBoxColumn();
            descripcionRecurso = new DataGridViewTextBoxColumn();
            URLRecurso = new DataGridViewTextBoxColumn();
            MateriaRecurso = new DataGridViewTextBoxColumn();
            TemaRecurso = new DataGridViewTextBoxColumn();
            CBTemaRecurso = new ComboBox();
            CBMateriaRecurso = new ComboBox();
            TBUrl = new TextBox();
            TBDescripcionRecurso = new TextBox();
            TBTituloRecurso = new TextBox();
            LURLRecurso = new Label();
            LDescripcionRecurso = new Label();
            LTemaRecurso = new Label();
            LMateriaRecurso = new Label();
            LTipoRecurso = new Label();
            LNombreRecurso = new Label();
            panel1 = new Panel();
            LTituloRecursos = new Label();
            panelMainRecursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVRecursos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMainRecursos
            // 
            panelMainRecursos.BackColor = SystemColors.GradientActiveCaption;
            panelMainRecursos.Controls.Add(BInactivosRecursos);
            panelMainRecursos.Controls.Add(BActivosRecursos);
            panelMainRecursos.Controls.Add(CBTipoRecurso);
            panelMainRecursos.Controls.Add(BEliminarRecurso);
            panelMainRecursos.Controls.Add(BModificarRecurso);
            panelMainRecursos.Controls.Add(BCancelarRecurso);
            panelMainRecursos.Controls.Add(BGuardarRecurso);
            panelMainRecursos.Controls.Add(TBBuscadorRecursos);
            panelMainRecursos.Controls.Add(DGVRecursos);
            panelMainRecursos.Controls.Add(CBTemaRecurso);
            panelMainRecursos.Controls.Add(CBMateriaRecurso);
            panelMainRecursos.Controls.Add(TBUrl);
            panelMainRecursos.Controls.Add(TBDescripcionRecurso);
            panelMainRecursos.Controls.Add(TBTituloRecurso);
            panelMainRecursos.Controls.Add(LURLRecurso);
            panelMainRecursos.Controls.Add(LDescripcionRecurso);
            panelMainRecursos.Controls.Add(LTemaRecurso);
            panelMainRecursos.Controls.Add(LMateriaRecurso);
            panelMainRecursos.Controls.Add(LTipoRecurso);
            panelMainRecursos.Controls.Add(LNombreRecurso);
            panelMainRecursos.Controls.Add(panel1);
            panelMainRecursos.Dock = DockStyle.Fill;
            panelMainRecursos.Location = new Point(0, 0);
            panelMainRecursos.Name = "panelMainRecursos";
            panelMainRecursos.Size = new Size(957, 523);
            panelMainRecursos.TabIndex = 0;
            // 
            // BInactivosRecursos
            // 
            BInactivosRecursos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BInactivosRecursos.Location = new Point(844, 318);
            BInactivosRecursos.Name = "BInactivosRecursos";
            BInactivosRecursos.Size = new Size(94, 29);
            BInactivosRecursos.TabIndex = 21;
            BInactivosRecursos.Text = "Inactivos";
            BInactivosRecursos.UseVisualStyleBackColor = true;
            // 
            // BActivosRecursos
            // 
            BActivosRecursos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BActivosRecursos.Location = new Point(744, 318);
            BActivosRecursos.Name = "BActivosRecursos";
            BActivosRecursos.Size = new Size(94, 29);
            BActivosRecursos.TabIndex = 20;
            BActivosRecursos.Text = "Activos";
            BActivosRecursos.UseVisualStyleBackColor = true;
            // 
            // CBTipoRecurso
            // 
            CBTipoRecurso.FormattingEnabled = true;
            CBTipoRecurso.Location = new Point(258, 124);
            CBTipoRecurso.Name = "CBTipoRecurso";
            CBTipoRecurso.Size = new Size(151, 28);
            CBTipoRecurso.TabIndex = 19;
            // 
            // BEliminarRecurso
            // 
            BEliminarRecurso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BEliminarRecurso.Location = new Point(652, 252);
            BEliminarRecurso.Name = "BEliminarRecurso";
            BEliminarRecurso.Size = new Size(94, 29);
            BEliminarRecurso.TabIndex = 18;
            BEliminarRecurso.Text = "Eliminar";
            BEliminarRecurso.UseVisualStyleBackColor = true;
            BEliminarRecurso.Visible = false;
            // 
            // BModificarRecurso
            // 
            BModificarRecurso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BModificarRecurso.Location = new Point(543, 252);
            BModificarRecurso.Name = "BModificarRecurso";
            BModificarRecurso.Size = new Size(94, 29);
            BModificarRecurso.TabIndex = 17;
            BModificarRecurso.Text = "Modificar";
            BModificarRecurso.UseVisualStyleBackColor = true;
            BModificarRecurso.Visible = false;
            // 
            // BCancelarRecurso
            // 
            BCancelarRecurso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCancelarRecurso.Location = new Point(652, 201);
            BCancelarRecurso.Name = "BCancelarRecurso";
            BCancelarRecurso.Size = new Size(94, 29);
            BCancelarRecurso.TabIndex = 16;
            BCancelarRecurso.Text = "Cancelar";
            BCancelarRecurso.UseVisualStyleBackColor = true;
            // 
            // BGuardarRecurso
            // 
            BGuardarRecurso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BGuardarRecurso.Location = new Point(541, 201);
            BGuardarRecurso.Name = "BGuardarRecurso";
            BGuardarRecurso.Size = new Size(94, 29);
            BGuardarRecurso.TabIndex = 15;
            BGuardarRecurso.Text = "Guardar";
            BGuardarRecurso.UseVisualStyleBackColor = true;
            // 
            // TBBuscadorRecursos
            // 
            TBBuscadorRecursos.Location = new Point(3, 320);
            TBBuscadorRecursos.Name = "TBBuscadorRecursos";
            TBBuscadorRecursos.Size = new Size(182, 27);
            TBBuscadorRecursos.TabIndex = 14;
            // 
            // DGVRecursos
            // 
            DGVRecursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVRecursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVRecursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVRecursos.Columns.AddRange(new DataGridViewColumn[] { id_recurso, tituloRecurso, TipoRecurso, descripcionRecurso, URLRecurso, MateriaRecurso, TemaRecurso });
            DGVRecursos.Location = new Point(-3, 353);
            DGVRecursos.Name = "DGVRecursos";
            DGVRecursos.RowHeadersWidth = 51;
            DGVRecursos.Size = new Size(957, 158);
            DGVRecursos.TabIndex = 13;
            DGVRecursos.CellClick += DGVRecursos_CellClick;
            // 
            // id_recurso
            // 
            id_recurso.HeaderText = "ID";
            id_recurso.MinimumWidth = 6;
            id_recurso.Name = "id_recurso";
            // 
            // tituloRecurso
            // 
            tituloRecurso.HeaderText = "Titulo";
            tituloRecurso.MinimumWidth = 6;
            tituloRecurso.Name = "tituloRecurso";
            // 
            // TipoRecurso
            // 
            TipoRecurso.HeaderText = "Tipo de Recurso";
            TipoRecurso.MinimumWidth = 6;
            TipoRecurso.Name = "TipoRecurso";
            // 
            // descripcionRecurso
            // 
            descripcionRecurso.HeaderText = "Descripcion";
            descripcionRecurso.MinimumWidth = 6;
            descripcionRecurso.Name = "descripcionRecurso";
            // 
            // URLRecurso
            // 
            URLRecurso.HeaderText = "URL";
            URLRecurso.MinimumWidth = 6;
            URLRecurso.Name = "URLRecurso";
            // 
            // MateriaRecurso
            // 
            MateriaRecurso.HeaderText = "Materia";
            MateriaRecurso.MinimumWidth = 6;
            MateriaRecurso.Name = "MateriaRecurso";
            // 
            // TemaRecurso
            // 
            TemaRecurso.HeaderText = "Tema";
            TemaRecurso.MinimumWidth = 6;
            TemaRecurso.Name = "TemaRecurso";
            // 
            // CBTemaRecurso
            // 
            CBTemaRecurso.FormattingEnabled = true;
            CBTemaRecurso.Location = new Point(542, 119);
            CBTemaRecurso.Name = "CBTemaRecurso";
            CBTemaRecurso.Size = new Size(151, 28);
            CBTemaRecurso.TabIndex = 12;
            // 
            // CBMateriaRecurso
            // 
            CBMateriaRecurso.FormattingEnabled = true;
            CBMateriaRecurso.Location = new Point(542, 79);
            CBMateriaRecurso.Name = "CBMateriaRecurso";
            CBMateriaRecurso.Size = new Size(151, 28);
            CBMateriaRecurso.TabIndex = 11;
            // 
            // TBUrl
            // 
            TBUrl.Location = new Point(258, 249);
            TBUrl.Name = "TBUrl";
            TBUrl.Size = new Size(125, 27);
            TBUrl.TabIndex = 10;
            // 
            // TBDescripcionRecurso
            // 
            TBDescripcionRecurso.Location = new Point(258, 167);
            TBDescripcionRecurso.Multiline = true;
            TBDescripcionRecurso.Name = "TBDescripcionRecurso";
            TBDescripcionRecurso.Size = new Size(251, 56);
            TBDescripcionRecurso.TabIndex = 9;
            // 
            // TBTituloRecurso
            // 
            TBTituloRecurso.Location = new Point(258, 77);
            TBTituloRecurso.Name = "TBTituloRecurso";
            TBTituloRecurso.Size = new Size(125, 27);
            TBTituloRecurso.TabIndex = 7;
            // 
            // LURLRecurso
            // 
            LURLRecurso.AutoSize = true;
            LURLRecurso.Location = new Point(138, 252);
            LURLRecurso.Name = "LURLRecurso";
            LURLRecurso.Size = new Size(35, 20);
            LURLRecurso.TabIndex = 6;
            LURLRecurso.Text = "URL";
            // 
            // LDescripcionRecurso
            // 
            LDescripcionRecurso.AutoSize = true;
            LDescripcionRecurso.Location = new Point(126, 167);
            LDescripcionRecurso.Name = "LDescripcionRecurso";
            LDescripcionRecurso.Size = new Size(87, 20);
            LDescripcionRecurso.TabIndex = 5;
            LDescripcionRecurso.Text = "Descripcion";
            // 
            // LTemaRecurso
            // 
            LTemaRecurso.AutoSize = true;
            LTemaRecurso.Location = new Point(422, 114);
            LTemaRecurso.Name = "LTemaRecurso";
            LTemaRecurso.Size = new Size(45, 20);
            LTemaRecurso.TabIndex = 4;
            LTemaRecurso.Text = "Tema";
            // 
            // LMateriaRecurso
            // 
            LMateriaRecurso.AutoSize = true;
            LMateriaRecurso.Location = new Point(422, 76);
            LMateriaRecurso.Name = "LMateriaRecurso";
            LMateriaRecurso.Size = new Size(60, 20);
            LMateriaRecurso.TabIndex = 3;
            LMateriaRecurso.Text = "Materia";
            // 
            // LTipoRecurso
            // 
            LTipoRecurso.AutoSize = true;
            LTipoRecurso.Location = new Point(126, 127);
            LTipoRecurso.Name = "LTipoRecurso";
            LTipoRecurso.Size = new Size(116, 20);
            LTipoRecurso.TabIndex = 2;
            LTipoRecurso.Text = "Tipo de Recurso";
            // 
            // LNombreRecurso
            // 
            LNombreRecurso.AutoSize = true;
            LNombreRecurso.Location = new Point(126, 76);
            LNombreRecurso.Name = "LNombreRecurso";
            LNombreRecurso.Size = new Size(47, 20);
            LNombreRecurso.TabIndex = 1;
            LNombreRecurso.Text = "Titulo";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(LTituloRecursos);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 55);
            panel1.TabIndex = 0;
            // 
            // LTituloRecursos
            // 
            LTituloRecursos.AutoSize = true;
            LTituloRecursos.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloRecursos.Location = new Point(339, 9);
            LTituloRecursos.Name = "LTituloRecursos";
            LTituloRecursos.Size = new Size(280, 38);
            LTituloRecursos.TabIndex = 0;
            LTituloRecursos.Text = "Gestion de Recursos";
            // 
            // FormGestionRecursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 523);
            Controls.Add(panelMainRecursos);
            Name = "FormGestionRecursos";
            Text = "FormGestionRecursos";
            panelMainRecursos.ResumeLayout(false);
            panelMainRecursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVRecursos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMainRecursos;
        private Panel panel1;
        private Label LTituloRecursos;
        private Label LURLRecurso;
        private Label LDescripcionRecurso;
        private Label LTemaRecurso;
        private Label LMateriaRecurso;
        private Label LTipoRecurso;
        private Label LNombreRecurso;
        private DataGridView DGVRecursos;
        private DataGridViewTextBoxColumn id_recurso;
        private DataGridViewTextBoxColumn tituloRecurso;
        private DataGridViewTextBoxColumn TipoRecurso;
        private DataGridViewTextBoxColumn descripcionRecurso;
        private DataGridViewTextBoxColumn URLRecurso;
        private DataGridViewTextBoxColumn MateriaRecurso;
        private DataGridViewTextBoxColumn TemaRecurso;
        private ComboBox CBTemaRecurso;
        private ComboBox CBMateriaRecurso;
        private TextBox TBUrl;
        private TextBox TBDescripcionRecurso;
        private TextBox TBTituloRecurso;
        private Button BEliminarRecurso;
        private Button BModificarRecurso;
        private Button BCancelarRecurso;
        private Button BGuardarRecurso;
        private TextBox TBBuscadorRecursos;
        private ComboBox CBTipoRecurso;
        private Button BInactivosRecursos;
        private Button BActivosRecursos;
    }
}