namespace Tematika
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());




            //Descomentar (y comentar lo de arriba) para usar solo la vista de estudiantes (rama-juan)
            //Application.Run(new FormMainEstudiante());
        }
    }
}