namespace Tematika.Forms
{
    partial class FormDashboardEstudiante
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
            pnlDashEstudianteDatos = new Panel();
            BUModificar = new Button();
            panelDatosEstudiante = new TableLayoutPanel();
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
            LTelefono = new Label();
            pnlDashEstudianteSuscripcion = new Panel();
            dataGridView1 = new DataGridView();
            IdSuscripcion = new DataGridViewTextBoxColumn();
            Activa = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            FechaInicio = new DataGridViewTextBoxColumn();
            FechaHasta = new DataGridViewTextBoxColumn();
            VerFactura = new DataGridViewButtonColumn();
            labelHistorialSuscripciones = new Label();
            btnSuscribirse = new Button();
            labelSuscripcionDescripcion = new Label();
            labelSuscripcionTitulo = new Label();
            labelAvisoBaja = new Label();
            pnlDashEstudianteDatos.SuspendLayout();
            panelDatosEstudiante.SuspendLayout();
            pnlDashEstudianteSuscripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlDashEstudianteDatos
            // 
            pnlDashEstudianteDatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlDashEstudianteDatos.AutoScroll = true;
            pnlDashEstudianteDatos.BackColor = Color.LightSkyBlue;
            pnlDashEstudianteDatos.Controls.Add(BUModificar);
            pnlDashEstudianteDatos.Controls.Add(panelDatosEstudiante);
            pnlDashEstudianteDatos.Location = new Point(0, 1);
            pnlDashEstudianteDatos.Name = "pnlDashEstudianteDatos";
            pnlDashEstudianteDatos.Size = new Size(783, 228);
            pnlDashEstudianteDatos.TabIndex = 0;
            // 
            // BUModificar
            // 
            BUModificar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BUModificar.BackColor = SystemColors.Highlight;
            BUModificar.FlatAppearance.BorderSize = 0;
            BUModificar.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 101, 192);
            BUModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 136, 229);
            BUModificar.FlatStyle = FlatStyle.Flat;
            BUModificar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUModificar.ForeColor = SystemColors.ButtonHighlight;
            BUModificar.Location = new Point(582, 178);
            BUModificar.Margin = new Padding(3, 2, 3, 2);
            BUModificar.Name = "BUModificar";
            BUModificar.Size = new Size(96, 30);
            BUModificar.TabIndex = 90;
            BUModificar.Text = "Modificar";
            BUModificar.UseVisualStyleBackColor = false;
            BUModificar.Click += BUModificar_Click;
            // 
            // panelDatosEstudiante
            // 
            panelDatosEstudiante.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDatosEstudiante.ColumnCount = 5;
            panelDatosEstudiante.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.73726F));
            panelDatosEstudiante.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.8578053F));
            panelDatosEstudiante.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2766762F));
            panelDatosEstudiante.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.1282539F));
            panelDatosEstudiante.ColumnStyles.Add(new ColumnStyle());
            panelDatosEstudiante.Controls.Add(LNombre, 0, 0);
            panelDatosEstudiante.Controls.Add(TBNombreUsuario, 1, 0);
            panelDatosEstudiante.Controls.Add(LApellido, 0, 1);
            panelDatosEstudiante.Controls.Add(TBApellidoUsuario, 1, 1);
            panelDatosEstudiante.Controls.Add(TBDNIUsuario, 3, 0);
            panelDatosEstudiante.Controls.Add(LDNI, 2, 0);
            panelDatosEstudiante.Controls.Add(LDireccion, 2, 4);
            panelDatosEstudiante.Controls.Add(LSexo, 2, 1);
            panelDatosEstudiante.Controls.Add(RBHombre, 3, 1);
            panelDatosEstudiante.Controls.Add(RBMujer, 4, 1);
            panelDatosEstudiante.Controls.Add(LContraseña, 0, 2);
            panelDatosEstudiante.Controls.Add(TBContraseñaUsuario, 1, 2);
            panelDatosEstudiante.Controls.Add(LEmail, 0, 3);
            panelDatosEstudiante.Controls.Add(TBEmailUsuario, 1, 3);
            panelDatosEstudiante.Controls.Add(LTelefono, 4, 0);
            panelDatosEstudiante.Location = new Point(24, 10);
            panelDatosEstudiante.Margin = new Padding(3, 2, 3, 2);
            panelDatosEstudiante.Name = "panelDatosEstudiante";
            panelDatosEstudiante.RowCount = 6;
            panelDatosEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            panelDatosEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            panelDatosEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            panelDatosEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            panelDatosEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            panelDatosEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            panelDatosEstudiante.Size = new Size(654, 164);
            panelDatosEstudiante.TabIndex = 96;
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
            // 
            // TBDNIUsuario
            // 
            TBDNIUsuario.Location = new Point(508, 2);
            TBDNIUsuario.Margin = new Padding(3, 2, 3, 2);
            TBDNIUsuario.Name = "TBDNIUsuario";
            TBDNIUsuario.Size = new Size(105, 23);
            TBDNIUsuario.TabIndex = 81;
            TBDNIUsuario.Tag = "DNI";
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
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(620, 0);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(0, 15);
            LTelefono.TabIndex = 73;
            // 
            // pnlDashEstudianteSuscripcion
            // 
            pnlDashEstudianteSuscripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDashEstudianteSuscripcion.AutoScroll = true;
            pnlDashEstudianteSuscripcion.BackColor = Color.SteelBlue;
            pnlDashEstudianteSuscripcion.Controls.Add(labelAvisoBaja);
            pnlDashEstudianteSuscripcion.Controls.Add(dataGridView1);
            pnlDashEstudianteSuscripcion.Controls.Add(labelHistorialSuscripciones);
            pnlDashEstudianteSuscripcion.Controls.Add(btnSuscribirse);
            pnlDashEstudianteSuscripcion.Controls.Add(labelSuscripcionDescripcion);
            pnlDashEstudianteSuscripcion.Controls.Add(labelSuscripcionTitulo);
            pnlDashEstudianteSuscripcion.Location = new Point(0, 235);
            pnlDashEstudianteSuscripcion.Name = "pnlDashEstudianteSuscripcion";
            pnlDashEstudianteSuscripcion.Size = new Size(783, 238);
            pnlDashEstudianteSuscripcion.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdSuscripcion, Activa, Tipo, FechaInicio, FechaHasta, VerFactura });
            dataGridView1.Location = new Point(24, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(720, 138);
            dataGridView1.TabIndex = 4;
            // 
            // IdSuscripcion
            // 
            IdSuscripcion.HeaderText = "ID Suscripción";
            IdSuscripcion.MinimumWidth = 6;
            IdSuscripcion.Name = "IdSuscripcion";
            IdSuscripcion.ReadOnly = true;
            // 
            // Activa
            // 
            Activa.HeaderText = "Activa";
            Activa.MinimumWidth = 6;
            Activa.Name = "Activa";
            Activa.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // FechaInicio
            // 
            FechaInicio.HeaderText = "Fecha Inicio";
            FechaInicio.MinimumWidth = 6;
            FechaInicio.Name = "FechaInicio";
            FechaInicio.ReadOnly = true;
            // 
            // FechaHasta
            // 
            FechaHasta.HeaderText = "Fecha Hasta";
            FechaHasta.MinimumWidth = 6;
            FechaHasta.Name = "FechaHasta";
            FechaHasta.ReadOnly = true;
            // 
            // VerFactura
            // 
            VerFactura.HeaderText = "Ver Factura";
            VerFactura.MinimumWidth = 6;
            VerFactura.Name = "VerFactura";
            VerFactura.ReadOnly = true;
            // 
            // labelHistorialSuscripciones
            // 
            labelHistorialSuscripciones.AutoSize = true;
            labelHistorialSuscripciones.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHistorialSuscripciones.ForeColor = Color.White;
            labelHistorialSuscripciones.Location = new Point(20, 93);
            labelHistorialSuscripciones.Name = "labelHistorialSuscripciones";
            labelHistorialSuscripciones.Size = new Size(213, 25);
            labelHistorialSuscripciones.TabIndex = 3;
            labelHistorialSuscripciones.Text = "Historial Suscripciones";
            // 
            // btnSuscribirse
            // 
            btnSuscribirse.BackColor = Color.FromArgb(53, 251, 113);
            btnSuscribirse.FlatAppearance.BorderColor = Color.Lime;
            btnSuscribirse.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnSuscribirse.FlatStyle = FlatStyle.Flat;
            btnSuscribirse.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuscribirse.ForeColor = Color.Black;
            btnSuscribirse.Location = new Point(456, 3);
            btnSuscribirse.Name = "btnSuscribirse";
            btnSuscribirse.Size = new Size(222, 77);
            btnSuscribirse.TabIndex = 2;
            btnSuscribirse.Text = "Suscribirse";
            btnSuscribirse.UseVisualStyleBackColor = false;
            btnSuscribirse.Click += btnSuscribirse_Click;
            // 
            // labelSuscripcionDescripcion
            // 
            labelSuscripcionDescripcion.AutoSize = true;
            labelSuscripcionDescripcion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuscripcionDescripcion.ForeColor = Color.WhiteSmoke;
            labelSuscripcionDescripcion.Location = new Point(24, 25);
            labelSuscripcionDescripcion.MaximumSize = new Size(750, 0);
            labelSuscripcionDescripcion.Name = "labelSuscripcionDescripcion";
            labelSuscripcionDescripcion.Size = new Size(321, 68);
            labelSuscripcionDescripcion.TabIndex = 1;
            labelSuscripcionDescripcion.Text = "Al suscribirte podrás acceder a:\r\n• Marcar recursos como favoritos sin límite\r\n• Crear notas personales ilimitadas\r\n• Participar en los comentarios públicos de recursos";
            // 
            // labelSuscripcionTitulo
            // 
            labelSuscripcionTitulo.AutoSize = true;
            labelSuscripcionTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuscripcionTitulo.ForeColor = Color.White;
            labelSuscripcionTitulo.Location = new Point(20, 0);
            labelSuscripcionTitulo.Name = "labelSuscripcionTitulo";
            labelSuscripcionTitulo.Size = new Size(201, 25);
            labelSuscripcionTitulo.TabIndex = 0;
            labelSuscripcionTitulo.Text = "Suscripción Premium";
            // 
            // labelAvisoBaja
            // 
            labelAvisoBaja.AutoSize = true;
            labelAvisoBaja.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAvisoBaja.ForeColor = Color.White;
            labelAvisoBaja.Location = new Point(26, 266);
            labelAvisoBaja.Name = "labelAvisoBaja";
            labelAvisoBaja.Size = new Size(614, 17);
            labelAvisoBaja.TabIndex = 5;
            labelAvisoBaja.Text = "Si su suscripción fue dada de baja, por favor consulte su email para informarse sobre los motivos.";
            labelAvisoBaja.Click += label1_Click;
            // 
            // FormDashboardEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(800, 473);
            Controls.Add(pnlDashEstudianteSuscripcion);
            Controls.Add(pnlDashEstudianteDatos);
            Name = "FormDashboardEstudiante";
            Text = "FormDashboardEstudiante";
            Load += FormDashboardEstudiante_Load;
            pnlDashEstudianteDatos.ResumeLayout(false);
            panelDatosEstudiante.ResumeLayout(false);
            panelDatosEstudiante.PerformLayout();
            pnlDashEstudianteSuscripcion.ResumeLayout(false);
            pnlDashEstudianteSuscripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDashEstudianteDatos;
        private Panel pnlDashEstudianteSuscripcion;
        private Button BUModificar;
        private TableLayoutPanel panelDatosEstudiante;
        private Label LNombre;
        private TextBox TBNombreUsuario;
        private Label LApellido;
        private TextBox TBApellidoUsuario;
        private TextBox TBDNIUsuario;
        private Label LDNI;
        private Label LDireccion;
        private Label LSexo;
        private RadioButton RBHombre;
        private RadioButton RBMujer;
        private Label LContraseña;
        private TextBox TBContraseñaUsuario;
        private Label LEmail;
        private TextBox TBEmailUsuario;
        private Label LTelefono;
        private Label labelSuscripcionTitulo;
        private Label labelSuscripcionDescripcion;
        private Button btnSuscribirse;
        private DataGridView dataGridView1;
        private Label labelHistorialSuscripciones;
        private DataGridViewTextBoxColumn IdSuscripcion;
        private DataGridViewTextBoxColumn Activa;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaHasta;
        private DataGridViewButtonColumn VerFactura;
        private Label labelAvisoBaja;
    }
}