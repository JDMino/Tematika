using System.Collections.Generic;
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

        public void CrearUsuario(Usuario usuario, string contrasenaPlano)
        {
            usuario.ContrasenaHash = SeguridadHelper.HashContrasena(contrasenaPlano);
            _repository.Crear(usuario);
        }

        public void ActualizarUsuario(Usuario usuario, string? nuevaContrasenaPlano = null)
        {
            if (!string.IsNullOrEmpty(nuevaContrasenaPlano))
            {
                usuario.ContrasenaHash = SeguridadHelper.HashContrasena(nuevaContrasenaPlano);
            }

            _repository.Actualizar(usuario);
        }

        public void EliminarUsuario(int id)
        {
            _repository.Eliminar(id);
        }
    }
}
