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
            panelMainLogin.Name = "panelMainLogin";
            panelMainLogin.Size = new Size(800, 450);
            panelMainLogin.TabIndex = 0;
            // 
            // panelBotones
            // 
            panelBotones.ColumnCount = 1;
            panelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelBotones.Controls.Add(BIniciarSesion, 0, 0);
            panelBotones.Controls.Add(BInvitado, 0, 1);
            panelBotones.Location = new Point(256, 318);
            panelBotones.Name = "panelBotones";
            panelBotones.RowCount = 2;
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 44.5322647F));
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 55.4677353F));
            panelBotones.Size = new Size(250, 95);
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
            BIniciarSesion.Location = new Point(54, 3);
            BIniciarSesion.Name = "BIniciarSesion";
            BIniciarSesion.Size = new Size(142, 36);
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
            BInvitado.Location = new Point(28, 54);
            BInvitado.Name = "BInvitado";
            BInvitado.Size = new Size(193, 29);
            BInvitado.TabIndex = 1;
            BInvitado.Text = "Ingresar como Invitado";
            BInvitado.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.ColumnCount = 1;
            panelLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            panelLogo.Controls.Add(LTitulo, 0, 1);
            panelLogo.Controls.Add(label1, 0, 0);
            panelLogo.Location = new Point(253, 12);
            panelLogo.Name = "panelLogo";
            panelLogo.RowCount = 2;
            panelLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelLogo.Size = new Size(250, 112);
            panelLogo.TabIndex = 1;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Dock = DockStyle.Fill;
            LTitulo.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTitulo.ForeColor = SystemColors.ButtonHighlight;
            LTitulo.Location = new Point(3, 56);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(244, 56);
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
            label1.Size = new Size(244, 56);
            label1.TabIndex = 1;
            label1.Text = "Tematika";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCampos
            // 
            panelCampos.BackColor = Color.Transparent;
            panelCampos.BackgroundImageLayout = ImageLayout.Stretch;
            panelCampos.ColumnCount = 3;
            panelCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            panelCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.05495F));
            panelCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.94505F));
            panelCampos.Controls.Add(LUsuario, 1, 0);
            panelCampos.Controls.Add(LContraseña, 1, 1);
            panelCampos.Controls.Add(TBUsuario, 2, 0);
            panelCampos.Controls.Add(TBContraseña, 2, 1);
            panelCampos.Controls.Add(pictureBoxUsuario, 0, 0);
            panelCampos.Controls.Add(pictureBoxContraseña, 0, 1);
            panelCampos.Location = new Point(200, 172);
            panelCampos.Name = "panelCampos";
            panelCampos.RowCount = 2;
            panelCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelCampos.Size = new Size(360, 125);
            panelCampos.TabIndex = 0;
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.ForeColor = SystemColors.ButtonHighlight;
            LUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            LUsuario.Location = new Point(43, 0);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(59, 20);
            LUsuario.TabIndex = 0;
            LUsuario.Text = "Usuario";
            LUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.ForeColor = SystemColors.ButtonHighlight;
            LContraseña.Location = new Point(43, 62);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(83, 20);
            LContraseña.TabIndex = 1;
            LContraseña.Text = "Contraseña";
            // 
            // TBUsuario
            // 
            TBUsuario.Location = new Point(187, 3);
            TBUsuario.Name = "TBUsuario";
            TBUsuario.Size = new Size(152, 27);
            TBUsuario.TabIndex = 2;
            // 
            // TBContraseña
            // 
            TBContraseña.Location = new Point(187, 65);
            TBContraseña.Name = "TBContraseña";
            TBContraseña.Size = new Size(152, 27);
            TBContraseña.TabIndex = 3;
            TBContraseña.UseSystemPasswordChar = true;
            // 
            // pictureBoxUsuario
            // 
            pictureBoxUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxUsuario.Image = (Image)resources.GetObject("pictureBoxUsuario.Image");
            pictureBoxUsuario.Location = new Point(3, 3);
            pictureBoxUsuario.Name = "pictureBoxUsuario";
            pictureBoxUsuario.Size = new Size(34, 56);
            pictureBoxUsuario.TabIndex = 4;
            pictureBoxUsuario.TabStop = false;
            // 
            // pictureBoxContraseña
            // 
            pictureBoxContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxContraseña.Image = (Image)resources.GetObject("pictureBoxContraseña.Image");
            pictureBoxContraseña.Location = new Point(3, 65);
            pictureBoxContraseña.Name = "pictureBoxContraseña";
            pictureBoxContraseña.Size = new Size(34, 57);
            pictureBoxContraseña.TabIndex = 5;
            pictureBoxContraseña.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMainLogin);
            Name = "FormLogin";
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