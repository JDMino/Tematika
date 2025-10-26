using System;
using System.Windows.Forms;
using Tematika.Models;

namespace Tematika.Forms
{
    public partial class FormFactura : Form
    {
        private readonly Factura factura;
        private readonly DetalleFactura detalle;
        private readonly Usuario usuarioDueño;

        public FormFactura(Factura factura, DetalleFactura detalle, Usuario usuarioDueño)
        {
            InitializeComponent();
            this.factura = factura;
            this.detalle = detalle;
            this.usuarioDueño = usuarioDueño;
            Load += FormFactura_Load;
            btnCerrar.Click += (s, e) => Close();
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
            lblFecha.Text = $"Fecha: {factura.FechaEmision:dd/MM/yyyy}";
            lblNombre.Text = $"Nombre: {usuarioDueño.Nombre} {usuarioDueño.Apellido}";
            lblEmail.Text = $"Email: {usuarioDueño.Correo}";
            lblTotal.Text = $"Total: ${factura.Total:0.00}";

            dgvDetalle.Rows.Clear();
            dgvDetalle.Rows.Add(detalle.Descripcion, detalle.Precio.ToString("0.00"));
        }
    }
}
