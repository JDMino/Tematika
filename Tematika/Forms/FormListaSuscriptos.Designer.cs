namespace Tematika.Forms
{
    partial class FormListaSuscriptos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelSuscripcion = new Panel();
            btnExportarPDF = new Button();
            DGVGestionSuscripciones = new DataGridView();
            id_suscripcion = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            activa = new DataGridViewTextBoxColumn();
            fecha_inicio = new DataGridViewTextBoxColumn();
            fecha_fin = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            verFactura = new DataGridViewButtonColumn();
            darDeBaja = new DataGridViewButtonColumn();
            panelCardsSuscripciones = new Panel();
            TBCardsSuscripciones = new TableLayoutPanel();
            panelEncabezadoS = new FlowLayoutPanel();
            LTituloSuscripciones = new Label();
            panelSuscripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVGestionSuscripciones).BeginInit();
            panelCardsSuscripciones.SuspendLayout();
            panelEncabezadoS.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuscripcion
            // 
            panelSuscripcion.BackColor = SystemColors.ActiveCaption;
            panelSuscripcion.Controls.Add(btnExportarPDF);
            panelSuscripcion.Controls.Add(DGVGestionSuscripciones);
            panelSuscripcion.Controls.Add(panelCardsSuscripciones);
            panelSuscripcion.Controls.Add(panelEncabezadoS);
            panelSuscripcion.Dock = DockStyle.Fill;
            panelSuscripcion.Location = new Point(0, 0);
            panelSuscripcion.Margin = new Padding(3, 4, 3, 4);
            panelSuscripcion.Name = "panelSuscripcion";
            panelSuscripcion.Size = new Size(1026, 543);
            panelSuscripcion.TabIndex = 1;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.BackColor = Color.RoyalBlue;
            btnExportarPDF.FlatAppearance.BorderSize = 0;
            btnExportarPDF.FlatStyle = FlatStyle.Flat;
            btnExportarPDF.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarPDF.ForeColor = SystemColors.ButtonHighlight;
            btnExportarPDF.Location = new Point(32, 319);
            btnExportarPDF.Margin = new Padding(3, 4, 3, 4);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(144, 35);
            btnExportarPDF.TabIndex = 108;
            btnExportarPDF.Text = "Exportar a PDF";
            btnExportarPDF.UseVisualStyleBackColor = false;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // DGVGestionSuscripciones
            // 
            DGVGestionSuscripciones.AllowUserToAddRows = false;
            DGVGestionSuscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVGestionSuscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVGestionSuscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVGestionSuscripciones.Columns.AddRange(new DataGridViewColumn[] { id_suscripcion, usuario, activa, fecha_inicio, fecha_fin, tipo, Precio, verFactura, darDeBaja });
            DGVGestionSuscripciones.Location = new Point(11, 367);
            DGVGestionSuscripciones.Name = "DGVGestionSuscripciones";
            DGVGestionSuscripciones.ReadOnly = true;
            DGVGestionSuscripciones.RowHeadersWidth = 51;
            DGVGestionSuscripciones.Size = new Size(1001, 81);
            DGVGestionSuscripciones.TabIndex = 107;
            // 
            // id_suscripcion
            // 
            id_suscripcion.HeaderText = "id_suscripcion";
            id_suscripcion.MinimumWidth = 6;
            id_suscripcion.Name = "id_suscripcion";
            id_suscripcion.ReadOnly = true;
            // 
            // usuario
            // 
            usuario.HeaderText = "usuario";
            usuario.MinimumWidth = 6;
            usuario.Name = "usuario";
            usuario.ReadOnly = true;
            // 
            // activa
            // 
            activa.HeaderText = "activa";
            activa.MinimumWidth = 6;
            activa.Name = "activa";
            activa.ReadOnly = true;
            // 
            // fecha_inicio
            // 
            fecha_inicio.HeaderText = "fecha_inicio";
            fecha_inicio.MinimumWidth = 6;
            fecha_inicio.Name = "fecha_inicio";
            fecha_inicio.ReadOnly = true;
            // 
            // fecha_fin
            // 
            fecha_fin.HeaderText = "fecha_fin";
            fecha_fin.MinimumWidth = 6;
            fecha_fin.Name = "fecha_fin";
            fecha_fin.ReadOnly = true;
            // 
            // tipo
            // 
            tipo.HeaderText = "tipo";
            tipo.MinimumWidth = 6;
            tipo.Name = "tipo";
            tipo.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // verFactura
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Green;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Green;
            verFactura.DefaultCellStyle = dataGridViewCellStyle1;
            verFactura.FlatStyle = FlatStyle.Flat;
            verFactura.HeaderText = "Ver Factura";
            verFactura.MinimumWidth = 6;
            verFactura.Name = "verFactura";
            verFactura.ReadOnly = true;
            verFactura.Text = "Ver factura";
            verFactura.UseColumnTextForButtonValue = true;
            // 
            // darDeBaja
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 0, 0);
            darDeBaja.DefaultCellStyle = dataGridViewCellStyle2;
            darDeBaja.FlatStyle = FlatStyle.Flat;
            darDeBaja.HeaderText = "Dar de Baja";
            darDeBaja.MinimumWidth = 6;
            darDeBaja.Name = "darDeBaja";
            darDeBaja.ReadOnly = true;
            darDeBaja.Text = "Dar de Baja";
            darDeBaja.UseColumnTextForButtonValue = true;
            // 
            // panelCardsSuscripciones
            // 
            panelCardsSuscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCardsSuscripciones.Controls.Add(TBCardsSuscripciones);
            panelCardsSuscripciones.Location = new Point(21, 81);
            panelCardsSuscripciones.Name = "panelCardsSuscripciones";
            panelCardsSuscripciones.Size = new Size(984, 205);
            panelCardsSuscripciones.TabIndex = 106;
            // 
            // TBCardsSuscripciones
            // 
            TBCardsSuscripciones.ColumnCount = 3;
            TBCardsSuscripciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TBCardsSuscripciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TBCardsSuscripciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TBCardsSuscripciones.Dock = DockStyle.Fill;
            TBCardsSuscripciones.Location = new Point(0, 0);
            TBCardsSuscripciones.Name = "TBCardsSuscripciones";
            TBCardsSuscripciones.RowCount = 2;
            TBCardsSuscripciones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TBCardsSuscripciones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TBCardsSuscripciones.Size = new Size(984, 205);
            TBCardsSuscripciones.TabIndex = 105;
            // 
            // panelEncabezadoS
            // 
            panelEncabezadoS.Controls.Add(LTituloSuscripciones);
            panelEncabezadoS.Dock = DockStyle.Top;
            panelEncabezadoS.Location = new Point(0, 0);
            panelEncabezadoS.Name = "panelEncabezadoS";
            panelEncabezadoS.Size = new Size(1026, 64);
            panelEncabezadoS.TabIndex = 104;
            // 
            // LTituloSuscripciones
            // 
            LTituloSuscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LTituloSuscripciones.AutoSize = true;
            LTituloSuscripciones.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloSuscripciones.Location = new Point(3, 0);
            LTituloSuscripciones.Name = "LTituloSuscripciones";
            LTituloSuscripciones.Size = new Size(341, 38);
            LTituloSuscripciones.TabIndex = 1;
            LTituloSuscripciones.Text = "Gestion de Suscripciones";
            // 
            // FormListaSuscriptos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 543);
            Controls.Add(panelSuscripcion);
            Name = "FormListaSuscriptos";
            Text = "FormListaSuscriptos";
            Load += FormListaSuscriptos_Load;
            panelSuscripcion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVGestionSuscripciones).EndInit();
            panelCardsSuscripciones.ResumeLayout(false);
            panelEncabezadoS.ResumeLayout(false);
            panelEncabezadoS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuscripcion;
        private FlowLayoutPanel panelEncabezadoS;
        private Label LTituloSuscripciones;
        private DataGridView DGVGestionSuscripciones;
        private Panel panelCardsSuscripciones;
        private TableLayoutPanel TBCardsSuscripciones;
        private Button btnExportarPDF;
        private DataGridViewTextBoxColumn id_suscripcion;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn activa;
        private DataGridViewTextBoxColumn fecha_inicio;
        private DataGridViewTextBoxColumn fecha_fin;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewButtonColumn verFactura;
        private DataGridViewButtonColumn darDeBaja;
    }
}