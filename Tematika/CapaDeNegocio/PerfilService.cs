using System.Collections.Generic;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio;

// Define la clase PerfilService dentro del namespace Tematika.CapaDeNegocio
public class PerfilService
{
    // Campo privado para acceder al repositorio de perfiles
    private readonly PerfilRepository _repository;

    // Constructor de la clase PerfilService
    public PerfilService()
    {
        // Inicializa el repositorio de perfiles
        _repository = new PerfilRepository();
    }

    // Método público que obtiene todos los perfiles registrados
    public List<Perfil> ListarPerfiles()
    {
        // Llama al repositorio para obtener todos los perfiles
        return _repository.ObtenerTodos();
    }

    // Método público para obtener un perfil por su id
    public Perfil? ObtenerPerfil(int idPerfil)
    {
        // Obtiene todos los perfiles desde el repositorio
        var perfiles = _repository.ObtenerTodos();
        // Busca el perfil que coincide con el id especificado
        return perfiles.FirstOrDefault(p => p.IdPerfil == idPerfil);
    }
}
