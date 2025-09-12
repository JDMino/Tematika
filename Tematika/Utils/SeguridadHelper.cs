using System.Security.Cryptography;
using System.Text;

namespace Tematika.Utils;
public static class SeguridadHelper
{
    public static string HashContrasena(string contrasena)
    {
        using var sha256 = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(contrasena);
        var hash = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }
}
