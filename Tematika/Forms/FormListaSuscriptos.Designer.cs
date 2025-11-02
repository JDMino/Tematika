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
            panelGestionPrecios = new Panel();
            buttonActualizar = new Button();
            TBPrecio = new TextBox();
            CBTiposSuscripcion = new ComboBox();
            labelPrecio = new Label();
            labelTipoSuscripcion = new Label();
            labelGestionPrecios = new Label();
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
            panelGestionPrecios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVGestionSuscripciones).BeginInit();
            panelCardsSuscripciones.SuspendLayout();
            panelEncabezadoS.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuscripcion
            // 
            panelSuscripcion.AutoScroll = true;
            panelSuscripcion.AutoSize = true;
            panelSuscripcion.BackColor = SystemColors.ActiveCaption;
            panelSuscripcion.Controls.Add(panelGestionPrecios);
            panelSuscripcion.Controls.Add(btnExportarPDF);
            panelSuscripcion.Controls.Add(DGVGestionSuscripciones);
            panelSuscripcion.Controls.Add(panelCardsSuscripciones);
            panelSuscripcion.Controls.Add(panelEncabezadoS);
            panelSuscripcion.Dock = DockStyle.Fill;
            panelSuscripcion.Location = new Point(0, 0);
            panelSuscripcion.Name = "panelSuscripcion";
            panelSuscripcion.Size = new Size(898, 466);
            panelSuscripcion.TabIndex = 1;
            // 
            // panelGestionPrecios
            // 
            panelGestionPrecios.BackColor = SystemColors.GrayText;
            panelGestionPrecios.Controls.Add(buttonActualizar);
            panelGestionPrecios.Controls.Add(TBPrecio);
            panelGestionPrecios.Controls.Add(CBTiposSuscripcion);
            panelGestionPrecios.Controls.Add(labelPrecio);
            panelGestionPrecios.Controls.Add(labelTipoSuscripcion);
            panelGestionPrecios.Controls.Add(labelGestionPrecios);
            panelGestionPrecios.Location = new Point(12, 460);
            panelGestionPrecios.Name = "panelGestionPrecios";
            panelGestionPrecios.Size = new Size(431, 127);
            panelGestionPrecios.TabIndex = 109;
            panelGestionPrecios.Paint += panel1_Paint;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = SystemColors.Highlight;
            buttonActualizar.Location = new Point(298, 81);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(83, 27);
            buttonActualizar.TabIndex = 5;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = false;
            // 
            // TBPrecio
            // 
            TBPrecio.Location = new Point(140, 81);
            TBPrecio.Name = "TBPrecio";
            TBPrecio.Size = new Size(121, 23);
            TBPrecio.TabIndex = 4;
            // 
            // CBTiposSuscripcion
            // 
            CBTiposSuscripcion.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTiposSuscripcion.FormattingEnabled = true;
            CBTiposSuscripcion.Location = new Point(140, 46);
            CBTiposSuscripcion.Name = "CBTiposSuscripcion";
            CBTiposSuscripcion.Size = new Size(121, 23);
            CBTiposSuscripcion.TabIndex = 3;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(16, 84);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(43, 15);
            labelPrecio.TabIndex = 2;
            labelPrecio.Text = "Precio:";
            // 
            // labelTipoSuscripcion
            // 
            labelTipoSuscripcion.AutoSize = true;
            labelTipoSuscripcion.Location = new Point(14, 49);
            labelTipoSuscripcion.Name = "labelTipoSuscripcion";
            labelTipoSuscripcion.Size = new Size(113, 15);
            labelTipoSuscripcion.TabIndex = 1;
            labelTipoSuscripcion.Text = "Tipo de Suscripción:";
            // 
            // labelGestionPrecios
            // 
            labelGestionPrecios.AutoSize = true;
            labelGestionPrecios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGestionPrecios.ForeColor = SystemColors.ControlLightLight;
            labelGestionPrecios.Location = new Point(16, 14);
            labelGestionPrecios.Name = "labelGestionPrecios";
            labelGestionPrecios.Size = new Size(150, 21);
            labelGestionPrecios.TabIndex = 0;
            labelGestionPrecios.Text = "Gestión de Precios";
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.BackColor = Color.RoyalBlue;
            btnExportarPDF.FlatAppearance.BorderSize = 0;
            btnExportarPDF.FlatStyle = FlatStyle.Flat;
            btnExportarPDF.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarPDF.ForeColor = SystemColors.ButtonHighlight;
            btnExportarPDF.Location = new Point(28, 239);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(126, 26);
            btnExportarPDF.TabIndex = 108;
            btnExportarPDF.Text = "Exportar a PDF";
            btnExportarPDF.UseVisualStyleBackColor = false;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // DGVGestionSuscripciones
            // 
            DGVGestionSuscripciones.AllowUserToAddRows = false;
            DGVGestionSuscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGVGestionSuscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVGestionSuscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVGestionSuscripciones.Columns.AddRange(new DataGridViewColumn[] { id_suscripcion, usuario, activa, fecha_inicio, fecha_fin, tipo, Precio, verFactura, darDeBaja });
            DGVGestionSuscripciones.Location = new Point(10, 275);
            DGVGestionSuscripciones.Margin = new Padding(3, 2, 3, 2);
            DGVGestionSuscripciones.Name = "DGVGestionSuscripciones";
            DGVGestionSuscripciones.ReadOnly = true;
            DGVGestionSuscripciones.RowHeadersWidth = 51;
            DGVGestionSuscripciones.Size = new Size(808, 180);
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
            panelCardsSuscripciones.Location = new Point(18, 61);
            panelCardsSuscripciones.Margin = new Padding(3, 2, 3, 2);
            panelCardsSuscripciones.Name = "panelCardsSuscripciones";
            panelCardsSuscripciones.Size = new Size(793, 154);
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
            TBCardsSuscripciones.Size = new Size(793, 154);
            TBCardsSuscripciones.TabIndex = 105;
            // 
            // panelEncabezadoS
            // 
            panelEncabezadoS.Controls.Add(LTituloSuscripciones);
            panelEncabezadoS.Dock = DockStyle.Top;
            panelEncabezadoS.Location = new Point(0, 0);
            panelEncabezadoS.Margin = new Padding(3, 2, 3, 2);
            panelEncabezadoS.Name = "panelEncabezadoS";
            panelEncabezadoS.Size = new Size(881, 48);
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
            // FormListaSuscriptos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(898, 466);
            Controls.Add(panelSuscripcion);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormListaSuscriptos";
            Text = "FormListaSuscriptos";
            Load += FormListaSuscriptos_Load;
            panelSuscripcion.ResumeLayout(false);
            panelGestionPrecios.ResumeLayout(false);
            panelGestionPrecios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVGestionSuscripciones).EndInit();
            panelCardsSuscripciones.ResumeLayout(false);
            panelEncabezadoS.ResumeLayout(false);
            panelEncabezadoS.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Panel panelGestionPrecios;
        private Label labelGestionPrecios;
        private Label labelPrecio;
        private Label labelTipoSuscripcion;
        private Button buttonActualizar;
        private TextBox TBPrecio;
        private ComboBox CBTiposSuscripcion;
    }
}