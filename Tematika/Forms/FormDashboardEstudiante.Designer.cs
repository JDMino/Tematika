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
            labelSuscripcionTitulo = new Label();
            labelSuscripcionDescripcion = new Label();
            btnSuscribirse = new Button();
            pnlDashEstudianteDatos.SuspendLayout();
            panelDatosEstudiante.SuspendLayout();
            pnlDashEstudianteSuscripcion.SuspendLayout();
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
            TBDNIUsuario.Size = new Size(106, 23);
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
            LSexo.Size = new Size(31, 15);
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
            pnlDashEstudianteSuscripcion.Controls.Add(btnSuscribirse);
            pnlDashEstudianteSuscripcion.Controls.Add(labelSuscripcionDescripcion);
            pnlDashEstudianteSuscripcion.Controls.Add(labelSuscripcionTitulo);
            pnlDashEstudianteSuscripcion.Location = new Point(0, 235);
            pnlDashEstudianteSuscripcion.Name = "pnlDashEstudianteSuscripcion";
            pnlDashEstudianteSuscripcion.Size = new Size(783, 215);
            pnlDashEstudianteSuscripcion.TabIndex = 1;
            // 
            // labelSuscripcionTitulo
            // 
            labelSuscripcionTitulo.AutoSize = true;
            labelSuscripcionTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuscripcionTitulo.ForeColor = Color.White;
            labelSuscripcionTitulo.Location = new Point(20, 20);
            labelSuscripcionTitulo.Name = "labelSuscripcionTitulo";
            labelSuscripcionTitulo.Size = new Size(201, 25);
            labelSuscripcionTitulo.TabIndex = 0;
            labelSuscripcionTitulo.Text = "Suscripción Premium";
            // 
            // labelSuscripcionDescripcion
            // 
            labelSuscripcionDescripcion.AutoSize = true;
            labelSuscripcionDescripcion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuscripcionDescripcion.ForeColor = Color.WhiteSmoke;
            labelSuscripcionDescripcion.Location = new Point(20, 60);
            labelSuscripcionDescripcion.MaximumSize = new Size(750, 0);
            labelSuscripcionDescripcion.Name = "labelSuscripcionDescripcion";
            labelSuscripcionDescripcion.Size = new Size(321, 85);
            labelSuscripcionDescripcion.TabIndex = 1;
            labelSuscripcionDescripcion.Text = "Al suscribirte podrás acceder a:\n\n• Marcar recursos como favoritos sin límite\n• Crear notas personales ilimitadas\n• Participar en los comentarios públicos de recursos";
            // 
            // btnSuscribirse
            // 
            btnSuscribirse.BackColor = Color.DarkGray;
            btnSuscribirse.FlatStyle = FlatStyle.Flat;
            btnSuscribirse.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuscribirse.ForeColor = Color.Black;
            btnSuscribirse.Location = new Point(20, 168);
            btnSuscribirse.Name = "btnSuscribirse";
            btnSuscribirse.Size = new Size(120, 35);
            btnSuscribirse.TabIndex = 2;
            btnSuscribirse.Text = "Suscribirse";
            btnSuscribirse.UseVisualStyleBackColor = false;
            // 
            // FormDashboardEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDashEstudianteSuscripcion);
            Controls.Add(pnlDashEstudianteDatos);
            Name = "FormDashboardEstudiante";
            Text = "FormDashboardEstudiante";
            pnlDashEstudianteDatos.ResumeLayout(false);
            panelDatosEstudiante.ResumeLayout(false);
            panelDatosEstudiante.PerformLayout();
            pnlDashEstudianteSuscripcion.ResumeLayout(false);
            pnlDashEstudianteSuscripcion.PerformLayout();
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
    }
}