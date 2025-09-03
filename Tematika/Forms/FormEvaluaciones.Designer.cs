namespace Tematika.Forms
{
    partial class FormEvaluaciones
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
            panel1 = new Panel();
            CBMateria = new ComboBox();
            LMateria = new Label();
            TBBuscadorPreg = new TextBox();
            DGVPreguntas = new DataGridView();
            IDPreg = new DataGridViewTextBoxColumn();
            EnunciadoPreg = new DataGridViewTextBoxColumn();
            TemaPreg = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            BEliminarPreg = new Button();
            BModificarPreg = new Button();
            BCancelar = new Button();
            BGuardarPreg = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            LOpcion3 = new Label();
            LOpcion2 = new Label();
            LOpcion1 = new Label();
            LOpcionCorrecta = new Label();
            CBTemas = new ComboBox();
            LTemasPreg = new Label();
            LEnunciado = new Label();
            LPregunta = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVPreguntas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(CBMateria);
            panel1.Controls.Add(LMateria);
            panel1.Controls.Add(TBBuscadorPreg);
            panel1.Controls.Add(DGVPreguntas);
            panel1.Controls.Add(BEliminarPreg);
            panel1.Controls.Add(BModificarPreg);
            panel1.Controls.Add(BCancelar);
            panel1.Controls.Add(BGuardarPreg);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(LOpcion3);
            panel1.Controls.Add(LOpcion2);
            panel1.Controls.Add(LOpcion1);
            panel1.Controls.Add(LOpcionCorrecta);
            panel1.Controls.Add(CBTemas);
            panel1.Controls.Add(LTemasPreg);
            panel1.Controls.Add(LEnunciado);
            panel1.Controls.Add(LPregunta);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // CBMateria
            // 
            CBMateria.FormattingEnabled = true;
            CBMateria.Location = new Point(148, 225);
            CBMateria.Name = "CBMateria";
            CBMateria.Size = new Size(151, 28);
            CBMateria.TabIndex = 21;
            // 
            // LMateria
            // 
            LMateria.AutoSize = true;
            LMateria.Location = new Point(81, 233);
            LMateria.Name = "LMateria";
            LMateria.Size = new Size(60, 20);
            LMateria.TabIndex = 20;
            LMateria.Text = "Materia";
            // 
            // TBBuscadorPreg
            // 
            TBBuscadorPreg.Location = new Point(111, 320);
            TBBuscadorPreg.Name = "TBBuscadorPreg";
            TBBuscadorPreg.Size = new Size(125, 27);
            TBBuscadorPreg.TabIndex = 19;
            // 
            // DGVPreguntas
            // 
            DGVPreguntas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVPreguntas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVPreguntas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPreguntas.Columns.AddRange(new DataGridViewColumn[] { IDPreg, EnunciadoPreg, TemaPreg, Materia });
            DGVPreguntas.Location = new Point(111, 353);
            DGVPreguntas.Name = "DGVPreguntas";
            DGVPreguntas.RowHeadersWidth = 51;
            DGVPreguntas.Size = new Size(539, 94);
            DGVPreguntas.TabIndex = 18;
            DGVPreguntas.CellClick += DGVPreguntas_CellClick;
            DGVPreguntas.CellContentClick += DGVPreguntas_CellContentClick;
            // 
            // IDPreg
            // 
            IDPreg.HeaderText = "ID";
            IDPreg.MinimumWidth = 6;
            IDPreg.Name = "IDPreg";
            // 
            // EnunciadoPreg
            // 
            EnunciadoPreg.HeaderText = "Enunciado";
            EnunciadoPreg.MinimumWidth = 6;
            EnunciadoPreg.Name = "EnunciadoPreg";
            // 
            // TemaPreg
            // 
            TemaPreg.HeaderText = "Tema";
            TemaPreg.MinimumWidth = 6;
            TemaPreg.Name = "TemaPreg";
            // 
            // Materia
            // 
            Materia.HeaderText = "Materia";
            Materia.MinimumWidth = 6;
            Materia.Name = "Materia";
            // 
            // BEliminarPreg
            // 
            BEliminarPreg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BEliminarPreg.Location = new Point(603, 299);
            BEliminarPreg.Name = "BEliminarPreg";
            BEliminarPreg.Size = new Size(94, 29);
            BEliminarPreg.TabIndex = 17;
            BEliminarPreg.Text = "Eliminar";
            BEliminarPreg.UseVisualStyleBackColor = true;
            // 
            // BModificarPreg
            // 
            BModificarPreg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BModificarPreg.Location = new Point(481, 299);
            BModificarPreg.Name = "BModificarPreg";
            BModificarPreg.Size = new Size(94, 29);
            BModificarPreg.TabIndex = 16;
            BModificarPreg.Text = "Modificar";
            BModificarPreg.UseVisualStyleBackColor = true;
            // 
            // BCancelar
            // 
            BCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCancelar.Location = new Point(603, 264);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(94, 29);
            BCancelar.TabIndex = 15;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = true;
            // 
            // BGuardarPreg
            // 
            BGuardarPreg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BGuardarPreg.Location = new Point(481, 264);
            BGuardarPreg.Name = "BGuardarPreg";
            BGuardarPreg.Size = new Size(94, 29);
            BGuardarPreg.TabIndex = 14;
            BGuardarPreg.Text = "Guardar";
            BGuardarPreg.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(269, 109);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(153, 46);
            textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(584, 225);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(584, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(584, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(584, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            // 
            // LOpcion3
            // 
            LOpcion3.AutoSize = true;
            LOpcion3.Location = new Point(440, 213);
            LOpcion3.Name = "LOpcion3";
            LOpcion3.Size = new Size(69, 20);
            LOpcion3.TabIndex = 8;
            LOpcion3.Text = "Opcion 3";
            // 
            // LOpcion2
            // 
            LOpcion2.AutoSize = true;
            LOpcion2.Location = new Point(440, 181);
            LOpcion2.Name = "LOpcion2";
            LOpcion2.Size = new Size(69, 20);
            LOpcion2.TabIndex = 7;
            LOpcion2.Text = "Opcion 2";
            // 
            // LOpcion1
            // 
            LOpcion1.AutoSize = true;
            LOpcion1.Location = new Point(440, 149);
            LOpcion1.Name = "LOpcion1";
            LOpcion1.Size = new Size(69, 20);
            LOpcion1.TabIndex = 6;
            LOpcion1.Text = "Opcion 1";
            // 
            // LOpcionCorrecta
            // 
            LOpcionCorrecta.AutoSize = true;
            LOpcionCorrecta.Location = new Point(440, 115);
            LOpcionCorrecta.Name = "LOpcionCorrecta";
            LOpcionCorrecta.Size = new Size(117, 20);
            LOpcionCorrecta.TabIndex = 5;
            LOpcionCorrecta.Text = "Opcion Correcta";
            // 
            // CBTemas
            // 
            CBTemas.FormattingEnabled = true;
            CBTemas.Location = new Point(148, 183);
            CBTemas.Name = "CBTemas";
            CBTemas.Size = new Size(151, 28);
            CBTemas.TabIndex = 4;
            // 
            // LTemasPreg
            // 
            LTemasPreg.AutoSize = true;
            LTemasPreg.Location = new Point(81, 191);
            LTemasPreg.Name = "LTemasPreg";
            LTemasPreg.Size = new Size(45, 20);
            LTemasPreg.TabIndex = 3;
            LTemasPreg.Text = "Tema";
            // 
            // LEnunciado
            // 
            LEnunciado.AutoSize = true;
            LEnunciado.Location = new Point(80, 116);
            LEnunciado.Name = "LEnunciado";
            LEnunciado.Size = new Size(178, 20);
            LEnunciado.TabIndex = 2;
            LEnunciado.Text = "Enunciado de la Pregunta";
            // 
            // LPregunta
            // 
            LPregunta.AutoSize = true;
            LPregunta.Location = new Point(80, 71);
            LPregunta.Name = "LPregunta";
            LPregunta.Size = new Size(114, 20);
            LPregunta.TabIndex = 1;
            LPregunta.Text = "Nueva Pregunta";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 49);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 9);
            label1.Name = "label1";
            label1.Size = new Size(485, 38);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Preguntas de Evaluacion";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormEvaluaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormEvaluaciones";
            Text = "FormEvaluaciones";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVPreguntas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private ComboBox CBTemas;
        private Label LTemasPreg;
        private Label LEnunciado;
        private Label LPregunta;
        private Button BGuardarPreg;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label LOpcion3;
        private Label LOpcion2;
        private Label LOpcion1;
        private Label LOpcionCorrecta;
        private TextBox TBBuscadorPreg;
        private DataGridView DGVPreguntas;
        private DataGridViewTextBoxColumn IDPreg;
        private DataGridViewTextBoxColumn EnunciadoPreg;
        private DataGridViewTextBoxColumn TemaPreg;
        private Button BEliminarPreg;
        private Button BModificarPreg;
        private Button BCancelar;
        private ComboBox CBMateria;
        private Label LMateria;
        private DataGridViewTextBoxColumn Materia;
    }
}