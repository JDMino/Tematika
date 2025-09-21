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
            cmbTemas = new ComboBox();
            cmbAsignaturas = new ComboBox();
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
            panelMainResources.Margin = new Padding(3, 4, 3, 4);
            panelMainResources.Name = "panelMainResources";
            panelMainResources.Size = new Size(914, 600);
            panelMainResources.TabIndex = 0;
            // 
            // flpRecursos
            // 
            flpRecursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpRecursos.AutoScroll = true;
            flpRecursos.BackColor = Color.Transparent;
            flpRecursos.Location = new Point(0, 117);
            flpRecursos.Margin = new Padding(3, 4, 3, 4);
            flpRecursos.Name = "flpRecursos";
            flpRecursos.Size = new Size(914, 483);
            flpRecursos.TabIndex = 4;
            // 
            // cmbTemas
            // 
            cmbTemas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbTemas.FormattingEnabled = true;
            cmbTemas.Location = new Point(155, 52);
            cmbTemas.Margin = new Padding(3, 4, 3, 4);
            cmbTemas.Name = "cmbTemas";
            cmbTemas.Size = new Size(709, 28);
            cmbTemas.TabIndex = 3;
            // 
            // cmbAsignaturas
            // 
            cmbAsignaturas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbAsignaturas.FormattingEnabled = true;
            cmbAsignaturas.Location = new Point(155, 12);
            cmbAsignaturas.Margin = new Padding(3, 4, 3, 4);
            cmbAsignaturas.Name = "cmbAsignaturas";
            cmbAsignaturas.Size = new Size(709, 28);
            cmbAsignaturas.TabIndex = 2;
            // 
            // labelTema
            // 
            labelTema.AutoSize = true;
            labelTema.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTema.Location = new Point(50, 45);
            labelTema.Name = "labelTema";
            labelTema.Size = new Size(81, 32);
            labelTema.TabIndex = 1;
            labelTema.Text = "Tema:";
            // 
            // labelAsignatura
            // 
            labelAsignatura.AutoSize = true;
            labelAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAsignatura.Location = new Point(3, 12);
            labelAsignatura.Name = "labelAsignatura";
            labelAsignatura.Size = new Size(146, 32);
            labelAsignatura.TabIndex = 0;
            labelAsignatura.Text = "Asignatura:";
            // 
            // panelFiltroRecursos
            // 
            panelFiltroRecursos.BackColor = Color.Silver;
            panelFiltroRecursos.Controls.Add(cmbTemas);
            panelFiltroRecursos.Controls.Add(cmbAsignaturas);
            panelFiltroRecursos.Controls.Add(labelTema);
            panelFiltroRecursos.Controls.Add(labelAsignatura);
            panelFiltroRecursos.Dock = DockStyle.Top;
            panelFiltroRecursos.Location = new Point(0, 0);
            panelFiltroRecursos.Margin = new Padding(3, 4, 3, 4);
            panelFiltroRecursos.Name = "panelFiltroRecursos";
            panelFiltroRecursos.Size = new Size(914, 120);
            panelFiltroRecursos.TabIndex = 1;
            // 
            // FormExploreResourcesEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(panelFiltroRecursos);
            Controls.Add(panelMainResources);
            Margin = new Padding(3, 4, 3, 4);
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
        private ComboBox cmbTemas;
        private ComboBox cmbAsignaturas;
        private Panel panelFiltroRecursos;
    }
}