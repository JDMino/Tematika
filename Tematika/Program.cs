using Tematika.Forms;
using Tematika.Utils;

namespace Tematika
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new AppContext());
        }
    }

    public class AppContext : ApplicationContext
    {
        public AppContext()
        {
            var loginForm = new FormLogin();
            loginForm.OnLoginSuccess += AbrirFormPrincipal;
            loginForm.FormClosed += (s, e) =>
            {
                if (!SesionManager.SesionActiva && !SesionManager.EsInvitado)
                    ExitThread(); // Solo cierra si no hay sesión y no es invitado
            };

            loginForm.Show();
        }

        private void AbrirFormPrincipal()
        {
            var usuario = SesionManager.UsuarioActual;
            Form destino;

            if (usuario == null)
            {
                destino = new FormMainEstudiante(); // Modo invitado
            }
            else
            {
                switch (usuario.IdPerfil)
                {
                    case 1:
                    case 2:
                        destino = new FormAdmin();
                        break;
                    case 3:
                        destino = new FormMainEstudiante();
                        break;
                    default:
                        MessageBox.Show("Perfil no reconocido.");
                        ExitThread();
                        return;
                }
            }

            destino.FormClosed += (s, e) =>
            {
                SesionManager.CerrarSesion();
                var nuevoLogin = new FormLogin();
                nuevoLogin.OnLoginSuccess += AbrirFormPrincipal;
                nuevoLogin.Show();
            };

            destino.Show();
        }

    }
}
