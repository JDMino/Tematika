using System;
using System.Drawing;
using System.Windows.Forms;
using Tematika.Models;

namespace Tematika.Forms
{
    public partial class FormGestionContenidos : Form
    {
        // --- Constructor del formulario ---
        public FormGestionContenidos()
        {
            InitializeComponent(); // Inicializa los componentes gráficos del formulario
        }

        // --- Botón: Gestión de Materias ---
        private void btnMaterias_Click(object sender, EventArgs e)
        {
            // Crea y muestra el formulario que permite gestionar las materias
            FormGestionMateria gestionMaterias = new FormGestionMateria();
            gestionMaterias.Show();
        }

        // --- Botón: Gestión de Temas ---
        private void btnTema_Click(object sender, EventArgs e)
        {
            // Crea y muestra el formulario que permite gestionar los temas
            FormGestionTemas gestionTemas = new FormGestionTemas();
            gestionTemas.Show();
        }

        // --- Botón: Gestión de Recursos ---
        private void btnRecursos_Click(object sender, EventArgs e)
        {
            // Crea y muestra el formulario que permite gestionar los recursos educativos
            FormGestionRecursos gestionRecursos = new FormGestionRecursos();
            gestionRecursos.Show();
        }

        // --- Botón: Gestión de Preguntas ---
        private void btnPreguntas_Click(object sender, EventArgs e)
        {
            // Crea y muestra el formulario que permite gestionar preguntas (evaluaciones, quizzes, etc.)
            FormGestionPreguntas gestionPreguntas = new FormGestionPreguntas();
            gestionPreguntas.Show();
        }

        // --- Botón: Asignación de Docentes a Materias ---
        private void btnAsignacionDocente_Click(object sender, EventArgs e)
        {
            // Crea y muestra el formulario que permite asignar docentes a las materias correspondientes
            FormGestionDocenteMateria gestionDocenteMateria = new FormGestionDocenteMateria();
            gestionDocenteMateria.Show();
        }

        // --- Evento que se ejecuta al cargar el formulario ---
        private void FormGestionContenidos_Load(object sender, EventArgs e)
        {
            // Obtiene el usuario que inició sesión actualmente
            var usuario = SesionManager.UsuarioActual;

            // Si el usuario es un docente (IdPerfil == 2), se restringe el acceso a ciertas opciones
            if (usuario != null && usuario.IdPerfil == 2) // Docente
            {
                // El docente no puede asignar docentes ni gestionar materias
                btnAsignacionDocente.Visible = false;
                btnMaterias.Visible = false;
            }
        }
    }
}
