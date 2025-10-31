using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase IntentoService dentro del namespace Tematika.CapaDeNegocio
    public class IntentoService
    {
        // Campo privado para acceder al repositorio de intentos
        private readonly IntentoRepository _repository;

        // Constructor de la clase IntentoService
        public IntentoService()
        {
            // Inicializa el repositorio de intentos
            _repository = new IntentoRepository();
        }

        // Método público para registrar un nuevo intento de respuesta
        public void RegistrarIntento(Intento intento)
        {
            // Llama al repositorio para registrar el intento
            _repository.Registrar(intento);
        }

        // Método público para obtener todos los intentos asociados a un historial
        public List<Intento> ListarPorHistorial(int idHistorial)
        {
            // Llama al repositorio para obtener los intentos por id de historial
            return _repository.ListarPorHistorial(idHistorial);
        }
    }
}
