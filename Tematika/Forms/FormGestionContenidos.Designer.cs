namespace Tematika.Forms
{
    partial class FormGestionContenidos
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
            panelGestionContenidos = new Panel();
            btnPreguntas = new Button();
            btnRecursos = new Button();
            btnTema = new Button();
            btnMaterias = new Button();
            panelGestionContenidos.SuspendLayout();
            SuspendLayout();
            // 
            // panelGestionContenidos
            // 
            panelGestionContenidos.BackColor = SystemColors.ActiveBorder;
            panelGestionContenidos.Controls.Add(btnPreguntas);
            panelGestionContenidos.Controls.Add(btnRecursos);
            panelGestionContenidos.Controls.Add(btnTema);
            panelGestionContenidos.Controls.Add(btnMaterias);
            panelGestionContenidos.Dock = DockStyle.Fill;
            panelGestionContenidos.Location = new Point(0, 0);
            panelGestionContenidos.Name = "panelGestionContenidos";
            panelGestionContenidos.Size = new Size(800, 450);
            panelGestionContenidos.TabIndex = 0;
            // 
            // btnPreguntas
            // 
            btnPreguntas.Location = new Point(374, 259);
            btnPreguntas.Name = "btnPreguntas";
            btnPreguntas.Size = new Size(178, 98);
            btnPreguntas.TabIndex = 3;
            btnPreguntas.Text = "Preguntas de Evaluación";
            btnPreguntas.UseVisualStyleBackColor = true;
            btnPreguntas.Click += btnPreguntas_Click;
            // 
            // btnRecursos
            // 
            btnRecursos.Location = new Point(102, 259);
            btnRecursos.Name = "btnRecursos";
            btnRecursos.Size = new Size(178, 98);
            btnRecursos.TabIndex = 2;
            btnRecursos.Text = "Recursos";
            btnRecursos.UseVisualStyleBackColor = true;
            btnRecursos.Click += btnRecursos_Click;
            // 
            // btnTema
            // 
            btnTema.Location = new Point(374, 83);
            btnTema.Name = "btnTema";
            btnTema.Size = new Size(178, 98);
            btnTema.TabIndex = 1;
            btnTema.Text = "Temas";
            btnTema.UseVisualStyleBackColor = true;
            btnTema.Click += btnTema_Click;
            // 
            // btnMaterias
            // 
            btnMaterias.Location = new Point(102, 83);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(178, 98);
            btnMaterias.TabIndex = 0;
            btnMaterias.Text = "Materias";
            btnMaterias.UseVisualStyleBackColor = true;
            btnMaterias.Click += btnMaterias_Click;
            // 
            // FormGestionContenidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelGestionContenidos);
            Name = "FormGestionContenidos";
            Text = "FormGestionContenidos";
            panelGestionContenidos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGestionContenidos;
        private Button btnPreguntas;
        private Button btnRecursos;
        private Button btnTema;
        private Button btnMaterias;
    }
}