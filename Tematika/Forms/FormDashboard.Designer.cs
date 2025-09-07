namespace Tematika.Forms
{
    partial class FormDashboard
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
            LDashboard = new Label();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            TBEstadisticas = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            LTitulo1 = new Label();
            tlpTarjetas = new TableLayoutPanel();
            TBActividadRec = new TabPage();
            DGVRecursosRec = new DataGridView();
            Titulo = new DataGridViewTextBoxColumn();
            Tema = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            label1 = new Label();
            DGVUsuariosReg = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            LTitulo2 = new Label();
            panelEncabezado.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            TBEstadisticas.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            TBActividadRec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVRecursosRec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVUsuariosReg).BeginInit();
            SuspendLayout();
            // 
            // panelEncabezado
            // 
            panelEncabezado.Controls.Add(LDashboard);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(1055, 71);
            panelEncabezado.TabIndex = 0;
            // 
            // LDashboard
            // 
            LDashboard.AutoSize = true;
            LDashboard.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LDashboard.Location = new Point(4, 21);
            LDashboard.Name = "LDashboard";
            LDashboard.Size = new Size(159, 38);
            LDashboard.TabIndex = 0;
            LDashboard.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(1055, 548);
            panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TBEstadisticas);
            tabControl1.Controls.Add(TBActividadRec);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1055, 548);
            tabControl1.TabIndex = 0;
            // 
            // TBEstadisticas
            // 
            TBEstadisticas.BackColor = Color.Transparent;
            TBEstadisticas.Controls.Add(tableLayoutPanel1);
            TBEstadisticas.Location = new Point(4, 29);
            TBEstadisticas.Name = "TBEstadisticas";
            TBEstadisticas.Padding = new Padding(3);
            TBEstadisticas.Size = new Size(1047, 515);
            TBEstadisticas.TabIndex = 0;
            TBEstadisticas.Text = "Estadisticas Generales";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(LTitulo1, 0, 0);
            tableLayoutPanel1.Controls.Add(tlpTarjetas, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1041, 509);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // LTitulo1
            // 
            LTitulo1.AutoSize = true;
            LTitulo1.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTitulo1.Location = new Point(3, 0);
            LTitulo1.Name = "LTitulo1";
            LTitulo1.Size = new Size(211, 28);
            LTitulo1.TabIndex = 1;
            LTitulo1.Text = "Resumen del sistema";
            // 
            // tlpTarjetas
            // 
            tlpTarjetas.ColumnCount = 2;
            tlpTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTarjetas.Dock = DockStyle.Fill;
            tlpTarjetas.Location = new Point(3, 53);
            tlpTarjetas.Name = "tlpTarjetas";
            tlpTarjetas.RowCount = 2;
            tlpTarjetas.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTarjetas.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTarjetas.Size = new Size(1035, 453);
            tlpTarjetas.TabIndex = 2;
            // 
            // TBActividadRec
            // 
            TBActividadRec.Controls.Add(DGVRecursosRec);
            TBActividadRec.Controls.Add(label1);
            TBActividadRec.Controls.Add(DGVUsuariosReg);
            TBActividadRec.Controls.Add(LTitulo2);
            TBActividadRec.Location = new Point(4, 29);
            TBActividadRec.Name = "TBActividadRec";
            TBActividadRec.Padding = new Padding(3);
            TBActividadRec.Size = new Size(1047, 515);
            TBActividadRec.TabIndex = 1;
            TBActividadRec.Text = "Actividad reciente";
            TBActividadRec.UseVisualStyleBackColor = true;
            // 
            // DGVRecursosRec
            // 
            DGVRecursosRec.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGVRecursosRec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVRecursosRec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVRecursosRec.Columns.AddRange(new DataGridViewColumn[] { Titulo, Tema, Tipo });
            DGVRecursosRec.Location = new Point(127, 353);
            DGVRecursosRec.Name = "DGVRecursosRec";
            DGVRecursosRec.RowHeadersWidth = 51;
            DGVRecursosRec.Size = new Size(715, 154);
            DGVRecursosRec.TabIndex = 3;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.MinimumWidth = 6;
            Titulo.Name = "Titulo";
            // 
            // Tema
            // 
            Tema.HeaderText = "Tema";
            Tema.MinimumWidth = 6;
            Tema.Name = "Tema";
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 297);
            label1.Name = "label1";
            label1.Size = new Size(232, 28);
            label1.TabIndex = 2;
            label1.Text = "Recursos mas recientes";
            // 
            // DGVUsuariosReg
            // 
            DGVUsuariosReg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGVUsuariosReg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVUsuariosReg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUsuariosReg.Columns.AddRange(new DataGridViewColumn[] { nombre, Correo, Rol, FechaRegistro });
            DGVUsuariosReg.Location = new Point(127, 62);
            DGVUsuariosReg.Name = "DGVUsuariosReg";
            DGVUsuariosReg.RowHeadersWidth = 51;
            DGVUsuariosReg.Size = new Size(715, 188);
            DGVUsuariosReg.TabIndex = 1;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.MinimumWidth = 6;
            FechaRegistro.Name = "FechaRegistro";
            // 
            // LTitulo2
            // 
            LTitulo2.AutoSize = true;
            LTitulo2.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTitulo2.Location = new Point(127, 23);
            LTitulo2.Name = "LTitulo2";
            LTitulo2.Size = new Size(284, 28);
            LTitulo2.TabIndex = 0;
            LTitulo2.Text = "Ultimos Usuarios registrados";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 619);
            Controls.Add(panel2);
            Controls.Add(panelEncabezado);
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            TBEstadisticas.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            TBActividadRec.ResumeLayout(false);
            TBActividadRec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVRecursosRec).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVUsuariosReg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEncabezado;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage TBEstadisticas;
        private TabPage TBActividadRec;
        private DataGridView DGVUsuariosReg;
        private Label LTitulo2;
        private Label LDashboard;
        private Label label1;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridView DGVRecursosRec;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Tema;
        private DataGridViewTextBoxColumn Tipo;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LTitulo1;
        private TableLayoutPanel tlpTarjetas;
    }
}