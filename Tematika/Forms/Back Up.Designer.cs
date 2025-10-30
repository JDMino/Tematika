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
            panelMain = new Panel();
            BBackUp = new Button();
            BRuta = new Button();
            BConectar = new Button();
            CBBackUp = new ComboBox();
            textBox2 = new TextBox();
            LBackUp2 = new Label();
            LBackUp1 = new Label();
            panelEncabezado = new Panel();
            LTituloBackUp = new Label();
            panelMain.SuspendLayout();
            panelEncabezado.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.BackColor = SystemColors.ActiveCaption;
            panelMain.Controls.Add(BBackUp);
            panelMain.Controls.Add(BRuta);
            panelMain.Controls.Add(BConectar);
            panelMain.Controls.Add(CBBackUp);
            panelMain.Controls.Add(textBox2);
            panelMain.Controls.Add(LBackUp2);
            panelMain.Controls.Add(LBackUp1);
            panelMain.Controls.Add(panelEncabezado);
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(700, 338);
            panelMain.TabIndex = 0;
            // 
            // BBackUp
            // 
            BBackUp.BackColor = SystemColors.Highlight;
            BBackUp.FlatAppearance.BorderSize = 0;
            BBackUp.FlatStyle = FlatStyle.Flat;
            BBackUp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BBackUp.ForeColor = SystemColors.ButtonHighlight;
            BBackUp.Location = new Point(525, 199);
            BBackUp.Margin = new Padding(3, 2, 3, 2);
            BBackUp.Name = "BBackUp";
            BBackUp.Size = new Size(82, 22);
            BBackUp.TabIndex = 8;
            BBackUp.Text = "Back Up";
            BBackUp.UseVisualStyleBackColor = false;
            // 
            // BRuta
            // 
            BRuta.BackColor = Color.Gray;
            BRuta.FlatAppearance.BorderSize = 0;
            BRuta.FlatStyle = FlatStyle.Flat;
            BRuta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BRuta.ForeColor = SystemColors.ButtonHighlight;
            BRuta.Location = new Point(525, 130);
            BRuta.Margin = new Padding(3, 2, 3, 2);
            BRuta.Name = "BRuta";
            BRuta.Size = new Size(82, 22);
            BRuta.TabIndex = 7;
            BRuta.Text = "Ruta";
            BRuta.UseVisualStyleBackColor = false;
            // 
            // BConectar
            // 
            BConectar.BackColor = Color.ForestGreen;
            BConectar.FlatAppearance.BorderSize = 0;
            BConectar.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 125, 50);
            BConectar.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 160, 71);
            BConectar.FlatStyle = FlatStyle.Flat;
            BConectar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BConectar.ForeColor = SystemColors.ButtonHighlight;
            BConectar.Location = new Point(525, 95);
            BConectar.Margin = new Padding(3, 2, 3, 2);
            BConectar.Name = "BConectar";
            BConectar.Size = new Size(82, 22);
            BConectar.TabIndex = 6;
            BConectar.Text = "Conectar";
            BConectar.UseVisualStyleBackColor = false;
            // 
            // CBBackUp
            // 
            CBBackUp.DropDownStyle = ComboBoxStyle.DropDownList;
            CBBackUp.FormattingEnabled = true;
            CBBackUp.Location = new Point(239, 93);
            CBBackUp.Margin = new Padding(3, 2, 3, 2);
            CBBackUp.Name = "CBBackUp";
            CBBackUp.Size = new Size(243, 23);
            CBBackUp.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(239, 130);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 23);
            textBox2.TabIndex = 4;
            // 
            // LBackUp2
            // 
            LBackUp2.AutoSize = true;
            LBackUp2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBackUp2.Location = new Point(102, 133);
            LBackUp2.Name = "LBackUp2";
            LBackUp2.Size = new Size(91, 19);
            LBackUp2.TabIndex = 2;
            LBackUp2.Text = "Ruta Guardar";
            // 
            // LBackUp1
            // 
            LBackUp1.AutoSize = true;
            LBackUp1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBackUp1.Location = new Point(102, 95);
            LBackUp1.Name = "LBackUp1";
            LBackUp1.Size = new Size(94, 19);
            LBackUp1.TabIndex = 1;
            LBackUp1.Text = "Base de datos";
            // 
            // panelEncabezado
            // 
            panelEncabezado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelEncabezado.BackColor = SystemColors.ButtonFace;
            panelEncabezado.Controls.Add(LTituloBackUp);
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Margin = new Padding(3, 2, 3, 2);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(700, 47);
            panelEncabezado.TabIndex = 0;
            // 
            // LTituloBackUp
            // 
            LTituloBackUp.AutoSize = true;
            LTituloBackUp.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloBackUp.Location = new Point(10, 7);
            LTituloBackUp.Name = "LTituloBackUp";
            LTituloBackUp.Size = new Size(98, 30);
            LTituloBackUp.TabIndex = 0;
            LTituloBackUp.Text = "Back Up";
            LTituloBackUp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Back_Up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panelMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Back_Up";
            Text = "Back_Up";
            WindowState = FormWindowState.Maximized;
            Load += Back_Up_Load;
            LocationChanged += Back_Up_LocationChanged;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Button BBackUp;
        private Button BRuta;
        private Button BConectar;
        private ComboBox CBBackUp;
        private TextBox textBox2;
        private Label LBackUp2;
        private Label LBackUp1;
        private Panel panelEncabezado;
        private Label LTituloBackUp;
    }
}