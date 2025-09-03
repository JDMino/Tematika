namespace Tematika.Forms
{
    partial class Gestion_de_Usuarios
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
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            BUEliminar = new Button();
            BUModificar = new Button();
            BCancelar = new Button();
            BGuardarUsuario = new Button();
            BUInactivos = new Button();
            BUActivos = new Button();
            TBBuscadorUsuarios = new TextBox();
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
            CBPerfil = new ComboBox();
            RBHombre = new RadioButton();
            RBMujer = new RadioButton();
            DTPFechaNac = new DateTimePicker();
            TBTelefonoUsuario = new TextBox();
            TBDireccionUsuario = new TextBox();
            TBDNIUsuario = new TextBox();
            TBEmailUsuario = new TextBox();
            TBContraseñaUsuario = new TextBox();
            TBUsuario = new TextBox();
            TBApellidoUsuario = new TextBox();
            TBNombreUsuario = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(876, 56);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 15);
            label1.Name = "label1";
            label1.Size = new Size(218, 31);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Usuarios";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 624);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(BUEliminar);
            panel3.Controls.Add(BUModificar);
            panel3.Controls.Add(BCancelar);
            panel3.Controls.Add(BGuardarUsuario);
            panel3.Controls.Add(BUInactivos);
            panel3.Controls.Add(BUActivos);
            panel3.Controls.Add(TBBuscadorUsuarios);
            panel3.Controls.Add(DGVUsuarios);
            panel3.Controls.Add(CBPerfil);
            panel3.Controls.Add(RBHombre);
            panel3.Controls.Add(RBMujer);
            panel3.Controls.Add(DTPFechaNac);
            panel3.Controls.Add(TBTelefonoUsuario);
            panel3.Controls.Add(TBDireccionUsuario);
            panel3.Controls.Add(TBDNIUsuario);
            panel3.Controls.Add(TBEmailUsuario);
            panel3.Controls.Add(TBContraseñaUsuario);
            panel3.Controls.Add(TBUsuario);
            panel3.Controls.Add(TBApellidoUsuario);
            panel3.Controls.Add(TBNombreUsuario);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(0, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 568);
            panel3.TabIndex = 6;
            // 
            // BUEliminar
            // 
            BUEliminar.Location = new Point(707, 274);
            BUEliminar.Name = "BUEliminar";
            BUEliminar.Size = new Size(94, 29);
            BUEliminar.TabIndex = 64;
            BUEliminar.Text = "Eliminar";
            BUEliminar.UseVisualStyleBackColor = true;
            BUEliminar.Visible = false;
            // 
            // BUModificar
            // 
            BUModificar.Location = new Point(607, 274);
            BUModificar.Name = "BUModificar";
            BUModificar.Size = new Size(94, 29);
            BUModificar.TabIndex = 63;
            BUModificar.Text = "Modificar";
            BUModificar.UseVisualStyleBackColor = true;
            BUModificar.Visible = false;
            // 
            // BCancelar
            // 
            BCancelar.Location = new Point(707, 239);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(94, 29);
            BCancelar.TabIndex = 62;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = true;
            // 
            // BGuardarUsuario
            // 
            BGuardarUsuario.Location = new Point(607, 239);
            BGuardarUsuario.Name = "BGuardarUsuario";
            BGuardarUsuario.Size = new Size(94, 29);
            BGuardarUsuario.TabIndex = 61;
            BGuardarUsuario.Text = "Guardar";
            BGuardarUsuario.UseVisualStyleBackColor = true;
            // 
            // BUInactivos
            // 
            BUInactivos.Location = new Point(707, 371);
            BUInactivos.Name = "BUInactivos";
            BUInactivos.Size = new Size(94, 29);
            BUInactivos.TabIndex = 60;
            BUInactivos.Text = "Inactivos";
            BUInactivos.UseVisualStyleBackColor = true;
            // 
            // BUActivos
            // 
            BUActivos.Location = new Point(607, 372);
            BUActivos.Name = "BUActivos";
            BUActivos.Size = new Size(94, 29);
            BUActivos.TabIndex = 59;
            BUActivos.Text = "Activos";
            BUActivos.UseVisualStyleBackColor = true;
            // 
            // TBBuscadorUsuarios
            // 
            TBBuscadorUsuarios.Location = new Point(69, 372);
            TBBuscadorUsuarios.Name = "TBBuscadorUsuarios";
            TBBuscadorUsuarios.Size = new Size(236, 27);
            TBBuscadorUsuarios.TabIndex = 58;
            // 
            // DGVUsuarios
            // 
            DGVUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUsuarios.Columns.AddRange(new DataGridViewColumn[] { idUsuario, idPerfil, Nombre, Apellido, Usuario, DNI, Direccion, Telefono, FechadeNacimiento, Sexo });
            DGVUsuarios.Location = new Point(69, 416);
            DGVUsuarios.Name = "DGVUsuarios";
            DGVUsuarios.RowHeadersWidth = 51;
            DGVUsuarios.Size = new Size(739, 107);
            DGVUsuarios.TabIndex = 57;
            // 
            // idUsuario
            // 
            idUsuario.HeaderText = "idUsuario";
            idUsuario.MinimumWidth = 6;
            idUsuario.Name = "idUsuario";
            idUsuario.Width = 125;
            // 
            // idPerfil
            // 
            idPerfil.HeaderText = "idPerfil";
            idPerfil.MinimumWidth = 6;
            idPerfil.Name = "idPerfil";
            idPerfil.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.Width = 125;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.Width = 125;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 6;
            DNI.Name = "DNI";
            DNI.Width = 125;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 125;
            // 
            // FechadeNacimiento
            // 
            FechadeNacimiento.HeaderText = "Fecha de Nacimiento";
            FechadeNacimiento.MinimumWidth = 6;
            FechadeNacimiento.Name = "FechadeNacimiento";
            FechadeNacimiento.Width = 125;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 6;
            Sexo.Name = "Sexo";
            Sexo.Width = 125;
            // 
            // CBPerfil
            // 
            CBPerfil.FormattingEnabled = true;
            CBPerfil.Location = new Point(272, 213);
            CBPerfil.Name = "CBPerfil";
            CBPerfil.Size = new Size(158, 28);
            CBPerfil.TabIndex = 56;
            // 
            // RBHombre
            // 
            RBHombre.AutoSize = true;
            RBHombre.Location = new Point(582, 180);
            RBHombre.Name = "RBHombre";
            RBHombre.Size = new Size(85, 24);
            RBHombre.TabIndex = 55;
            RBHombre.TabStop = true;
            RBHombre.Text = "Hombre";
            RBHombre.UseVisualStyleBackColor = true;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(508, 180);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(68, 24);
            RBMujer.TabIndex = 54;
            RBMujer.TabStop = true;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            // 
            // DTPFechaNac
            // 
            DTPFechaNac.Location = new Point(604, 147);
            DTPFechaNac.Name = "DTPFechaNac";
            DTPFechaNac.Size = new Size(109, 27);
            DTPFechaNac.TabIndex = 53;
            // 
            // TBTelefonoUsuario
            // 
            TBTelefonoUsuario.Location = new Point(527, 117);
            TBTelefonoUsuario.Name = "TBTelefonoUsuario";
            TBTelefonoUsuario.Size = new Size(135, 27);
            TBTelefonoUsuario.TabIndex = 52;
            // 
            // TBDireccionUsuario
            // 
            TBDireccionUsuario.Location = new Point(527, 80);
            TBDireccionUsuario.Name = "TBDireccionUsuario";
            TBDireccionUsuario.Size = new Size(122, 27);
            TBDireccionUsuario.TabIndex = 51;
            // 
            // TBDNIUsuario
            // 
            TBDNIUsuario.Location = new Point(527, 46);
            TBDNIUsuario.Name = "TBDNIUsuario";
            TBDNIUsuario.Size = new Size(122, 27);
            TBDNIUsuario.TabIndex = 50;
            // 
            // TBEmailUsuario
            // 
            TBEmailUsuario.Location = new Point(272, 179);
            TBEmailUsuario.Name = "TBEmailUsuario";
            TBEmailUsuario.Size = new Size(159, 27);
            TBEmailUsuario.TabIndex = 49;
            // 
            // TBContraseñaUsuario
            // 
            TBContraseñaUsuario.Location = new Point(273, 146);
            TBContraseñaUsuario.Name = "TBContraseñaUsuario";
            TBContraseñaUsuario.Size = new Size(158, 27);
            TBContraseñaUsuario.TabIndex = 48;
            // 
            // TBUsuario
            // 
            TBUsuario.Location = new Point(272, 113);
            TBUsuario.Name = "TBUsuario";
            TBUsuario.Size = new Size(159, 27);
            TBUsuario.TabIndex = 47;
            // 
            // TBApellidoUsuario
            // 
            TBApellidoUsuario.Location = new Point(272, 80);
            TBApellidoUsuario.Name = "TBApellidoUsuario";
            TBApellidoUsuario.Size = new Size(159, 27);
            TBApellidoUsuario.TabIndex = 46;
            // 
            // TBNombreUsuario
            // 
            TBNombreUsuario.Location = new Point(272, 47);
            TBNombreUsuario.Name = "TBNombreUsuario";
            TBNombreUsuario.Size = new Size(159, 27);
            TBNombreUsuario.TabIndex = 45;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(449, 181);
            label12.Name = "label12";
            label12.Size = new Size(41, 20);
            label12.TabIndex = 44;
            label12.Text = "Sexo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(449, 147);
            label11.Name = "label11";
            label11.Size = new Size(149, 20);
            label11.TabIndex = 43;
            label11.Text = "Fecha de Nacimiento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(449, 112);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 42;
            label10.Text = "Telefono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(449, 81);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 41;
            label9.Text = "Direccion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(186, 182);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 40;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(449, 47);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 39;
            label7.Text = "DNI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 213);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 38;
            label6.Text = "Perfil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 147);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 37;
            label5.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 49);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 34;
            label2.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 110);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 36;
            label4.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 78);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 35;
            label3.Text = "Apellido";
            // 
            // Gestion_de_Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 624);
            Controls.Add(panel1);
            Name = "Gestion_de_Usuarios";
            Text = "Gestion_de_Usuarios";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Button BUEliminar;
        private Button BUModificar;
        private Button BCancelar;
        private Button BGuardarUsuario;
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
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}