using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using Tematika.CapaDeDatos;
using Tematika.Models;
using Tematika.Utils;

namespace Tematika.CapaDeNegocio
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _repository;

        public UsuarioService()
        {
            _repository = new UsuarioRepository();
        }

        public List<Usuario> ListarUsuarios()
        {
            return _repository.ObtenerTodos();
        }

        public Usuario? ObtenerUsuario(int id)
        {
            return _repository.ObtenerPorId(id);
        }

        public string? CrearUsuario(Usuario usuario, string contrasenaPlano)
        {
            try
            {
                usuario.ContrasenaHash = SeguridadHelper.HashContrasena(contrasenaPlano);
                _repository.Crear(usuario);
                return null;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_Usuario_dni"))
                        return "Ya existe un usuario con ese DNI.";
                    if (ex.Message.Contains("UQ_Usuario_Correo"))
                        return "Ya existe un usuario con ese correo.";
                    return "Ya existe un usuario con datos duplicados.";
                }

                return "Error al crear el usuario: " + ex.Message;
            }
        }

        public string? ActualizarUsuario(Usuario usuario, string? nuevaContrasenaPlano = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nuevaContrasenaPlano))
                {
                    var actual = _repository.ObtenerPorId(usuario.IdUsuario);
                    usuario.ContrasenaHash = actual?.ContrasenaHash ?? usuario.ContrasenaHash;
                }
                else
                {
                    usuario.ContrasenaHash = SeguridadHelper.HashContrasena(nuevaContrasenaPlano);
                }

                _repository.Actualizar(usuario);
                return null;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_Usuario_dni"))
                        return "Ya existe otro usuario con ese DNI.";
                    if (ex.Message.Contains("UQ_Usuario_Correo"))
                        return "Ya existe otro usuario con ese correo.";
                    return "Ya existe otro usuario con datos duplicados.";
                }

                return "Error al actualizar el usuario: " + ex.Message;
            }
        }

        public void EliminarUsuario(int id)
        {
            _repository.Eliminar(id);
        }

        public (Usuario? usuario, string? mensajeError) ValidarCredenciales(string correo, string contrasenaPlano)
        {
            var usuarios = _repository.ObtenerTodos();
            var usuario = usuarios.FirstOrDefault(u => u.Correo == correo);

            if (usuario == null)
                return (null, "Usuario no encontrado.");

            if (usuario.Eliminado)
                return (null, "El usuario está inactivo. Contacte al administrador.");

            var hashIngresado = SeguridadHelper.HashContrasena(contrasenaPlano);
            if (usuario.ContrasenaHash != hashIngresado)
                return (null, "Contraseña incorrecta.");

            return (usuario, null);
        }

        public Usuario? ObtenerUsuarioPorSuscripcion(int idSuscripcion)
        {
            var suscripcion = new SuscripcionService().ObtenerTodas()
                .FirstOrDefault(s => s.IdSuscripcion == idSuscripcion);

            if (suscripcion == null)
                return null;

            return ObtenerUsuario(suscripcion.IdUsuario);
        }
    }
}
