using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tematika.CapaDeNegocio;
using Tematika.Models;
using Tematika.Styles;
using Tematika.Utils;

namespace Tematika.Forms
{
    public partial class FormGestionUsuarios : Form
    {
        private readonly UsuarioService _usuarioService = new UsuarioService();
        private readonly PerfilService _perfilService = new PerfilService();
        private int? usuarioSeleccionadoId = null;
        private bool mostrarActivos = true;

        public FormGestionUsuarios()
        {
            InitializeComponent();
            TBBuscadorUsuarios.TextChanged += (s, e) =>
            {
                GridUtils.FiltrarFilasPorTexto(DGVUsuarios, TBBuscadorUsuarios.Text);
            };

        }

        private void FormGestionUsuarios_Load(object sender, EventArgs e)
        {
            EstiloEncabezado.Aplicar(panelEncabezado, LTituloUsuarios);
            panelMain.BackColor = ColorTranslator.FromHtml("#cfd8dc");
            CargarPerfiles();
            CargarUsuarios();

            CBEliminado.Items.Clear();
            CBEliminado.Items.Add("No");
            CBEliminado.Items.Add("Sí");
            CBEliminado.SelectedIndex = 0;

            LEliminado.Visible = false;
            CBEliminado.Visible = false;
        }

        private void CargarPerfiles()
        {
            var perfiles = _perfilService.ListarPerfiles();
            var usuarioActual = SesionManager.UsuarioActual;

            bool esSuperAdmin = usuarioActual != null &&
                                _perfilService.ObtenerPerfil(usuarioActual.IdPerfil)?.NombrePerfil.ToLower() == "superadmin";

            var perfilesFiltrados = esSuperAdmin
                ? perfiles
                : perfiles.Where(p => p.NombrePerfil.ToLower() != "superadmin").ToList();

            CBPerfil.DataSource = perfilesFiltrados;
            CBPerfil.DisplayMember = "NombrePerfil";
            CBPerfil.ValueMember = "IdPerfil";
        }


        private void CargarUsuarios()
        {
            var usuarios = _usuarioService.ListarUsuarios()
                .Where(u => u.Eliminado == !mostrarActivos)
                .ToList();

            DGVUsuarios.Rows.Clear();

            foreach (var u in usuarios)
            {
                DGVUsuarios.Rows.Add(u.IdUsuario, u.IdPerfil, u.Nombre, u.Apellido, u.Correo, u.Dni, u.Sexo);
            }

            BUModificar.Visible = false;
            BUEliminar.Visible = false;
            BGuardar.Visible = true;
            LEliminado.Visible = false;
            CBEliminado.Visible = false;
        }

