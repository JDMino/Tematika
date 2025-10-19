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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            panelMisNotas.Margin = new Padding(3, 4, 3, 4);
            panelMisNotas.Name = "panelMisNotas";
            panelMisNotas.Size = new Size(914, 329);
            panelMisNotas.TabIndex = 0;
            // 
            // DGVMisNotas
            // 
            DGVMisNotas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGVMisNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVMisNotas.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVMisNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVMisNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMisNotas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewButtonColumn1, dataGridViewButtonColumn2 });
            DGVMisNotas.Location = new Point(0, 104);
            DGVMisNotas.Margin = new Padding(3, 4, 3, 4);
            DGVMisNotas.Name = "DGVMisNotas";
            DGVMisNotas.RowHeadersWidth = 51;
            DGVMisNotas.Size = new Size(914, 185);
            DGVMisNotas.TabIndex = 8;
            // 
            // labelMisNotas
            // 
            labelMisNotas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelMisNotas.AutoSize = true;
            labelMisNotas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMisNotas.Location = new Point(337, 12);
            labelMisNotas.Name = "labelMisNotas";
            labelMisNotas.Size = new Size(233, 32);
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
            panelNuevaNota.Location = new Point(0, 328);
            panelNuevaNota.Margin = new Padding(3, 4, 3, 4);
            panelNuevaNota.Name = "panelNuevaNota";
            panelNuevaNota.Size = new Size(914, 317);
            panelNuevaNota.TabIndex = 1;
            // 
            // btnGuardarMisNotas
            // 
            btnGuardarMisNotas.BackColor = Color.ForestGreen;
            btnGuardarMisNotas.FlatAppearance.BorderSize = 0;
            btnGuardarMisNotas.FlatStyle = FlatStyle.Flat;
            btnGuardarMisNotas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarMisNotas.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarMisNotas.Location = new Point(165, 271);
            btnGuardarMisNotas.Margin = new Padding(3, 4, 3, 4);
            btnGuardarMisNotas.Name = "btnGuardarMisNotas";
            btnGuardarMisNotas.Size = new Size(163, 31);
            btnGuardarMisNotas.TabIndex = 15;
            btnGuardarMisNotas.Text = "Guardar Nueva Nota";
            btnGuardarMisNotas.UseVisualStyleBackColor = false;
            // 
            // TBContenidoMisNotas
            // 
            TBContenidoMisNotas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TBContenidoMisNotas.Location = new Point(165, 171);
            TBContenidoMisNotas.Margin = new Padding(3, 4, 3, 4);
            TBContenidoMisNotas.Multiline = true;
            TBContenidoMisNotas.Name = "TBContenidoMisNotas";
            TBContenidoMisNotas.Size = new Size(735, 91);
            TBContenidoMisNotas.TabIndex = 14;
            // 
            // labelContenidoMisNotas
            // 
            labelContenidoMisNotas.AutoSize = true;
            labelContenidoMisNotas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContenidoMisNotas.Location = new Point(3, 157);
            labelContenidoMisNotas.Name = "labelContenidoMisNotas";
            labelContenidoMisNotas.Size = new Size(140, 32);
            labelContenidoMisNotas.TabIndex = 13;
            labelContenidoMisNotas.Text = "Contenido:";
            // 
            // labelRecursoMisNotas
            // 
            labelRecursoMisNotas.AutoSize = true;
            labelRecursoMisNotas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRecursoMisNotas.Location = new Point(3, 124);
            labelRecursoMisNotas.Name = "labelRecursoMisNotas";
            labelRecursoMisNotas.Size = new Size(112, 32);
            labelRecursoMisNotas.TabIndex = 12;
            labelRecursoMisNotas.Text = "Recurso:";
            // 
            // cmbRecursosMisNotas
            // 
            cmbRecursosMisNotas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbRecursosMisNotas.FormattingEnabled = true;
            cmbRecursosMisNotas.Location = new Point(165, 124);
            cmbRecursosMisNotas.Margin = new Padding(3, 4, 3, 4);
            cmbRecursosMisNotas.Name = "cmbRecursosMisNotas";
            cmbRecursosMisNotas.Size = new Size(735, 28);
            cmbRecursosMisNotas.TabIndex = 11;
            // 
            // labelAsignaturaMisNotas
            // 
            labelAsignaturaMisNotas.AutoSize = true;
            labelAsignaturaMisNotas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAsignaturaMisNotas.Location = new Point(3, 47);
            labelAsignaturaMisNotas.Name = "labelAsignaturaMisNotas";
            labelAsignaturaMisNotas.Size = new Size(146, 32);
            labelAsignaturaMisNotas.TabIndex = 10;
            labelAsignaturaMisNotas.Text = "Asignatura:";
            // 
            // cmbAsignaturasMisNotas
            // 
            cmbAsignaturasMisNotas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbAsignaturasMisNotas.FormattingEnabled = true;
            cmbAsignaturasMisNotas.Location = new Point(165, 47);
            cmbAsignaturasMisNotas.Margin = new Padding(3, 4, 3, 4);
            cmbAsignaturasMisNotas.Name = "cmbAsignaturasMisNotas";
            cmbAsignaturasMisNotas.Size = new Size(735, 28);
            cmbAsignaturasMisNotas.TabIndex = 9;
            // 
            // labelTemaMisNotas
            // 
            labelTemaMisNotas.AutoSize = true;
            labelTemaMisNotas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTemaMisNotas.Location = new Point(3, 85);
            labelTemaMisNotas.Name = "labelTemaMisNotas";
            labelTemaMisNotas.Size = new Size(81, 32);
            labelTemaMisNotas.TabIndex = 8;
            labelTemaMisNotas.Text = "Tema:";
            // 
            // cmbTemasMisNotas
            // 
            cmbTemasMisNotas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbTemasMisNotas.FormattingEnabled = true;
            cmbTemasMisNotas.Location = new Point(165, 85);
            cmbTemasMisNotas.Margin = new Padding(3, 4, 3, 4);
            cmbTemasMisNotas.Name = "cmbTemasMisNotas";
            cmbTemasMisNotas.Size = new Size(735, 28);
            cmbTemasMisNotas.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 5);
            label1.Name = "label1";
            label1.Size = new Size(234, 32);
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
            // FormNotesEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 645);
            Controls.Add(panelNuevaNota);
            Controls.Add(panelMisNotas);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}