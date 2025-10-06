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
            panel1 = new Panel();
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
            panel1.SuspendLayout();
            panelCamposTemas.SuspendLayout();
            panelBuscador.SuspendLayout();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTemas).BeginInit();
            panelEncabezadoT.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(panelCamposTemas);
            panel1.Controls.Add(panelBuscador);
            panel1.Controls.Add(panelBotones);
            panel1.Controls.Add(DGVTemas);
            panel1.Controls.Add(panelEncabezadoT);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
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
            panelCamposTemas.Location = new Point(77, 65);
            panelCamposTemas.Margin = new Padding(3, 2, 3, 2);
            panelCamposTemas.Name = "panelCamposTemas";
            panelCamposTemas.RowCount = 3;
            panelCamposTemas.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelCamposTemas.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelCamposTemas.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelCamposTemas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelCamposTemas.Size = new Size(481, 104);
            panelCamposTemas.TabIndex = 100;
            // 
            // CBEliminado
            // 
            CBEliminado.FormattingEnabled = true;
            CBEliminado.Location = new Point(183, 70);
            CBEliminado.Margin = new Padding(3, 2, 3, 2);
            CBEliminado.Name = "CBEliminado";
            CBEliminado.Size = new Size(47, 23);
            CBEliminado.TabIndex = 27;
            CBEliminado.Tag = "Materia asociada";
            // 
            // labelEliminado
            // 
            labelEliminado.AutoSize = true;
            labelEliminado.Location = new Point(3, 68);
            labelEliminado.Name = "labelEliminado";
            labelEliminado.Size = new Size(60, 15);
            labelEliminado.TabIndex = 26;
            labelEliminado.Text = "Eliminado";
            labelEliminado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LNombreTema
            // 
            LNombreTema.AutoSize = true;
            LNombreTema.Location = new Point(3, 0);
            LNombreTema.Name = "LNombreTema";
            LNombreTema.Size = new Size(54, 15);
            LNombreTema.TabIndex = 16;
            LNombreTema.Text = "Nombre ";
            LNombreTema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Materia
            // 
            Materia.AutoSize = true;
            Materia.Location = new Point(3, 34);
            Materia.Name = "Materia";
            Materia.Size = new Size(96, 15);
            Materia.TabIndex = 17;
            Materia.Text = "Materia asociada";
            Materia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBNombreTema
            // 
            TBNombreTema.Location = new Point(183, 2);
            TBNombreTema.Margin = new Padding(3, 2, 3, 2);
            TBNombreTema.Name = "TBNombreTema";
            TBNombreTema.Size = new Size(295, 23);
            TBNombreTema.TabIndex = 18;
            TBNombreTema.Tag = "Nombre";
            // 
            // CBMaterias
            // 
            CBMaterias.FormattingEnabled = true;
            CBMaterias.Location = new Point(183, 36);
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
            panelBuscador.Controls.Add(BTemasActivos, 1, 0);
            panelBuscador.Controls.Add(BTemasInactivos, 2, 0);
            panelBuscador.Controls.Add(CBFiltroMaterias, 0, 1);
            panelBuscador.Location = new Point(74, 263);
            panelBuscador.Margin = new Padding(3, 2, 3, 2);
            panelBuscador.Name = "panelBuscador";
            panelBuscador.RowCount = 2;
            panelBuscador.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBuscador.RowStyles.Add(new RowStyle());
            panelBuscador.Size = new Size(710, 77);
            panelBuscador.TabIndex = 99;
            // 
            // TBBuscadorTema
            // 
            TBBuscadorTema.Location = new Point(3, 2);
            TBBuscadorTema.Margin = new Padding(3, 2, 3, 2);
            TBBuscadorTema.Name = "TBBuscadorTema";
            TBBuscadorTema.PlaceholderText = "Buscar tema..";
            TBBuscadorTema.Size = new Size(207, 23);
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
            BTemasActivos.Location = new Point(537, 2);
            BTemasActivos.Margin = new Padding(3, 2, 3, 2);
            BTemasActivos.Name = "BTemasActivos";
            BTemasActivos.Size = new Size(82, 22);
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
            BTemasInactivos.Location = new Point(625, 2);
            BTemasInactivos.Margin = new Padding(3, 2, 3, 2);
            BTemasInactivos.Name = "BTemasInactivos";
            BTemasInactivos.Size = new Size(82, 22);
            BTemasInactivos.TabIndex = 64;
            BTemasInactivos.Text = "Inactivos";
            BTemasInactivos.UseVisualStyleBackColor = false;
            // 
            // CBFiltroMaterias
            // 
            CBFiltroMaterias.FormattingEnabled = true;
            CBFiltroMaterias.Location = new Point(3, 52);
            CBFiltroMaterias.Margin = new Padding(3, 2, 3, 2);
            CBFiltroMaterias.Name = "CBFiltroMaterias";
            CBFiltroMaterias.Size = new Size(343, 23);
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
            panelBotones.Location = new Point(414, 187);
            panelBotones.Margin = new Padding(3, 2, 3, 2);
            panelBotones.Name = "panelBotones";
            panelBotones.RowCount = 1;
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            panelBotones.Size = new Size(368, 38);
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
            BEliminarTema.Location = new Point(279, 2);
            BEliminarTema.Margin = new Padding(3, 2, 3, 2);
            BEliminarTema.Name = "BEliminarTema";
            BEliminarTema.Size = new Size(82, 22);
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
            BModificarTema.Location = new Point(179, 2);
            BModificarTema.Margin = new Padding(3, 2, 3, 2);
            BModificarTema.Name = "BModificarTema";
            BModificarTema.Size = new Size(94, 22);
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
            DGVTemas.Columns.AddRange(new DataGridViewColumn[] { idTema, Nombre, IdMateria });
            DGVTemas.Location = new Point(74, 351);
            DGVTemas.Margin = new Padding(3, 2, 3, 2);
            DGVTemas.Name = "DGVTemas";
            DGVTemas.RowHeadersWidth = 51;
            DGVTemas.Size = new Size(710, 111);
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
            IdMateria.Name = "IdMateria";
            IdMateria.ReadOnly = true;
            // 
            // panelEncabezadoT
            // 
            panelEncabezadoT.Controls.Add(LTituloTemas);
            panelEncabezadoT.Dock = DockStyle.Top;
            panelEncabezadoT.Location = new Point(0, 0);
            panelEncabezadoT.Margin = new Padding(3, 2, 3, 2);
            panelEncabezadoT.Name = "panelEncabezadoT";
            panelEncabezadoT.Size = new Size(800, 52);
            panelEncabezadoT.TabIndex = 96;
            // 
            // LTituloTemas
            // 
            LTituloTemas.AutoSize = true;
            LTituloTemas.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloTemas.ForeColor = Color.Black;
            LTituloTemas.Location = new Point(3, 0);
            LTituloTemas.Name = "LTituloTemas";
            LTituloTemas.Size = new Size(197, 30);
            LTituloTemas.TabIndex = 1;
            LTituloTemas.Text = "Gestion de Temas";
            LTituloTemas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormGestionTemas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormGestionTemas";
            Text = "FormGestionTemas";
            panel1.ResumeLayout(false);
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

        private Panel panel1;
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