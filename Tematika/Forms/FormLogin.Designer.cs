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
            panelMainLogin = new Panel();
            panelBotones = new TableLayoutPanel();
            BIniciarSesion = new Button();
            BInvitado = new Button();
            panelLogo = new TableLayoutPanel();
            LTitulo = new Label();
            panelCampos = new TableLayoutPanel();
            LUsuario = new Label();
            LContraseña = new Label();
            TBUsuario = new TextBox();
            TBContraseña = new TextBox();
            panelMainLogin.SuspendLayout();
            panelBotones.SuspendLayout();
            panelLogo.SuspendLayout();
            panelCampos.SuspendLayout();
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
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 42.8571434F));
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 57.1428566F));
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
            BIniciarSesion.Location = new Point(54, 4);
            BIniciarSesion.Name = "BIniciarSesion";
            BIniciarSesion.Size = new Size(142, 32);
            BIniciarSesion.TabIndex = 0;
            BIniciarSesion.Text = "Iniciar sesion";
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
            BInvitado.Location = new Point(28, 53);
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
            LTitulo.Text = "Tematika - Sistema academico";
            LTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCampos
            // 
            panelCampos.BackColor = Color.Transparent;
            panelCampos.ColumnCount = 2;
            panelCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.0549469F));
            panelCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.9450531F));
            panelCampos.Controls.Add(LUsuario, 0, 0);
            panelCampos.Controls.Add(LContraseña, 0, 1);
            panelCampos.Controls.Add(TBUsuario, 1, 0);
            panelCampos.Controls.Add(TBContraseña, 1, 1);
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
            LUsuario.Location = new Point(3, 0);
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
            LContraseña.Location = new Point(3, 62);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(83, 20);
            LContraseña.TabIndex = 1;
            LContraseña.Text = "Contraseña";
            // 
            // TBUsuario
            // 
            TBUsuario.Location = new Point(165, 3);
            TBUsuario.Name = "TBUsuario";
            TBUsuario.Size = new Size(152, 27);
            TBUsuario.TabIndex = 2;
            // 
            // TBContraseña
            // 
            TBContraseña.Location = new Point(165, 65);
            TBContraseña.Name = "TBContraseña";
            TBContraseña.Size = new Size(152, 27);
            TBContraseña.TabIndex = 3;
            TBContraseña.UseSystemPasswordChar = true;
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
    }
}