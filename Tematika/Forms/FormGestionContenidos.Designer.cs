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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionContenidos));
            panelGestionContenidos = new Panel();
            TLPContenido = new TableLayoutPanel();
            btnMaterias = new Button();
            btnPreguntas = new Button();
            btnTema = new Button();
            btnRecursos = new Button();
            btnAsignacionDocente = new Button();
            panelGestionContenidos.SuspendLayout();
            TLPContenido.SuspendLayout();
            SuspendLayout();
            // 
            // panelGestionContenidos
            // 
            panelGestionContenidos.BackColor = SystemColors.ActiveBorder;
            panelGestionContenidos.Controls.Add(TLPContenido);
            panelGestionContenidos.Dock = DockStyle.Fill;
            panelGestionContenidos.Location = new Point(0, 0);
            panelGestionContenidos.Margin = new Padding(3, 4, 3, 4);
            panelGestionContenidos.Name = "panelGestionContenidos";
            panelGestionContenidos.Size = new Size(914, 600);
            panelGestionContenidos.TabIndex = 0;
            // 
            // TLPContenido
            // 
            TLPContenido.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TLPContenido.ColumnCount = 2;
            TLPContenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TLPContenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TLPContenido.Controls.Add(btnMaterias, 0, 0);
            TLPContenido.Controls.Add(btnPreguntas, 1, 1);
            TLPContenido.Controls.Add(btnTema, 1, 0);
            TLPContenido.Controls.Add(btnRecursos, 0, 1);
            TLPContenido.Controls.Add(btnAsignacionDocente, 0, 2);
            TLPContenido.Location = new Point(85, 76);
            TLPContenido.Name = "TLPContenido";
            TLPContenido.RowCount = 3;
            TLPContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLPContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLPContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TLPContenido.Size = new Size(701, 433);
            TLPContenido.TabIndex = 4;
            // 
            // btnMaterias
            // 
            btnMaterias.BackColor = Color.DarkGray;
            btnMaterias.Dock = DockStyle.Fill;
            btnMaterias.FlatAppearance.BorderSize = 0;
            btnMaterias.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnMaterias.FlatStyle = FlatStyle.Flat;
            btnMaterias.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaterias.ForeColor = SystemColors.ButtonHighlight;
            btnMaterias.Image = (Image)resources.GetObject("btnMaterias.Image");
            btnMaterias.Location = new Point(5, 4);
            btnMaterias.Margin = new Padding(5, 4, 5, 4);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Padding = new Padding(2, 3, 2, 3);
            btnMaterias.Size = new Size(340, 136);
            btnMaterias.TabIndex = 0;
            btnMaterias.Text = "Materias";
            btnMaterias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMaterias.UseVisualStyleBackColor = false;
            btnMaterias.Click += btnMaterias_Click;
            // 
            // btnPreguntas
            // 
            btnPreguntas.BackColor = Color.DarkGray;
            btnPreguntas.Dock = DockStyle.Fill;
            btnPreguntas.FlatAppearance.BorderSize = 0;
            btnPreguntas.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnPreguntas.FlatStyle = FlatStyle.Flat;
            btnPreguntas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPreguntas.ForeColor = SystemColors.ButtonHighlight;
            btnPreguntas.Image = (Image)resources.GetObject("btnPreguntas.Image");
            btnPreguntas.Location = new Point(355, 148);
            btnPreguntas.Margin = new Padding(5, 4, 5, 4);
            btnPreguntas.Name = "btnPreguntas";
            btnPreguntas.Padding = new Padding(2, 3, 2, 3);
            btnPreguntas.Size = new Size(341, 136);
            btnPreguntas.TabIndex = 3;
            btnPreguntas.Text = "Preguntas de Evaluación";
            btnPreguntas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPreguntas.UseVisualStyleBackColor = false;
            btnPreguntas.Click += btnPreguntas_Click;
            // 
            // btnTema
            // 
            btnTema.BackColor = Color.DarkGray;
            btnTema.Dock = DockStyle.Fill;
            btnTema.FlatAppearance.BorderSize = 0;
            btnTema.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnTema.FlatStyle = FlatStyle.Flat;
            btnTema.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTema.ForeColor = SystemColors.ButtonHighlight;
            btnTema.Image = (Image)resources.GetObject("btnTema.Image");
            btnTema.Location = new Point(355, 4);
            btnTema.Margin = new Padding(5, 4, 5, 4);
            btnTema.Name = "btnTema";
            btnTema.Padding = new Padding(2, 3, 2, 3);
            btnTema.Size = new Size(341, 136);
            btnTema.TabIndex = 1;
            btnTema.Text = "Temas";
            btnTema.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTema.UseVisualStyleBackColor = false;
            btnTema.Click += btnTema_Click;
            // 
            // btnRecursos
            // 
            btnRecursos.BackColor = Color.DarkGray;
            btnRecursos.Dock = DockStyle.Fill;
            btnRecursos.FlatAppearance.BorderSize = 0;
            btnRecursos.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnRecursos.FlatStyle = FlatStyle.Flat;
            btnRecursos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecursos.ForeColor = SystemColors.ButtonHighlight;
            btnRecursos.Image = (Image)resources.GetObject("btnRecursos.Image");
            btnRecursos.Location = new Point(5, 148);
            btnRecursos.Margin = new Padding(5, 4, 5, 4);
            btnRecursos.Name = "btnRecursos";
            btnRecursos.Padding = new Padding(2, 3, 2, 3);
            btnRecursos.Size = new Size(340, 136);
            btnRecursos.TabIndex = 2;
            btnRecursos.Text = "Recursos";
            btnRecursos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRecursos.UseVisualStyleBackColor = false;
            btnRecursos.Click += btnRecursos_Click;
            // 
            // btnAsignacionDocente
            // 
            btnAsignacionDocente.BackColor = Color.DarkGray;
            btnAsignacionDocente.Dock = DockStyle.Fill;
            btnAsignacionDocente.FlatAppearance.BorderSize = 0;
            btnAsignacionDocente.FlatStyle = FlatStyle.Flat;
            btnAsignacionDocente.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsignacionDocente.ForeColor = SystemColors.ButtonHighlight;
            btnAsignacionDocente.Image = (Image)resources.GetObject("btnAsignacionDocente.Image");
            btnAsignacionDocente.Location = new Point(3, 292);
            btnAsignacionDocente.Margin = new Padding(3, 4, 3, 4);
            btnAsignacionDocente.Name = "btnAsignacionDocente";
            btnAsignacionDocente.Size = new Size(344, 137);
            btnAsignacionDocente.TabIndex = 4;
            btnAsignacionDocente.Text = "Asignación\r\nDocente - Materias";
            btnAsignacionDocente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAsignacionDocente.UseVisualStyleBackColor = false;
            btnAsignacionDocente.Click += btnAsignacionDocente_Click;
            // 
            // FormGestionContenidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelGestionContenidos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionContenidos";
            Text = "FormGestionContenidos";
            Load += FormGestionContenidos_Load;
            panelGestionContenidos.ResumeLayout(false);
            TLPContenido.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGestionContenidos;
        private Button btnPreguntas;
        private Button btnRecursos;
        private Button btnTema;
        private Button btnMaterias;
        private TableLayoutPanel TLPContenido;
        private Button btnAsignacionDocente;
    }
}