namespace Tematika.Forms
{
    partial class Gestion_de_Temas
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
            LDescripcionTema = new Label();
            LNombreTema = new Label();
            BTemasInactivos = new Button();
            Materia = new Label();
            BTemasActivos = new Button();
            CBFiltroMaterias = new ComboBox();
            TBBuscadorTema = new TextBox();
            DGVTemas = new DataGridView();
            idTema = new DataGridViewTextBoxColumn();
            NombreTema = new DataGridViewTextBoxColumn();
            DescripcionTema = new DataGridViewTextBoxColumn();
            TBDescripcionTema = new TextBox();
            BEliminarTema = new Button();
            BModificarTema = new Button();
            BCancelarTema = new Button();
            BGuardarTema = new Button();
            CBMaterias = new ComboBox();
            TBNombreTema = new TextBox();
            panel2 = new Panel();
            LTituloTemas = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTemas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LDescripcionTema);
            panel1.Controls.Add(LNombreTema);
            panel1.Controls.Add(BTemasInactivos);
            panel1.Controls.Add(Materia);
            panel1.Controls.Add(BTemasActivos);
            panel1.Controls.Add(CBFiltroMaterias);
            panel1.Controls.Add(TBBuscadorTema);
            panel1.Controls.Add(DGVTemas);
            panel1.Controls.Add(TBDescripcionTema);
            panel1.Controls.Add(BEliminarTema);
            panel1.Controls.Add(BModificarTema);
            panel1.Controls.Add(BCancelarTema);
            panel1.Controls.Add(BGuardarTema);
            panel1.Controls.Add(CBMaterias);
            panel1.Controls.Add(TBNombreTema);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(961, 509);
            panel1.TabIndex = 0;
            // 
            // LDescripcionTema
            // 
            LDescripcionTema.AutoSize = true;
            LDescripcionTema.Location = new Point(169, 163);
            LDescripcionTema.Name = "LDescripcionTema";
            LDescripcionTema.Size = new Size(87, 20);
            LDescripcionTema.TabIndex = 9;
            LDescripcionTema.Text = "Descripcion";
            LDescripcionTema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LNombreTema
            // 
            LNombreTema.AutoSize = true;
            LNombreTema.Location = new Point(169, 116);
            LNombreTema.Name = "LNombreTema";
            LNombreTema.Size = new Size(68, 20);
            LNombreTema.TabIndex = 1;
            LNombreTema.Text = "Nombre ";
            LNombreTema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTemasInactivos
            // 
            BTemasInactivos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTemasInactivos.Location = new Point(603, 343);
            BTemasInactivos.Name = "BTemasInactivos";
            BTemasInactivos.Size = new Size(94, 29);
            BTemasInactivos.TabIndex = 15;
            BTemasInactivos.Text = "Inactivos";
            BTemasInactivos.UseVisualStyleBackColor = true;
            // 
            // Materia
            // 
            Materia.AutoSize = true;
            Materia.Location = new Point(169, 206);
            Materia.Name = "Materia";
            Materia.Size = new Size(123, 20);
            Materia.TabIndex = 2;
            Materia.Text = "Materia asociada";
            Materia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BTemasActivos
            // 
            BTemasActivos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTemasActivos.Location = new Point(492, 343);
            BTemasActivos.Name = "BTemasActivos";
            BTemasActivos.Size = new Size(94, 29);
            BTemasActivos.TabIndex = 14;
            BTemasActivos.Text = "Activos";
            BTemasActivos.UseVisualStyleBackColor = true;
            // 
            // CBFiltroMaterias
            // 
            CBFiltroMaterias.FormattingEnabled = true;
            CBFiltroMaterias.Location = new Point(185, 346);
            CBFiltroMaterias.Name = "CBFiltroMaterias";
            CBFiltroMaterias.Size = new Size(151, 28);
            CBFiltroMaterias.TabIndex = 13;
            // 
            // TBBuscadorTema
            // 
            TBBuscadorTema.Location = new Point(185, 303);
            TBBuscadorTema.Name = "TBBuscadorTema";
            TBBuscadorTema.Size = new Size(151, 27);
            TBBuscadorTema.TabIndex = 12;
            // 
            // DGVTemas
            // 
            DGVTemas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVTemas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVTemas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVTemas.Columns.AddRange(new DataGridViewColumn[] { idTema, NombreTema, DescripcionTema });
            DGVTemas.Location = new Point(195, 385);
            DGVTemas.Name = "DGVTemas";
            DGVTemas.RowHeadersWidth = 51;
            DGVTemas.Size = new Size(416, 100);
            DGVTemas.TabIndex = 11;
            DGVTemas.CellClick += DGVTemas_CellClick;
            // 
            // idTema
            // 
            idTema.HeaderText = "ID Tema";
            idTema.MinimumWidth = 6;
            idTema.Name = "idTema";
            // 
            // NombreTema
            // 
            NombreTema.HeaderText = "Nombre";
            NombreTema.MinimumWidth = 6;
            NombreTema.Name = "NombreTema";
            // 
            // DescripcionTema
            // 
            DescripcionTema.HeaderText = "Descripcion";
            DescripcionTema.MinimumWidth = 6;
            DescripcionTema.Name = "DescripcionTema";
            // 
            // TBDescripcionTema
            // 
            TBDescripcionTema.Location = new Point(312, 161);
            TBDescripcionTema.Name = "TBDescripcionTema";
            TBDescripcionTema.Size = new Size(248, 27);
            TBDescripcionTema.TabIndex = 10;
            // 
            // BEliminarTema
            // 
            BEliminarTema.Location = new Point(573, 284);
            BEliminarTema.Name = "BEliminarTema";
            BEliminarTema.Size = new Size(94, 29);
            BEliminarTema.TabIndex = 8;
            BEliminarTema.Text = "Eliminar";
            BEliminarTema.UseVisualStyleBackColor = true;
            // 
            // BModificarTema
            // 
            BModificarTema.Location = new Point(473, 284);
            BModificarTema.Name = "BModificarTema";
            BModificarTema.Size = new Size(94, 29);
            BModificarTema.TabIndex = 7;
            BModificarTema.Text = "Modificar";
            BModificarTema.UseVisualStyleBackColor = true;
            // 
            // BCancelarTema
            // 
            BCancelarTema.Location = new Point(573, 249);
            BCancelarTema.Name = "BCancelarTema";
            BCancelarTema.Size = new Size(94, 29);
            BCancelarTema.TabIndex = 6;
            BCancelarTema.Text = "Cancelar";
            BCancelarTema.UseVisualStyleBackColor = true;
            // 
            // BGuardarTema
            // 
            BGuardarTema.Location = new Point(473, 249);
            BGuardarTema.Name = "BGuardarTema";
            BGuardarTema.Size = new Size(94, 29);
            BGuardarTema.TabIndex = 5;
            BGuardarTema.Text = "Guardar";
            BGuardarTema.UseVisualStyleBackColor = true;
            // 
            // CBMaterias
            // 
            CBMaterias.FormattingEnabled = true;
            CBMaterias.Location = new Point(312, 203);
            CBMaterias.Name = "CBMaterias";
            CBMaterias.Size = new Size(151, 28);
            CBMaterias.TabIndex = 4;
            // 
            // TBNombreTema
            // 
            TBNombreTema.Location = new Point(312, 118);
            TBNombreTema.Name = "TBNombreTema";
            TBNombreTema.Size = new Size(248, 27);
            TBNombreTema.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(LTituloTemas);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(961, 48);
            panel2.TabIndex = 0;
            // 
            // LTituloTemas
            // 
            LTituloTemas.AutoSize = true;
            LTituloTemas.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloTemas.ForeColor = Color.Black;
            LTituloTemas.Location = new Point(679, 9);
            LTituloTemas.Name = "LTituloTemas";
            LTituloTemas.Size = new Size(249, 38);
            LTituloTemas.TabIndex = 0;
            LTituloTemas.Text = "Gestion de Temas";
            LTituloTemas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Gestion_de_Temas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 509);
            Controls.Add(panel1);
            Name = "Gestion_de_Temas";
            Text = "Gestion_de_Temas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTemas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LNombreTema;
        private Panel panel2;
        private Label LTituloTemas;
        private ComboBox CBMaterias;
        private TextBox TBNombreTema;
        private Label Materia;
        private Button BEliminarTema;
        private Button BModificarTema;
        private Button BCancelarTema;
        private Button BGuardarTema;
        private Label LDescripcionTema;
        private TextBox TBDescripcionTema;
        private DataGridView DGVTemas;
        private DataGridViewTextBoxColumn idTema;
        private DataGridViewTextBoxColumn NombreTema;
        private DataGridViewTextBoxColumn DescripcionTema;
        private TextBox TBBuscadorTema;
        private Button BTemasInactivos;
        private Button BTemasActivos;
        private ComboBox CBFiltroMaterias;
    }
}