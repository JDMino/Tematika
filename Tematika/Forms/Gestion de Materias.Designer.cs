namespace Tematika.Forms
{
    partial class Gestion_de_Materias
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
            panel3 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            TBDescripcionMateria = new TextBox();
            TBNivelMateria = new TextBox();
            DGVMaterias = new DataGridView();
            idMateria = new DataGridViewTextBoxColumn();
            NombreMateria = new DataGridViewTextBoxColumn();
            NivelMateria = new DataGridViewTextBoxColumn();
            DescripcionMateria = new DataGridViewTextBoxColumn();
            BEliminarMateria = new Button();
            BModificarMateria = new Button();
            BCancelarMateria = new Button();
            BGuardarMateria = new Button();
            TBNombreMateria = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVMaterias).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(853, 62);
            panel3.TabIndex = 3;
            panel3.TabStop = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(361, 24);
            label2.Name = "label2";
            label2.Size = new Size(279, 38);
            label2.TabIndex = 0;
            label2.Text = "Gestion de Materias";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(TBDescripcionMateria);
            panel1.Controls.Add(TBNivelMateria);
            panel1.Controls.Add(DGVMaterias);
            panel1.Controls.Add(BEliminarMateria);
            panel1.Controls.Add(BModificarMateria);
            panel1.Controls.Add(BCancelarMateria);
            panel1.Controls.Add(BGuardarMateria);
            panel1.Controls.Add(TBNombreMateria);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 478);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // TBDescripcionMateria
            // 
            TBDescripcionMateria.Location = new Point(378, 129);
            TBDescripcionMateria.MinimumSize = new Size(180, 27);
            TBDescripcionMateria.Name = "TBDescripcionMateria";
            TBDescripcionMateria.Size = new Size(180, 27);
            TBDescripcionMateria.TabIndex = 32;
            // 
            // TBNivelMateria
            // 
            TBNivelMateria.Location = new Point(378, 82);
            TBNivelMateria.MinimumSize = new Size(180, 27);
            TBNivelMateria.Name = "TBNivelMateria";
            TBNivelMateria.Size = new Size(180, 27);
            TBNivelMateria.TabIndex = 31;
            // 
            // DGVMaterias
            // 
            DGVMaterias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMaterias.Columns.AddRange(new DataGridViewColumn[] { idMateria, NombreMateria, NivelMateria, DescripcionMateria });
            DGVMaterias.Location = new Point(3, 293);
            DGVMaterias.Name = "DGVMaterias";
            DGVMaterias.RowHeadersWidth = 51;
            DGVMaterias.Size = new Size(847, 173);
            DGVMaterias.TabIndex = 30;
            // 
            // idMateria
            // 
            idMateria.HeaderText = "ID_Materia";
            idMateria.MinimumWidth = 6;
            idMateria.Name = "idMateria";
            // 
            // NombreMateria
            // 
            NombreMateria.HeaderText = "Nombre";
            NombreMateria.MinimumWidth = 6;
            NombreMateria.Name = "NombreMateria";
            // 
            // NivelMateria
            // 
            NivelMateria.HeaderText = "Nivel";
            NivelMateria.MinimumWidth = 6;
            NivelMateria.Name = "NivelMateria";
            // 
            // DescripcionMateria
            // 
            DescripcionMateria.HeaderText = "Descripcion";
            DescripcionMateria.MinimumWidth = 6;
            DescripcionMateria.Name = "DescripcionMateria";
            // 
            // BEliminarMateria
            // 
            BEliminarMateria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BEliminarMateria.Location = new Point(378, 209);
            BEliminarMateria.MaximumSize = new Size(94, 29);
            BEliminarMateria.MinimumSize = new Size(94, 29);
            BEliminarMateria.Name = "BEliminarMateria";
            BEliminarMateria.Size = new Size(94, 29);
            BEliminarMateria.TabIndex = 24;
            BEliminarMateria.Text = "Eliminar";
            BEliminarMateria.UseVisualStyleBackColor = true;
            // 
            // BModificarMateria
            // 
            BModificarMateria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BModificarMateria.Location = new Point(478, 209);
            BModificarMateria.MaximumSize = new Size(94, 29);
            BModificarMateria.MinimumSize = new Size(94, 29);
            BModificarMateria.Name = "BModificarMateria";
            BModificarMateria.Size = new Size(94, 29);
            BModificarMateria.TabIndex = 29;
            BModificarMateria.Text = "Modificar";
            BModificarMateria.UseVisualStyleBackColor = true;
            // 
            // BCancelarMateria
            // 
            BCancelarMateria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCancelarMateria.Location = new Point(478, 174);
            BCancelarMateria.MaximumSize = new Size(94, 29);
            BCancelarMateria.MinimumSize = new Size(94, 29);
            BCancelarMateria.Name = "BCancelarMateria";
            BCancelarMateria.Size = new Size(94, 29);
            BCancelarMateria.TabIndex = 25;
            BCancelarMateria.Text = "Cancelar";
            BCancelarMateria.UseVisualStyleBackColor = true;
            // 
            // BGuardarMateria
            // 
            BGuardarMateria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BGuardarMateria.Location = new Point(378, 174);
            BGuardarMateria.MaximumSize = new Size(94, 29);
            BGuardarMateria.MinimumSize = new Size(94, 29);
            BGuardarMateria.Name = "BGuardarMateria";
            BGuardarMateria.Size = new Size(94, 29);
            BGuardarMateria.TabIndex = 28;
            BGuardarMateria.Text = "Guardar";
            BGuardarMateria.UseVisualStyleBackColor = true;
            // 
            // TBNombreMateria
            // 
            TBNombreMateria.Location = new Point(378, 39);
            TBNombreMateria.MinimumSize = new Size(180, 27);
            TBNombreMateria.Name = "TBNombreMateria";
            TBNombreMateria.Size = new Size(180, 27);
            TBNombreMateria.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 129);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 26;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 82);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 23;
            label3.Text = "Nivel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 39);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 22;
            label1.Text = "Nombre";
            // 
            // Gestion_de_Materias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(853, 546);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Gestion_de_Materias";
            Text = "Gestion_de_Materias";
            Load += Gestion_de_Materias_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVMaterias).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label2;
        private Panel panel1;
        private TextBox TBDescripcionMateria;
        private TextBox TBNivelMateria;
        private DataGridView DGVMaterias;
        private DataGridViewTextBoxColumn idMateria;
        private DataGridViewTextBoxColumn NombreMateria;
        private DataGridViewTextBoxColumn NivelMateria;
        private DataGridViewTextBoxColumn DescripcionMateria;
        private Button BEliminarMateria;
        private Button BModificarMateria;
        private Button BCancelarMateria;
        private Button BGuardarMateria;
        private TextBox TBNombreMateria;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}