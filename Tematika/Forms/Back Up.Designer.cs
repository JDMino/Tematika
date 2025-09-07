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
            BConecatr = new Button();
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
            panelMain.Controls.Add(BConecatr);
            panelMain.Controls.Add(CBBackUp);
            panelMain.Controls.Add(textBox2);
            panelMain.Controls.Add(LBackUp2);
            panelMain.Controls.Add(LBackUp1);
            panelMain.Controls.Add(panelEncabezado);
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 450);
            panelMain.TabIndex = 0;
            // 
            // BBackUp
            // 
            BBackUp.BackColor = SystemColors.Highlight;
            BBackUp.FlatAppearance.BorderSize = 0;
            BBackUp.FlatStyle = FlatStyle.Flat;
            BBackUp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BBackUp.ForeColor = SystemColors.ButtonHighlight;
            BBackUp.Location = new Point(600, 265);
            BBackUp.Name = "BBackUp";
            BBackUp.Size = new Size(94, 29);
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
            BRuta.Location = new Point(600, 173);
            BRuta.Name = "BRuta";
            BRuta.Size = new Size(94, 29);
            BRuta.TabIndex = 7;
            BRuta.Text = "Ruta";
            BRuta.UseVisualStyleBackColor = false;
            // 
            // BConecatr
            // 
            BConecatr.BackColor = Color.ForestGreen;
            BConecatr.FlatAppearance.BorderSize = 0;
            BConecatr.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 125, 50);
            BConecatr.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 160, 71);
            BConecatr.FlatStyle = FlatStyle.Flat;
            BConecatr.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            BConecatr.ForeColor = SystemColors.ButtonHighlight;
            BConecatr.Location = new Point(600, 127);
            BConecatr.Name = "BConecatr";
            BConecatr.Size = new Size(94, 29);
            BConecatr.TabIndex = 6;
            BConecatr.Text = "Conectar";
            BConecatr.UseVisualStyleBackColor = false;
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
            LBackUp2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBackUp2.Location = new Point(117, 177);
            LBackUp2.Name = "LBackUp2";
            LBackUp2.Size = new Size(112, 23);
            LBackUp2.TabIndex = 2;
            LBackUp2.Text = "Ruta Guardar";
            // 
            // LBackUp1
            // 
            LBackUp1.AutoSize = true;
            LBackUp1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBackUp1.Location = new Point(117, 127);
            LBackUp1.Name = "LBackUp1";
            LBackUp1.Size = new Size(116, 23);
            LBackUp1.TabIndex = 1;
            LBackUp1.Text = "Base de datos";
            // 
            // panelEncabezado
            // 
            panelEncabezado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelEncabezado.BackColor = SystemColors.ButtonFace;
            panelEncabezado.Controls.Add(LTituloBackUp);
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(800, 63);
            panelEncabezado.TabIndex = 0;
            // 
            // LTituloBackUp
            // 
            LTituloBackUp.AutoSize = true;
            LTituloBackUp.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloBackUp.Location = new Point(12, 9);
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
            Controls.Add(panelMain);
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
        private Button BConecatr;
        private ComboBox CBBackUp;
        private TextBox textBox2;
        private Label LBackUp2;
        private Label LBackUp1;
        private Panel panelEncabezado;
        private Label LTituloBackUp;
    }
}