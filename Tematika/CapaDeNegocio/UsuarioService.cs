using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using Tematika.CapaDeDatos;
using Tematika.Models;
using Tematika.Utils;

namespace Tematika.CapaDeNegocio
{
    // Define la clase UsuarioService dentro del namespace Tematika.CapaDeNegocio
    public class UsuarioService
    {
        // Campo privado para acceder al repositorio de usuarios
        private readonly UsuarioRepository _repository;

        // Constructor de la clase UsuarioService
        public UsuarioService()
        {
            // Inicializa el repositorio de usuarios
            _repository = new UsuarioRepository();
        }

        // Método público que obtiene todos los usuarios registrados
        public List<Usuario> ListarUsuarios()
        {
            // Llama al repositorio para obtener todos los usuarios
            return _repository.ObtenerTodos();
        }

        // Método público para obtener un usuario por su id
        public Usuario? ObtenerUsuario(int id)
        {
            // Llama al repositorio para obtener el usuario correspondiente
            return _repository.ObtenerPorId(id);
        }

        // Método público para crear un nuevo usuario, con manejo de errores por duplicados
        public string? CrearUsuario(Usuario usuario, string contrasenaPlano)
        {
            try
            {
                // Genera el hash de la contraseña en texto plano
                usuario.ContrasenaHash = SeguridadHelper.HashContrasena(contrasenaPlano);
                // Llama al repositorio para registrar el usuario
                _repository.Crear(usuario);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Maneja errores por claves duplicadas
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_Usuario_dni"))
                        return "Ya existe un usuario con ese DNI.";
                    if (ex.Message.Contains("UQ_Usuario_Correo"))
                        return "Ya existe un usuario con ese correo.";
                    return "Ya existe un usuario con datos duplicados.";
                }

                // Retorna mensaje genérico si no es error de duplicado
                return "Error al crear el usuario: " + ex.Message;
            }
        }

        // Método público para actualizar un usuario existente, con opción de cambiar la contraseña
        public string? ActualizarUsuario(Usuario usuario, string? nuevaContrasenaPlano = null)
        {
            try
            {
                // Si no se especifica nueva contraseña, se conserva la actual
                if (string.IsNullOrWhiteSpace(nuevaContrasenaPlano))
                {
                    var actual = _repository.ObtenerPorId(usuario.IdUsuario);
                    usuario.ContrasenaHash = actual?.ContrasenaHash ?? usuario.ContrasenaHash;
                }
                else
                {
                    // Si se especifica nueva contraseña, se genera el nuevo hash
                    usuario.ContrasenaHash = SeguridadHelper.HashContrasena(nuevaContrasenaPlano);
                }

                // Llama al repositorio para actualizar el usuario
                _repository.Actualizar(usuario);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Maneja errores por claves duplicadas
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_Usuario_dni"))
                        return "Ya existe otro usuario con ese DNI.";
                    if (ex.Message.Contains("UQ_Usuario_Correo"))
                        return "Ya existe otro usuario con ese correo.";
                    return "Ya existe otro usuario con datos duplicados.";
                }

                // Retorna mensaje genérico si no es error de duplicado
                return "Error al actualizar el usuario: " + ex.Message;
            }
        }

        // Método público para eliminar un usuario por su id
        public void EliminarUsuario(int id)
        {
            // Llama al repositorio para eliminar el usuario correspondiente
            _repository.Eliminar(id);
        }

        // Método público para validar credenciales de acceso
        public (Usuario? usuario, string? mensajeError) ValidarCredenciales(string correo, string contrasenaPlano)
        {
            // Obtiene todos los usuarios registrados
            var usuarios = _repository.ObtenerTodos();
            // Busca el usuario por correo
            var usuario = usuarios.FirstOrDefault(u => u.Correo == correo);

            // Si no se encuentra el usuario, retorna error
            if (usuario == null)
                return (null, "Usuario no encontrado.");

            // Si el usuario está marcado como eliminado, retorna error
            if (usuario.Eliminado)
                return (null, "El usuario está inactivo. Contacte al administrador.");

            // Genera el hash de la contraseña ingresada
            var hashIngresado = SeguridadHelper.HashContrasena(contrasenaPlano);
            // Compara el hash con el almacenado
            if (usuario.ContrasenaHash != hashIngresado)
                return (null, "Contraseña incorrecta.");

            // Si todo es válido, retorna el usuario y sin mensaje de error
            return (usuario, null);
        }

        // Método público para obtener el usuario asociado a una suscripción
        public Usuario? ObtenerUsuarioPorSuscripcion(int idSuscripcion)
        {
            // Busca la suscripción por id
            var suscripcion = new SuscripcionService().ObtenerTodas()
                .FirstOrDefault(s => s.IdSuscripcion == idSuscripcion);

            // Si no se encuentra la suscripción, retorna null
            if (suscripcion == null)
                return null;

            // Retorna el usuario asociado a la suscripción
            return ObtenerUsuario(suscripcion.IdUsuario);
        }
    }
}