        private void LimpiarCampos()
        {
            TBNombreUsuario.Clear();
            TBApellidoUsuario.Clear();
            TBEmailUsuario.Clear();
            TBDNIUsuario.Clear();
            TBContraseñaUsuario.Clear();
            CBPerfil.SelectedIndex = 0;
            RBHombre.Checked = true;
            usuarioSeleccionadoId = null;

            CBEliminado.SelectedIndex = 0;
            LEliminado.Visible = false;
            CBEliminado.Visible = false;

            BGuardar.Visible = true;
            BUModificar.Visible = false;
            BUEliminar.Visible = false;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            bool validacionExitosa;

            if (usuarioSeleccionadoId == null)
            {
                // Alta: todos los campos obligatorios, incluyendo contraseña
                validacionExitosa = Validaciones.ValidarCamposObligatorios(panelCamposUsuarios);
            }
            else
            {
                // Modificación: excluye la contraseña
                var camposSinContraseña = panelCamposUsuarios.Controls
                    .OfType<Control>()
                    .Where(c => c.Name != "TBContraseñaUsuario")
                    .ToList();

                validacionExitosa = Validaciones.ValidarControlesObligatorios(camposSinContraseña);
            }

            if (!validacionExitosa)
                return;

            // DNI debe tener entre 7 y 9 dígitos
            string dniTexto = TBDNIUsuario.Text.Trim();

            if (!System.Text.RegularExpressions.Regex.IsMatch(dniTexto, @"^\d{7,9}$"))
            {
                MessageBox.Show("El DNI debe contener solo números y tener entre 7 y 9 dígitos.",
                                "Validación de DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBDNIUsuario.Focus();
                return;
            }

            // Si la validación pasa, continúa normalmente
            var usuario = new Usuario
            {
                Dni = int.Parse(dniTexto),
                Nombre = TBNombreUsuario.Text,
                Apellido = TBApellidoUsuario.Text,
                Correo = TBEmailUsuario.Text,
                IdPerfil = Convert.ToInt32(CBPerfil.SelectedValue),
                Sexo = RBHombre.Checked ? 'm' : 'f',
                Eliminado = CBEliminado.SelectedItem?.ToString() == "Sí"
            };

            var contrasenaPlano = TBContraseñaUsuario.Text;

            if (usuarioSeleccionadoId == null)
            {
                var mensajeError = _usuarioService.CrearUsuario(usuario, contrasenaPlano);

                if (mensajeError != null)
                {
                    MessageBox.Show(mensajeError, "Error de creación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Usuario creado correctamente.");
            }
            else
            {
                usuario.IdUsuario = usuarioSeleccionadoId.Value;
                var mensajeError = _usuarioService.ActualizarUsuario(
                    usuario,
                    string.IsNullOrWhiteSpace(contrasenaPlano) ? null : contrasenaPlano
                );

                if (mensajeError != null)
                {
                    MessageBox.Show(mensajeError, "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Usuario actualizado correctamente.");
            }

            LimpiarCampos();
            CargarUsuarios();
        }




        private void BUEliminar_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionadoId == null)
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuarioActual = SesionManager.UsuarioActual;

            if (usuarioActual != null && usuarioSeleccionadoId.Value == usuarioActual.IdUsuario)
            {
                MessageBox.Show("No puede eliminar su propio usuario mientras está logueado.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (confirmacion == DialogResult.Yes)
            {
                _usuarioService.EliminarUsuario(usuarioSeleccionadoId.Value);
                MessageBox.Show("Usuario eliminado correctamente.");
                LimpiarCampos();
                CargarUsuarios();
            }
        }


        private void BUModificar_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionadoId != null)
            {
                BGuardar_Click(sender, e);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BUActivos_Click(object sender, EventArgs e)
        {
            mostrarActivos = true;
            CargarUsuarios();
        }

        private void BUInactivos_Click(object sender, EventArgs e)
        {
            mostrarActivos = false;
            CargarUsuarios();
        }

        private void DGVUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //desactivar boton eliminar si estamos 
            if (!mostrarActivos ? BUEliminar.Visible = false : BUEliminar.Visible = true) ;

            if (e.RowIndex >= 0)
            {
                var fila = DGVUsuarios.Rows[e.RowIndex];
                usuarioSeleccionadoId = Convert.ToInt32(fila.Cells["idUsuario"].Value);

                var usuario = _usuarioService.ObtenerUsuario(usuarioSeleccionadoId.Value);
                if (usuario != null)
                {
                    // Cargar datos en los campos
                    TBNombreUsuario.Text = usuario.Nombre;
                    TBApellidoUsuario.Text = usuario.Apellido;
                    TBEmailUsuario.Text = usuario.Correo;
                    TBDNIUsuario.Text = usuario.Dni.ToString();
                    CBPerfil.SelectedValue = usuario.IdPerfil;
                    RBHombre.Checked = usuario.Sexo == 'm';
                    RBMujer.Checked = usuario.Sexo == 'f';
                    CBEliminado.SelectedItem = usuario.Eliminado ? "Sí" : "No";

                    // Obtener perfiles
                    var usuarioActual = SesionManager.UsuarioActual;
                    var perfilActual = _perfilService.ObtenerPerfil(usuarioActual.IdPerfil);
                    var perfilSeleccionado = _perfilService.ObtenerPerfil(usuario.IdPerfil);

                    // Evaluar roles
                    bool esSuperAdmin = perfilActual?.NombrePerfil.ToLower() == "superadmin";
                    bool esAdmin = perfilActual?.NombrePerfil.ToLower() == "admin";
                    bool objetivoEsAdminOSuper = perfilSeleccionado?.NombrePerfil.ToLower() is "admin" or "superadmin";
                    bool esUsuarioActual = usuarioActual.IdUsuario == usuario.IdUsuario;

                    // Control de botones
                    BGuardar.Visible = false;
                    BUModificar.Visible = esSuperAdmin || (esAdmin && !objetivoEsAdminOSuper);
                    BUEliminar.Visible = esSuperAdmin || (esAdmin && !objetivoEsAdminOSuper && !esUsuarioActual);
                    LEliminado.Visible = true;
                    CBEliminado.Visible = true;

                    if (usuario.Eliminado)
                    {
                        BUEliminar.Visible = false;
                    }
                }
            }
        }



        private void TBEmailUsuario_Leave(object sender, EventArgs e)
        {
            string correo = TBEmailUsuario.Text;

            Validaciones.ValidarEmail(correo);
        }

        private void TBNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        private void TBApellidoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        private void TBDNIUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros(e);
        }

        private void panelCamposUsuarios_Paint(object sender, PaintEventArgs e) { }

        private void LDireccion_Click(object sender, EventArgs e) { }
    }
}
