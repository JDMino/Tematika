using System.Collections.Generic;
using Tematika.CapaDeDatos;
using Tematika.Models;

namespace Tematika.CapaDeNegocio;

public class PerfilService
{
    private readonly PerfilRepository _repository;

    public PerfilService()
    {
        _repository = new PerfilRepository();
    }

    public List<Perfil> ListarPerfiles()
    {
        return _repository.ObtenerTodos();
    }
}
