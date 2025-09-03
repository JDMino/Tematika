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
            BDashboard = new Button();
            BEvaluaciones = new Button();
            BInformes = new Button();
            BTemas = new Button();
            BRecursos = new Button();
            BMaterias = new Button();
            BUsuarios = new Button();
            BBackUp = new Button();
            panelMain = new Panel();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.Controls.Add(BDashboard);
            sideBar.Controls.Add(BEvaluaciones);
            sideBar.Controls.Add(BInformes);
            sideBar.Controls.Add(BTemas);
            sideBar.Controls.Add(BRecursos);
            sideBar.Controls.Add(BMaterias);
            sideBar.Controls.Add(BUsuarios);
            sideBar.Controls.Add(BBackUp);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(250, 778);
            sideBar.TabIndex = 0;
            // 
            // BDashboard
            // 
            BDashboard.Location = new Point(50, 29);
            BDashboard.Name = "BDashboard";
            BDashboard.Size = new Size(121, 40);
            BDashboard.TabIndex = 7;
            BDashboard.Text = "Dashboard";
            BDashboard.UseVisualStyleBackColor = true;
            // 
            // BEvaluaciones
            // 
            BEvaluaciones.Location = new Point(50, 537);
            BEvaluaciones.Name = "BEvaluaciones";
            BEvaluaciones.Size = new Size(121, 40);
            BEvaluaciones.TabIndex = 6;
            BEvaluaciones.Text = "Evaluaciones";
            BEvaluaciones.UseVisualStyleBackColor = true;
            // 
            // BInformes
            // 
            BInformes.Location = new Point(50, 627);
            BInformes.Name = "BInformes";
            BInformes.Size = new Size(121, 40);
            BInformes.TabIndex = 5;
            BInformes.Text = "Informes";
            BInformes.UseVisualStyleBackColor = true;
            // 
            // BTemas
            // 
            BTemas.Location = new Point(50, 445);
            BTemas.Name = "BTemas";
            BTemas.Size = new Size(121, 40);
            BTemas.TabIndex = 4;
            BTemas.Text = "Temas";
            BTemas.UseVisualStyleBackColor = true;
            // 
            // BRecursos
            // 
            BRecursos.Location = new Point(50, 361);
            BRecursos.Name = "BRecursos";
            BRecursos.Size = new Size(121, 40);
            BRecursos.TabIndex = 3;
            BRecursos.Text = "Recursos";
            BRecursos.UseVisualStyleBackColor = true;
            // 
            // BMaterias
            // 
            BMaterias.Location = new Point(50, 280);
            BMaterias.Name = "BMaterias";
            BMaterias.Size = new Size(121, 40);
            BMaterias.TabIndex = 2;
            BMaterias.Text = "Materias";
            BMaterias.UseVisualStyleBackColor = true;
            // 
            // BUsuarios
            // 
            BUsuarios.Location = new Point(50, 199);
            BUsuarios.Name = "BUsuarios";
            BUsuarios.Size = new Size(121, 40);
            BUsuarios.TabIndex = 1;
            BUsuarios.Text = "Usuarios";
            BUsuarios.UseVisualStyleBackColor = true;
            // 
            // BBackUp
            // 
            BBackUp.Location = new Point(50, 118);
            BBackUp.Name = "BBackUp";
            BBackUp.Size = new Size(121, 40);
            BBackUp.TabIndex = 0;
            BBackUp.Text = "Back Up";
            BBackUp.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(688, 778);
            panelMain.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel sideBar;
        private Panel panelMain;
        private Button BBackUp;
        private Button BInformes;
        private Button BTemas;
        private Button BRecursos;
        private Button BMaterias;
        private Button BUsuarios;
        private Button BEvaluaciones;
        private Button BDashboard;
    }
}
