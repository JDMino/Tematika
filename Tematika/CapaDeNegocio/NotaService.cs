using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class NotaService
    {
        private readonly NotaRepository _repository;

        public NotaService()
        {
            _repository = new NotaRepository();
        }

        public List<Nota> ListarPorUsuario(int idUsuario)
        {
            return _repository.ObtenerPorUsuario(idUsuario);
        }

        public string? CrearNota(Nota nota)
        {
            try
            {
                _repository.Crear(nota);
                return null;
            }
            catch (SqlException ex)
            {
                return "Error al registrar la nota: " + ex.Message;
            }
        }

        public void EliminarNota(int idNota)
        {
            _repository.Eliminar(idNota);
        }
    }
}
