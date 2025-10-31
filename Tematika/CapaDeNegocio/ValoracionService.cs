using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio
{
    // Define la clase ValoracionService dentro del namespace Tematika.CapaDeNegocio
    public class ValoracionService
    {
        // Campo privado para acceder al repositorio de valoraciones
        private readonly ValoracionRepository _repository;

        // Constructor de la clase ValoracionService
        public ValoracionService()
        {
            // Inicializa el repositorio de valoraciones
            _repository = new ValoracionRepository();
        }

        // Método público que obtiene todas las valoraciones asociadas a un recurso
        public List<Valoracion> ListarPorRecurso(int idRecurso)
        {
            // Llama al repositorio para obtener las valoraciones por id de recurso
            return _repository.ObtenerPorRecurso(idRecurso);
        }

        // Método público para registrar o actualizar una valoración, con manejo de errores
        public string? RegistrarValoracion(Valoracion valoracion)
        {
            try
            {
                // Verifica si ya existe una valoración del mismo usuario para el mismo recurso
                var existente = _repository.ObtenerPorUsuarioYRecurso(valoracion.IdUsuario, valoracion.IdRecurso);

                if (existente != null)
                {
                    // Si ya existe, actualiza la valoración existente
                    valoracion.IdValoracion = existente.IdValoracion;
                    _repository.Actualizar(valoracion);
                }
                else
                {
                    // Si no existe, crea una nueva valoración
                    _repository.Crear(valoracion);
                }

                // Retorna null si no hubo errores
                return null;
            }
            catch (SqlException ex)
            {
                // Retorna un mensaje de error si ocurre una excepción SQL
                return "Error al registrar la valoración: " + ex.Message;
            }
        }
    }
}
