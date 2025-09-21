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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainEstudiante));
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
            panelSidebar.Margin = new Padding(3, 4, 3, 4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(286, 999);
            panelSidebar.TabIndex = 0;
            // 
            // labelNombreUsuario
            // 
            labelNombreUsuario.AutoSize = true;
            labelNombreUsuario.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreUsuario.ForeColor = Color.White;
            labelNombreUsuario.Location = new Point(24, 767);
            labelNombreUsuario.Name = "labelNombreUsuario";
            labelNombreUsuario.Size = new Size(229, 37);
            labelNombreUsuario.TabIndex = 8;
            labelNombreUsuario.Text = "Nombre Usuario";
            labelNombreUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.AutoSize = true;
            btnCerrarSesion.BackColor = Color.Firebrick;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10.2F);
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(31, 867);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(185, 70);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // labelRolEstudiante
            // 
            labelRolEstudiante.AutoSize = true;
            labelRolEstudiante.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRolEstudiante.ForeColor = Color.White;
            labelRolEstudiante.Location = new Point(24, 815);
            labelRolEstudiante.Name = "labelRolEstudiante";
            labelRolEstudiante.Size = new Size(152, 37);
            labelRolEstudiante.TabIndex = 6;
            labelRolEstudiante.Text = "Estudiante";
            labelRolEstudiante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNotes
            // 
            btnNotes.AutoSize = true;
            btnNotes.FlatAppearance.BorderSize = 0;
            btnNotes.FlatStyle = FlatStyle.Flat;
            btnNotes.Font = new Font("Segoe UI", 10F);
            btnNotes.Image = (Image)resources.GetObject("btnNotes.Image");
            btnNotes.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotes.Location = new Point(14, 583);
            btnNotes.Margin = new Padding(3, 4, 3, 4);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(263, 70);
            btnNotes.TabIndex = 5;
            btnNotes.Text = "Mis Notas";
            btnNotes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNotes.UseVisualStyleBackColor = true;
            // 
            // btnEvaluations
            // 
            btnEvaluations.AutoSize = true;
            btnEvaluations.FlatAppearance.BorderSize = 0;
            btnEvaluations.FlatStyle = FlatStyle.Flat;
            btnEvaluations.Font = new Font("Segoe UI", 10F);
            btnEvaluations.Image = (Image)resources.GetObject("btnEvaluations.Image");
            btnEvaluations.ImageAlign = ContentAlignment.MiddleLeft;
            btnEvaluations.Location = new Point(14, 460);
            btnEvaluations.Margin = new Padding(3, 4, 3, 4);
            btnEvaluations.Name = "btnEvaluations";
            btnEvaluations.Size = new Size(263, 70);
            btnEvaluations.TabIndex = 4;
            btnEvaluations.Text = "Mis Evaluaciones";
            btnEvaluations.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEvaluations.UseVisualStyleBackColor = true;
            // 
            // btnFavorites
            // 
            btnFavorites.AutoSize = true;
            btnFavorites.FlatAppearance.BorderSize = 0;
            btnFavorites.FlatStyle = FlatStyle.Flat;
            btnFavorites.Font = new Font("Segoe UI", 10F);
            btnFavorites.Image = (Image)resources.GetObject("btnFavorites.Image");
            btnFavorites.ImageAlign = ContentAlignment.MiddleLeft;
            btnFavorites.Location = new Point(14, 337);
            btnFavorites.Margin = new Padding(3, 4, 3, 4);
            btnFavorites.Name = "btnFavorites";
            btnFavorites.Size = new Size(263, 70);
            btnFavorites.TabIndex = 3;
            btnFavorites.Text = "Mis Favoritos";
            btnFavorites.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFavorites.UseVisualStyleBackColor = true;
            // 
            // btnExploreResources
            // 
            btnExploreResources.AutoSize = true;
            btnExploreResources.FlatAppearance.BorderSize = 0;
            btnExploreResources.FlatStyle = FlatStyle.Flat;
            btnExploreResources.Font = new Font("Segoe UI", 10F);
            btnExploreResources.Image = (Image)resources.GetObject("btnExploreResources.Image");
            btnExploreResources.ImageAlign = ContentAlignment.MiddleLeft;
            btnExploreResources.Location = new Point(14, 215);
            btnExploreResources.Margin = new Padding(3, 4, 3, 4);
            btnExploreResources.Name = "btnExploreResources";
            btnExploreResources.Size = new Size(263, 70);
            btnExploreResources.TabIndex = 2;
            btnExploreResources.Text = "Explorar Contenido";
            btnExploreResources.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExploreResources.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSize = true;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.TopLeft;
            btnDashboard.Location = new Point(14, 92);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(263, 70);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(71, 12);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(146, 41);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tematika";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.White;
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(286, 0);
            panelMainContent.Margin = new Padding(3, 4, 3, 4);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(1067, 999);
            panelMainContent.TabIndex = 1;
            // 
            // FormMainEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 999);
            Controls.Add(panelMainContent);
            Controls.Add(panelSidebar);
            Margin = new Padding(3, 4, 3, 4);
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
