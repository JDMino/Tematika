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
        private bool loginExitoso = false;

        public AppContext()
        {
            MostrarLogin();
        }

        private void MostrarLogin()
        {
            var loginForm = new FormLogin();

            loginForm.OnLoginSuccess += () => {
                loginExitoso = true;
                AbrirFormPrincipal();
            };

            loginForm.FormClosed += (s, e) => {
                if (!loginExitoso)
                    ExitThread(); // Cierra si el login fue cancelado
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
                    case 4:
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

            destino.FormClosed += (s, e) => {
                SesionManager.CerrarSesion();
                loginExitoso = false; // Reiniciamos el estado
                MostrarLogin(); // Volvemos a mostrar el login
            };

            destino.Show();
        }
    }

}