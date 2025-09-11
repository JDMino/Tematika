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
        }

        private void FormGestionUsuarios_Load(object sender, EventArgs e)
        {
            EstiloEncabezado.Aplicar(panelEncabezado, LTituloUsuarios);
            panelMain.BackColor = ColorTranslator.FromHtml("#cfd8dc");
            CargarPerfiles();
            CargarUsuarios();
        }

        private void CargarPerfiles()
        {
            var perfiles = _perfilService.ListarPerfiles();
            CBPerfil.DataSource = perfiles;
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

            BGuardar.Visible = true;
            BUModificar.Visible = false;
            BUEliminar.Visible = false;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposObligatorios(panelCamposUsuarios))
                return;

            var usuario = new Usuario
            {
                Dni = int.Parse(TBDNIUsuario.Text),
                Nombre = TBNombreUsuario.Text,
                Apellido = TBApellidoUsuario.Text,
                Correo = TBEmailUsuario.Text,
                IdPerfil = Convert.ToInt32(CBPerfil.SelectedValue),
                Sexo = RBHombre.Checked ? 'm' : 'f',
                Eliminado = false
            };

            var contrasenaPlano = TBContraseñaUsuario.Text;

            if (usuarioSeleccionadoId == null)
            {
                _usuarioService.CrearUsuario(usuario, contrasenaPlano);
                MessageBox.Show("Usuario creado correctamente.");
            }
            else
            {
                usuario.IdUsuario = usuarioSeleccionadoId.Value;
                _usuarioService.ActualizarUsuario(usuario, contrasenaPlano);
                MessageBox.Show("Usuario actualizado correctamente.");
            }

            LimpiarCampos();
            CargarUsuarios();
        }

        private void BUEliminar_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionadoId != null)
            {
                var confirm = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    _usuarioService.EliminarUsuario(usuarioSeleccionadoId.Value);
                    MessageBox.Show("Usuario eliminado.");
                    LimpiarCampos();
                    CargarUsuarios();
                }
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
            if (e.RowIndex >= 0)
            {
                var fila = DGVUsuarios.Rows[e.RowIndex];
                usuarioSeleccionadoId = Convert.ToInt32(fila.Cells["idUsuario"].Value);

                var usuario = _usuarioService.ObtenerUsuario(usuarioSeleccionadoId.Value);
                if (usuario != null)
                {
                    TBNombreUsuario.Text = usuario.Nombre;
                    TBApellidoUsuario.Text = usuario.Apellido;
                    TBEmailUsuario.Text = usuario.Correo;
                    TBDNIUsuario.Text = usuario.Dni.ToString();
                    CBPerfil.SelectedValue = usuario.IdPerfil;
                    RBHombre.Checked = usuario.Sexo == 'm';
                    RBMujer.Checked = usuario.Sexo == 'f';

                    BGuardar.Visible = false;
                    BUModificar.Visible = true;
                    BUEliminar.Visible = true;
                }
            }
        }

        private void TBEmailUsuario_Leave(object sender, EventArgs e)
        {
            Validaciones.ValidarEmail(TBEmailUsuario);
        }

        private void TBNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        private void TBApellidoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloLetras(e);
        }

        private void panelCamposUsuarios_Paint(object sender, PaintEventArgs e) { }

        private void LDireccion_Click(object sender, EventArgs e) { }
    }
}
