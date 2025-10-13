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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            panelTituloVisualizador.BackColor = Color.RoyalBlue;
            panelTituloVisualizador.Controls.Add(labelTituloVRecurso);
            panelTituloVisualizador.Dock = DockStyle.Top;
            panelTituloVisualizador.Location = new Point(0, 0);
            panelTituloVisualizador.Margin = new Padding(3, 4, 3, 4);
            panelTituloVisualizador.Name = "panelTituloVisualizador";
            panelTituloVisualizador.Size = new Size(1104, 52);
            panelTituloVisualizador.TabIndex = 0;
            // 
            // labelTituloVRecurso
            // 
            labelTituloVRecurso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTituloVRecurso.AutoSize = true;
            labelTituloVRecurso.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloVRecurso.Location = new Point(493, 12);
            labelTituloVRecurso.Name = "labelTituloVRecurso";
            labelTituloVRecurso.Size = new Size(179, 32);
            labelTituloVRecurso.TabIndex = 6;
            labelTituloVRecurso.Text = "Titulo Recurso";
            labelTituloVRecurso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMarcarFavorito
            // 
            btnMarcarFavorito.Location = new Point(23, 72);
            btnMarcarFavorito.Margin = new Padding(3, 4, 3, 4);
            btnMarcarFavorito.Name = "btnMarcarFavorito";
            btnMarcarFavorito.Size = new Size(158, 31);
            btnMarcarFavorito.TabIndex = 1;
            btnMarcarFavorito.Text = "Marcar como Favorito";
            btnMarcarFavorito.UseVisualStyleBackColor = true;
            // 
            // labelValoracion
            // 
            labelValoracion.AutoSize = true;
            labelValoracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValoracion.Location = new Point(209, 77);
            labelValoracion.Name = "labelValoracion";
            labelValoracion.Size = new Size(86, 20);
            labelValoracion.TabIndex = 2;
            labelValoracion.Text = "Valoración:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox1.Location = new Point(303, 72);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(44, 28);
            comboBox1.TabIndex = 3;
            // 
            // panelContenidoRecurso
            // 
            panelContenidoRecurso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelContenidoRecurso.AutoScroll = true;
            panelContenidoRecurso.BackColor = SystemColors.ActiveCaption;
            panelContenidoRecurso.Location = new Point(0, 111);
            panelContenidoRecurso.Margin = new Padding(3, 4, 3, 4);
            panelContenidoRecurso.Name = "panelContenidoRecurso";
            panelContenidoRecurso.Size = new Size(1045, 357);
            panelContenidoRecurso.TabIndex = 4;
            // 
            // labelNotaRecurso
            // 
            labelNotaRecurso.AutoSize = true;
            labelNotaRecurso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNotaRecurso.Location = new Point(23, 487);
            labelNotaRecurso.Name = "labelNotaRecurso";
            labelNotaRecurso.Size = new Size(126, 20);
            labelNotaRecurso.TabIndex = 11;
            labelNotaRecurso.Text = "Mi Nota Privada:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(23, 511);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(1008, 59);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(23, 651);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(1008, 59);
            textBox2.TabIndex = 14;
            // 
            // labelComentarioRecurso
            // 
            labelComentarioRecurso.AutoSize = true;
            labelComentarioRecurso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelComentarioRecurso.Location = new Point(23, 627);
            labelComentarioRecurso.Name = "labelComentarioRecurso";
            labelComentarioRecurso.Size = new Size(102, 20);
            labelComentarioRecurso.TabIndex = 13;
            labelComentarioRecurso.Text = "Comentarios:";
            // 
            // btnGuardarNota
            // 
            btnGuardarNota.Location = new Point(23, 579);
            btnGuardarNota.Margin = new Padding(3, 4, 3, 4);
            btnGuardarNota.Name = "btnGuardarNota";
            btnGuardarNota.Size = new Size(112, 31);
            btnGuardarNota.TabIndex = 15;
            btnGuardarNota.Text = "Guardar Nota";
            btnGuardarNota.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(23, 719);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(130, 31);
            button1.TabIndex = 16;
            button1.Text = "Enviar Comentario";
            button1.UseVisualStyleBackColor = true;
            // 
            // DGVComentariosRecursos
            // 
            DGVComentariosRecursos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGVComentariosRecursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVComentariosRecursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVComentariosRecursos.Columns.AddRange(new DataGridViewColumn[] { FechaComentarioRecurso, NombreComentarioRecurso, Comentario });
            DGVComentariosRecursos.Location = new Point(23, 757);
            DGVComentariosRecursos.Margin = new Padding(3, 4, 3, 4);
            DGVComentariosRecursos.Name = "DGVComentariosRecursos";
            DGVComentariosRecursos.RowHeadersWidth = 51;
            DGVComentariosRecursos.Size = new Size(1009, 159);
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
            btnGuardarValoracion.Location = new Point(371, 72);
            btnGuardarValoracion.Margin = new Padding(3, 4, 3, 4);
            btnGuardarValoracion.Name = "btnGuardarValoracion";
            btnGuardarValoracion.Size = new Size(131, 31);
            btnGuardarValoracion.TabIndex = 18;
            btnGuardarValoracion.Text = "Guardar Valoración";
            btnGuardarValoracion.UseVisualStyleBackColor = true;
            // 
            // FormVisualizadorRecurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1125, 748);
            Controls.Add(btnGuardarValoracion);
            Controls.Add(DGVComentariosRecursos);
            Controls.Add(button1);
            Controls.Add(btnGuardarNota);
            Controls.Add(textBox2);
            Controls.Add(labelComentarioRecurso);
            Controls.Add(textBox1);
            Controls.Add(labelNotaRecurso);
            Controls.Add(panelContenidoRecurso);
            Controls.Add(comboBox1);
            Controls.Add(labelValoracion);
            Controls.Add(btnMarcarFavorito);
            Controls.Add(panelTituloVisualizador);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnMarcarFavorito;
        private Label labelValoracion;
        private ComboBox comboBox1;
        private Panel panelContenidoRecurso;
        private Label labelNotaRecurso;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelComentarioRecurso;
        private Button btnGuardarNota;
        private Button button1;
        private DataGridView DGVComentariosRecursos;
        private DataGridViewTextBoxColumn FechaComentarioRecurso;
        private DataGridViewTextBoxColumn NombreComentarioRecurso;
        private DataGridViewTextBoxColumn Comentario;
        private Button btnGuardarValoracion;
    }
}