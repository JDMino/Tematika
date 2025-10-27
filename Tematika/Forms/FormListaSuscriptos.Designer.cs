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
            panelSuscripcion = new Panel();
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
            btnExportarPDF = new Button();
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
            panelSuscripcion.Name = "panelSuscripcion";
            panelSuscripcion.Size = new Size(898, 407);
            panelSuscripcion.TabIndex = 1;
            // 
            // DGVGestionSuscripciones
            // 
            DGVGestionSuscripciones.AllowUserToAddRows = false;
            DGVGestionSuscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVGestionSuscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVGestionSuscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVGestionSuscripciones.Columns.AddRange(new DataGridViewColumn[] { id_suscripcion, usuario, activa, fecha_inicio, fecha_fin, tipo, Precio, verFactura, darDeBaja });
            DGVGestionSuscripciones.Location = new Point(10, 275);
            DGVGestionSuscripciones.Margin = new Padding(3, 2, 3, 2);
            DGVGestionSuscripciones.Name = "DGVGestionSuscripciones";
            DGVGestionSuscripciones.RowHeadersWidth = 51;
            DGVGestionSuscripciones.Size = new Size(876, 61);
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
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // verFactura
            // 
            verFactura.HeaderText = "Ver Factura";
            verFactura.MinimumWidth = 6;
            verFactura.Name = "verFactura";
            verFactura.Text = "Ver factura";
            verFactura.UseColumnTextForButtonValue = true;
            // 
            // darDeBaja
            // 
            darDeBaja.HeaderText = "Dar de Baja";
            darDeBaja.MinimumWidth = 6;
            darDeBaja.Name = "darDeBaja";
            darDeBaja.Text = "Dar de Baja";
            darDeBaja.UseColumnTextForButtonValue = true;
            // 
            // panelCardsSuscripciones
            // 
            panelCardsSuscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCardsSuscripciones.Controls.Add(TBCardsSuscripciones);
            panelCardsSuscripciones.Location = new Point(18, 61);
            panelCardsSuscripciones.Margin = new Padding(3, 2, 3, 2);
            panelCardsSuscripciones.Name = "panelCardsSuscripciones";
            panelCardsSuscripciones.Size = new Size(861, 154);
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
            TBCardsSuscripciones.Margin = new Padding(3, 2, 3, 2);
            TBCardsSuscripciones.Name = "TBCardsSuscripciones";
            TBCardsSuscripciones.RowCount = 2;
            TBCardsSuscripciones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TBCardsSuscripciones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TBCardsSuscripciones.Size = new Size(861, 154);
            TBCardsSuscripciones.TabIndex = 105;
            // 
            // panelEncabezadoS
            // 
            panelEncabezadoS.Controls.Add(LTituloSuscripciones);
            panelEncabezadoS.Dock = DockStyle.Top;
            panelEncabezadoS.Location = new Point(0, 0);
            panelEncabezadoS.Margin = new Padding(3, 2, 3, 2);
            panelEncabezadoS.Name = "panelEncabezadoS";
            panelEncabezadoS.Size = new Size(898, 48);
            panelEncabezadoS.TabIndex = 104;
            // 
            // LTituloSuscripciones
            // 
            LTituloSuscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LTituloSuscripciones.AutoSize = true;
            LTituloSuscripciones.Font = new Font("Ebrima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTituloSuscripciones.Location = new Point(3, 0);
            LTituloSuscripciones.Name = "LTituloSuscripciones";
            LTituloSuscripciones.Size = new Size(270, 30);
            LTituloSuscripciones.TabIndex = 1;
            LTituloSuscripciones.Text = "Gestion de Suscripciones";
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Location = new Point(28, 239);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(126, 26);
            btnExportarPDF.TabIndex = 108;
            btnExportarPDF.Text = "Exportar a PDF";
            btnExportarPDF.UseVisualStyleBackColor = true;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // FormListaSuscriptos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 407);
            Controls.Add(panelSuscripcion);
            Margin = new Padding(3, 2, 3, 2);
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
        private DataGridViewTextBoxColumn id_suscripcion;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn activa;
        private DataGridViewTextBoxColumn fecha_inicio;
        private DataGridViewTextBoxColumn fecha_fin;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewButtonColumn verFactura;
        private DataGridViewButtonColumn darDeBaja;
        private Button btnExportarPDF;
    }
}