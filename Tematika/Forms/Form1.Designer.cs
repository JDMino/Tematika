namespace Tematika
{
    partial class Form1
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
            sideBar = new Panel();
            BSalir = new Button();
            BGestionTematica = new Button();
            BDashboard = new Button();
            BInformes = new Button();
            BUsuarios = new Button();
            BBackUp = new Button();
            panelMain = new Panel();
            BLogin = new Button();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.Controls.Add(BLogin);
            sideBar.Controls.Add(BSalir);
            sideBar.Controls.Add(BGestionTematica);
            sideBar.Controls.Add(BDashboard);
            sideBar.Controls.Add(BInformes);
            sideBar.Controls.Add(BUsuarios);
            sideBar.Controls.Add(BBackUp);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(244, 778);
            sideBar.TabIndex = 0;
            // 
            // BSalir
            // 
            BSalir.FlatAppearance.BorderSize = 0;
            BSalir.FlatStyle = FlatStyle.Flat;
            BSalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BSalir.Location = new Point(33, 482);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(175, 40);
            BSalir.TabIndex = 10;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = true;
            // 
            // BGestionTematica
            // 
            BGestionTematica.AutoSize = true;
            BGestionTematica.FlatAppearance.BorderSize = 0;
            BGestionTematica.FlatStyle = FlatStyle.Flat;
            BGestionTematica.Font = new Font("Segoe UI", 10F);
            BGestionTematica.Location = new Point(33, 299);
            BGestionTematica.Name = "BGestionTematica";
            BGestionTematica.Size = new Size(193, 40);
            BGestionTematica.TabIndex = 8;
            BGestionTematica.Text = "Organizacion Tematica";
            BGestionTematica.UseVisualStyleBackColor = true;
            // 
            // BDashboard
            // 
            BDashboard.FlatAppearance.BorderSize = 0;
            BDashboard.FlatStyle = FlatStyle.Flat;
            BDashboard.Font = new Font("Segoe UI", 10F);
            BDashboard.ForeColor = SystemColors.ActiveCaptionText;
            BDashboard.Location = new Point(33, 29);
            BDashboard.Name = "BDashboard";
            BDashboard.Size = new Size(176, 40);
            BDashboard.TabIndex = 7;
            BDashboard.Text = "Dashboard";
            BDashboard.UseVisualStyleBackColor = true;
            // 
            // BInformes
            // 
            BInformes.FlatAppearance.BorderSize = 0;
            BInformes.FlatStyle = FlatStyle.Flat;
            BInformes.Font = new Font("Segoe UI", 10F);
            BInformes.Location = new Point(34, 390);
            BInformes.Name = "BInformes";
            BInformes.Size = new Size(175, 40);
            BInformes.TabIndex = 5;
            BInformes.Text = "Informes";
            BInformes.UseVisualStyleBackColor = true;
            // 
            // BUsuarios
            // 
            BUsuarios.FlatAppearance.BorderSize = 0;
            BUsuarios.FlatStyle = FlatStyle.Flat;
            BUsuarios.Font = new Font("Segoe UI", 10F);
            BUsuarios.Location = new Point(33, 210);
            BUsuarios.Name = "BUsuarios";
            BUsuarios.Size = new Size(176, 40);
            BUsuarios.TabIndex = 1;
            BUsuarios.Text = "Usuarios";
            BUsuarios.UseVisualStyleBackColor = true;
            // 
            // BBackUp
            // 
            BBackUp.FlatAppearance.BorderSize = 0;
            BBackUp.FlatStyle = FlatStyle.Flat;
            BBackUp.Font = new Font("Segoe UI", 10F);
            BBackUp.Location = new Point(33, 118);
            BBackUp.Name = "BBackUp";
            BBackUp.Size = new Size(176, 40);
            BBackUp.TabIndex = 0;
            BBackUp.Text = "Back Up";
            BBackUp.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(244, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(694, 778);
            panelMain.TabIndex = 1;
            // 
            // BLogin
            // 
            BLogin.FlatAppearance.BorderSize = 0;
            BLogin.FlatStyle = FlatStyle.Flat;
            BLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BLogin.Location = new Point(33, 549);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(175, 40);
            BLogin.TabIndex = 11;
            BLogin.Text = "Login";
            BLogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 778);
            Controls.Add(panelMain);
            Controls.Add(sideBar);
            Name = "Form1";
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
        private Button BLogin;
    }
}
