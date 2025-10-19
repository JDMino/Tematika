namespace Tematika.Forms
{
    partial class FormFavoritesEstudiante
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
            panelMainFavorites = new Panel();
            DGVFavoritos = new DataGridView();
            labelTituloFavoritos = new Label();
            Titulo = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Tema = new DataGridViewTextBoxColumn();
            FechaAgregado = new DataGridViewTextBoxColumn();
            Acciones = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            panelMainFavorites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVFavoritos).BeginInit();
            SuspendLayout();
            // 
            // panelMainFavorites
            // 
            panelMainFavorites.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMainFavorites.BackColor = SystemColors.ActiveCaption;
            panelMainFavorites.Controls.Add(DGVFavoritos);
            panelMainFavorites.Controls.Add(labelTituloFavoritos);
            panelMainFavorites.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelMainFavorites.Location = new Point(0, 0);
            panelMainFavorites.Margin = new Padding(3, 4, 3, 4);
            panelMainFavorites.Name = "panelMainFavorites";
            panelMainFavorites.Size = new Size(914, 600);
            panelMainFavorites.TabIndex = 0;
            // 
            // DGVFavoritos
            // 
            DGVFavoritos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGVFavoritos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVFavoritos.BackgroundColor = SystemColors.ActiveBorder;
            DGVFavoritos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVFavoritos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewButtonColumn1, dataGridViewButtonColumn2 });
            DGVFavoritos.GridColor = Color.MidnightBlue;
            DGVFavoritos.Location = new Point(0, 67);
            DGVFavoritos.Margin = new Padding(3, 4, 3, 4);
            DGVFavoritos.Name = "DGVFavoritos";
            DGVFavoritos.RowHeadersWidth = 51;
            DGVFavoritos.Size = new Size(914, 533);
            DGVFavoritos.TabIndex = 1;
            // 
            // labelTituloFavoritos
            // 
            labelTituloFavoritos.AutoSize = true;
            labelTituloFavoritos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloFavoritos.Location = new Point(24, 29);
            labelTituloFavoritos.Name = "labelTituloFavoritos";
            labelTituloFavoritos.Size = new Size(275, 32);
            labelTituloFavoritos.TabIndex = 0;
            labelTituloFavoritos.Text = "Mis Recursos Favoritos";
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Título";
            Titulo.MinimumWidth = 6;
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            Titulo.Width = 125;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 125;
            // 
            // Tema
            // 
            Tema.HeaderText = "Tema";
            Tema.MinimumWidth = 6;
            Tema.Name = "Tema";
            Tema.ReadOnly = true;
            Tema.Width = 125;
            // 
            // FechaAgregado
            // 
            FechaAgregado.HeaderText = "Fecha Agregado";
            FechaAgregado.MinimumWidth = 6;
            FechaAgregado.Name = "FechaAgregado";
            FechaAgregado.ReadOnly = true;
            FechaAgregado.Width = 125;
            // 
            // Acciones
            // 
            Acciones.HeaderText = "Acciones";
            Acciones.MinimumWidth = 6;
            Acciones.Name = "Acciones";
            Acciones.ReadOnly = true;
            Acciones.Width = 125;
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
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
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
            // FormFavoritesEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(panelMainFavorites);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormFavoritesEstudiante";
            Text = "FormFavoritesEstudiante";
            panelMainFavorites.ResumeLayout(false);
            panelMainFavorites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVFavoritos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMainFavorites;
        private Label labelTituloFavoritos;
        private DataGridView DGVFavoritos;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Tema;
        private DataGridViewTextBoxColumn FechaAgregado;
        private DataGridViewButtonColumn Acciones;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}