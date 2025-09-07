namespace Tematika.Forms
{
    partial class FormGestionUsuarios
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
            panelEncabezado = new Panel();
            LTituloUsuarios = new Label();
            panelMain = new Panel();
            panelCamposUsuarios = new TableLayoutPanel();
            LNombre = new Label();
            TBNombreUsuario = new TextBox();
            LApellido = new Label();
            LUsuario = new Label();
            RBHombre = new RadioButton();
            CBPerfil = new ComboBox();
            RBMujer = new RadioButton();
            LContraseña = new Label();
            DTPFechaNac = new DateTimePicker();
            LEmail = new Label();
            TBTelefonoUsuario = new TextBox();
            LPerfil = new Label();
            TBDireccionUsuario = new TextBox();
            TBApellidoUsuario = new TextBox();
            TBDNIUsuario = new TextBox();
            TBUsuario = new TextBox();
            LSexo = new Label();
            TBContraseñaUsuario = new TextBox();
            LFechaNac = new Label();
            TBEmailUsuario = new TextBox();
            LTelefono = new Label();
            LDNI = new Label();
            LDireccion = new Label();
            panelBuscador = new TableLayoutPanel();
            TBBuscadorUsuarios = new TextBox();
            BUActivos = new Button();
            BUInactivos = new Button();
            panelBotones = new TableLayoutPanel();
            BGuardar = new Button();
            BCancelar = new Button();
            BUEliminar = new Button();
            BUModificar = new Button();
            DGVUsuarios = new DataGridView();
            idUsuario = new DataGridViewTextBoxColumn();
            idPerfil = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            FechadeNacimiento = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            panelEncabezado.SuspendLayout();
            panelMain.SuspendLayout();
            panelCamposUsuarios.SuspendLayout();
            panelBuscador.SuspendLayout();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panelEncabezado
            // 
            panelEncabezado.Controls.Add(LTituloUsuarios);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(884, 83);
            panelEncabezado.TabIndex = 0;
            // 
            // LTituloUsuarios
            // 
            LTituloUsuarios.AutoSize = true;
            LTituloUsuarios.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloUsuarios.Location = new Point(3, 30);
            LTituloUsuarios.Name = "LTituloUsuarios";
            LTituloUsuarios.Size = new Size(277, 38);
            LTituloUsuarios.TabIndex = 1;
            LTituloUsuarios.Text = "Gestion de Usuarios";
            LTituloUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.ActiveCaption;
            panelMain.Controls.Add(panelCamposUsuarios);
            panelMain.Controls.Add(panelBuscador);
            panelMain.Controls.Add(panelBotones);
            panelMain.Controls.Add(DGVUsuarios);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 83);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(884, 475);
            panelMain.TabIndex = 1;
            // 
            // panelCamposUsuarios
            // 
            panelCamposUsuarios.ColumnCount = 5;
            panelCamposUsuarios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.78649F));
            panelCamposUsuarios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.7864933F));
            panelCamposUsuarios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.7472858F));
            panelCamposUsuarios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.6797371F));
            panelCamposUsuarios.ColumnStyles.Add(new ColumnStyle());
            panelCamposUsuarios.Controls.Add(LNombre, 0, 0);
            panelCamposUsuarios.Controls.Add(TBNombreUsuario, 1, 0);
            panelCamposUsuarios.Controls.Add(LApellido, 0, 1);
            panelCamposUsuarios.Controls.Add(LUsuario, 0, 2);
            panelCamposUsuarios.Controls.Add(RBHombre, 4, 4);
            panelCamposUsuarios.Controls.Add(CBPerfil, 1, 5);
            panelCamposUsuarios.Controls.Add(RBMujer, 3, 4);
            panelCamposUsuarios.Controls.Add(LContraseña, 0, 3);
            panelCamposUsuarios.Controls.Add(DTPFechaNac, 3, 3);
            panelCamposUsuarios.Controls.Add(LEmail, 0, 4);
            panelCamposUsuarios.Controls.Add(TBTelefonoUsuario, 3, 2);
            panelCamposUsuarios.Controls.Add(LPerfil, 0, 5);
            panelCamposUsuarios.Controls.Add(TBDireccionUsuario, 3, 1);
            panelCamposUsuarios.Controls.Add(TBApellidoUsuario, 1, 1);
            panelCamposUsuarios.Controls.Add(TBDNIUsuario, 3, 0);
            panelCamposUsuarios.Controls.Add(TBUsuario, 1, 2);
            panelCamposUsuarios.Controls.Add(LSexo, 2, 4);
            panelCamposUsuarios.Controls.Add(TBContraseñaUsuario, 1, 3);
            panelCamposUsuarios.Controls.Add(LFechaNac, 2, 3);
            panelCamposUsuarios.Controls.Add(TBEmailUsuario, 1, 4);
            panelCamposUsuarios.Controls.Add(LTelefono, 2, 2);
            panelCamposUsuarios.Controls.Add(LDNI, 2, 0);
            panelCamposUsuarios.Controls.Add(LDireccion, 2, 1);
            panelCamposUsuarios.Location = new Point(31, 6);
            panelCamposUsuarios.Name = "panelCamposUsuarios";
            panelCamposUsuarios.RowCount = 6;
            panelCamposUsuarios.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            panelCamposUsuarios.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            panelCamposUsuarios.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            panelCamposUsuarios.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            panelCamposUsuarios.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            panelCamposUsuarios.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            panelCamposUsuarios.Size = new Size(748, 219);
            panelCamposUsuarios.TabIndex = 94;
            panelCamposUsuarios.Paint += panelCamposUsuarios_Paint;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(3, 0);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(64, 20);
            LNombre.TabIndex = 65;
            LNombre.Text = "Nombre";
            // 
            // TBNombreUsuario
            // 
            TBNombreUsuario.Location = new Point(146, 3);
            TBNombreUsuario.Name = "TBNombreUsuario";
            TBNombreUsuario.Size = new Size(130, 27);
            TBNombreUsuario.TabIndex = 76;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(3, 36);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(66, 20);
            LApellido.TabIndex = 66;
            LApellido.Text = "Apellido";
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.Location = new Point(3, 72);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(59, 20);
            LUsuario.TabIndex = 67;
            LUsuario.Text = "Usuario";
            // 
            // RBHombre
            // 
            RBHombre.AutoSize = true;
            RBHombre.Location = new Point(659, 147);
            RBHombre.Name = "RBHombre";
            RBHombre.Size = new Size(85, 24);
            RBHombre.TabIndex = 86;
            RBHombre.TabStop = true;
            RBHombre.Text = "Hombre";
            RBHombre.UseVisualStyleBackColor = true;
            // 
            // CBPerfil
            // 
            CBPerfil.FormattingEnabled = true;
            CBPerfil.Location = new Point(146, 183);
            CBPerfil.Name = "CBPerfil";
            CBPerfil.Size = new Size(130, 28);
            CBPerfil.TabIndex = 87;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(445, 147);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(68, 24);
            RBMujer.TabIndex = 85;
            RBMujer.TabStop = true;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Location = new Point(3, 108);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(83, 20);
            LContraseña.TabIndex = 68;
            LContraseña.Text = "Contraseña";
            // 
            // DTPFechaNac
            // 
            DTPFechaNac.Location = new Point(445, 111);
            DTPFechaNac.Name = "DTPFechaNac";
            DTPFechaNac.Size = new Size(199, 27);
            DTPFechaNac.TabIndex = 84;
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Location = new Point(3, 144);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(46, 20);
            LEmail.TabIndex = 71;
            LEmail.Text = "Email";
            // 
            // TBTelefonoUsuario
            // 
            TBTelefonoUsuario.Location = new Point(445, 75);
            TBTelefonoUsuario.Name = "TBTelefonoUsuario";
            TBTelefonoUsuario.Size = new Size(122, 27);
            TBTelefonoUsuario.TabIndex = 83;
            // 
            // LPerfil
            // 
            LPerfil.AutoSize = true;
            LPerfil.Location = new Point(3, 180);
            LPerfil.Name = "LPerfil";
            LPerfil.Size = new Size(42, 20);
            LPerfil.TabIndex = 69;
            LPerfil.Text = "Perfil";
            // 
            // TBDireccionUsuario
            // 
            TBDireccionUsuario.Location = new Point(445, 39);
            TBDireccionUsuario.Name = "TBDireccionUsuario";
            TBDireccionUsuario.Size = new Size(122, 27);
            TBDireccionUsuario.TabIndex = 82;
            // 
            // TBApellidoUsuario
            // 
            TBApellidoUsuario.Location = new Point(146, 39);
            TBApellidoUsuario.Name = "TBApellidoUsuario";
            TBApellidoUsuario.Size = new Size(130, 27);
            TBApellidoUsuario.TabIndex = 77;
            // 
            // TBDNIUsuario
            // 
            TBDNIUsuario.Location = new Point(445, 3);
            TBDNIUsuario.Name = "TBDNIUsuario";
            TBDNIUsuario.Size = new Size(122, 27);
            TBDNIUsuario.TabIndex = 81;
            // 
            // TBUsuario
            // 
            TBUsuario.Location = new Point(146, 75);
            TBUsuario.Name = "TBUsuario";
            TBUsuario.Size = new Size(130, 27);
            TBUsuario.TabIndex = 78;
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.Location = new Point(289, 144);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(41, 20);
            LSexo.TabIndex = 75;
            LSexo.Text = "Sexo";
            // 
            // TBContraseñaUsuario
            // 
            TBContraseñaUsuario.Location = new Point(146, 111);
            TBContraseñaUsuario.Name = "TBContraseñaUsuario";
            TBContraseñaUsuario.Size = new Size(130, 27);
            TBContraseñaUsuario.TabIndex = 79;
            // 
            // LFechaNac
            // 
            LFechaNac.AutoSize = true;
            LFechaNac.Location = new Point(289, 108);
            LFechaNac.Name = "LFechaNac";
            LFechaNac.Size = new Size(149, 20);
            LFechaNac.TabIndex = 74;
            LFechaNac.Text = "Fecha de Nacimiento";
            // 
            // TBEmailUsuario
            // 
            TBEmailUsuario.Location = new Point(146, 147);
            TBEmailUsuario.Name = "TBEmailUsuario";
            TBEmailUsuario.Size = new Size(130, 27);
            TBEmailUsuario.TabIndex = 80;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(289, 72);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(67, 20);
            LTelefono.TabIndex = 73;
            LTelefono.Text = "Telefono";
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Location = new Point(289, 0);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(35, 20);
            LDNI.TabIndex = 70;
            LDNI.Text = "DNI";
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Location = new Point(289, 36);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(72, 20);
            LDireccion.TabIndex = 72;
            LDireccion.Text = "Direccion";
            // 
            // panelBuscador
            // 
            panelBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelBuscador.ColumnCount = 3;
            panelBuscador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelBuscador.ColumnStyles.Add(new ColumnStyle());
            panelBuscador.ColumnStyles.Add(new ColumnStyle());
            panelBuscador.Controls.Add(TBBuscadorUsuarios, 0, 0);
            panelBuscador.Controls.Add(BUActivos, 1, 0);
            panelBuscador.Controls.Add(BUInactivos, 2, 0);
            panelBuscador.Location = new Point(28, 297);
            panelBuscador.Name = "panelBuscador";
            panelBuscador.RowCount = 1;
            panelBuscador.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBuscador.Size = new Size(812, 40);
            panelBuscador.TabIndex = 93;
            // 
            // TBBuscadorUsuarios
            // 
            TBBuscadorUsuarios.Location = new Point(3, 3);
            TBBuscadorUsuarios.Name = "TBBuscadorUsuarios";
            TBBuscadorUsuarios.PlaceholderText = "Buscar usuario..";
            TBBuscadorUsuarios.Size = new Size(236, 27);
            TBBuscadorUsuarios.TabIndex = 62;
            // 
            // BUActivos
            // 
            BUActivos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BUActivos.BackColor = SystemColors.Highlight;
            BUActivos.FlatAppearance.BorderSize = 0;
            BUActivos.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 101, 192);
            BUActivos.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 136, 229);
            BUActivos.FlatStyle = FlatStyle.Flat;
            BUActivos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUActivos.ForeColor = SystemColors.ButtonHighlight;
            BUActivos.Location = new Point(615, 3);
            BUActivos.Name = "BUActivos";
            BUActivos.Size = new Size(94, 29);
            BUActivos.TabIndex = 63;
            BUActivos.Text = "Activos";
            BUActivos.UseVisualStyleBackColor = false;
            // 
            // BUInactivos
            // 
            BUInactivos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BUInactivos.BackColor = Color.Gray;
            BUInactivos.FlatAppearance.BorderSize = 0;
            BUInactivos.FlatStyle = FlatStyle.Flat;
            BUInactivos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUInactivos.ForeColor = SystemColors.ButtonHighlight;
            BUInactivos.Location = new Point(715, 3);
            BUInactivos.Name = "BUInactivos";
            BUInactivos.Size = new Size(94, 29);
            BUInactivos.TabIndex = 64;
            BUInactivos.Text = "Inactivos";
            BUInactivos.UseVisualStyleBackColor = false;
            // 
            // panelBotones
            // 
            panelBotones.ColumnCount = 4;
            panelBotones.ColumnStyles.Add(new ColumnStyle());
            panelBotones.ColumnStyles.Add(new ColumnStyle());
            panelBotones.ColumnStyles.Add(new ColumnStyle());
            panelBotones.ColumnStyles.Add(new ColumnStyle());
            panelBotones.Controls.Add(BGuardar, 0, 0);
            panelBotones.Controls.Add(BCancelar, 1, 0);
            panelBotones.Controls.Add(BUEliminar, 3, 0);
            panelBotones.Controls.Add(BUModificar, 2, 0);
            panelBotones.Location = new Point(419, 231);
            panelBotones.Name = "panelBotones";
            panelBotones.RowCount = 1;
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBotones.Size = new Size(421, 45);
            panelBotones.TabIndex = 92;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.ForestGreen;
            BGuardar.FlatAppearance.BorderSize = 0;
            BGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 125, 50);
            BGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 160, 71);
            BGuardar.FlatStyle = FlatStyle.Flat;
            BGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BGuardar.ForeColor = SystemColors.ButtonHighlight;
            BGuardar.Location = new Point(3, 3);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(94, 29);
            BGuardar.TabIndex = 88;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = Color.Gray;
            BCancelar.FlatAppearance.BorderSize = 0;
            BCancelar.FlatStyle = FlatStyle.Flat;
            BCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCancelar.ForeColor = SystemColors.ButtonHighlight;
            BCancelar.Location = new Point(103, 3);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(94, 29);
            BCancelar.TabIndex = 89;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = false;
            // 
            // BUEliminar
            // 
            BUEliminar.BackColor = Color.OrangeRed;
            BUEliminar.FlatAppearance.BorderSize = 0;
            BUEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(183, 28, 28);
            BUEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 57, 53);
            BUEliminar.FlatStyle = FlatStyle.Flat;
            BUEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUEliminar.ForeColor = SystemColors.ButtonHighlight;
            BUEliminar.Location = new Point(319, 3);
            BUEliminar.Name = "BUEliminar";
            BUEliminar.Size = new Size(87, 29);
            BUEliminar.TabIndex = 91;
            BUEliminar.Text = "Eliminar";
            BUEliminar.UseVisualStyleBackColor = false;
            BUEliminar.Visible = false;
            // 
            // BUModificar
            // 
            BUModificar.BackColor = SystemColors.Highlight;
            BUModificar.FlatAppearance.BorderSize = 0;
            BUModificar.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 101, 192);
            BUModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 136, 229);
            BUModificar.FlatStyle = FlatStyle.Flat;
            BUModificar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUModificar.ForeColor = SystemColors.ButtonHighlight;
            BUModificar.Location = new Point(203, 3);
            BUModificar.Name = "BUModificar";
            BUModificar.Size = new Size(110, 29);
            BUModificar.TabIndex = 90;
            BUModificar.Text = "Modificar";
            BUModificar.UseVisualStyleBackColor = false;
            BUModificar.Visible = false;
            // 
            // DGVUsuarios
            // 
            DGVUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUsuarios.Columns.AddRange(new DataGridViewColumn[] { idUsuario, idPerfil, Nombre, Apellido, Usuario, DNI, Direccion, Telefono, FechadeNacimiento, Sexo });
            DGVUsuarios.Location = new Point(28, 356);
            DGVUsuarios.Name = "DGVUsuarios";
            DGVUsuarios.RowHeadersWidth = 51;
            DGVUsuarios.Size = new Size(812, 107);
            DGVUsuarios.TabIndex = 61;
            DGVUsuarios.CellClick += DGVUsuarios_CellClick;
            // 
            // idUsuario
            // 
            idUsuario.HeaderText = "idUsuario";
            idUsuario.MinimumWidth = 6;
            idUsuario.Name = "idUsuario";
            // 
            // idPerfil
            // 
            idPerfil.HeaderText = "idPerfil";
            idPerfil.MinimumWidth = 6;
            idPerfil.Name = "idPerfil";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 6;
            DNI.Name = "DNI";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            // 
            // FechadeNacimiento
            // 
            FechadeNacimiento.HeaderText = "Fecha de Nacimiento";
            FechadeNacimiento.MinimumWidth = 6;
            FechadeNacimiento.Name = "FechadeNacimiento";
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 6;
            Sexo.Name = "Sexo";
            // 
            // FormGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 558);
            Controls.Add(panelMain);
            Controls.Add(panelEncabezado);
            Name = "FormGestionUsuarios";
            Text = "FormGestionUsuarios";
            Load += FormGestionUsuarios_Load;
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            panelMain.ResumeLayout(false);
            panelCamposUsuarios.ResumeLayout(false);
            panelCamposUsuarios.PerformLayout();
            panelBuscador.ResumeLayout(false);
            panelBuscador.PerformLayout();
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEncabezado;
        private Label LTituloUsuarios;
        private Panel panelMain;
        private Button BUInactivos;
        private Button BUActivos;
        private TextBox TBBuscadorUsuarios;
        private DataGridView DGVUsuarios;
        private DataGridViewTextBoxColumn idUsuario;
        private DataGridViewTextBoxColumn idPerfil;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn FechadeNacimiento;
        private DataGridViewTextBoxColumn Sexo;
        private TableLayoutPanel panelBotones;
        private Button BGuardar;
        private Button BCancelar;
        private Button BUEliminar;
        private Button BUModificar;
        private ComboBox CBPerfil;
        private RadioButton RBHombre;
        private RadioButton RBMujer;
        private DateTimePicker DTPFechaNac;
        private TextBox TBTelefonoUsuario;
        private TextBox TBDireccionUsuario;
        private TextBox TBDNIUsuario;
        private TextBox TBEmailUsuario;
        private TextBox TBContraseñaUsuario;
        private TextBox TBUsuario;
        private TextBox TBApellidoUsuario;
        private TextBox TBNombreUsuario;
        private Label LSexo;
        private Label LFechaNac;
        private Label LTelefono;
        private Label LDireccion;
        private Label LEmail;
        private Label LDNI;
        private Label LPerfil;
        private Label LContraseña;
        private Label LNombre;
        private Label LUsuario;
        private Label LApellido;
        private TableLayoutPanel panelBuscador;
        private TableLayoutPanel panelCamposUsuarios;
    }
}