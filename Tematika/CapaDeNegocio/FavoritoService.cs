using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class FavoritoService
    {
        private readonly FavoritoRepository _repository;

        public FavoritoService()
        {
            _repository = new FavoritoRepository();
        }

        public List<Favorito> ListarPorUsuario(int idUsuario)
        {
            return _repository.ObtenerPorUsuario(idUsuario);
        }

        public string? MarcarFavorito(Favorito favorito)
        {
            try
            {
                _repository.Crear(favorito);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al marcar como favorito: " + ex.Message;
            }
        }

        public void EliminarFavorito(int idFavorito)
        {
            _repository.Eliminar(idFavorito);
        }
    }
}
