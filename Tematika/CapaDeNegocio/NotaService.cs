using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase NotaService dentro del namespace Tematika.CapaDeNegocio
    public class NotaService
    {
        // Campo privado para acceder al repositorio de notas
        private readonly NotaRepository _repository;

        // Constructor de la clase NotaService
        public NotaService()
        {
            // Inicializa el repositorio de notas
            _repository = new NotaRepository();
        }

        // Método público que obtiene todas las notas asociadas a un usuario
        public List<Nota> ListarPorUsuario(int idUsuario)
        {
            // Llama al repositorio para obtener las notas por id de usuario
            return _repository.ObtenerPorUsuario(idUsuario);
        }

        // Método público para registrar una nueva nota, con manejo de errores
        public string? CrearNota(Nota nota)
        {
            try
            {
                // Intenta registrar la nota usando el repositorio
                _repository.Crear(nota);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Retorna un mensaje de error si ocurre una excepción SQL
                return "Error al registrar la nota: " + ex.Message;
            }
        }

        // Método público para eliminar una nota por su id
        public void EliminarNota(int idNota)
        {
            // Llama al repositorio para eliminar la nota correspondiente
            _repository.Eliminar(idNota);
        }

        // Método público que obtiene todas las notas registradas en el sistema
        public List<Nota> ListarTodas()
        {
            // Llama al repositorio para obtener todas las notas
            return _repository.ObtenerTodas();
        }
    }
}
