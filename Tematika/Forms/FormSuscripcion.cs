using System;
using System.Windows.Forms;
using Tematika.Models;
using Tematika.CapaDeNegocio;
using Tematika.Utils;
using System.Reflection.Metadata.Ecma335;

namespace Tematika.Forms
{
    // Formulario que permite al usuario realizar una suscripción a un plan
    public partial class FormSuscripcion : Form
    {
        // Servicios para manejar tipos de suscripción, suscripciones, facturas y detalles de factura
        private readonly TipoSuscripcionService tipoService = new TipoSuscripcionService();
        private readonly SuscripcionService suscripcionService = new SuscripcionService();
        private readonly FacturaService facturaService = new FacturaService();
        private readonly DetalleFacturaService detalleService = new DetalleFacturaService();

        public FormSuscripcion()
        {
            InitializeComponent();

            // Eventos del formulario
            Load += FormSuscripcion_Load; // Al cargar el formulario
                                          //btnConfirmar.Click += btnConfirmar_Click; // Confirmar suscripción (comentado, se activa en diseño)

            // Cambios en el método de pago
            radioTransferencia.CheckedChanged += ActualizarCamposPago;
            radioTarjeta.CheckedChanged += ActualizarCamposPago;

            // Validaciones de entrada para los campos de texto
            txtTitularTransferencia.KeyPress += (s, e) => Validaciones.ValidarTextoConCaracteresEspeciales(e);
            txtBanco.KeyPress += (s, e) => Validaciones.ValidarTextoConCaracteresEspeciales(e);
        }

        // Evento al cargar el formulario
        private void FormSuscripcion_Load(object sender, EventArgs e)
        {
            var usuario = SesionManager.UsuarioActual;
            if (usuario == null) return; // Si no hay usuario logueado, no hacemos nada

            // Rellenamos los campos con datos del usuario
            txtNombre.Text = usuario.Nombre;
            txtEmail.Text = usuario.Correo;
            txtDocumento.Text = usuario.Dni.ToString();

            // Bloqueamos la edición de estos campos
            txtNombre.Enabled = txtEmail.Enabled = txtDocumento.Enabled = false;

            // Obtenemos los planes de suscripción disponibles
            var planes = tipoService.ObtenerPlanes();
            cmbPlan.DataSource = planes; // Asignamos la lista al combo
            cmbPlan.DisplayMember = "Nombre"; // Propiedad que se mostrará
            cmbPlan.ValueMember = "IdTipoSuscripcion"; // Propiedad interna
            cmbPlan.SelectedIndexChanged += (s, ev) =>
            {
                // Al cambiar el plan, actualizamos el precio mostrado
                if (cmbPlan.SelectedItem is TipoSuscripcion tipo)
                    txtPrecio.Text = tipo.Precio.ToString("0.00");
                else
                    txtPrecio.Text = "";
            };
            cmbPlan.SelectedIndex = -1; // Ningún plan seleccionado inicialmente

            // Evita escribir manualmente en el DateTimePicker
            DTPVencimiento.KeyDown += (s, ev) => ev.SuppressKeyPress = true;


            // Actualizamos los campos de pago según el método seleccionado
            ActualizarCamposPago(null, null);
        }

        // Habilita o deshabilita los campos según el método de pago seleccionado
        private void ActualizarCamposPago(object sender, EventArgs e)
        {
            bool transferencia = radioTransferencia.Checked;

            // Si es transferencia, habilitamos campos de transferencia
            txtCBU.Enabled = txtBanco.Enabled = txtTitularTransferencia.Enabled = transferencia;

            // Si es tarjeta, habilitamos campos de tarjeta y deshabilitamos los de transferencia
            txtNumeroTarjeta.Enabled = DTPVencimiento.Enabled = txtCVV.Enabled = txtTitularTarjeta.Enabled = !transferencia;
        }

