using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    public class IntentoService
    {
        private readonly IntentoRepository _repository;

        public IntentoService()
        {
            _repository = new IntentoRepository();
        }

        public void RegistrarIntento(Intento intento)
        {
            _repository.Registrar(intento);
        }

        public List<Intento> ListarPorHistorial(int idHistorial)
        {
            return _repository.ListarPorHistorial(idHistorial);
        }
    }
}
