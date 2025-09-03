namespace Tematika.Forms
{
    partial class Back_Up
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
            BBackUp = new Button();
            BRuta = new Button();
            BConecatr = new Button();
            CBBackUp = new ComboBox();
            textBox2 = new TextBox();
            LBackUp2 = new Label();
            LBackUp1 = new Label();
            PBackUp = new Panel();
            LTituloBackUp = new Label();
            panel1.SuspendLayout();
            PBackUp.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(BBackUp);
            panel1.Controls.Add(BRuta);
            panel1.Controls.Add(BConecatr);
            panel1.Controls.Add(CBBackUp);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(LBackUp2);
            panel1.Controls.Add(LBackUp1);
            panel1.Controls.Add(PBackUp);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // BBackUp
            // 
            BBackUp.Location = new Point(600, 265);
            BBackUp.Name = "BBackUp";
            BBackUp.Size = new Size(94, 29);
            BBackUp.TabIndex = 8;
            BBackUp.Text = "Back Up";
            BBackUp.UseVisualStyleBackColor = true;
            // 
            // BRuta
            // 
            BRuta.Location = new Point(600, 173);
            BRuta.Name = "BRuta";
            BRuta.Size = new Size(94, 29);
            BRuta.TabIndex = 7;
            BRuta.Text = "Ruta";
            BRuta.UseVisualStyleBackColor = true;
            // 
            // BConecatr
            // 
            BConecatr.Location = new Point(600, 127);
            BConecatr.Name = "BConecatr";
            BConecatr.Size = new Size(94, 29);
            BConecatr.TabIndex = 6;
            BConecatr.Text = "Conectar";
            BConecatr.UseVisualStyleBackColor = true;
            // 
            // CBBackUp
            // 
            CBBackUp.FormattingEnabled = true;
            CBBackUp.Location = new Point(273, 124);
            CBBackUp.Name = "CBBackUp";
            CBBackUp.Size = new Size(277, 28);
            CBBackUp.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(273, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 27);
            textBox2.TabIndex = 4;
            // 
            // LBackUp2
            // 
            LBackUp2.AutoSize = true;
            LBackUp2.Location = new Point(117, 177);
            LBackUp2.Name = "LBackUp2";
            LBackUp2.Size = new Size(96, 20);
            LBackUp2.TabIndex = 2;
            LBackUp2.Text = "Ruta Guardar";
            // 
            // LBackUp1
            // 
            LBackUp1.AutoSize = true;
            LBackUp1.Location = new Point(117, 127);
            LBackUp1.Name = "LBackUp1";
            LBackUp1.Size = new Size(102, 20);
            LBackUp1.TabIndex = 1;
            LBackUp1.Text = "Base de datos";
            // 
            // PBackUp
            // 
            PBackUp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PBackUp.BackColor = SystemColors.ButtonFace;
            PBackUp.Controls.Add(LTituloBackUp);
            PBackUp.Location = new Point(0, 0);
            PBackUp.Name = "PBackUp";
            PBackUp.Size = new Size(800, 47);
            PBackUp.TabIndex = 0;
            // 
            // LTituloBackUp
            // 
            LTituloBackUp.AutoSize = true;
            LTituloBackUp.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloBackUp.Location = new Point(409, 0);
            LTituloBackUp.Name = "LTituloBackUp";
            LTituloBackUp.Size = new Size(124, 38);
            LTituloBackUp.TabIndex = 0;
            LTituloBackUp.Text = "Back Up";
            LTituloBackUp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Back_Up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Back_Up";
            Text = "Back_Up";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PBackUp.ResumeLayout(false);
            PBackUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BBackUp;
        private Button BRuta;
        private Button BConecatr;
        private ComboBox CBBackUp;
        private TextBox textBox2;
        private Label LBackUp2;
        private Label LBackUp1;
        private Panel PBackUp;
        private Label LTituloBackUp;
    }
}