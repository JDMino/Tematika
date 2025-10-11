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
            Materia = new Label();
            CBMaterias = new ComboBox();
            panelBuscador = new TableLayoutPanel();
            TBBuscadorTema = new TextBox();
            panelBotones = new TableLayoutPanel();
            BGuardarTema = new Button();
            BEliminarTema = new Button();
            BCancelarTema = new Button();
            DGVTemas = new DataGridView();
            panelEncabezadoT = new FlowLayoutPanel();
            LTituloDocenteMateria = new Label();
            labelDocente = new Label();
            CBDocente = new ComboBox();
            NombreDocente = new DataGridViewTextBoxColumn();
            IdMateria = new DataGridViewTextBoxColumn();
            panelDocenteMateria.SuspendLayout();
            panelCamposTemas.SuspendLayout();
            panelBuscador.SuspendLayout();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTemas).BeginInit();
            panelEncabezadoT.SuspendLayout();
            SuspendLayout();
            // 
            // panelDocenteMateria
            // 
            panelDocenteMateria.BackColor = Color.Chocolate;
            panelDocenteMateria.Controls.Add(panelCamposTemas);
            panelDocenteMateria.Controls.Add(panelBuscador);
            panelDocenteMateria.Controls.Add(panelBotones);
            panelDocenteMateria.Controls.Add(DGVTemas);
            panelDocenteMateria.Controls.Add(panelEncabezadoT);
            panelDocenteMateria.Dock = DockStyle.Fill;
            panelDocenteMateria.Location = new Point(0, 0);
            panelDocenteMateria.Name = "panelDocenteMateria";
            panelDocenteMateria.Size = new Size(800, 450);
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
            panelCamposTemas.Location = new Point(77, 52);
            panelCamposTemas.Margin = new Padding(3, 2, 3, 2);
            panelCamposTemas.Name = "panelCamposTemas";
            panelCamposTemas.RowCount = 2;
            panelCamposTemas.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelCamposTemas.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelCamposTemas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelCamposTemas.Size = new Size(481, 104);
            panelCamposTemas.TabIndex = 105;
            // 
            // Materia
            // 
            Materia.AutoSize = true;
            Materia.Location = new Point(3, 52);
            Materia.Name = "Materia";
            Materia.Size = new Size(96, 15);
            Materia.TabIndex = 17;
            Materia.Text = "Materia asociada";
            Materia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CBMaterias
            // 
            CBMaterias.FormattingEnabled = true;
            CBMaterias.Location = new Point(183, 54);
            CBMaterias.Margin = new Padding(3, 2, 3, 2);
            CBMaterias.Name = "CBMaterias";
            CBMaterias.Size = new Size(295, 23);
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
            panelBuscador.Controls.Add(TBBuscadorTema, 0, 0);
            panelBuscador.Location = new Point(74, 250);
            panelBuscador.Margin = new Padding(3, 2, 3, 2);
            panelBuscador.Name = "panelBuscador";
            panelBuscador.RowCount = 2;
            panelBuscador.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBuscador.RowStyles.Add(new RowStyle());
            panelBuscador.Size = new Size(249, 32);
            panelBuscador.TabIndex = 104;
            // 
            // TBBuscadorTema
            // 
            TBBuscadorTema.Location = new Point(3, 2);
            TBBuscadorTema.Margin = new Padding(3, 2, 3, 2);
            TBBuscadorTema.Name = "TBBuscadorTema";
            TBBuscadorTema.PlaceholderText = "Buscar Docente..";
            TBBuscadorTema.Size = new Size(207, 23);
            TBBuscadorTema.TabIndex = 62;
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
            panelBotones.Location = new Point(414, 174);
            panelBotones.Margin = new Padding(3, 2, 3, 2);
            panelBotones.Name = "panelBotones";
            panelBotones.RowCount = 1;
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            panelBotones.Size = new Size(266, 38);
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
            BGuardarTema.Location = new Point(3, 2);
            BGuardarTema.Margin = new Padding(3, 2, 3, 2);
            BGuardarTema.Name = "BGuardarTema";
            BGuardarTema.Size = new Size(82, 22);
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
            BEliminarTema.Location = new Point(179, 2);
            BEliminarTema.Margin = new Padding(3, 2, 3, 2);
            BEliminarTema.Name = "BEliminarTema";
            BEliminarTema.Size = new Size(82, 22);
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
            BCancelarTema.Location = new Point(91, 2);
            BCancelarTema.Margin = new Padding(3, 2, 3, 2);
            BCancelarTema.Name = "BCancelarTema";
            BCancelarTema.Size = new Size(82, 22);
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
            DGVTemas.Location = new Point(74, 297);
            DGVTemas.Margin = new Padding(3, 2, 3, 2);
            DGVTemas.Name = "DGVTemas";
            DGVTemas.RowHeadersWidth = 51;
            DGVTemas.Size = new Size(710, 125);
            DGVTemas.TabIndex = 102;
            // 
            // panelEncabezadoT
            // 
            panelEncabezadoT.Controls.Add(LTituloDocenteMateria);
            panelEncabezadoT.Dock = DockStyle.Top;
            panelEncabezadoT.Location = new Point(0, 0);
            panelEncabezadoT.Margin = new Padding(3, 2, 3, 2);
            panelEncabezadoT.Name = "panelEncabezadoT";
            panelEncabezadoT.Size = new Size(800, 52);
            panelEncabezadoT.TabIndex = 101;
            // 
            // LTituloDocenteMateria
            // 
            LTituloDocenteMateria.AutoSize = true;
            LTituloDocenteMateria.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloDocenteMateria.ForeColor = Color.Black;
            LTituloDocenteMateria.Location = new Point(3, 0);
            LTituloDocenteMateria.Name = "LTituloDocenteMateria";
            LTituloDocenteMateria.Size = new Size(320, 30);
            LTituloDocenteMateria.TabIndex = 1;
            LTituloDocenteMateria.Text = "Asignación Docente - Materia";
            LTituloDocenteMateria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDocente
            // 
            labelDocente.AutoSize = true;
            labelDocente.Location = new Point(3, 0);
            labelDocente.Name = "labelDocente";
            labelDocente.Size = new Size(96, 15);
            labelDocente.TabIndex = 28;
            labelDocente.Text = "Materia asociada";
            labelDocente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CBDocente
            // 
            CBDocente.FormattingEnabled = true;
            CBDocente.Location = new Point(183, 2);
            CBDocente.Margin = new Padding(3, 2, 3, 2);
            CBDocente.Name = "CBDocente";
            CBDocente.Size = new Size(295, 23);
            CBDocente.TabIndex = 29;
            CBDocente.Tag = "Materia asociada";
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
            // FormGestionDocenteMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDocenteMateria);
            Name = "FormGestionDocenteMateria";
            Text = "FormGestionDocenteMateria";
            panelDocenteMateria.ResumeLayout(false);
            panelCamposTemas.ResumeLayout(false);
            panelCamposTemas.PerformLayout();
            panelBuscador.ResumeLayout(false);
            panelBuscador.PerformLayout();
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVTemas).EndInit();
            panelEncabezadoT.ResumeLayout(false);
            panelEncabezadoT.PerformLayout();
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
        private TextBox TBBuscadorTema;
        private TableLayoutPanel panelBotones;
        private Button BGuardarTema;
        private Button BEliminarTema;
        private Button BCancelarTema;
        private DataGridView DGVTemas;
        private FlowLayoutPanel panelEncabezadoT;
        private Label LTituloDocenteMateria;
        private DataGridViewTextBoxColumn NombreDocente;
        private DataGridViewTextBoxColumn IdMateria;
    }
}