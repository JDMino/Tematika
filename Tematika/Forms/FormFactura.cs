using System;
using System.Windows.Forms;
using Tematika.Models;

namespace Tematika.Forms
{
    public partial class FormFactura : Form
    {
        // --- Campos privados para almacenar los datos de la factura ---
        private readonly Factura factura;          // Contiene los datos principales de la factura (fecha, total, etc.)
        private readonly DetalleFactura detalle;   // Contiene la descripción y el precio del servicio o producto
        private readonly Usuario usuarioDueño;     // Usuario al que pertenece la factura

        // --- Constructor del formulario ---
        public FormFactura(Factura factura, DetalleFactura detalle, Usuario usuarioDueño)
        {
            InitializeComponent();

            // Se guardan los objetos recibidos como parámetros
            this.factura = factura;
            this.detalle = detalle;
            this.usuarioDueño = usuarioDueño;

            // Se asocian los eventos del formulario
            Load += FormFactura_Load;                    // Evento al cargar el formulario
            btnCerrar.Click += (s, e) => Close();        // Botón para cerrar la ventana
        }

        // --- Evento que se ejecuta al cargar el formulario ---
        private void FormFactura_Load(object sender, EventArgs e)
        {
            // Muestra los datos de la factura y del usuario en los labels
            lblFecha.Text = $"Fecha: {factura.FechaEmision:dd/MM/yyyy}";
            lblNombre.Text = $"Nombre: {usuarioDueño.Nombre} {usuarioDueño.Apellido}";
            lblEmail.Text = $"Email: {usuarioDueño.Correo}";
            lblTotal.Text = $"Total: ${factura.Total:0.00}";

            // Limpia el DataGridView por si tenía datos anteriores
            dgvDetalle.Rows.Clear();

            // Agrega el detalle de la factura (solo una línea en este caso)
            dgvDetalle.Rows.Add(
                detalle.Descripcion,                 // Descripción del servicio o recurso
                detalle.Precio.ToString("0.00")      // Precio formateado con dos decimales
            );
        }
    }
}
