namespace Tematika.Forms
{
    partial class FormNotesEstudiante
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
            panelMisNotas = new Panel();
            DGVMisNotas = new DataGridView();
            labelMisNotas = new Label();
            RecursoAsociado = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            Acciones = new DataGridViewTextBoxColumn();
            panelNuevaNota = new Panel();
            btnGuardarMisNotas = new Button();
            TBContenidoMisNotas = new TextBox();
            labelContenidoMisNotas = new Label();
            labelRecursoMisNotas = new Label();
            cmbRecursosMisNotas = new ComboBox();
            labelAsignaturaMisNotas = new Label();
            cmbAsignaturasMisNotas = new ComboBox();
            labelTemaMisNotas = new Label();
            cmbTemasMisNotas = new ComboBox();
            label1 = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
            panelMisNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVMisNotas).BeginInit();
            panelNuevaNota.SuspendLayout();
            SuspendLayout();
            // 
            // panelMisNotas
            // 
            panelMisNotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMisNotas.BackColor = SystemColors.ActiveCaption;
            panelMisNotas.Controls.Add(DGVMisNotas);
            panelMisNotas.Controls.Add(labelMisNotas);
            panelMisNotas.Location = new Point(0, 0);
            panelMisNotas.Name = "panelMisNotas";
            panelMisNotas.Size = new Size(800, 247);
            panelMisNotas.TabIndex = 0;
            // 
            // DGVMisNotas
            // 
            DGVMisNotas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGVMisNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVMisNotas.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVMisNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVMisNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMisNotas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewButtonColumn3, dataGridViewButtonColumn4 });
            DGVMisNotas.Location = new Point(0, 78);
            DGVMisNotas.Name = "DGVMisNotas";
            DGVMisNotas.RowHeadersWidth = 51;
            DGVMisNotas.Size = new Size(800, 139);
            DGVMisNotas.TabIndex = 8;
            // 
            // labelMisNotas
            // 
            labelMisNotas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMisNotas.AutoSize = true;
            labelMisNotas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMisNotas.Location = new Point(295, 9);
            labelMisNotas.Name = "labelMisNotas";
            labelMisNotas.Size = new Size(180, 25);
            labelMisNotas.TabIndex = 5;
            labelMisNotas.Text = "Mis Notas Privadas";
            // 
            // RecursoAsociado
            // 
            RecursoAsociado.HeaderText = "Recurso Asociado";
            RecursoAsociado.MinimumWidth = 6;
            RecursoAsociado.Name = "RecursoAsociado";
            RecursoAsociado.ReadOnly = true;
            RecursoAsociado.Width = 125;
            // 
            // Nota
            // 
            Nota.HeaderText = "Nota";
            Nota.MinimumWidth = 6;
            Nota.Name = "Nota";
            Nota.ReadOnly = true;
            Nota.Width = 125;
            // 
            // Acciones
            // 
            Acciones.HeaderText = "Acciones";
            Acciones.MinimumWidth = 6;
            Acciones.Name = "Acciones";
            Acciones.ReadOnly = true;
            Acciones.Width = 125;
            // 
            // panelNuevaNota
            // 
            panelNuevaNota.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelNuevaNota.BackColor = SystemColors.ControlLight;
            panelNuevaNota.Controls.Add(btnGuardarMisNotas);
            panelNuevaNota.Controls.Add(TBContenidoMisNotas);
            panelNuevaNota.Controls.Add(labelContenidoMisNotas);
            panelNuevaNota.Controls.Add(labelRecursoMisNotas);
            panelNuevaNota.Controls.Add(cmbRecursosMisNotas);
            panelNuevaNota.Controls.Add(labelAsignaturaMisNotas);
            panelNuevaNota.Controls.Add(cmbAsignaturasMisNotas);
            panelNuevaNota.Controls.Add(labelTemaMisNotas);
            panelNuevaNota.Controls.Add(cmbTemasMisNotas);
            panelNuevaNota.Controls.Add(label1);
            panelNuevaNota.Location = new Point(0, 246);
            panelNuevaNota.Name = "panelNuevaNota";
            panelNuevaNota.Size = new Size(800, 238);
            panelNuevaNota.TabIndex = 1;
            // 
            // btnGuardarMisNotas
            // 
            btnGuardarMisNotas.BackColor = Color.ForestGreen;
            btnGuardarMisNotas.FlatAppearance.BorderSize = 0;
            btnGuardarMisNotas.FlatStyle = FlatStyle.Flat;
            btnGuardarMisNotas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarMisNotas.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarMisNotas.Location = new Point(144, 203);
            btnGuardarMisNotas.Name = "btnGuardarMisNotas";
            btnGuardarMisNotas.Size = new Size(143, 23);
            btnGuardarMisNotas.TabIndex = 15;
            btnGuardarMisNotas.Text = "Guardar Nueva Nota";
            btnGuardarMisNotas.UseVisualStyleBackColor = false;
            // 
            // TBContenidoMisNotas
            // 
            TBContenidoMisNotas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TBContenidoMisNotas.Location = new Point(144, 128);
            TBContenidoMisNotas.Multiline = true;
            TBContenidoMisNotas.Name = "TBContenidoMisNotas";
            TBContenidoMisNotas.Size = new Size(644, 69);
            TBContenidoMisNotas.TabIndex = 14;
            // 
            // labelContenidoMisNotas
            // 
            labelContenidoMisNotas.AutoSize = true;
            labelContenidoMisNotas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContenidoMisNotas.Location = new Point(3, 118);
            labelContenidoMisNotas.Name = "labelContenidoMisNotas";
            labelContenidoMisNotas.Size = new Size(111, 25);
            labelContenidoMisNotas.TabIndex = 13;
            labelContenidoMisNotas.Text = "Contenido:";
            // 
            // labelRecursoMisNotas
            // 
            labelRecursoMisNotas.AutoSize = true;
            labelRecursoMisNotas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRecursoMisNotas.Location = new Point(3, 93);
            labelRecursoMisNotas.Name = "labelRecursoMisNotas";
            labelRecursoMisNotas.Size = new Size(88, 25);
            labelRecursoMisNotas.TabIndex = 12;
            labelRecursoMisNotas.Text = "Recurso:";
            // 
            // cmbRecursosMisNotas
            // 
            cmbRecursosMisNotas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbRecursosMisNotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecursosMisNotas.FormattingEnabled = true;
            cmbRecursosMisNotas.Location = new Point(144, 93);
            cmbRecursosMisNotas.Name = "cmbRecursosMisNotas";
            cmbRecursosMisNotas.Size = new Size(644, 23);
            cmbRecursosMisNotas.TabIndex = 11;
            // 
            // labelAsignaturaMisNotas
            // 
            labelAsignaturaMisNotas.AutoSize = true;
            labelAsignaturaMisNotas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAsignaturaMisNotas.Location = new Point(3, 35);
            labelAsignaturaMisNotas.Name = "labelAsignaturaMisNotas";
            labelAsignaturaMisNotas.Size = new Size(114, 25);
            labelAsignaturaMisNotas.TabIndex = 10;
            labelAsignaturaMisNotas.Text = "Asignatura:";
            // 
            // cmbAsignaturasMisNotas
            // 
            cmbAsignaturasMisNotas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbAsignaturasMisNotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAsignaturasMisNotas.FormattingEnabled = true;
            cmbAsignaturasMisNotas.Location = new Point(144, 35);
            cmbAsignaturasMisNotas.Name = "cmbAsignaturasMisNotas";
            cmbAsignaturasMisNotas.Size = new Size(644, 23);
            cmbAsignaturasMisNotas.TabIndex = 9;
            // 
            // labelTemaMisNotas
            // 
            labelTemaMisNotas.AutoSize = true;
            labelTemaMisNotas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTemaMisNotas.Location = new Point(3, 64);
            labelTemaMisNotas.Name = "labelTemaMisNotas";
            labelTemaMisNotas.Size = new Size(63, 25);
            labelTemaMisNotas.TabIndex = 8;
            labelTemaMisNotas.Text = "Tema:";
            // 
            // cmbTemasMisNotas
            // 
            cmbTemasMisNotas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbTemasMisNotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTemasMisNotas.FormattingEnabled = true;
            cmbTemasMisNotas.Location = new Point(144, 64);
            cmbTemasMisNotas.Name = "cmbTemasMisNotas";
            cmbTemasMisNotas.Size = new Size(644, 23);
            cmbTemasMisNotas.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 4);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 6;
            label1.Text = "Añadir Nueva Nota";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewButtonColumn2.MinimumWidth = 6;
            dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            // 
            // dataGridViewButtonColumn4
            // 
            dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            // 
            // FormNotesEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 484);
            Controls.Add(panelNuevaNota);
            Controls.Add(panelMisNotas);
            Name = "FormNotesEstudiante";
            Text = "FormNotesEstudiante";
            panelMisNotas.ResumeLayout(false);
            panelMisNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVMisNotas).EndInit();
            panelNuevaNota.ResumeLayout(false);
            panelNuevaNota.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMisNotas;
        private Panel panelNuevaNota;
        private Label labelMisNotas;
        private Label label1;
        private DataGridView DGVMisNotas;
        private DataGridViewTextBoxColumn RecursoAsociado;
        private DataGridViewTextBoxColumn Nota;
        private DataGridViewTextBoxColumn Acciones;
        private ComboBox cmbTemasMisNotas;
        private Label labelTemaMisNotas;
        private Label labelRecursoMisNotas;
        private ComboBox cmbRecursosMisNotas;
        private Label labelAsignaturaMisNotas;
        private ComboBox cmbAsignaturasMisNotas;
        private TextBox TBContenidoMisNotas;
        private Label labelContenidoMisNotas;
        private Button btnGuardarMisNotas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn4;
    }
}