namespace Tematika.Forms;

partial class FormSuscripcion
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
        groupDatosPersonales = new GroupBox();
        lblNombre = new Label();
        txtNombre = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        lblDocumento = new Label();
        txtDocumento = new TextBox();
        groupServicio = new GroupBox();
        txtPrecio = new TextBox();
        lblPlan = new Label();
        cmbPlan = new ComboBox();
        lblPrecio = new Label();
        groupPago = new GroupBox();
        DTPVencimiento = new DateTimePicker();
        labelPlataformaTarjeta = new Label();
        radioTransferencia = new RadioButton();
        radioTarjeta = new RadioButton();
        lblCBU = new Label();
        txtCBU = new TextBox();
        lblBanco = new Label();
        txtBanco = new TextBox();
        lblTitularTransferencia = new Label();
        txtTitularTransferencia = new TextBox();
        lblNumeroTarjeta = new Label();
        txtNumeroTarjeta = new TextBox();
        lblVencimiento = new Label();
        lblCVV = new Label();
        txtCVV = new TextBox();
        lblTitularTarjeta = new Label();
        txtTitularTarjeta = new TextBox();
        btnConfirmar = new Button();
        groupDatosPersonales.SuspendLayout();
        groupServicio.SuspendLayout();
        groupPago.SuspendLayout();
        SuspendLayout();
        // 
        // groupDatosPersonales
        // 
        groupDatosPersonales.BackColor = SystemColors.MenuHighlight;
        groupDatosPersonales.Controls.Add(lblNombre);
        groupDatosPersonales.Controls.Add(txtNombre);
        groupDatosPersonales.Controls.Add(lblEmail);
        groupDatosPersonales.Controls.Add(txtEmail);
        groupDatosPersonales.Controls.Add(lblDocumento);
        groupDatosPersonales.Controls.Add(txtDocumento);
        groupDatosPersonales.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        groupDatosPersonales.Location = new Point(20, 20);
        groupDatosPersonales.Name = "groupDatosPersonales";
        groupDatosPersonales.Size = new Size(360, 150);
        groupDatosPersonales.TabIndex = 0;
        groupDatosPersonales.TabStop = false;
        groupDatosPersonales.Text = "Datos personales";
        // 
        // lblNombre
        // 
        lblNombre.Location = new Point(10, 25);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(100, 23);
        lblNombre.TabIndex = 0;
        lblNombre.Text = "Nombre completo:";
        // 
        // txtNombre
        // 
        txtNombre.Font = new Font("Segoe UI", 9F);
        txtNombre.Location = new Point(150, 22);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(100, 23);
        txtNombre.TabIndex = 1;
        // 
        // lblEmail
        // 
        lblEmail.Location = new Point(10, 55);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(100, 23);
        lblEmail.TabIndex = 2;
        lblEmail.Text = "Correo electrónico:";
        // 
        // txtEmail
        // 
        txtEmail.Font = new Font("Segoe UI", 9F);
        txtEmail.Location = new Point(150, 52);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(100, 23);
        txtEmail.TabIndex = 3;
        // 
        // lblDocumento
        // 
        lblDocumento.Location = new Point(10, 85);
        lblDocumento.Name = "lblDocumento";
        lblDocumento.Size = new Size(100, 23);
        lblDocumento.TabIndex = 4;
        lblDocumento.Text = "Documento:";
        // 
        // txtDocumento
        // 
        txtDocumento.Font = new Font("Segoe UI", 9F);
        txtDocumento.Location = new Point(150, 82);
        txtDocumento.Name = "txtDocumento";
        txtDocumento.Size = new Size(100, 23);
        txtDocumento.TabIndex = 5;
        // 
        // groupServicio
        // 
        groupServicio.BackColor = SystemColors.MenuHighlight;
        groupServicio.Controls.Add(txtPrecio);
        groupServicio.Controls.Add(lblPlan);
        groupServicio.Controls.Add(cmbPlan);
        groupServicio.Controls.Add(lblPrecio);
        groupServicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        groupServicio.Location = new Point(400, 20);
        groupServicio.Name = "groupServicio";
        groupServicio.Size = new Size(360, 150);
        groupServicio.TabIndex = 1;
        groupServicio.TabStop = false;
        groupServicio.Text = "Servicio académico";
        // 
        // txtPrecio
        // 
        txtPrecio.Font = new Font("Segoe UI", 9F);
        txtPrecio.Location = new Point(150, 51);
        txtPrecio.Name = "txtPrecio";
        txtPrecio.ReadOnly = true;
        txtPrecio.Size = new Size(100, 23);
        txtPrecio.TabIndex = 6;
        txtPrecio.Tag = "Precio";
        // 
        // lblPlan
        // 
        lblPlan.Location = new Point(10, 25);
        lblPlan.Name = "lblPlan";
        lblPlan.Size = new Size(100, 23);
        lblPlan.TabIndex = 0;
        lblPlan.Text = "Plan:";
        // 
        // cmbPlan
        // 
        cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPlan.Font = new Font("Segoe UI", 9F);
        cmbPlan.Location = new Point(150, 22);
        cmbPlan.Name = "cmbPlan";
        cmbPlan.Size = new Size(121, 23);
        cmbPlan.TabIndex = 1;
        cmbPlan.Tag = "Plan";
        // 
        // lblPrecio
        // 
        lblPrecio.Location = new Point(10, 55);
        lblPrecio.Name = "lblPrecio";
        lblPrecio.Size = new Size(100, 23);
        lblPrecio.TabIndex = 2;
        lblPrecio.Text = "Precio:";
        // 
        // groupPago
        // 
        groupPago.BackColor = SystemColors.MenuHighlight;
        groupPago.Controls.Add(DTPVencimiento);
        groupPago.Controls.Add(labelPlataformaTarjeta);
        groupPago.Controls.Add(radioTransferencia);
        groupPago.Controls.Add(radioTarjeta);
        groupPago.Controls.Add(lblCBU);
        groupPago.Controls.Add(txtCBU);
        groupPago.Controls.Add(lblBanco);
        groupPago.Controls.Add(txtBanco);
        groupPago.Controls.Add(lblTitularTransferencia);
        groupPago.Controls.Add(txtTitularTransferencia);
        groupPago.Controls.Add(lblNumeroTarjeta);
        groupPago.Controls.Add(txtNumeroTarjeta);
        groupPago.Controls.Add(lblVencimiento);
        groupPago.Controls.Add(lblCVV);
        groupPago.Controls.Add(txtCVV);
        groupPago.Controls.Add(lblTitularTarjeta);
        groupPago.Controls.Add(txtTitularTarjeta);
        groupPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        groupPago.Location = new Point(20, 190);
        groupPago.Name = "groupPago";
        groupPago.Size = new Size(740, 250);
        groupPago.TabIndex = 2;
        groupPago.TabStop = false;
        groupPago.Text = "Método de pago";
        // 
        // DTPVencimiento
        // 
        DTPVencimiento.Format = DateTimePickerFormat.Short;
        DTPVencimiento.Location = new Point(520, 98);
        DTPVencimiento.Name = "DTPVencimiento";
        DTPVencimiento.Size = new Size(100, 23);
        DTPVencimiento.TabIndex = 17;
        DTPVencimiento.Tag = "Vencimiento";
        // 
        // labelPlataformaTarjeta
        // 
        labelPlataformaTarjeta.AutoSize = true;
        labelPlataformaTarjeta.BackColor = Color.Silver;
        labelPlataformaTarjeta.Location = new Point(400, 35);
        labelPlataformaTarjeta.Name = "labelPlataformaTarjeta";
        labelPlataformaTarjeta.Size = new Size(89, 15);
        labelPlataformaTarjeta.TabIndex = 16;
        labelPlataformaTarjeta.Text = "Mercado Pago:";
        // 
        // radioTransferencia
        // 
        radioTransferencia.Checked = true;
        radioTransferencia.Location = new Point(20, 30);
        radioTransferencia.Name = "radioTransferencia";
        radioTransferencia.Size = new Size(200, 24);
        radioTransferencia.TabIndex = 0;
        radioTransferencia.TabStop = true;
        radioTransferencia.Text = "Transferencia bancaria";
        // 
        // radioTarjeta
        // 
        radioTarjeta.Location = new Point(226, 30);
        radioTarjeta.Name = "radioTarjeta";
        radioTarjeta.Size = new Size(104, 24);
        radioTarjeta.TabIndex = 1;
        radioTarjeta.Text = "Tarjeta débito/crédito";
        // 
        // lblCBU
        // 
        lblCBU.Location = new Point(20, 70);
        lblCBU.Name = "lblCBU";
        lblCBU.Size = new Size(100, 23);
        lblCBU.TabIndex = 2;
        lblCBU.Text = "CBU/CVU:";
        // 
        // txtCBU
        // 
        txtCBU.Font = new Font("Segoe UI", 9F);
        txtCBU.Location = new Point(120, 67);
        txtCBU.Name = "txtCBU";
        txtCBU.ReadOnly = true;
        txtCBU.Size = new Size(114, 23);
        txtCBU.TabIndex = 3;
        txtCBU.Text = "46546346546465";
        // 
        // lblBanco
        // 
        lblBanco.Location = new Point(20, 100);
        lblBanco.Name = "lblBanco";
        lblBanco.Size = new Size(100, 23);
        lblBanco.TabIndex = 4;
        lblBanco.Text = "Banco:";
        // 
        // txtBanco
        // 
        txtBanco.Font = new Font("Segoe UI", 9F);
        txtBanco.Location = new Point(120, 97);
        txtBanco.Name = "txtBanco";
        txtBanco.ReadOnly = true;
        txtBanco.Size = new Size(114, 23);
        txtBanco.TabIndex = 5;
        txtBanco.Text = "Banco de Corrientes";
        // 
        // lblTitularTransferencia
        // 
        lblTitularTransferencia.Location = new Point(20, 130);
        lblTitularTransferencia.Name = "lblTitularTransferencia";
        lblTitularTransferencia.Size = new Size(100, 23);
        lblTitularTransferencia.TabIndex = 6;
        lblTitularTransferencia.Text = "Titular:";
        // 
        // txtTitularTransferencia
        // 
        txtTitularTransferencia.Font = new Font("Segoe UI", 9F);
        txtTitularTransferencia.Location = new Point(120, 127);
        txtTitularTransferencia.Name = "txtTitularTransferencia";
        txtTitularTransferencia.ReadOnly = true;
        txtTitularTransferencia.Size = new Size(114, 23);
        txtTitularTransferencia.TabIndex = 7;
        txtTitularTransferencia.Text = "Tematika S.A.";
        // 
        // lblNumeroTarjeta
        // 
        lblNumeroTarjeta.Location = new Point(400, 70);
        lblNumeroTarjeta.Name = "lblNumeroTarjeta";
        lblNumeroTarjeta.Size = new Size(100, 23);
        lblNumeroTarjeta.TabIndex = 8;
        lblNumeroTarjeta.Text = "Número:";
        // 
        // txtNumeroTarjeta
        // 
        txtNumeroTarjeta.Font = new Font("Segoe UI", 9F);
        txtNumeroTarjeta.Location = new Point(520, 67);
        txtNumeroTarjeta.Name = "txtNumeroTarjeta";
        txtNumeroTarjeta.Size = new Size(100, 23);
        txtNumeroTarjeta.TabIndex = 9;
        txtNumeroTarjeta.Tag = "Número";
        txtNumeroTarjeta.KeyPress += txtNumeroTarjeta_KeyPress;
        // 
        // lblVencimiento
        // 
        lblVencimiento.Location = new Point(400, 100);
        lblVencimiento.Name = "lblVencimiento";
        lblVencimiento.Size = new Size(100, 23);
        lblVencimiento.TabIndex = 10;
        lblVencimiento.Text = "Vencimiento:";
        // 
        // lblCVV
        // 
        lblCVV.Location = new Point(400, 130);
        lblCVV.Name = "lblCVV";
        lblCVV.Size = new Size(100, 23);
        lblCVV.TabIndex = 12;
        lblCVV.Text = "CVV:";
        // 
        // txtCVV
        // 
        txtCVV.Font = new Font("Segoe UI", 9F);
        txtCVV.Location = new Point(520, 127);
        txtCVV.Name = "txtCVV";
        txtCVV.Size = new Size(100, 23);
        txtCVV.TabIndex = 13;
        txtCVV.Tag = "CVV";
        txtCVV.KeyPress += txtCVV_KeyPress;
        // 
        // lblTitularTarjeta
        // 
        lblTitularTarjeta.Location = new Point(400, 160);
        lblTitularTarjeta.Name = "lblTitularTarjeta";
        lblTitularTarjeta.Size = new Size(100, 23);
        lblTitularTarjeta.TabIndex = 14;
        lblTitularTarjeta.Text = "Titular:";
        // 
        // txtTitularTarjeta
        // 
        txtTitularTarjeta.Font = new Font("Segoe UI", 9F);
        txtTitularTarjeta.Location = new Point(520, 157);
        txtTitularTarjeta.Name = "txtTitularTarjeta";
        txtTitularTarjeta.Size = new Size(100, 23);
        txtTitularTarjeta.TabIndex = 15;
        txtTitularTarjeta.Tag = "Titular";
        txtTitularTarjeta.KeyPress += txtTitularTarjeta_KeyPress;
        // 
        // btnConfirmar
        // 
        btnConfirmar.BackColor = Color.SteelBlue;
        btnConfirmar.FlatAppearance.BorderColor = Color.Cyan;
        btnConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnConfirmar.Location = new Point(300, 460);
        btnConfirmar.Name = "btnConfirmar";
        btnConfirmar.Size = new Size(247, 37);
        btnConfirmar.TabIndex = 3;
        btnConfirmar.Text = "Confirmar suscripción";
        btnConfirmar.UseVisualStyleBackColor = false;
        btnConfirmar.Click += btnConfirmar_Click;
        // 
        // FormSuscripcion
        // 
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(800, 519);
        Controls.Add(groupDatosPersonales);
        Controls.Add(groupServicio);
        Controls.Add(groupPago);
        Controls.Add(btnConfirmar);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Name = "FormSuscripcion";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Suscripción Académica";
        groupDatosPersonales.ResumeLayout(false);
        groupDatosPersonales.PerformLayout();
        groupServicio.ResumeLayout(false);
        groupServicio.PerformLayout();
        groupPago.ResumeLayout(false);
        groupPago.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.GroupBox groupDatosPersonales;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.TextBox txtDocumento;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblDocumento;

    private System.Windows.Forms.GroupBox groupServicio;
    private System.Windows.Forms.ComboBox cmbPlan;
    private System.Windows.Forms.Label lblPlan;
    private System.Windows.Forms.Label lblPrecio;

    private System.Windows.Forms.GroupBox groupPago;
    private System.Windows.Forms.RadioButton radioTransferencia;
    private System.Windows.Forms.RadioButton radioTarjeta;

    private System.Windows.Forms.TextBox txtCBU;
    private System.Windows.Forms.TextBox txtBanco;
    private System.Windows.Forms.TextBox txtTitularTransferencia;
    private System.Windows.Forms.Label lblCBU;
    private System.Windows.Forms.Label lblBanco;
    private System.Windows.Forms.Label lblTitularTransferencia;

    private System.Windows.Forms.TextBox txtNumeroTarjeta;
    private System.Windows.Forms.TextBox txtCVV;
    private System.Windows.Forms.TextBox txtTitularTarjeta;
    private System.Windows.Forms.Label lblNumeroTarjeta;
    private System.Windows.Forms.Label lblVencimiento;
    private System.Windows.Forms.Label lblCVV;
    private System.Windows.Forms.Label lblTitularTarjeta;

    private System.Windows.Forms.Button btnConfirmar;
    private TextBox txtPrecio;
    private Label labelPlataformaTarjeta;
    private DateTimePicker DTPVencimiento;
}