namespace Tematika.Forms
{
    partial class FormVisualizadorRecurso
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
            panelTituloVisualizador = new Panel();
            labelTituloVRecurso = new Label();
            btnMarcarFavorito = new Button();
            labelValoracion = new Label();
            comboBox1 = new ComboBox();
            panelContenidoRecurso = new Panel();
            labelNotaRecurso = new Label();
            TBNota = new TextBox();
            TBComentario = new TextBox();
            labelComentarioRecurso = new Label();
            btnGuardarNota = new Button();
            button1 = new Button();
            DGVComentariosRecursos = new DataGridView();
            FechaComentarioRecurso = new DataGridViewTextBoxColumn();
            NombreComentarioRecurso = new DataGridViewTextBoxColumn();
            Comentario = new DataGridViewTextBoxColumn();
            btnGuardarValoracion = new Button();
            panelTituloVisualizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVComentariosRecursos).BeginInit();
            SuspendLayout();
            // 
            // panelTituloVisualizador
            // 
            panelTituloVisualizador.BackColor = SystemColors.ActiveCaption;
            panelTituloVisualizador.Controls.Add(labelTituloVRecurso);
            panelTituloVisualizador.Dock = DockStyle.Top;
            panelTituloVisualizador.Location = new Point(0, 0);
            panelTituloVisualizador.Name = "panelTituloVisualizador";
            panelTituloVisualizador.Size = new Size(967, 39);
            panelTituloVisualizador.TabIndex = 0;
            // 
            // labelTituloVRecurso
            // 
            labelTituloVRecurso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTituloVRecurso.AutoSize = true;
            labelTituloVRecurso.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloVRecurso.Location = new Point(431, 9);
            labelTituloVRecurso.Name = "labelTituloVRecurso";
            labelTituloVRecurso.Size = new Size(140, 25);
            labelTituloVRecurso.TabIndex = 6;
            labelTituloVRecurso.Text = "Titulo Recurso";
            labelTituloVRecurso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMarcarFavorito
            // 
            btnMarcarFavorito.BackColor = Color.Orange;
            btnMarcarFavorito.FlatAppearance.BorderSize = 0;
            btnMarcarFavorito.FlatStyle = FlatStyle.Flat;
            btnMarcarFavorito.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMarcarFavorito.ForeColor = SystemColors.ButtonHighlight;
            btnMarcarFavorito.Location = new Point(20, 54);
            btnMarcarFavorito.Name = "btnMarcarFavorito";
            btnMarcarFavorito.Size = new Size(174, 23);
            btnMarcarFavorito.TabIndex = 1;
            btnMarcarFavorito.Text = "Marcar como Favorito";
            btnMarcarFavorito.UseVisualStyleBackColor = false;
            // 
            // labelValoracion
            // 
            labelValoracion.AutoSize = true;
            labelValoracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValoracion.Location = new Point(200, 58);
            labelValoracion.Name = "labelValoracion";
            labelValoracion.Size = new Size(67, 15);
            labelValoracion.TabIndex = 2;
            labelValoracion.Text = "Valoración:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox1.Location = new Point(282, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(39, 23);
            comboBox1.TabIndex = 3;
            // 
            // panelContenidoRecurso
            // 
            panelContenidoRecurso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelContenidoRecurso.AutoScroll = true;
            panelContenidoRecurso.BackColor = SystemColors.ActiveBorder;
            panelContenidoRecurso.Location = new Point(20, 83);
            panelContenidoRecurso.Name = "panelContenidoRecurso";
            panelContenidoRecurso.Size = new Size(790, 268);
            panelContenidoRecurso.TabIndex = 4;
            // 
            // labelNotaRecurso
            // 
            labelNotaRecurso.AutoSize = true;
            labelNotaRecurso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNotaRecurso.Location = new Point(20, 365);
            labelNotaRecurso.Name = "labelNotaRecurso";
            labelNotaRecurso.Size = new Size(98, 15);
            labelNotaRecurso.TabIndex = 11;
            labelNotaRecurso.Text = "Mi Nota Privada:";
            // 
            // TBNota
            // 
            TBNota.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TBNota.Location = new Point(20, 383);
            TBNota.Multiline = true;
            TBNota.Name = "TBNota";
            TBNota.ScrollBars = ScrollBars.Vertical;
            TBNota.Size = new Size(758, 45);
            TBNota.TabIndex = 12;
            // 
            // TBComentario
            // 
            TBComentario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TBComentario.Location = new Point(20, 488);
            TBComentario.Multiline = true;
            TBComentario.Name = "TBComentario";
            TBComentario.ScrollBars = ScrollBars.Vertical;
            TBComentario.Size = new Size(758, 45);
            TBComentario.TabIndex = 14;
            // 
            // labelComentarioRecurso
            // 
            labelComentarioRecurso.AutoSize = true;
            labelComentarioRecurso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelComentarioRecurso.Location = new Point(20, 470);
            labelComentarioRecurso.Name = "labelComentarioRecurso";
            labelComentarioRecurso.Size = new Size(80, 15);
            labelComentarioRecurso.TabIndex = 13;
            labelComentarioRecurso.Text = "Comentarios:";
            // 
            // btnGuardarNota
            // 
            btnGuardarNota.BackColor = Color.ForestGreen;
            btnGuardarNota.FlatAppearance.BorderSize = 0;
            btnGuardarNota.FlatStyle = FlatStyle.Flat;
            btnGuardarNota.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarNota.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarNota.Location = new Point(20, 434);
            btnGuardarNota.Name = "btnGuardarNota";
            btnGuardarNota.Size = new Size(98, 23);
            btnGuardarNota.TabIndex = 15;
            btnGuardarNota.Text = "Guardar Nota";
            btnGuardarNota.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(20, 539);
            button1.Name = "button1";
            button1.Size = new Size(130, 22);
            button1.TabIndex = 16;
            button1.Text = "Enviar Comentario";
            button1.UseVisualStyleBackColor = false;
            // 
            // DGVComentariosRecursos
            // 
            DGVComentariosRecursos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGVComentariosRecursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVComentariosRecursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVComentariosRecursos.Columns.AddRange(new DataGridViewColumn[] { FechaComentarioRecurso, NombreComentarioRecurso, Comentario });
            DGVComentariosRecursos.Location = new Point(20, 568);
            DGVComentariosRecursos.Name = "DGVComentariosRecursos";
            DGVComentariosRecursos.RowHeadersWidth = 51;
            DGVComentariosRecursos.Size = new Size(758, 119);
            DGVComentariosRecursos.TabIndex = 17;
            // 
            // FechaComentarioRecurso
            // 
            FechaComentarioRecurso.FillWeight = 50F;
            FechaComentarioRecurso.HeaderText = "Fecha";
            FechaComentarioRecurso.MinimumWidth = 6;
            FechaComentarioRecurso.Name = "FechaComentarioRecurso";
            FechaComentarioRecurso.ReadOnly = true;
            // 
            // NombreComentarioRecurso
            // 
            NombreComentarioRecurso.HeaderText = "Nombre";
            NombreComentarioRecurso.MinimumWidth = 6;
            NombreComentarioRecurso.Name = "NombreComentarioRecurso";
            NombreComentarioRecurso.ReadOnly = true;
            // 
            // Comentario
            // 
            Comentario.FillWeight = 150F;
            Comentario.HeaderText = "Comentario";
            Comentario.MinimumWidth = 6;
            Comentario.Name = "Comentario";
            Comentario.ReadOnly = true;
            // 
            // btnGuardarValoracion
            // 
            btnGuardarValoracion.BackColor = Color.ForestGreen;
            btnGuardarValoracion.FlatAppearance.BorderSize = 0;
            btnGuardarValoracion.FlatStyle = FlatStyle.Flat;
            btnGuardarValoracion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarValoracion.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarValoracion.Location = new Point(341, 54);
            btnGuardarValoracion.Name = "btnGuardarValoracion";
            btnGuardarValoracion.Size = new Size(144, 23);
            btnGuardarValoracion.TabIndex = 18;
            btnGuardarValoracion.Text = "Guardar Valoración";
            btnGuardarValoracion.UseVisualStyleBackColor = false;
            // 
            // FormVisualizadorRecurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(984, 561);
            Controls.Add(btnGuardarValoracion);
            Controls.Add(DGVComentariosRecursos);
            Controls.Add(button1);
            Controls.Add(btnGuardarNota);
            Controls.Add(TBComentario);
            Controls.Add(labelComentarioRecurso);
            Controls.Add(TBNota);
            Controls.Add(labelNotaRecurso);
            Controls.Add(panelContenidoRecurso);
            Controls.Add(comboBox1);
            Controls.Add(labelValoracion);
            Controls.Add(btnMarcarFavorito);
            Controls.Add(panelTituloVisualizador);
            Name = "FormVisualizadorRecurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVisualizadorRecurso";
            panelTituloVisualizador.ResumeLayout(false);
            panelTituloVisualizador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVComentariosRecursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTituloVisualizador;
        private Label labelTituloVRecurso;
        public Button btnMarcarFavorito;
        private Label labelValoracion;
        public ComboBox comboBox1;
        private Panel panelContenidoRecurso;
        private Label labelNotaRecurso;
        private TextBox TBNota;
        private TextBox TBComentario;
        private Label labelComentarioRecurso;
        public Button btnGuardarNota;
        public Button button1;
        private DataGridView DGVComentariosRecursos;
        private DataGridViewTextBoxColumn FechaComentarioRecurso;
        private DataGridViewTextBoxColumn NombreComentarioRecurso;
        private DataGridViewTextBoxColumn Comentario;
        public Button btnGuardarValoracion;
    }
}