namespace Tematika.Forms
{
    partial class FormGestionDocenteMateria
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
            panelDocenteMateria = new Panel();
            panelCamposTemas = new TableLayoutPanel();
            CBDocente = new ComboBox();
            labelDocente = new Label();
            Materia = new Label();
            CBMaterias = new ComboBox();
            panelBuscador = new TableLayoutPanel();
            TBBuscadorDocente = new TextBox();
            panelBotones = new TableLayoutPanel();
            BGuardarTema = new Button();
            BEliminarTema = new Button();
            BCancelarTema = new Button();
            DGVTemas = new DataGridView();
            NombreDocente = new DataGridViewTextBoxColumn();
            IdMateria = new DataGridViewTextBoxColumn();
            panelEncabezadoDM = new FlowLayoutPanel();
            LTituloDocenteMateria = new Label();
            panelDocenteMateria.SuspendLayout();
            panelCamposTemas.SuspendLayout();
            panelBuscador.SuspendLayout();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTemas).BeginInit();
            panelEncabezadoDM.SuspendLayout();
            SuspendLayout();
            // 
            // panelDocenteMateria
            // 
            panelDocenteMateria.BackColor = Color.Chocolate;
            panelDocenteMateria.Controls.Add(panelCamposTemas);
            panelDocenteMateria.Controls.Add(panelBuscador);
            panelDocenteMateria.Controls.Add(panelBotones);
            panelDocenteMateria.Controls.Add(DGVTemas);
            panelDocenteMateria.Controls.Add(panelEncabezadoDM);
            panelDocenteMateria.Dock = DockStyle.Fill;
            panelDocenteMateria.Location = new Point(0, 0);
            panelDocenteMateria.Margin = new Padding(3, 4, 3, 4);
            panelDocenteMateria.Name = "panelDocenteMateria";
            panelDocenteMateria.Size = new Size(914, 600);
            panelDocenteMateria.TabIndex = 0;
            panelDocenteMateria.Paint += panelDocenteMateria_Paint;
            // 
            // panelCamposTemas
            // 
            panelCamposTemas.ColumnCount = 2;
            panelCamposTemas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            panelCamposTemas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            panelCamposTemas.Controls.Add(CBDocente, 1, 0);
            panelCamposTemas.Controls.Add(labelDocente, 0, 0);
            panelCamposTemas.Controls.Add(Materia, 0, 1);
            panelCamposTemas.Controls.Add(CBMaterias, 1, 1);
            panelCamposTemas.Location = new Point(88, 69);
            panelCamposTemas.Name = "panelCamposTemas";
            panelCamposTemas.RowCount = 2;
            panelCamposTemas.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelCamposTemas.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelCamposTemas.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            panelCamposTemas.Size = new Size(550, 139);
            panelCamposTemas.TabIndex = 105;
            // 
            // CBDocente
            // 
            CBDocente.FormattingEnabled = true;
            CBDocente.Location = new Point(209, 3);
            CBDocente.Name = "CBDocente";
            CBDocente.Size = new Size(337, 28);
            CBDocente.TabIndex = 29;
            CBDocente.Tag = "Materia asociada";
            // 
            // labelDocente
            // 
            labelDocente.AutoSize = true;
            labelDocente.Location = new Point(3, 0);
            labelDocente.Name = "labelDocente";
            labelDocente.Size = new Size(65, 20);
            labelDocente.TabIndex = 28;
            labelDocente.Text = "Docente";
            labelDocente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Materia
            // 
            Materia.AutoSize = true;
            Materia.Location = new Point(3, 69);
            Materia.Name = "Materia";
            Materia.Size = new Size(123, 20);
            Materia.TabIndex = 17;
            Materia.Text = "Materia asociada";
            Materia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CBMaterias
            // 
            CBMaterias.FormattingEnabled = true;
            CBMaterias.Location = new Point(209, 72);
            CBMaterias.Name = "CBMaterias";
            CBMaterias.Size = new Size(337, 28);
            CBMaterias.TabIndex = 19;
            CBMaterias.Tag = "Materia asociada";
            // 
            // panelBuscador
            // 
            panelBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelBuscador.ColumnCount = 3;
            panelBuscador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelBuscador.ColumnStyles.Add(new ColumnStyle());
            panelBuscador.ColumnStyles.Add(new ColumnStyle());
            panelBuscador.Controls.Add(TBBuscadorDocente, 0, 0);
            panelBuscador.Location = new Point(85, 333);
            panelBuscador.Name = "panelBuscador";
            panelBuscador.RowCount = 2;
            panelBuscador.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBuscador.RowStyles.Add(new RowStyle());
            panelBuscador.Size = new Size(285, 43);
            panelBuscador.TabIndex = 104;
            // 
            // TBBuscadorDocente
            // 
            TBBuscadorDocente.Location = new Point(3, 3);
            TBBuscadorDocente.Name = "TBBuscadorDocente";
            TBBuscadorDocente.PlaceholderText = "Buscar Docente..";
            TBBuscadorDocente.Size = new Size(236, 27);
            TBBuscadorDocente.TabIndex = 62;
            // 
            // panelBotones
            // 
            panelBotones.ColumnCount = 4;
            panelBotones.ColumnStyles.Add(new ColumnStyle());
            panelBotones.ColumnStyles.Add(new ColumnStyle());
            panelBotones.ColumnStyles.Add(new ColumnStyle());
            panelBotones.ColumnStyles.Add(new ColumnStyle());
            panelBotones.Controls.Add(BGuardarTema, 0, 0);
            panelBotones.Controls.Add(BEliminarTema, 3, 0);
            panelBotones.Controls.Add(BCancelarTema, 1, 0);
            panelBotones.Location = new Point(473, 232);
            panelBotones.Name = "panelBotones";
            panelBotones.RowCount = 1;
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            panelBotones.Size = new Size(304, 51);
            panelBotones.TabIndex = 103;
            // 
            // BGuardarTema
            // 
            BGuardarTema.BackColor = Color.ForestGreen;
            BGuardarTema.FlatAppearance.BorderSize = 0;
            BGuardarTema.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 125, 50);
            BGuardarTema.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 160, 71);
            BGuardarTema.FlatStyle = FlatStyle.Flat;
            BGuardarTema.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BGuardarTema.ForeColor = SystemColors.ButtonHighlight;
            BGuardarTema.Location = new Point(3, 3);
            BGuardarTema.Name = "BGuardarTema";
            BGuardarTema.Size = new Size(94, 29);
            BGuardarTema.TabIndex = 88;
            BGuardarTema.Text = "Guardar";
            BGuardarTema.UseVisualStyleBackColor = false;
            // 
            // BEliminarTema
            // 
            BEliminarTema.BackColor = Color.OrangeRed;
            BEliminarTema.FlatAppearance.BorderSize = 0;
            BEliminarTema.FlatStyle = FlatStyle.Flat;
            BEliminarTema.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BEliminarTema.ForeColor = SystemColors.ButtonHighlight;
            BEliminarTema.Location = new Point(203, 3);
            BEliminarTema.Name = "BEliminarTema";
            BEliminarTema.Size = new Size(94, 29);
            BEliminarTema.TabIndex = 91;
            BEliminarTema.Text = "Eliminar";
            BEliminarTema.UseVisualStyleBackColor = false;
            BEliminarTema.Visible = false;
            // 
            // BCancelarTema
            // 
            BCancelarTema.BackColor = Color.Gray;
            BCancelarTema.FlatAppearance.BorderSize = 0;
            BCancelarTema.FlatStyle = FlatStyle.Flat;
            BCancelarTema.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCancelarTema.ForeColor = SystemColors.ButtonHighlight;
            BCancelarTema.Location = new Point(103, 3);
            BCancelarTema.Name = "BCancelarTema";
            BCancelarTema.Size = new Size(94, 29);
            BCancelarTema.TabIndex = 89;
            BCancelarTema.Text = "Cancelar";
            BCancelarTema.UseVisualStyleBackColor = false;
            // 
            // DGVTemas
            // 
            DGVTemas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVTemas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVTemas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVTemas.Columns.AddRange(new DataGridViewColumn[] { NombreDocente, IdMateria });
            DGVTemas.Location = new Point(85, 396);
            DGVTemas.Name = "DGVTemas";
            DGVTemas.RowHeadersWidth = 51;
            DGVTemas.Size = new Size(811, 167);
            DGVTemas.TabIndex = 102;
            // 
            // NombreDocente
            // 
            NombreDocente.HeaderText = "Docente";
            NombreDocente.MinimumWidth = 6;
            NombreDocente.Name = "NombreDocente";
            // 
            // IdMateria
            // 
            IdMateria.HeaderText = "Materia Asociada";
            IdMateria.MinimumWidth = 6;
            IdMateria.Name = "IdMateria";
            IdMateria.ReadOnly = true;
            // 
            // panelEncabezadoDM
            // 
            panelEncabezadoDM.Controls.Add(LTituloDocenteMateria);
            panelEncabezadoDM.Dock = DockStyle.Top;
            panelEncabezadoDM.Location = new Point(0, 0);
            panelEncabezadoDM.Name = "panelEncabezadoDM";
            panelEncabezadoDM.Size = new Size(914, 69);
            panelEncabezadoDM.TabIndex = 101;
            // 
            // LTituloDocenteMateria
            // 
            LTituloDocenteMateria.AutoSize = true;
            LTituloDocenteMateria.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloDocenteMateria.ForeColor = Color.Black;
            LTituloDocenteMateria.Location = new Point(3, 0);
            LTituloDocenteMateria.Name = "LTituloDocenteMateria";
            LTituloDocenteMateria.Size = new Size(407, 38);
            LTituloDocenteMateria.TabIndex = 1;
            LTituloDocenteMateria.Text = "Asignación Docente - Materia";
            LTituloDocenteMateria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormGestionDocenteMateria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelDocenteMateria);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionDocenteMateria";
            Text = "FormGestionDocenteMateria";
            panelDocenteMateria.ResumeLayout(false);
            panelCamposTemas.ResumeLayout(false);
            panelCamposTemas.PerformLayout();
            panelBuscador.ResumeLayout(false);
            panelBuscador.PerformLayout();
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVTemas).EndInit();
            panelEncabezadoDM.ResumeLayout(false);
            panelEncabezadoDM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDocenteMateria;
        private TableLayoutPanel panelCamposTemas;
        private ComboBox CBDocente;
        private Label labelDocente;
        private Label Materia;
        private ComboBox CBMaterias;
        private TableLayoutPanel panelBuscador;
        private TextBox TBBuscadorDocente;
        private TableLayoutPanel panelBotones;
        private Button BGuardarTema;
        private Button BEliminarTema;
        private Button BCancelarTema;
        private DataGridView DGVTemas;
        private FlowLayoutPanel panelEncabezadoDM;
        private Label LTituloDocenteMateria;
        private DataGridViewTextBoxColumn NombreDocente;
        private DataGridViewTextBoxColumn IdMateria;
    }
}