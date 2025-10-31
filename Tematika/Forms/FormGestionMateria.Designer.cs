namespace Tematika.Forms
{
    partial class FormGestionMateria
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
            panelMateria = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            BGuardarMateria = new Button();
            BEliminarMateria = new Button();
            BCancelarMateria = new Button();
            BModificarMateria = new Button();
            panelCamposMaterias = new TableLayoutPanel();
            labelEliminado = new Label();
            CBNivelMateria = new ComboBox();
            labelNombre = new Label();
            TBNombreMateria = new TextBox();
            labelNivel = new Label();
            TBDescripcionMateria = new TextBox();
            labelDescripcion = new Label();
            comboBoxEliminado = new ComboBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            TBBuscadorMaterias = new TextBox();
            BMateriasActivas = new Button();
            BMateriasInactivas = new Button();
            DGVMaterias = new DataGridView();
            idMateria = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Nivel = new DataGridViewTextBoxColumn();
            DescripcionMateria = new DataGridViewTextBoxColumn();
            panelEncabezadoM = new FlowLayoutPanel();
            LTituloMaterias = new Label();
            panelMateria.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panelCamposMaterias.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVMaterias).BeginInit();
            panelEncabezadoM.SuspendLayout();
            SuspendLayout();
            // 
            // panelMateria
            // 
            panelMateria.BackColor = Color.Lime;
            panelMateria.Controls.Add(tableLayoutPanel5);
            panelMateria.Controls.Add(panelCamposMaterias);
            panelMateria.Controls.Add(tableLayoutPanel6);
            panelMateria.Controls.Add(DGVMaterias);
            panelMateria.Controls.Add(panelEncabezadoM);
            panelMateria.Dock = DockStyle.Fill;
            panelMateria.Location = new Point(0, 0);
            panelMateria.Margin = new Padding(3, 4, 3, 4);
            panelMateria.Name = "panelMateria";
            panelMateria.Size = new Size(914, 600);
            panelMateria.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.Controls.Add(BGuardarMateria, 0, 0);
            tableLayoutPanel5.Controls.Add(BEliminarMateria, 3, 0);
            tableLayoutPanel5.Controls.Add(BCancelarMateria, 1, 0);
            tableLayoutPanel5.Controls.Add(BModificarMateria, 2, 0);
            tableLayoutPanel5.Location = new Point(448, 239);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel5.Size = new Size(409, 53);
            tableLayoutPanel5.TabIndex = 108;
            // 
            // BGuardarMateria
            // 
            BGuardarMateria.BackColor = Color.ForestGreen;
            BGuardarMateria.FlatAppearance.BorderSize = 0;
            BGuardarMateria.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 125, 50);
            BGuardarMateria.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 160, 71);
            BGuardarMateria.FlatStyle = FlatStyle.Flat;
            BGuardarMateria.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BGuardarMateria.ForeColor = SystemColors.ButtonHighlight;
            BGuardarMateria.Location = new Point(3, 3);
            BGuardarMateria.Name = "BGuardarMateria";
            BGuardarMateria.Size = new Size(94, 29);
            BGuardarMateria.TabIndex = 88;
            BGuardarMateria.Text = "Guardar";
            BGuardarMateria.UseVisualStyleBackColor = false;
            // 
            // BEliminarMateria
            // 
            BEliminarMateria.BackColor = Color.OrangeRed;
            BEliminarMateria.FlatAppearance.BorderSize = 0;
            BEliminarMateria.FlatStyle = FlatStyle.Flat;
            BEliminarMateria.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BEliminarMateria.ForeColor = SystemColors.ButtonHighlight;
            BEliminarMateria.Location = new Point(315, 3);
            BEliminarMateria.Name = "BEliminarMateria";
            BEliminarMateria.Size = new Size(94, 29);
            BEliminarMateria.TabIndex = 91;
            BEliminarMateria.Text = "Eliminar";
            BEliminarMateria.UseVisualStyleBackColor = false;
            BEliminarMateria.Visible = false;
            // 
            // BCancelarMateria
            // 
            BCancelarMateria.BackColor = Color.Gray;
            BCancelarMateria.FlatAppearance.BorderSize = 0;
            BCancelarMateria.FlatStyle = FlatStyle.Flat;
            BCancelarMateria.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BCancelarMateria.ForeColor = SystemColors.ButtonHighlight;
            BCancelarMateria.Location = new Point(103, 3);
            BCancelarMateria.Name = "BCancelarMateria";
            BCancelarMateria.Size = new Size(94, 29);
            BCancelarMateria.TabIndex = 89;
            BCancelarMateria.Text = "Cancelar";
            BCancelarMateria.UseVisualStyleBackColor = false;
            // 
            // BModificarMateria
            // 
            BModificarMateria.BackColor = SystemColors.Highlight;
            BModificarMateria.FlatAppearance.BorderSize = 0;
            BModificarMateria.FlatStyle = FlatStyle.Flat;
            BModificarMateria.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BModificarMateria.ForeColor = SystemColors.ButtonHighlight;
            BModificarMateria.Location = new Point(203, 3);
            BModificarMateria.Name = "BModificarMateria";
            BModificarMateria.Size = new Size(106, 29);
            BModificarMateria.TabIndex = 90;
            BModificarMateria.Text = "Modificar";
            BModificarMateria.UseVisualStyleBackColor = false;
            BModificarMateria.Visible = false;
            // 
            // panelCamposMaterias
            // 
            panelCamposMaterias.ColumnCount = 2;
            panelCamposMaterias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelCamposMaterias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelCamposMaterias.Controls.Add(labelEliminado, 0, 3);
            panelCamposMaterias.Controls.Add(CBNivelMateria, 1, 1);
            panelCamposMaterias.Controls.Add(labelNombre, 0, 0);
            panelCamposMaterias.Controls.Add(TBNombreMateria, 1, 0);
            panelCamposMaterias.Controls.Add(labelNivel, 0, 1);
            panelCamposMaterias.Controls.Add(TBDescripcionMateria, 1, 2);
            panelCamposMaterias.Controls.Add(labelDescripcion, 0, 2);
            panelCamposMaterias.Controls.Add(comboBoxEliminado, 1, 3);
            panelCamposMaterias.Location = new Point(93, 76);
            panelCamposMaterias.Name = "panelCamposMaterias";
            panelCamposMaterias.RowCount = 4;
            panelCamposMaterias.RowStyles.Add(new RowStyle());
            panelCamposMaterias.RowStyles.Add(new RowStyle());
            panelCamposMaterias.RowStyles.Add(new RowStyle());
            panelCamposMaterias.RowStyles.Add(new RowStyle());
            panelCamposMaterias.Size = new Size(561, 144);
            panelCamposMaterias.TabIndex = 107;
            // 
            // labelEliminado
            // 
            labelEliminado.AutoSize = true;
            labelEliminado.Location = new Point(3, 100);
            labelEliminado.Name = "labelEliminado";
            labelEliminado.Size = new Size(76, 20);
            labelEliminado.TabIndex = 100;
            labelEliminado.Text = "Eliminado";
            // 
            // CBNivelMateria
            // 
            CBNivelMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            CBNivelMateria.FormattingEnabled = true;
            CBNivelMateria.Items.AddRange(new object[] { "Primer año", "Segundo año", "Tercer año", "Cuarto año", "Quinto año" });
            CBNivelMateria.Location = new Point(283, 36);
            CBNivelMateria.Name = "CBNivelMateria";
            CBNivelMateria.Size = new Size(269, 28);
            CBNivelMateria.TabIndex = 99;
            CBNivelMateria.Tag = "Nivel";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(3, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(64, 20);
            labelNombre.TabIndex = 33;
            labelNombre.Text = "Nombre";
            // 
            // TBNombreMateria
            // 
            TBNombreMateria.Location = new Point(283, 3);
            TBNombreMateria.MinimumSize = new Size(180, 27);
            TBNombreMateria.Name = "TBNombreMateria";
            TBNombreMateria.Size = new Size(269, 27);
            TBNombreMateria.TabIndex = 38;
            TBNombreMateria.Tag = "Nombre";
            // 
            // labelNivel
            // 
            labelNivel.AutoSize = true;
            labelNivel.Location = new Point(3, 33);
            labelNivel.Name = "labelNivel";
            labelNivel.Size = new Size(43, 20);
            labelNivel.TabIndex = 34;
            labelNivel.Text = "Nivel";
            // 
            // TBDescripcionMateria
            // 
            TBDescripcionMateria.Location = new Point(283, 70);
            TBDescripcionMateria.MinimumSize = new Size(180, 27);
            TBDescripcionMateria.Name = "TBDescripcionMateria";
            TBDescripcionMateria.Size = new Size(269, 27);
            TBDescripcionMateria.TabIndex = 43;
            TBDescripcionMateria.Tag = "Descripcion";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(3, 67);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(87, 20);
            labelDescripcion.TabIndex = 37;
            labelDescripcion.Text = "Descripcion";
            // 
            // comboBoxEliminado
            // 
            comboBoxEliminado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEliminado.FormattingEnabled = true;
            comboBoxEliminado.Location = new Point(283, 104);
            comboBoxEliminado.Margin = new Padding(3, 4, 3, 4);
            comboBoxEliminado.Name = "comboBoxEliminado";
            comboBoxEliminado.Size = new Size(177, 28);
            comboBoxEliminado.TabIndex = 101;
            comboBoxEliminado.Tag = "Eliminado";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.Controls.Add(TBBuscadorMaterias, 0, 0);
            tableLayoutPanel6.Controls.Add(BMateriasActivas, 1, 0);
            tableLayoutPanel6.Controls.Add(BMateriasInactivas, 2, 0);
            tableLayoutPanel6.Location = new Point(78, 297);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(811, 40);
            tableLayoutPanel6.TabIndex = 106;
            // 
            // TBBuscadorMaterias
            // 
            TBBuscadorMaterias.Location = new Point(3, 3);
            TBBuscadorMaterias.Name = "TBBuscadorMaterias";
            TBBuscadorMaterias.PlaceholderText = "Buscar materia..";
            TBBuscadorMaterias.Size = new Size(236, 27);
            TBBuscadorMaterias.TabIndex = 62;
            // 
            // BMateriasActivas
            // 
            BMateriasActivas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMateriasActivas.BackColor = SystemColors.Highlight;
            BMateriasActivas.FlatAppearance.BorderSize = 0;
            BMateriasActivas.FlatStyle = FlatStyle.Flat;
            BMateriasActivas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BMateriasActivas.ForeColor = SystemColors.ButtonHighlight;
            BMateriasActivas.Location = new Point(614, 3);
            BMateriasActivas.Name = "BMateriasActivas";
            BMateriasActivas.Size = new Size(94, 29);
            BMateriasActivas.TabIndex = 63;
            BMateriasActivas.Text = "Activos";
            BMateriasActivas.UseVisualStyleBackColor = false;
            // 
            // BMateriasInactivas
            // 
            BMateriasInactivas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMateriasInactivas.BackColor = Color.Gray;
            BMateriasInactivas.FlatAppearance.BorderSize = 0;
            BMateriasInactivas.FlatStyle = FlatStyle.Flat;
            BMateriasInactivas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BMateriasInactivas.ForeColor = SystemColors.ButtonHighlight;
            BMateriasInactivas.Location = new Point(714, 3);
            BMateriasInactivas.Name = "BMateriasInactivas";
            BMateriasInactivas.Size = new Size(94, 29);
            BMateriasInactivas.TabIndex = 64;
            BMateriasInactivas.Text = "Inactivos";
            BMateriasInactivas.UseVisualStyleBackColor = false;
            // 
            // DGVMaterias
            // 
            DGVMaterias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMaterias.Columns.AddRange(new DataGridViewColumn[] { idMateria, Nombre, Nivel, DescripcionMateria });
            DGVMaterias.Location = new Point(78, 364);
            DGVMaterias.Name = "DGVMaterias";
            DGVMaterias.ReadOnly = true;
            DGVMaterias.RowHeadersWidth = 51;
            DGVMaterias.Size = new Size(811, 249);
            DGVMaterias.TabIndex = 105;
            // 
            // idMateria
            // 
            idMateria.HeaderText = "ID_Materia";
            idMateria.MinimumWidth = 6;
            idMateria.Name = "idMateria";
            idMateria.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Nivel
            // 
            Nivel.HeaderText = "Nivel";
            Nivel.MinimumWidth = 6;
            Nivel.Name = "Nivel";
            Nivel.ReadOnly = true;
            // 
            // DescripcionMateria
            // 
            DescripcionMateria.HeaderText = "Descripcion";
            DescripcionMateria.MinimumWidth = 6;
            DescripcionMateria.Name = "DescripcionMateria";
            DescripcionMateria.ReadOnly = true;
            // 
            // panelEncabezadoM
            // 
            panelEncabezadoM.Controls.Add(LTituloMaterias);
            panelEncabezadoM.Dock = DockStyle.Top;
            panelEncabezadoM.Location = new Point(0, 0);
            panelEncabezadoM.Name = "panelEncabezadoM";
            panelEncabezadoM.Size = new Size(914, 64);
            panelEncabezadoM.TabIndex = 104;
            // 
            // LTituloMaterias
            // 
            LTituloMaterias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LTituloMaterias.AutoSize = true;
            LTituloMaterias.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloMaterias.Location = new Point(3, 0);
            LTituloMaterias.Name = "LTituloMaterias";
            LTituloMaterias.Size = new Size(279, 38);
            LTituloMaterias.TabIndex = 1;
            LTituloMaterias.Text = "Gestion de Materias";
            // 
            // FormGestionMateria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelMateria);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionMateria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGestionMateria";
            Load += FormGestionMateria_Load;
            panelMateria.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panelCamposMaterias.ResumeLayout(false);
            panelCamposMaterias.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVMaterias).EndInit();
            panelEncabezadoM.ResumeLayout(false);
            panelEncabezadoM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMateria;
        private TableLayoutPanel tableLayoutPanel5;
        private Button BGuardarMateria;
        private Button BEliminarMateria;
        private Button BCancelarMateria;
        private Button BModificarMateria;
        private TableLayoutPanel panelCamposMaterias;
        private ComboBox CBNivelMateria;
        private Label labelNombre;
        private TextBox TBNombreMateria;
        private Label labelNivel;
        private TextBox TBDescripcionMateria;
        private Label labelDescripcion;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox TBBuscadorMaterias;
        private Button BMateriasActivas;
        private Button BMateriasInactivas;
        private DataGridView DGVMaterias;
        private FlowLayoutPanel panelEncabezadoM;
        private Label LTituloMaterias;
        private DataGridViewTextBoxColumn idMateria;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Nivel;
        private DataGridViewTextBoxColumn DescripcionMateria;
        private Label labelEliminado;
        private ComboBox comboBoxEliminado;
    }
}