        // Evento al hacer clic en "Confirmar suscripción"
        private void btnConfirmar_Click(object sender, EventArgs e)
        {


            // Validamos que los campos obligatorios estén completos
            if (!Validaciones.ValidarCamposObligatorios(groupDatosPersonales) ||
                !Validaciones.ValidarCamposObligatorios(groupServicio))
                return;

            var controlesObligatorios = new List<Control> { cmbPlan }; // Plan siempre obligatorio

            // Añadimos campos obligatorios según el método de pago
            if (radioTransferencia.Checked)
            {
                controlesObligatorios.AddRange(new[] { txtCBU, txtBanco, txtTitularTransferencia });
            }
            else if (radioTarjeta.Checked)
            {

                // Si la fecha seleccionada es anterior a hoy, no se puede avanzar
                if (DTPVencimiento.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("La fecha de vencimiento no puede ser anterior a hoy.",
                                    "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DTPVencimiento.Focus();
                    return;
                }


                // Numero de tarjeta debe tener 16 dígitos
                string numeroTarjeta = txtNumeroTarjeta.Text.Trim();

                if (!System.Text.RegularExpressions.Regex.IsMatch(numeroTarjeta, @"^\d{16}$"))
                {
                    MessageBox.Show("El número de tarjeta debe contener 16 dígitos.",
                                    "Validación de Número de Tarjeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumeroTarjeta.Focus();
                    return;
                }

                // CVV debe tener 3 digitos
                string numeroCVV = txtCVV.Text.Trim();

                if (!System.Text.RegularExpressions.Regex.IsMatch(numeroCVV, @"^\d{3}$"))
                {
                    MessageBox.Show("El código CVV debe tener 3 dígitos.",
                                    "Validación de CVV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCVV.Focus();
                    return;
                }

                // Nombre de titular debe tener como minimo 5 caracteres
                string cantidadLetrasTitular = txtTitularTarjeta.Text.Trim();

                if (cantidadLetrasTitular.Length < 5)
                {
                    MessageBox.Show("El campo Titular debe tener como mínimo 5 caracteres.",
                                    "Validación de Titular", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTitularTarjeta.Focus();
                    return;
                }


                // Agregar los controles a la lista de controles obligatorios
                controlesObligatorios.AddRange(new[] { txtNumeroTarjeta, txtCVV, txtTitularTarjeta });
            }

            // Validamos que todos los controles obligatorios tengan datos
            if (!Validaciones.ValidarControlesObligatorios(controlesObligatorios))
                return;



            // Confirmación del usuario
            var confirm = MessageBox.Show("¿Desea confirmar la suscripción?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            // Datos del usuario y plan seleccionado
            var usuario = SesionManager.UsuarioActual!;
            var tipo = (TipoSuscripcion)cmbPlan.SelectedItem!;
            var fechaInicio = DateTime.Now;

            // Creamos la suscripción
            var suscripcion = new Suscripcion
            {
                IdUsuario = usuario.IdUsuario,
                IdTipoSuscripcion = tipo.IdTipoSuscripcion,
                Activa = true,
                FechaInicio = fechaInicio
            };
            int idSuscripcion = suscripcionService.CrearSuscripcion(suscripcion);

            // Creamos la factura asociada a la suscripción
            string metodo = radioTransferencia.Checked ? "Transferencia" : "Tarjeta";
            string descripcion = "Pago Exitoso";

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

            // Creamos el detalle de la factura
            var detalle = new DetalleFactura
            {
                IdFactura = idFactura,
                Descripcion = tipo.Nombre,
                Precio = tipo.Precio
            };
            detalleService.CrearDetalle(detalle);

            // Mostramos el formulario con la factura generada
            var formFactura = new FormFactura(factura, detalle, usuario);
            formFactura.Show();

            // Cerramos el formulario de suscripción
            Close();
        }



        private void txtNumeroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros(e);
        }

        private void txtCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros(e);
        }

        private void txtTitularTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }
    }
}
