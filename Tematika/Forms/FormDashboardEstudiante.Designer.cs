
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
            pnlDashEstudianteDatos.Margin = new Padding(3, 4, 3, 4);
            pnlDashEstudianteDatos.Name = "pnlDashEstudianteDatos";
            pnlDashEstudianteDatos.Size = new Size(895, 304);
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
            BUModificar.Location = new Point(665, 237);
            BUModificar.Name = "BUModificar";
            BUModificar.Size = new Size(110, 40);
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
            panelDatosEstudiante.Location = new Point(27, 13);
            panelDatosEstudiante.Name = "panelDatosEstudiante";
            panelDatosEstudiante.RowCount = 6;
            panelDatosEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            panelDatosEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            panelDatosEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            panelDatosEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            panelDatosEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            panelDatosEstudiante.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            panelDatosEstudiante.Size = new Size(747, 219);
            panelDatosEstudiante.TabIndex = 96;
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
            TBNombreUsuario.Location = new Point(205, 3);
            TBNombreUsuario.Name = "TBNombreUsuario";
            TBNombreUsuario.Size = new Size(130, 27);
            TBNombreUsuario.TabIndex = 76;
            TBNombreUsuario.Tag = "Nombre";
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
            // TBApellidoUsuario
            // 
            TBApellidoUsuario.Location = new Point(205, 39);
            TBApellidoUsuario.Name = "TBApellidoUsuario";
            TBApellidoUsuario.Size = new Size(130, 27);
            TBApellidoUsuario.TabIndex = 77;
            TBApellidoUsuario.Tag = "Apellido";
            // 
            // TBDNIUsuario
            // 
            TBDNIUsuario.Location = new Point(579, 3);
            TBDNIUsuario.Name = "TBDNIUsuario";
            TBDNIUsuario.Size = new Size(119, 27);
            TBDNIUsuario.TabIndex = 81;
            TBDNIUsuario.Tag = "DNI";
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Location = new Point(408, 0);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(35, 20);
            LDNI.TabIndex = 70;
            LDNI.Text = "DNI";
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Location = new Point(408, 144);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(0, 20);
            LDireccion.TabIndex = 72;
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.Location = new Point(408, 36);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(41, 20);
            LSexo.TabIndex = 75;
            LSexo.Text = "Sexo";
            // 
            // RBHombre
            // 
            RBHombre.AutoSize = true;
            RBHombre.Location = new Point(579, 39);
            RBHombre.Name = "RBHombre";
            RBHombre.Size = new Size(43, 24);
            RBHombre.TabIndex = 86;
            RBHombre.TabStop = true;
            RBHombre.Text = "m";
            RBHombre.UseVisualStyleBackColor = true;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(706, 39);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(35, 24);
            RBMujer.TabIndex = 85;
            RBMujer.TabStop = true;
            RBMujer.Text = "f";
            RBMujer.UseVisualStyleBackColor = true;
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Location = new Point(3, 72);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(83, 20);
            LContraseña.TabIndex = 68;
            LContraseña.Text = "Contraseña";
            // 
            // TBContraseñaUsuario
            // 
            TBContraseñaUsuario.Location = new Point(205, 75);
            TBContraseñaUsuario.Name = "TBContraseñaUsuario";
            TBContraseñaUsuario.Size = new Size(130, 27);
            TBContraseñaUsuario.TabIndex = 79;
            TBContraseñaUsuario.Tag = "Contraseña";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Location = new Point(3, 108);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(46, 20);
            LEmail.TabIndex = 71;
            LEmail.Text = "Email";
            // 
            // TBEmailUsuario
            // 
            TBEmailUsuario.Location = new Point(205, 111);
            TBEmailUsuario.Name = "TBEmailUsuario";
            TBEmailUsuario.Size = new Size(130, 27);
            TBEmailUsuario.TabIndex = 80;
            TBEmailUsuario.Tag = "Email";
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(706, 0);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(0, 20);
            LTelefono.TabIndex = 73;
            // 
            // pnlDashEstudianteSuscripcion
            // 
            pnlDashEstudianteSuscripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDashEstudianteSuscripcion.AutoScroll = true;
            pnlDashEstudianteSuscripcion.BackColor = Color.SteelBlue;
            pnlDashEstudianteSuscripcion.Controls.Add(dataGridView1);
            pnlDashEstudianteSuscripcion.Controls.Add(labelHistorialSuscripciones);
            pnlDashEstudianteSuscripcion.Controls.Add(btnSuscribirse);
            pnlDashEstudianteSuscripcion.Controls.Add(labelSuscripcionDescripcion);
            pnlDashEstudianteSuscripcion.Controls.Add(labelSuscripcionTitulo);
            pnlDashEstudianteSuscripcion.Location = new Point(0, 313);
            pnlDashEstudianteSuscripcion.Margin = new Padding(3, 4, 3, 4);
            pnlDashEstudianteSuscripcion.Name = "pnlDashEstudianteSuscripcion";
            pnlDashEstudianteSuscripcion.Size = new Size(895, 287);
            pnlDashEstudianteSuscripcion.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdSuscripcion, Activa, Tipo, FechaInicio, FechaHasta, VerFactura });
            dataGridView1.Location = new Point(32, 215);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(823, 200);
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
            labelHistorialSuscripciones.Location = new Point(27, 155);
            labelHistorialSuscripciones.Name = "labelHistorialSuscripciones";
            labelHistorialSuscripciones.Size = new Size(274, 32);
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
            btnSuscribirse.Location = new Point(521, 35);
            btnSuscribirse.Margin = new Padding(3, 4, 3, 4);
            btnSuscribirse.Name = "btnSuscribirse";
            btnSuscribirse.Size = new Size(254, 103);
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
            labelSuscripcionDescripcion.Location = new Point(23, 47);
            labelSuscripcionDescripcion.MaximumSize = new Size(857, 0);
            labelSuscripcionDescripcion.Name = "labelSuscripcionDescripcion";
            labelSuscripcionDescripcion.Size = new Size(403, 92);
            labelSuscripcionDescripcion.TabIndex = 1;
            labelSuscripcionDescripcion.Text = "Al suscribirte podrás acceder a:\r\n• Marcar recursos como favoritos sin límite\r\n• Crear notas personales ilimitadas\r\n• Participar en los comentarios públicos de recursos";
            // 
            // labelSuscripcionTitulo
            // 
            labelSuscripcionTitulo.AutoSize = true;
            labelSuscripcionTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuscripcionTitulo.ForeColor = Color.White;
            labelSuscripcionTitulo.Location = new Point(23, 0);
            labelSuscripcionTitulo.Name = "labelSuscripcionTitulo";
            labelSuscripcionTitulo.Size = new Size(257, 32);
            labelSuscripcionTitulo.TabIndex = 0;
            labelSuscripcionTitulo.Text = "Suscripción Premium";
            // 
            // FormDashboardEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(pnlDashEstudianteSuscripcion);
            Controls.Add(pnlDashEstudianteDatos);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}