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
            tableLayoutPanel6 = new TableLayoutPanel();
            BMateriasActivas = new Button();
            BMateriasInactivas = new Button();
            DGVGestionSuscripciones = new DataGridView();
            panelCardsSuscripciones = new Panel();
            TBCardsSuscripciones = new TableLayoutPanel();
            panelEncabezadoS = new FlowLayoutPanel();
            LTituloSuscripciones = new Label();
            id_suscripcion = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            activa = new DataGridViewTextBoxColumn();
            fecha_inicio = new DataGridViewTextBoxColumn();
            fecha_fin = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            eliminar = new DataGridViewButtonColumn();
            ver = new DataGridViewButtonColumn();
            panelSuscripcion.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVGestionSuscripciones).BeginInit();
            panelCardsSuscripciones.SuspendLayout();
            panelEncabezadoS.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuscripcion
            // 
            panelSuscripcion.BackColor = SystemColors.ActiveCaption;
            panelSuscripcion.Controls.Add(tableLayoutPanel6);
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
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.Controls.Add(BMateriasActivas, 1, 0);
            tableLayoutPanel6.Controls.Add(BMateriasInactivas, 2, 0);
            tableLayoutPanel6.Location = new Point(12, 306);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1001, 40);
            tableLayoutPanel6.TabIndex = 108;
            // 
            // BMateriasActivas
            // 
            BMateriasActivas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMateriasActivas.BackColor = SystemColors.Highlight;
            BMateriasActivas.FlatAppearance.BorderSize = 0;
            BMateriasActivas.FlatStyle = FlatStyle.Flat;
            BMateriasActivas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BMateriasActivas.ForeColor = SystemColors.ButtonHighlight;
            BMateriasActivas.Location = new Point(804, 3);
            BMateriasActivas.Name = "BMateriasActivas";
            BMateriasActivas.Size = new Size(94, 29);
            BMateriasActivas.TabIndex = 63;
            BMateriasActivas.Text = "Activos";
            BMateriasActivas.UseVisualStyleBackColor = false;
            // 
            // BMateriasInactivas
            // 
            BMateriasInactivas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMateriasInactivas.BackColor = Color.Gray;
            BMateriasInactivas.FlatAppearance.BorderSize = 0;
            BMateriasInactivas.FlatStyle = FlatStyle.Flat;
            BMateriasInactivas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BMateriasInactivas.ForeColor = SystemColors.ButtonHighlight;
            BMateriasInactivas.Location = new Point(904, 3);
            BMateriasInactivas.Name = "BMateriasInactivas";
            BMateriasInactivas.Size = new Size(94, 29);
            BMateriasInactivas.TabIndex = 64;
            BMateriasInactivas.Text = "Inactivos";
            BMateriasInactivas.UseVisualStyleBackColor = false;
            // 
            // DGVGestionSuscripciones
            // 
            DGVGestionSuscripciones.AllowUserToAddRows = false;
            DGVGestionSuscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVGestionSuscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVGestionSuscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVGestionSuscripciones.Columns.AddRange(new DataGridViewColumn[] { id_suscripcion, usuario, activa, fecha_inicio, fecha_fin, tipo, eliminar, ver });
            DGVGestionSuscripciones.Location = new Point(12, 367);
            DGVGestionSuscripciones.Name = "DGVGestionSuscripciones";
            DGVGestionSuscripciones.RowHeadersWidth = 51;
            DGVGestionSuscripciones.Size = new Size(1001, 81);
            DGVGestionSuscripciones.TabIndex = 107;
            // 
            // panelCardsSuscripciones
            // 
            panelCardsSuscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCardsSuscripciones.Controls.Add(TBCardsSuscripciones);
            panelCardsSuscripciones.Location = new Point(20, 81);
            panelCardsSuscripciones.Name = "panelCardsSuscripciones";
            panelCardsSuscripciones.Size = new Size(984, 206);
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
            TBCardsSuscripciones.Size = new Size(984, 206);
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
            // eliminar
            // 
            eliminar.HeaderText = "eliminar";
            eliminar.MinimumWidth = 6;
            eliminar.Name = "eliminar";
            eliminar.Text = "Eliminar";
            eliminar.UseColumnTextForButtonValue = true;
            // 
            // ver
            // 
            ver.HeaderText = "ver";
            ver.MinimumWidth = 6;
            ver.Name = "ver";
            ver.Text = "Ver factura";
            ver.UseColumnTextForButtonValue = true;
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
            tableLayoutPanel6.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel6;
        private Button BMateriasActivas;
        private Button BMateriasInactivas;
        private DataGridViewTextBoxColumn id_suscripcion;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn activa;
        private DataGridViewTextBoxColumn fecha_inicio;
        private DataGridViewTextBoxColumn fecha_fin;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewButtonColumn eliminar;
        private DataGridViewButtonColumn ver;
    }
}