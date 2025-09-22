namespace Tematika.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panelMainLogin = new Panel();
            panelBotones = new TableLayoutPanel();
            BIniciarSesion = new Button();
            BInvitado = new Button();
            panelLogo = new TableLayoutPanel();
            LTitulo = new Label();
            label1 = new Label();
            panelCampos = new TableLayoutPanel();
            LUsuario = new Label();
            LContraseña = new Label();
            TBUsuario = new TextBox();
            TBContraseña = new TextBox();
            pictureBoxUsuario = new PictureBox();
            pictureBoxContraseña = new PictureBox();
            panelMainLogin.SuspendLayout();
            panelBotones.SuspendLayout();
            panelLogo.SuspendLayout();
            panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxContraseña).BeginInit();
            SuspendLayout();
            // 
            // panelMainLogin
            // 
            panelMainLogin.BackColor = SystemColors.ActiveCaption;
            panelMainLogin.Controls.Add(panelBotones);
            panelMainLogin.Controls.Add(panelLogo);
            panelMainLogin.Controls.Add(panelCampos);
            panelMainLogin.Dock = DockStyle.Fill;
            panelMainLogin.Location = new Point(0, 0);
            panelMainLogin.Margin = new Padding(3, 2, 3, 2);
            panelMainLogin.Name = "panelMainLogin";
            panelMainLogin.Size = new Size(700, 338);
            panelMainLogin.TabIndex = 0;
            // 
            // panelBotones
            // 
            panelBotones.ColumnCount = 1;
            panelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelBotones.Controls.Add(BIniciarSesion, 0, 0);
            panelBotones.Controls.Add(BInvitado, 0, 1);
            panelBotones.Location = new Point(224, 238);
            panelBotones.Margin = new Padding(3, 2, 3, 2);
            panelBotones.Name = "panelBotones";
            panelBotones.RowCount = 2;
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 44.5322647F));
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 55.4677353F));
            panelBotones.Size = new Size(219, 71);
            panelBotones.TabIndex = 2;
            // 
            // BIniciarSesion
            // 
            BIniciarSesion.Anchor = AnchorStyles.None;
            BIniciarSesion.AutoSize = true;
            BIniciarSesion.FlatAppearance.BorderSize = 0;
            BIniciarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            BIniciarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            BIniciarSesion.FlatStyle = FlatStyle.Flat;
            BIniciarSesion.Image = (Image)resources.GetObject("BIniciarSesion.Image");
            BIniciarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            BIniciarSesion.Location = new Point(47, 2);
            BIniciarSesion.Margin = new Padding(3, 2, 3, 2);
            BIniciarSesion.Name = "BIniciarSesion";
            BIniciarSesion.Size = new Size(124, 27);
            BIniciarSesion.TabIndex = 0;
            BIniciarSesion.Text = "Iniciar sesion";
            BIniciarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            BIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // BInvitado
            // 
            BInvitado.Anchor = AnchorStyles.None;
            BInvitado.AutoEllipsis = true;
            BInvitado.FlatAppearance.BorderSize = 0;
            BInvitado.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            BInvitado.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            BInvitado.FlatStyle = FlatStyle.Flat;
            BInvitado.Location = new Point(25, 40);
            BInvitado.Margin = new Padding(3, 2, 3, 2);
            BInvitado.Name = "BInvitado";
            BInvitado.Size = new Size(169, 22);
            BInvitado.TabIndex = 1;
            BInvitado.Text = "Ingresar como Invitado";
            BInvitado.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.ColumnCount = 1;
            panelLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            panelLogo.Controls.Add(LTitulo, 0, 1);
            panelLogo.Controls.Add(label1, 0, 0);
            panelLogo.Location = new Point(221, 9);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.RowCount = 2;
            panelLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelLogo.Size = new Size(219, 84);
            panelLogo.TabIndex = 1;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Dock = DockStyle.Fill;
            LTitulo.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTitulo.ForeColor = SystemColors.ButtonHighlight;
            LTitulo.Location = new Point(3, 42);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(213, 42);
            LTitulo.TabIndex = 0;
            LTitulo.Text = "Sistema academico";
            LTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 42);
            label1.TabIndex = 1;
            label1.Text = "Tematika";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCampos
            // 
            panelCampos.BackColor = Color.Transparent;
            panelCampos.BackgroundImageLayout = ImageLayout.Stretch;
            panelCampos.ColumnCount = 3;
            panelCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            panelCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.05495F));
            panelCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.94505F));
            panelCampos.Controls.Add(LUsuario, 1, 0);
            panelCampos.Controls.Add(LContraseña, 1, 1);
            panelCampos.Controls.Add(TBUsuario, 2, 0);
            panelCampos.Controls.Add(TBContraseña, 2, 1);
            panelCampos.Controls.Add(pictureBoxUsuario, 0, 0);
            panelCampos.Controls.Add(pictureBoxContraseña, 0, 1);
            panelCampos.Location = new Point(175, 129);
            panelCampos.Margin = new Padding(3, 2, 3, 2);
            panelCampos.Name = "panelCampos";
            panelCampos.RowCount = 2;
            panelCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelCampos.Size = new Size(315, 94);
            panelCampos.TabIndex = 0;
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.ForeColor = SystemColors.ButtonHighlight;
            LUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            LUsuario.Location = new Point(38, 0);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(47, 15);
            LUsuario.TabIndex = 0;
            LUsuario.Text = "Usuario";
            LUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.ForeColor = SystemColors.ButtonHighlight;
            LContraseña.Location = new Point(38, 47);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(67, 15);
            LContraseña.TabIndex = 1;
            LContraseña.Text = "Contraseña";
            // 
            // TBUsuario
            // 
            TBUsuario.Location = new Point(164, 2);
            TBUsuario.Margin = new Padding(3, 2, 3, 2);
            TBUsuario.Name = "TBUsuario";
            TBUsuario.Size = new Size(134, 23);
            TBUsuario.TabIndex = 2;
            // 
            // TBContraseña
            // 
            TBContraseña.Location = new Point(164, 49);
            TBContraseña.Margin = new Padding(3, 2, 3, 2);
            TBContraseña.Name = "TBContraseña";
            TBContraseña.Size = new Size(134, 23);
            TBContraseña.TabIndex = 3;
            TBContraseña.UseSystemPasswordChar = true;
            // 
            // pictureBoxUsuario
            // 
            pictureBoxUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxUsuario.Image = (Image)resources.GetObject("pictureBoxUsuario.Image");
            pictureBoxUsuario.Location = new Point(3, 2);
            pictureBoxUsuario.Margin = new Padding(3, 2, 3, 2);
            pictureBoxUsuario.Name = "pictureBoxUsuario";
            pictureBoxUsuario.Size = new Size(29, 42);
            pictureBoxUsuario.TabIndex = 4;
            pictureBoxUsuario.TabStop = false;
            // 
            // pictureBoxContraseña
            // 
            pictureBoxContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxContraseña.Image = (Image)resources.GetObject("pictureBoxContraseña.Image");
            pictureBoxContraseña.Location = new Point(3, 49);
            pictureBoxContraseña.Margin = new Padding(3, 2, 3, 2);
            pictureBoxContraseña.Name = "pictureBoxContraseña";
            pictureBoxContraseña.Size = new Size(29, 43);
            pictureBoxContraseña.TabIndex = 5;
            pictureBoxContraseña.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panelMainLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FormLogin_Load;
            panelMainLogin.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            panelBotones.PerformLayout();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelCampos.ResumeLayout(false);
            panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxContraseña).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMainLogin;
        private TableLayoutPanel panelCampos;
        private TableLayoutPanel panelLogo;
        private Label LTitulo;
        private Label LUsuario;
        private Label LContraseña;
        private TextBox TBUsuario;
        private TextBox TBContraseña;
        private TableLayoutPanel panelBotones;
        private Button BIniciarSesion;
        private Button BInvitado;
        private PictureBox pictureBoxUsuario;
        private PictureBox pictureBoxContraseña;
        private Label label1;
    }
}