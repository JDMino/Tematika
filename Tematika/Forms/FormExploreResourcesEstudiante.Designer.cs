namespace Tematika.Forms
{
    partial class FormExploreResourcesEstudiante
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
            panelMainResources = new Panel();
            flpRecursos = new FlowLayoutPanel();
            CBTema = new ComboBox();
            CBMateria = new ComboBox();
            labelTema = new Label();
            labelAsignatura = new Label();
            panelFiltroRecursos = new Panel();
            panelMainResources.SuspendLayout();
            panelFiltroRecursos.SuspendLayout();
            SuspendLayout();
            // 
            // panelMainResources
            // 
            panelMainResources.BackColor = Color.Transparent;
            panelMainResources.Controls.Add(flpRecursos);
            panelMainResources.Dock = DockStyle.Fill;
            panelMainResources.Location = new Point(0, 0);
            panelMainResources.Name = "panelMainResources";
            panelMainResources.Size = new Size(800, 450);
            panelMainResources.TabIndex = 0;
            // 
            // flpRecursos
            // 
            flpRecursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpRecursos.AutoScroll = true;
            flpRecursos.BackColor = Color.Transparent;
            flpRecursos.Location = new Point(0, 88);
            flpRecursos.Name = "flpRecursos";
            flpRecursos.Size = new Size(800, 362);
            flpRecursos.TabIndex = 4;
            // 
            // CBTema
            // 
            CBTema.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CBTema.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTema.FormattingEnabled = true;
            CBTema.Location = new Point(136, 39);
            CBTema.Name = "CBTema";
            CBTema.Size = new Size(621, 23);
            CBTema.TabIndex = 3;
            // 
            // CBMateria
            // 
            CBMateria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CBMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            CBMateria.FormattingEnabled = true;
            CBMateria.Location = new Point(136, 9);
            CBMateria.Name = "CBMateria";
            CBMateria.Size = new Size(621, 23);
            CBMateria.TabIndex = 2;
            // 
            // labelTema
            // 
            labelTema.AutoSize = true;
            labelTema.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTema.Location = new Point(66, 34);
            labelTema.Name = "labelTema";
            labelTema.Size = new Size(63, 25);
            labelTema.TabIndex = 1;
            labelTema.Text = "Tema:";
            // 
            // labelAsignatura
            // 
            labelAsignatura.AutoSize = true;
            labelAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAsignatura.Location = new Point(44, 9);
            labelAsignatura.Name = "labelAsignatura";
            labelAsignatura.Size = new Size(85, 25);
            labelAsignatura.TabIndex = 0;
            labelAsignatura.Text = "Materia:";
            // 
            // panelFiltroRecursos
            // 
            panelFiltroRecursos.BackColor = Color.Silver;
            panelFiltroRecursos.Controls.Add(CBTema);
            panelFiltroRecursos.Controls.Add(CBMateria);
            panelFiltroRecursos.Controls.Add(labelTema);
            panelFiltroRecursos.Controls.Add(labelAsignatura);
            panelFiltroRecursos.Dock = DockStyle.Top;
            panelFiltroRecursos.Location = new Point(0, 0);
            panelFiltroRecursos.Name = "panelFiltroRecursos";
            panelFiltroRecursos.Size = new Size(800, 90);
            panelFiltroRecursos.TabIndex = 1;
            // 
            // FormExploreResourcesEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFiltroRecursos);
            Controls.Add(panelMainResources);
            Name = "FormExploreResourcesEstudiante";
            Text = "FormExploreResourcesEstudiante";
            Load += FormExploreResourcesEstudiante_Load;
            panelMainResources.ResumeLayout(false);
            panelFiltroRecursos.ResumeLayout(false);
            panelFiltroRecursos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMainResources;
        private Label labelAsignatura;
        private Label labelTema;
        private FlowLayoutPanel flpRecursos;
        private ComboBox CBTema;
        private ComboBox CBMateria;
        private Panel panelFiltroRecursos;
    }
}