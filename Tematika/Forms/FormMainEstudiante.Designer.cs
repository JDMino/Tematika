namespace Tematika
{
    partial class FormMainEstudiante
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            labelNombreUsuario = new Label();
            btnCerrarSesion = new Button();
            labelRolEstudiante = new Label();
            btnNotes = new Button();
            btnEvaluations = new Button();
            btnFavorites = new Button();
            btnExploreResources = new Button();
            btnDashboard = new Button();
            labelTitulo = new Label();
            panelMainContent = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.Controls.Add(labelNombreUsuario);
            panelSidebar.Controls.Add(btnCerrarSesion);
            panelSidebar.Controls.Add(labelRolEstudiante);
            panelSidebar.Controls.Add(btnNotes);
            panelSidebar.Controls.Add(btnEvaluations);
            panelSidebar.Controls.Add(btnFavorites);
            panelSidebar.Controls.Add(btnExploreResources);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(labelTitulo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 749);
            panelSidebar.TabIndex = 0;
            // 
            // labelNombreUsuario
            // 
            labelNombreUsuario.AutoSize = true;
            labelNombreUsuario.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreUsuario.ForeColor = Color.White;
            labelNombreUsuario.Location = new Point(40, 566);
            labelNombreUsuario.Name = "labelNombreUsuario";
            labelNombreUsuario.Size = new Size(183, 30);
            labelNombreUsuario.TabIndex = 8;
            labelNombreUsuario.Text = "Nombre Usuario";
            labelNombreUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Firebrick;
            btnCerrarSesion.Location = new Point(62, 648);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(116, 40);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // labelRolEstudiante
            // 
            labelRolEstudiante.AutoSize = true;
            labelRolEstudiante.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRolEstudiante.ForeColor = Color.White;
            labelRolEstudiante.Location = new Point(62, 607);
            labelRolEstudiante.Name = "labelRolEstudiante";
            labelRolEstudiante.Size = new Size(123, 30);
            labelRolEstudiante.TabIndex = 6;
            labelRolEstudiante.Text = "Estudiante";
            labelRolEstudiante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNotes
            // 
            btnNotes.Location = new Point(12, 437);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(230, 40);
            btnNotes.TabIndex = 5;
            btnNotes.Text = "Mis Notas";
            btnNotes.UseVisualStyleBackColor = true;
            // 
            // btnEvaluations
            // 
            btnEvaluations.Location = new Point(12, 345);
            btnEvaluations.Name = "btnEvaluations";
            btnEvaluations.Size = new Size(230, 40);
            btnEvaluations.TabIndex = 4;
            btnEvaluations.Text = "Mis Evaluaciones";
            btnEvaluations.UseVisualStyleBackColor = true;
            // 
            // btnFavorites
            // 
            btnFavorites.Location = new Point(12, 253);
            btnFavorites.Name = "btnFavorites";
            btnFavorites.Size = new Size(230, 40);
            btnFavorites.TabIndex = 3;
            btnFavorites.Text = "Mis Favoritos";
            btnFavorites.UseVisualStyleBackColor = true;
            // 
            // btnExploreResources
            // 
            btnExploreResources.Location = new Point(12, 161);
            btnExploreResources.Name = "btnExploreResources";
            btnExploreResources.Size = new Size(230, 40);
            btnExploreResources.TabIndex = 2;
            btnExploreResources.Text = "Explorar Contenido";
            btnExploreResources.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(12, 69);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(230, 40);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(62, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(116, 32);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tematika";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.White;
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(250, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(934, 749);
            panelMainContent.TabIndex = 1;
            // 
            // FormMainEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 749);
            Controls.Add(panelMainContent);
            Controls.Add(panelSidebar);
            Name = "FormMainEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tematika";
            Load += FormMain_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label labelTitulo;
        private Button btnDashboard;
        private Button btnNotes;
        private Button btnEvaluations;
        private Button btnFavorites;
        private Button btnExploreResources;
        private Panel panelMainContent;
        private Label labelRolEstudiante;
        private Label labelNombreUsuario;
        private Button btnCerrarSesion;
    }
}
