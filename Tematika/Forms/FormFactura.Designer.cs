
namespace Tematika.Forms;

partial class FormFactura
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblFecha = new Label();
        lblNombre = new Label();
        lblEmail = new Label();
        dgvDetalle = new DataGridView();
        colTipo = new DataGridViewTextBoxColumn();
        colDuracion = new DataGridViewTextBoxColumn();
        colPrecio = new DataGridViewTextBoxColumn();
        lblTotal = new Label();
        btnCerrar = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitulo.ForeColor = SystemColors.Control;
        lblTitulo.Location = new Point(20, 20);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(400, 30);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Factura de Suscripción - Tematika";
        // 
        // lblFecha
        // 
        lblFecha.ForeColor = SystemColors.Control;
        lblFecha.Location = new Point(20, 60);
        lblFecha.Name = "lblFecha";
        lblFecha.Size = new Size(300, 20);
        lblFecha.TabIndex = 1;
        lblFecha.Text = "Fecha: ";
        // 
        // lblNombre
        // 
        lblNombre.ForeColor = SystemColors.Control;
        lblNombre.Location = new Point(20, 90);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(300, 20);
        lblNombre.TabIndex = 2;
        lblNombre.Text = "Nombre: ";
        // 
        // lblEmail
        // 
        lblEmail.ForeColor = SystemColors.Control;
        lblEmail.Location = new Point(20, 120);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(300, 20);
        lblEmail.TabIndex = 3;
        lblEmail.Text = "Email: ";
        // 
        // dgvDetalle
        // 
        dgvDetalle.AllowUserToAddRows = false;
        dgvDetalle.AllowUserToDeleteRows = false;
        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { colTipo, colDuracion, colPrecio });
        dgvDetalle.Location = new Point(20, 160);
        dgvDetalle.Name = "dgvDetalle";
        dgvDetalle.ReadOnly = true;
        dgvDetalle.Size = new Size(500, 100);
        dgvDetalle.TabIndex = 4;
        // 
        // colTipo
        // 
        colTipo.HeaderText = "Tipo de suscripción";
        colTipo.Name = "colTipo";
        colTipo.ReadOnly = true;
        // 
        // colDuracion
        // 
        colDuracion.HeaderText = "Duración";
        colDuracion.Name = "colDuracion";
        colDuracion.ReadOnly = true;
        // 
        // colPrecio
        // 
        colPrecio.HeaderText = "Precio";
        colPrecio.Name = "colPrecio";
        colPrecio.ReadOnly = true;
        // 
        // lblTotal
        // 
        lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTotal.ForeColor = SystemColors.Control;
        lblTotal.Location = new Point(20, 280);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(300, 25);
        lblTotal.TabIndex = 5;
        lblTotal.Text = "Total: $";
        // 
        // btnCerrar
        // 
        btnCerrar.ForeColor = SystemColors.Control;
        btnCerrar.Location = new Point(420, 320);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Size = new Size(100, 30);
        btnCerrar.TabIndex = 6;
        btnCerrar.Text = "Cerrar";
        btnCerrar.Click += btnCerrar_Click;
        // 
        // FormFactura
        // 
        BackColor = SystemColors.MenuHighlight;
        ClientSize = new Size(560, 380);
        Controls.Add(lblTitulo);
        Controls.Add(lblFecha);
        Controls.Add(lblNombre);
        Controls.Add(lblEmail);
        Controls.Add(dgvDetalle);
        Controls.Add(lblTotal);
        Controls.Add(btnCerrar);
        Name = "FormFactura";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Factura";
        ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblFecha;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.DataGridView dgvDetalle;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDuracion;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.Button btnCerrar;
}