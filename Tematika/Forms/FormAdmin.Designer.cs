namespace Tematika
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            sideBar = new Panel();
            LNombreUsuario = new Label();
            LRol = new Label();
            LTituloForm = new Label();
            BSalir = new Button();
            BGestionTematica = new Button();
            BDashboard = new Button();
            BInformes = new Button();
            BUsuarios = new Button();
            BBackUp = new Button();
            panelMain = new Panel();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.Controls.Add(BBackUp);
            sideBar.Controls.Add(LNombreUsuario);
            sideBar.Controls.Add(LRol);
            sideBar.Controls.Add(LTituloForm);
            sideBar.Controls.Add(BSalir);
            sideBar.Controls.Add(BGestionTematica);
            sideBar.Controls.Add(BDashboard);
            sideBar.Controls.Add(BInformes);
            sideBar.Controls.Add(BUsuarios);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Margin = new Padding(3, 2, 3, 2);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(250, 562);
            sideBar.TabIndex = 0;
            // 
            // LNombreUsuario
            // 
            LNombreUsuario.AutoSize = true;
            LNombreUsuario.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNombreUsuario.ForeColor = Color.White;
            LNombreUsuario.Location = new Point(21, 575);
            LNombreUsuario.Name = "LNombreUsuario";
            LNombreUsuario.Size = new Size(183, 30);
            LNombreUsuario.TabIndex = 13;
            LNombreUsuario.Text = "Nombre Usuario";
            LNombreUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LRol
            // 
            LRol.AutoSize = true;
            LRol.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LRol.ForeColor = Color.White;
            LRol.Location = new Point(21, 611);
            LRol.Name = "LRol";
            LRol.Size = new Size(45, 30);
            LRol.TabIndex = 12;
            LRol.Text = "Rol";
            LRol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LTituloForm
            // 
            LTituloForm.AutoSize = true;
            LTituloForm.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloForm.ForeColor = Color.White;
            LTituloForm.Location = new Point(42, 18);
            LTituloForm.Name = "LTituloForm";
            LTituloForm.Size = new Size(116, 32);
            LTituloForm.TabIndex = 11;
            LTituloForm.Text = "Tematika";
            LTituloForm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BSalir
            // 
            BSalir.FlatAppearance.BorderSize = 0;
            BSalir.FlatStyle = FlatStyle.Flat;
            BSalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BSalir.Image = (Image)resources.GetObject("BSalir.Image");
            BSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BSalir.Location = new Point(27, 650);
            BSalir.Margin = new Padding(3, 2, 3, 2);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(162, 52);
            BSalir.TabIndex = 10;
            BSalir.Text = "Cerrar Sesión";
            BSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // BGestionTematica
            // 
            BGestionTematica.AutoSize = true;
            BGestionTematica.FlatAppearance.BorderSize = 0;
            BGestionTematica.FlatStyle = FlatStyle.Flat;
            BGestionTematica.Font = new Font("Segoe UI", 10F);
            BGestionTematica.Image = (Image)resources.GetObject("BGestionTematica.Image");
            BGestionTematica.ImageAlign = ContentAlignment.MiddleLeft;
            BGestionTematica.Location = new Point(10, 267);
            BGestionTematica.Margin = new Padding(3, 2, 3, 2);
            BGestionTematica.Name = "BGestionTematica";
            BGestionTematica.Size = new Size(230, 70);
            BGestionTematica.TabIndex = 8;
            BGestionTematica.Text = "Organizacion Tematica";
            BGestionTematica.TextImageRelation = TextImageRelation.ImageBeforeText;
            BGestionTematica.UseVisualStyleBackColor = true;
            // 
            // BDashboard
            // 
            BDashboard.AutoSize = true;
            BDashboard.FlatAppearance.BorderSize = 0;
            BDashboard.FlatStyle = FlatStyle.Flat;
            BDashboard.Font = new Font("Segoe UI", 10F);
            BDashboard.ForeColor = SystemColors.ActiveCaptionText;
            BDashboard.Image = (Image)resources.GetObject("BDashboard.Image");
            BDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            BDashboard.Location = new Point(10, 73);
            BDashboard.Margin = new Padding(3, 2, 3, 2);
            BDashboard.Name = "BDashboard";
            BDashboard.Size = new Size(230, 70);
            BDashboard.TabIndex = 7;
            BDashboard.Text = "Dashboard";
            BDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            BDashboard.UseVisualStyleBackColor = true;
            // 
            // BInformes
            // 
            BInformes.AutoSize = true;
            BInformes.FlatAppearance.BorderSize = 0;
            BInformes.FlatStyle = FlatStyle.Flat;
            BInformes.Font = new Font("Segoe UI", 10F);
            BInformes.Image = (Image)resources.GetObject("BInformes.Image");
            BInformes.ImageAlign = ContentAlignment.MiddleLeft;
            BInformes.Location = new Point(10, 360);
            BInformes.Margin = new Padding(3, 2, 3, 2);
            BInformes.Name = "BInformes";
            BInformes.Size = new Size(230, 70);
            BInformes.TabIndex = 5;
            BInformes.Text = "Informes";
            BInformes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BInformes.UseVisualStyleBackColor = true;
            // 
            // BUsuarios
            // 
            BUsuarios.AutoSize = true;
            BUsuarios.BackgroundImageLayout = ImageLayout.Stretch;
            BUsuarios.FlatAppearance.BorderSize = 0;
            BUsuarios.FlatStyle = FlatStyle.Flat;
            BUsuarios.Font = new Font("Segoe UI", 10F);
            BUsuarios.Image = (Image)resources.GetObject("BUsuarios.Image");
            BUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            BUsuarios.Location = new Point(10, 163);
            BUsuarios.Margin = new Padding(3, 2, 3, 2);
            BUsuarios.Name = "BUsuarios";
            BUsuarios.Size = new Size(230, 70);
            BUsuarios.TabIndex = 1;
            BUsuarios.Text = "Usuarios";
            BUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            BUsuarios.UseVisualStyleBackColor = true;
            // 
            // BBackUp
            // 
            BBackUp.AutoSize = true;
            BBackUp.BackgroundImageLayout = ImageLayout.Stretch;
            BBackUp.FlatAppearance.BorderSize = 0;
            BBackUp.FlatStyle = FlatStyle.Flat;
            BBackUp.Font = new Font("Segoe UI", 10F);
            BBackUp.Image = (Image)resources.GetObject("BBackUp.Image");
            BBackUp.ImageAlign = ContentAlignment.MiddleLeft;
            BBackUp.Location = new Point(10, 468);
            BBackUp.Margin = new Padding(3, 2, 3, 2);
            BBackUp.Name = "BBackUp";
            BBackUp.Size = new Size(230, 70);
            BBackUp.TabIndex = 0;
            BBackUp.Text = "Back Up";
            BBackUp.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBackUp.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 0);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(934, 562);
            panelMain.TabIndex = 1;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 562);
            Controls.Add(panelMain);
            Controls.Add(sideBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tematika";
            Load += Form1_Load;
            sideBar.ResumeLayout(false);
            sideBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sideBar;
        private Panel panelMain;
        private Button BBackUp;
        private Button BInformes;
        private Button BUsuarios;
        private Button BDashboard;
        private Button BGestionTematica;
        private Button BSalir;
        private Label LTituloForm;
        private Label LNombreUsuario;
        private Label LRol;
    }
}
