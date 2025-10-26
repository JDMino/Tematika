using System;
using System.Windows.Forms;
using Tematika.Models;
using Tematika.CapaDeNegocio;
using Tematika.Utils;

namespace Tematika.Forms
{
    public partial class FormSuscripcion : Form
    {
        private readonly TipoSuscripcionService tipoService = new TipoSuscripcionService();
        private readonly SuscripcionService suscripcionService = new SuscripcionService();
        private readonly FacturaService facturaService = new FacturaService();
        private readonly DetalleFacturaService detalleService = new DetalleFacturaService();

        public FormSuscripcion()
        {
            InitializeComponent();
            Load += FormSuscripcion_Load;
            //btnConfirmar.Click += btnConfirmar_Click;
            radioTransferencia.CheckedChanged += ActualizarCamposPago;
            radioTarjeta.CheckedChanged += ActualizarCamposPago;
        }

        private void FormSuscripcion_Load(object sender, EventArgs e)
        {
            var usuario = SesionManager.UsuarioActual;
            if (usuario == null) return;

            txtNombre.Text = usuario.Nombre;
            txtEmail.Text = usuario.Correo;
            txtDocumento.Text = usuario.Dni.ToString();
            txtNombre.Enabled = txtEmail.Enabled = txtDocumento.Enabled = false;

            var planes = tipoService.ObtenerPlanes();
            cmbPlan.DataSource = planes;
            cmbPlan.DisplayMember = "Nombre";
            cmbPlan.ValueMember = "IdTipoSuscripcion";
            cmbPlan.SelectedIndexChanged += (s, ev) =>
            {
                if (cmbPlan.SelectedItem is TipoSuscripcion tipo)
                    txtPrecio.Text = tipo.Precio.ToString("0.00");
                else
                    txtPrecio.Text = "";
            };
            cmbPlan.SelectedIndex = -1;

            ActualizarCamposPago(null, null);
        }

        private void ActualizarCamposPago(object sender, EventArgs e)
        {
            bool transferencia = radioTransferencia.Checked;

            txtCBU.Enabled = txtBanco.Enabled = txtTitularTransferencia.Enabled = transferencia;
            txtNumeroTarjeta.Enabled = txtVencimiento.Enabled = txtCVV.Enabled = txtTitularTarjeta.Enabled = !transferencia;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposObligatorios(groupDatosPersonales) ||
                !Validaciones.ValidarCamposObligatorios(groupServicio))
                //!Validaciones.ValidarCamposObligatorios(groupPago))
                return;

            var confirm = MessageBox.Show("¿Desea confirmar la suscripción?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            var usuario = SesionManager.UsuarioActual!;
            var tipo = (TipoSuscripcion)cmbPlan.SelectedItem!;
            var fechaInicio = DateTime.Now;

            var suscripcion = new Suscripcion
            {
                IdUsuario = usuario.IdUsuario,
                IdTipoSuscripcion = tipo.IdTipoSuscripcion,
                Activa = true,
                FechaInicio = fechaInicio
            };

            int idSuscripcion = suscripcionService.CrearSuscripcion(suscripcion);

            string metodo = radioTransferencia.Checked ? "Transferencia" : "Tarjeta";
            string descripcion = radioTransferencia.Checked
                ? $"CBU: {txtCBU.Text}, Banco: {txtBanco.Text}, Titular: {txtTitularTransferencia.Text}"
                : $"Tarjeta: {txtNumeroTarjeta.Text}, Vencimiento: {txtVencimiento.Text}, CVV: {txtCVV.Text}, Titular: {txtTitularTarjeta.Text}";

            var factura = new Factura
            {
                IdUsuario = usuario.IdUsuario,
                IdSuscripcion = idSuscripcion,
                FechaEmision = DateTime.Now,
                Total = tipo.Precio,
                MetodoPago = metodo,
                DescripcionPago = descripcion
            };

            int idFactura = facturaService.CrearFactura(factura);

            var detalle = new DetalleFactura
            {
                IdFactura = idFactura,
                Descripcion = tipo.Nombre,
                Precio = tipo.Precio
            };

            detalleService.CrearDetalle(detalle);

            var formFactura = new FormFactura(factura, detalle, usuario);
            formFactura.Show();
            Close();
        }
    }
}
