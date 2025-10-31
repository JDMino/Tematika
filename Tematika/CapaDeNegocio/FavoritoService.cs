using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase FavoritoService dentro del namespace Tematika.CapaDeNegocio
    public class FavoritoService
    {
        // Campo privado para acceder al repositorio de favoritos
        private readonly FavoritoRepository _repository;

        // Constructor de la clase FavoritoService
        public FavoritoService()
        {
            // Inicializa el repositorio de favoritos
            _repository = new FavoritoRepository();
        }

        // Método público que obtiene todos los favoritos de un usuario
        public List<Favorito> ListarPorUsuario(int idUsuario)
        {
            // Llama al repositorio para obtener los favoritos por id de usuario
            return _repository.ObtenerPorUsuario(idUsuario);
        }

        // Método público para marcar un recurso como favorito, con manejo de errores
        public string? MarcarFavorito(Favorito favorito)
        {
            try
            {
                // Intenta registrar el favorito usando el repositorio
                _repository.Crear(favorito);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Retorna un mensaje de error si ocurre una excepción SQL
                return "Error al marcar como favorito: " + ex.Message;
            }
        }

        // Método público para eliminar un favorito por su id
        public void EliminarFavorito(int idFavorito)
        {
            // Llama al repositorio para marcar el favorito como eliminado
            _repository.Eliminar(idFavorito);
        }
    }
}
