using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase TemaService dentro del namespace Tematika.CapaDeNegocio
    public class TemaService
    {
        // Campo privado para acceder al repositorio de temas
        private readonly TemaRepository _repository;

        // Constructor de la clase TemaService
        public TemaService()
        {
            // Inicializa el repositorio de temas
            _repository = new TemaRepository();
        }

        // Método público que obtiene todos los temas registrados
        public List<Tema> ListarTemas()
        {
            // Llama al repositorio para obtener todos los temas
            return _repository.ObtenerTodos();
        }

        // Método público para obtener un tema por su id
        public Tema? ObtenerTema(int id)
        {
            // Llama al repositorio para obtener el tema correspondiente
            return _repository.ObtenerPorId(id);
        }

        // Método público para crear un nuevo tema, con manejo de errores por duplicados
        public string? CrearTema(Tema tema)
        {
            try
            {
                // Llama al repositorio para registrar el tema
                _repository.Crear(tema);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Maneja errores por claves duplicadas
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_Tema_nombre"))
                        return "Ya existe un tema con ese nombre.";
                    return "Ya existe un tema con datos duplicados.";
                }

                // Retorna mensaje genérico si no es error de duplicado
                return "Error al crear el tema: " + ex.Message;
            }
        }

        // Método público para actualizar un tema existente, con manejo de errores por duplicados
        public string? ActualizarTema(Tema tema)
        {
            try
            {
                // Llama al repositorio para actualizar el tema
                _repository.Actualizar(tema);
                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Maneja errores por claves duplicadas
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_Tema_nombre"))
                        return "Ya existe otro tema con ese nombre.";
                    return "Ya existe otro tema con datos duplicados.";
                }

                // Retorna mensaje genérico si no es error de duplicado
                return "Error al actualizar el tema: " + ex.Message;
            }
        }

        // Método público para eliminar un tema por su id
        public void EliminarTema(int id)
        {
            // Llama al repositorio para eliminar el tema correspondiente
            _repository.Eliminar(id);
        }
    }
}
