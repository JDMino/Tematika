using Tematika.Models;

public static class SesionManager
{
    public static Usuario? UsuarioActual { get; private set; }

    public static void IniciarSesion(Usuario? usuario)
    {
        UsuarioActual = usuario;
    }

    public static void CerrarSesion()
    {
        UsuarioActual = null;
    }

    public static bool SesionActiva => UsuarioActual != null;

    public static bool EsInvitado => UsuarioActual == null;
}
