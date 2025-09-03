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
            Titulo = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Tema = new DataGridViewTextBoxColumn();
            FechaAgregado = new DataGridViewTextBoxColumn();
            Acciones = new DataGridViewButtonColumn();
            labelTituloFavoritos = new Label();
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
            panelMainFavorites.Name = "panelMainFavorites";
            panelMainFavorites.Size = new Size(800, 450);
            panelMainFavorites.TabIndex = 0;
            panelMainFavorites.Paint += panelMainFavorites_Paint;
            // 
            // DGVFavoritos
            // 
            DGVFavoritos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGVFavoritos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVFavoritos.BackgroundColor = Color.RoyalBlue;
            DGVFavoritos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVFavoritos.Columns.AddRange(new DataGridViewColumn[] { Titulo, Tipo, Tema, FechaAgregado, Acciones });
            DGVFavoritos.GridColor = Color.MidnightBlue;
            DGVFavoritos.Location = new Point(0, 50);
            DGVFavoritos.Name = "DGVFavoritos";
            DGVFavoritos.Size = new Size(800, 400);
            DGVFavoritos.TabIndex = 1;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Título";
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Tema
            // 
            Tema.HeaderText = "Tema";
            Tema.Name = "Tema";
            Tema.ReadOnly = true;
            // 
            // FechaAgregado
            // 
            FechaAgregado.HeaderText = "Fecha Agregado";
            FechaAgregado.Name = "FechaAgregado";
            FechaAgregado.ReadOnly = true;
            // 
            // Acciones
            // 
            Acciones.HeaderText = "Acciones";
            Acciones.Name = "Acciones";
            Acciones.ReadOnly = true;
            // 
            // labelTituloFavoritos
            // 
            labelTituloFavoritos.AutoSize = true;
            labelTituloFavoritos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloFavoritos.Location = new Point(21, 22);
            labelTituloFavoritos.Name = "labelTituloFavoritos";
            labelTituloFavoritos.Size = new Size(213, 25);
            labelTituloFavoritos.TabIndex = 0;
            labelTituloFavoritos.Text = "Mis Recursos Favoritos";
            // 
            // FormFavoritesEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMainFavorites);
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
    }
}