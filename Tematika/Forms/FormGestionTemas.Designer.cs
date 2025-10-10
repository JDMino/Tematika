namespace Tematika.Forms
{
    partial class FormGestionTemas
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
            panelTema = new Panel();
            panelCamposTemas = new TableLayoutPanel();
            CBEliminado = new ComboBox();
            labelEliminado = new Label();
            LNombreTema = new Label();
            Materia = new Label();
            TBNombreTema = new TextBox();
            CBMaterias = new ComboBox();
            panelBuscador = new TableLayoutPanel();
            TBBuscadorTema = new TextBox();
            BTemasActivos = new Button();
            BTemasInactivos = new Button();
            CBFiltroMaterias = new ComboBox();
            panelBotones = new TableLayoutPanel();
            BGuardarTema = new Button();
            BEliminarTema = new Button();
            BModificarTema = new Button();
            BCancelarTema = new Button();
            DGVTemas = new DataGridView();
            idTema = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            IdMateria = new DataGridViewTextBoxColumn();
            panelEncabezadoT = new FlowLayoutPanel();
            LTituloTemas = new Label();
            panelTema.SuspendLayout();
            panelCamposTemas.SuspendLayout();
            panelBuscador.SuspendLayout();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTemas).BeginInit();
            panelEncabezadoT.SuspendLayout();
            SuspendLayout();
            // 
            // panelTema
            // 
            panelTema.BackColor = Color.DarkOrange;
            panelTema.Controls.Add(panelCamposTemas);
            panelTema.Controls.Add(panelBuscador);
            panelTema.Controls.Add(panelBotones);
            panelTema.Controls.Add(DGVTemas);
            panelTema.Controls.Add(panelEncabezadoT);
            panelTema.Dock = DockStyle.Fill;
            panelTema.Location = new Point(0, 0);
            panelTema.Margin = new Padding(3, 4, 3, 4);
            panelTema.Name = "panelTema";
            panelTema.Size = new Size(914, 684);
            panelTema.TabIndex = 0;
            // 
            // panelCamposTemas
            // 
            panelCamposTemas.ColumnCount = 2;
            panelCamposTemas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            panelCamposTemas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            panelCamposTemas.Controls.Add(CBEliminado, 1, 2);
            panelCamposTemas.Controls.Add(labelEliminado, 0, 2);
            panelCamposTemas.Controls.Add(LNombreTema, 0, 0);
            panelCamposTemas.Controls.Add(Materia, 0, 1);
            panelCamposTemas.Controls.Add(TBNombreTema, 1, 0);
            panelCamposTemas.Controls.Add(CBMaterias, 1, 1);
            panelCamposTemas.Location = new Point(88, 87);
            panelCamposTemas.Name = "panelCamposTemas";
            panelCamposTemas.RowCount = 3;
            panelCamposTemas.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelCamposTemas.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelCamposTemas.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelCamposTemas.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            panelCamposTemas.Size = new Size(550, 139);
            panelCamposTemas.TabIndex = 100;
            // 
            // CBEliminado
            // 
            CBEliminado.FormattingEnabled = true;
            CBEliminado.Location = new Point(209, 95);
            CBEliminado.Name = "CBEliminado";
            CBEliminado.Size = new Size(53, 28);
            CBEliminado.TabIndex = 27;
            CBEliminado.Tag = "Materia asociada";
            // 
            // labelEliminado
            // 
            labelEliminado.AutoSize = true;
            labelEliminado.Location = new Point(3, 92);
            labelEliminado.Name = "labelEliminado";
            labelEliminado.Size = new Size(76, 20);
            labelEliminado.TabIndex = 26;
            labelEliminado.Text = "Eliminado";
            labelEliminado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LNombreTema
            // 
            LNombreTema.AutoSize = true;
            LNombreTema.Location = new Point(3, 0);
            LNombreTema.Name = "LNombreTema";
            LNombreTema.Size = new Size(68, 20);
            LNombreTema.TabIndex = 16;
            LNombreTema.Text = "Nombre ";
            LNombreTema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Materia
            // 
            Materia.AutoSize = true;
            Materia.Location = new Point(3, 46);
            Materia.Name = "Materia";
            Materia.Size = new Size(123, 20);
            Materia.TabIndex = 17;
            Materia.Text = "Materia asociada";
            Materia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBNombreTema
            // 
            TBNombreTema.Location = new Point(209, 3);
            TBNombreTema.Name = "TBNombreTema";
            TBNombreTema.Size = new Size(337, 27);
            TBNombreTema.TabIndex = 18;
            TBNombreTema.Tag = "Nombre";
            // 
            // CBMaterias
            // 
            CBMaterias.FormattingEnabled = true;
            CBMaterias.Location = new Point(209, 49);
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
            panelBuscador.Controls.Add(TBBuscadorTema, 0, 0);
            panelBuscador.Controls.Add(BTemasActivos, 1, 0);
            panelBuscador.Controls.Add(BTemasInactivos, 2, 0);
            panelBuscador.Controls.Add(CBFiltroMaterias, 0, 1);
            panelBuscador.Location = new Point(85, 351);
            panelBuscador.Name = "panelBuscador";
            panelBuscador.RowCount = 2;
            panelBuscador.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBuscador.RowStyles.Add(new RowStyle());
            panelBuscador.Size = new Size(811, 103);
            panelBuscador.TabIndex = 99;
            // 
            // TBBuscadorTema
            // 
            TBBuscadorTema.Location = new Point(3, 3);
            TBBuscadorTema.Name = "TBBuscadorTema";
            TBBuscadorTema.PlaceholderText = "Buscar tema..";
            TBBuscadorTema.Size = new Size(236, 27);
            TBBuscadorTema.TabIndex = 62;
            // 
            // BTemasActivos
            // 
            BTemasActivos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTemasActivos.BackColor = SystemColors.Highlight;
            BTemasActivos.FlatAppearance.BorderSize = 0;
            BTemasActivos.FlatStyle = FlatStyle.Flat;
            BTemasActivos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BTemasActivos.ForeColor = SystemColors.ButtonHighlight;
            BTemasActivos.Location = new Point(614, 3);
            BTemasActivos.Name = "BTemasActivos";
            BTemasActivos.Size = new Size(94, 29);
            BTemasActivos.TabIndex = 63;
            BTemasActivos.Text = "Activos";
            BTemasActivos.UseVisualStyleBackColor = false;
            // 
            // BTemasInactivos
            // 
            BTemasInactivos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTemasInactivos.BackColor = Color.Gray;
            BTemasInactivos.FlatAppearance.BorderSize = 0;
            BTemasInactivos.FlatStyle = FlatStyle.Flat;
            BTemasInactivos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BTemasInactivos.ForeColor = SystemColors.ButtonHighlight;
            BTemasInactivos.Location = new Point(714, 3);
            BTemasInactivos.Name = "BTemasInactivos";
            BTemasInactivos.Size = new Size(94, 29);
            BTemasInactivos.TabIndex = 64;
            BTemasInactivos.Text = "Inactivos";
            BTemasInactivos.UseVisualStyleBackColor = false;
            // 
            // CBFiltroMaterias
            // 
            CBFiltroMaterias.FormattingEnabled = true;
            CBFiltroMaterias.Location = new Point(3, 72);
            CBFiltroMaterias.Name = "CBFiltroMaterias";
            CBFiltroMaterias.Size = new Size(391, 28);
            CBFiltroMaterias.TabIndex = 28;
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
            panelBotones.Controls.Add(BModificarTema, 2, 0);
            panelBotones.Controls.Add(BCancelarTema, 1, 0);
            panelBotones.Location = new Point(473, 249);
            panelBotones.Name = "panelBotones";
            panelBotones.RowCount = 1;
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            panelBotones.Size = new Size(421, 51);
            panelBotones.TabIndex = 98;
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
            BEliminarTema.Location = new Point(316, 3);
            BEliminarTema.Name = "BEliminarTema";
            BEliminarTema.Size = new Size(94, 29);
            BEliminarTema.TabIndex = 91;
            BEliminarTema.Text = "Eliminar";
            BEliminarTema.UseVisualStyleBackColor = false;
            BEliminarTema.Visible = false;
            // 
            // BModificarTema
            // 
            BModificarTema.BackColor = SystemColors.Highlight;
            BModificarTema.FlatAppearance.BorderSize = 0;
            BModificarTema.FlatStyle = FlatStyle.Flat;
            BModificarTema.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BModificarTema.ForeColor = SystemColors.ButtonHighlight;
            BModificarTema.Location = new Point(203, 3);
            BModificarTema.Name = "BModificarTema";
            BModificarTema.Size = new Size(107, 29);
            BModificarTema.TabIndex = 90;
            BModificarTema.Text = "Modificar";
            BModificarTema.UseVisualStyleBackColor = false;
            BModificarTema.Visible = false;
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
            DGVTemas.Columns.AddRange(new DataGridViewColumn[] { idTema, Nombre, IdMateria });
            DGVTemas.Location = new Point(85, 468);
            DGVTemas.Name = "DGVTemas";
            DGVTemas.RowHeadersWidth = 51;
            DGVTemas.Size = new Size(811, 167);
            DGVTemas.TabIndex = 97;
            // 
            // idTema
            // 
            idTema.HeaderText = "ID Tema";
            idTema.MinimumWidth = 6;
            idTema.Name = "idTema";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // IdMateria
            // 
            IdMateria.HeaderText = "Materia Asociada";
            IdMateria.MinimumWidth = 6;
            IdMateria.Name = "IdMateria";
            IdMateria.ReadOnly = true;
            // 
            // panelEncabezadoT
            // 
            panelEncabezadoT.Controls.Add(LTituloTemas);
            panelEncabezadoT.Dock = DockStyle.Top;
            panelEncabezadoT.Location = new Point(0, 0);
            panelEncabezadoT.Name = "panelEncabezadoT";
            panelEncabezadoT.Size = new Size(914, 69);
            panelEncabezadoT.TabIndex = 96;
            // 
            // LTituloTemas
            // 
            LTituloTemas.AutoSize = true;
            LTituloTemas.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloTemas.ForeColor = Color.Black;
            LTituloTemas.Location = new Point(3, 0);
            LTituloTemas.Name = "LTituloTemas";
            LTituloTemas.Size = new Size(249, 38);
            LTituloTemas.TabIndex = 1;
            LTituloTemas.Text = "Gestion de Temas";
            LTituloTemas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormGestionTemas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 684);
            Controls.Add(panelTema);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionTemas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGestionTemas";
            panelTema.ResumeLayout(false);
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

        private Panel panelTema;
        private TableLayoutPanel panelCamposTemas;
        private Label LNombreTema;
        private Label Materia;
        private TextBox TBNombreTema;
        private ComboBox CBMaterias;
        private TableLayoutPanel panelBuscador;
        private TextBox TBBuscadorTema;
        private Button BTemasActivos;
        private Button BTemasInactivos;
        private ComboBox CBFiltroMaterias;
        private TableLayoutPanel panelBotones;
        private Button BGuardarTema;
        private Button BEliminarTema;
        private Button BModificarTema;
        private Button BCancelarTema;
        private DataGridView DGVTemas;
        private FlowLayoutPanel panelEncabezadoT;
        private Label LTituloTemas;
        private ComboBox CBEliminado;
        private Label labelEliminado;
        private DataGridViewTextBoxColumn idTema;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn IdMateria;
    }
}