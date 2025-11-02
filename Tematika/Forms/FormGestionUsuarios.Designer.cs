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
            TBApellidoUsuario = new TextBox();
            TBDNIUsuario = new TextBox();
            LDNI = new Label();
            LDireccion = new Label();
            LSexo = new Label();
            RBHombre = new RadioButton();
            RBMujer = new RadioButton();
            LContraseña = new Label();
            TBContraseñaUsuario = new TextBox();
            LEmail = new Label();
            TBEmailUsuario = new TextBox();
            LPerfil = new Label();
            CBPerfil = new ComboBox();
            CBEliminado = new ComboBox();
            LTelefono = new Label();
            LEliminado = new Label();
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
            Correo = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
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
            panelEncabezado.Margin = new Padding(3, 2, 3, 2);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(774, 62);
            panelEncabezado.TabIndex = 0;
            // 
            // LTituloUsuarios
            // 
            LTituloUsuarios.AutoSize = true;
            LTituloUsuarios.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloUsuarios.Location = new Point(3, 22);
            LTituloUsuarios.Name = "LTituloUsuarios";
            LTituloUsuarios.Size = new Size(219, 30);
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
            panelMain.Location = new Point(0, 62);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(774, 356);
            panelMain.TabIndex = 1;
            // 
            // panelCamposUsuarios
            // 
            panelCamposUsuarios.ColumnCount = 5;
            panelCamposUsuarios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.73726F));
            panelCamposUsuarios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.8578053F));
            panelCamposUsuarios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2766762F));
            panelCamposUsuarios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.1282539F));
            panelCamposUsuarios.ColumnStyles.Add(new ColumnStyle());
            panelCamposUsuarios.Controls.Add(LNombre, 0, 0);
            panelCamposUsuarios.Controls.Add(TBNombreUsuario, 1, 0);
            panelCamposUsuarios.Controls.Add(LApellido, 0, 1);
            panelCamposUsuarios.Controls.Add(TBApellidoUsuario, 1, 1);
            panelCamposUsuarios.Controls.Add(TBDNIUsuario, 3, 0);
            panelCamposUsuarios.Controls.Add(LDNI, 2, 0);
            panelCamposUsuarios.Controls.Add(LDireccion, 2, 4);
            panelCamposUsuarios.Controls.Add(LSexo, 2, 1);
            panelCamposUsuarios.Controls.Add(RBHombre, 3, 1);
            panelCamposUsuarios.Controls.Add(RBMujer, 4, 1);
            panelCamposUsuarios.Controls.Add(LContraseña, 0, 2);
            panelCamposUsuarios.Controls.Add(TBContraseñaUsuario, 1, 2);
            panelCamposUsuarios.Controls.Add(LEmail, 0, 3);
            panelCamposUsuarios.Controls.Add(TBEmailUsuario, 1, 3);
            panelCamposUsuarios.Controls.Add(LPerfil, 0, 4);
            panelCamposUsuarios.Controls.Add(CBPerfil, 1, 4);
            panelCamposUsuarios.Controls.Add(CBEliminado, 3, 2);
            panelCamposUsuarios.Controls.Add(LTelefono, 4, 0);
            panelCamposUsuarios.Controls.Add(LEliminado, 2, 2);
            panelCamposUsuarios.Location = new Point(27, 4);
            panelCamposUsuarios.Margin = new Padding(3, 2, 3, 2);
            panelCamposUsuarios.Name = "panelCamposUsuarios";
            panelCamposUsuarios.RowCount = 6;
            panelCamposUsuarios.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            panelCamposUsuarios.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            panelCamposUsuarios.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            panelCamposUsuarios.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            panelCamposUsuarios.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            panelCamposUsuarios.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            panelCamposUsuarios.Size = new Size(654, 164);
            panelCamposUsuarios.TabIndex = 94;
            panelCamposUsuarios.Paint += panelCamposUsuarios_Paint;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(3, 0);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 65;
            LNombre.Text = "Nombre";
            // 
            // TBNombreUsuario
            // 
            TBNombreUsuario.Location = new Point(180, 2);
            TBNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            TBNombreUsuario.Name = "TBNombreUsuario";
            TBNombreUsuario.Size = new Size(114, 23);
            TBNombreUsuario.TabIndex = 76;
            TBNombreUsuario.Tag = "Nombre";
            TBNombreUsuario.KeyPress += TBNombreUsuario_KeyPress;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(3, 27);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 66;
            LApellido.Text = "Apellido";
            // 
            // TBApellidoUsuario
            // 
            TBApellidoUsuario.Location = new Point(180, 29);
            TBApellidoUsuario.Margin = new Padding(3, 2, 3, 2);
            TBApellidoUsuario.Name = "TBApellidoUsuario";
            TBApellidoUsuario.Size = new Size(114, 23);
            TBApellidoUsuario.TabIndex = 77;
            TBApellidoUsuario.Tag = "Apellido";
            TBApellidoUsuario.KeyPress += TBApellidoUsuario_KeyPress;
            // 
            // TBDNIUsuario
            // 
            TBDNIUsuario.Location = new Point(508, 2);
            TBDNIUsuario.Margin = new Padding(3, 2, 3, 2);
            TBDNIUsuario.Name = "TBDNIUsuario";
            TBDNIUsuario.Size = new Size(105, 23);
            TBDNIUsuario.TabIndex = 81;
            TBDNIUsuario.Tag = "DNI";
            TBDNIUsuario.KeyPress += TBDNIUsuario_KeyPress;
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Location = new Point(358, 0);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(27, 15);
            LDNI.TabIndex = 70;
            LDNI.Text = "DNI";
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Location = new Point(358, 108);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(0, 15);
            LDireccion.TabIndex = 72;
            LDireccion.Click += LDireccion_Click;
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.Location = new Point(358, 27);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(32, 15);
            LSexo.TabIndex = 75;
            LSexo.Text = "Sexo";
            // 
            // RBHombre
            // 
            RBHombre.AutoSize = true;
            RBHombre.Location = new Point(508, 29);
            RBHombre.Margin = new Padding(3, 2, 3, 2);
            RBHombre.Name = "RBHombre";
            RBHombre.Size = new Size(36, 19);
            RBHombre.TabIndex = 86;
            RBHombre.TabStop = true;
            RBHombre.Text = "m";
            RBHombre.UseVisualStyleBackColor = true;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(620, 29);
            RBMujer.Margin = new Padding(3, 2, 3, 2);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(29, 19);
            RBMujer.TabIndex = 85;
            RBMujer.TabStop = true;
            RBMujer.Text = "f";
            RBMujer.UseVisualStyleBackColor = true;
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Location = new Point(3, 54);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(67, 15);
            LContraseña.TabIndex = 68;
            LContraseña.Text = "Contraseña";
            // 
            // TBContraseñaUsuario
            // 
            TBContraseñaUsuario.Location = new Point(180, 56);
            TBContraseñaUsuario.Margin = new Padding(3, 2, 3, 2);
            TBContraseñaUsuario.Name = "TBContraseñaUsuario";
            TBContraseñaUsuario.Size = new Size(114, 23);
            TBContraseñaUsuario.TabIndex = 79;
            TBContraseñaUsuario.Tag = "Contraseña";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Location = new Point(3, 81);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(36, 15);
            LEmail.TabIndex = 71;
            LEmail.Text = "Email";
            // 
            // TBEmailUsuario
            // 
            TBEmailUsuario.Location = new Point(180, 83);
            TBEmailUsuario.Margin = new Padding(3, 2, 3, 2);
            TBEmailUsuario.Name = "TBEmailUsuario";
            TBEmailUsuario.Size = new Size(114, 23);
            TBEmailUsuario.TabIndex = 80;
            TBEmailUsuario.Tag = "Email";
            TBEmailUsuario.Leave += TBEmailUsuario_Leave;
            // 
            // LPerfil
            // 
            LPerfil.AutoSize = true;
            LPerfil.Location = new Point(3, 108);
            LPerfil.Name = "LPerfil";
            LPerfil.Size = new Size(34, 15);
            LPerfil.TabIndex = 69;
            LPerfil.Text = "Perfil";
            // 
            // CBPerfil
            // 
            CBPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            CBPerfil.FormattingEnabled = true;
            CBPerfil.Location = new Point(180, 110);
            CBPerfil.Margin = new Padding(3, 2, 3, 2);
            CBPerfil.Name = "CBPerfil";
            CBPerfil.Size = new Size(114, 23);
            CBPerfil.TabIndex = 87;
            // 
            // CBEliminado
            // 
            CBEliminado.DropDownStyle = ComboBoxStyle.DropDownList;
            CBEliminado.FormattingEnabled = true;
            CBEliminado.Location = new Point(508, 56);
            CBEliminado.Margin = new Padding(3, 2, 3, 2);
            CBEliminado.Name = "CBEliminado";
            CBEliminado.Size = new Size(105, 23);
            CBEliminado.TabIndex = 89;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(620, 0);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(0, 15);
            LTelefono.TabIndex = 73;
            // 
            // LEliminado
            // 
            LEliminado.AutoSize = true;
            LEliminado.Location = new Point(358, 54);
            LEliminado.Name = "LEliminado";
            LEliminado.Size = new Size(60, 15);
            LEliminado.TabIndex = 90;
            LEliminado.Text = "Eliminado";
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
            panelBuscador.Location = new Point(24, 223);
            panelBuscador.Margin = new Padding(3, 2, 3, 2);
            panelBuscador.Name = "panelBuscador";
            panelBuscador.RowCount = 1;
            panelBuscador.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBuscador.Size = new Size(710, 30);
            panelBuscador.TabIndex = 93;
            // 
            // TBBuscadorUsuarios
            // 
            TBBuscadorUsuarios.Location = new Point(3, 2);
            TBBuscadorUsuarios.Margin = new Padding(3, 2, 3, 2);
            TBBuscadorUsuarios.Name = "TBBuscadorUsuarios";
            TBBuscadorUsuarios.PlaceholderText = "Buscar usuario..";
            TBBuscadorUsuarios.Size = new Size(207, 23);
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
            BUActivos.Location = new Point(537, 2);
            BUActivos.Margin = new Padding(3, 2, 3, 2);
            BUActivos.Name = "BUActivos";
            BUActivos.Size = new Size(82, 22);
            BUActivos.TabIndex = 63;
            BUActivos.Text = "Activos";
            BUActivos.UseVisualStyleBackColor = false;
            BUActivos.Click += BUActivos_Click;
            // 
            // BUInactivos
            // 
            BUInactivos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BUInactivos.BackColor = Color.Gray;
            BUInactivos.FlatAppearance.BorderSize = 0;
            BUInactivos.FlatStyle = FlatStyle.Flat;
            BUInactivos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUInactivos.ForeColor = SystemColors.ButtonHighlight;
            BUInactivos.Location = new Point(625, 2);
            BUInactivos.Margin = new Padding(3, 2, 3, 2);
            BUInactivos.Name = "BUInactivos";
            BUInactivos.Size = new Size(82, 22);
            BUInactivos.TabIndex = 64;
            BUInactivos.Text = "Inactivos";
            BUInactivos.UseVisualStyleBackColor = false;
            BUInactivos.Click += BUInactivos_Click;
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
            panelBotones.Location = new Point(367, 173);
            panelBotones.Margin = new Padding(3, 2, 3, 2);
            panelBotones.Name = "panelBotones";
            panelBotones.RowCount = 1;
            panelBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBotones.Size = new Size(368, 34);
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
            BGuardar.Location = new Point(3, 2);
            BGuardar.Margin = new Padding(3, 2, 3, 2);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(82, 22);
            BGuardar.TabIndex = 88;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = Color.Gray;
            BCancelar.FlatAppearance.BorderSize = 0;
            BCancelar.FlatStyle = FlatStyle.Flat;
            BCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCancelar.ForeColor = SystemColors.ButtonHighlight;
            BCancelar.Location = new Point(91, 2);
            BCancelar.Margin = new Padding(3, 2, 3, 2);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(82, 22);
            BCancelar.TabIndex = 89;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
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
            BUEliminar.Location = new Point(281, 2);
            BUEliminar.Margin = new Padding(3, 2, 3, 2);
            BUEliminar.Name = "BUEliminar";
            BUEliminar.Size = new Size(76, 22);
            BUEliminar.TabIndex = 91;
            BUEliminar.Text = "Eliminar";
            BUEliminar.UseVisualStyleBackColor = false;
            BUEliminar.Visible = false;
            BUEliminar.Click += BUEliminar_Click;
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
            BUModificar.Location = new Point(179, 2);
            BUModificar.Margin = new Padding(3, 2, 3, 2);
            BUModificar.Name = "BUModificar";
            BUModificar.Size = new Size(96, 22);
            BUModificar.TabIndex = 90;
            BUModificar.Text = "Modificar";
            BUModificar.UseVisualStyleBackColor = false;
            BUModificar.Visible = false;
            BUModificar.Click += BUModificar_Click;
            // 
            // DGVUsuarios
            // 
            DGVUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUsuarios.Columns.AddRange(new DataGridViewColumn[] { idUsuario, idPerfil, Nombre, Apellido, Correo, DNI, Sexo });
            DGVUsuarios.Location = new Point(24, 267);
            DGVUsuarios.Margin = new Padding(3, 2, 3, 2);
            DGVUsuarios.Name = "DGVUsuarios";
            DGVUsuarios.ReadOnly = true;
            DGVUsuarios.RowHeadersWidth = 51;
            DGVUsuarios.Size = new Size(710, 80);
            DGVUsuarios.TabIndex = 61;
            DGVUsuarios.CellClick += DGVUsuarios_CellClick;
            // 
            // idUsuario
            // 
            idUsuario.HeaderText = "idUsuario";
            idUsuario.MinimumWidth = 6;
            idUsuario.Name = "idUsuario";
            idUsuario.ReadOnly = true;
            // 
            // idPerfil
            // 
            idPerfil.HeaderText = "idPerfil";
            idPerfil.MinimumWidth = 6;
            idPerfil.Name = "idPerfil";
            idPerfil.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 6;
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 6;
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            // 
            // FormGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 418);
            Controls.Add(panelMain);
            Controls.Add(panelEncabezado);
            Margin = new Padding(3, 2, 3, 2);
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
        private TableLayoutPanel panelBotones;
        private Button BGuardar;
        private Button BCancelar;
        private Button BUEliminar;
        private Button BUModificar;
        private ComboBox CBPerfil;
        private RadioButton RBHombre;
        private RadioButton RBMujer;
        private TextBox TBDNIUsuario;
        private TextBox TBEmailUsuario;
        private TextBox TBContraseñaUsuario;
        private TextBox TBApellidoUsuario;
        private TextBox TBNombreUsuario;
        private Label LSexo;
        private Label LTelefono;
        private Label LDireccion;
        private Label LEmail;
        private Label LDNI;
        private Label LPerfil;
        private Label LContraseña;
        private Label LNombre;
        private Label LApellido;
        private TableLayoutPanel panelBuscador;
        private TableLayoutPanel panelCamposUsuarios;
        private DataGridViewTextBoxColumn idUsuario;
        private DataGridViewTextBoxColumn idPerfil;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Sexo;
        private Label LEliminado;
        private ComboBox CBEliminado;
    }
}