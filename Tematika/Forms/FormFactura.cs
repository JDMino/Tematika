using System;
using System.Windows.Forms;
using Tematika.Models;

namespace Tematika.Forms
{
    public partial class FormFactura : Form
    {
        private readonly Factura factura;
        private readonly DetalleFactura detalle;

        public FormFactura(Factura factura, DetalleFactura detalle)
        {
            InitializeComponent();
            this.factura = factura;
            this.detalle = detalle;
            Load += FormFactura_Load;
            btnCerrar.Click += (s, e) => Close();
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
            var usuario = SesionManager.UsuarioActual!;
            lblFecha.Text = $"Fecha: {factura.FechaEmision:dd/MM/yyyy}";
            lblNombre.Text = $"Nombre: {usuario.Nombre}";
            lblEmail.Text = $"Email: {usuario.Correo}";
            lblTotal.Text = $"Total: ${factura.Total:0.00}";

            dgvDetalle.Rows.Clear();
            dgvDetalle.Rows.Add(detalle.Descripcion, detalle.Precio.ToString("0.00"));
        }
    }
}
