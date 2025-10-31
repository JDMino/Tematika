using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tematika.Utils
{
    // Clase estática que agrupa métodos de validación reutilizables
    public static class Validaciones
    {
        // Valida que todos los TextBox y ComboBox dentro de un contenedor tengan valores válidos
        public static bool ValidarCamposObligatorios(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                // Verifica si el TextBox está vacío
                if (control is TextBox tb && string.IsNullOrWhiteSpace(tb.Text))
                {
                    string campo = tb.Tag?.ToString() ?? tb.Name;
                    MessageBox.Show($"El campo '{campo}' no puede estar vacío.");
                    tb.Focus();
                    return false;
                }

                // Verifica si el ComboBox no tiene una opción seleccionada
                if (control is ComboBox cb && cb.SelectedItem == null)
                {
                    string campo = cb.Tag?.ToString() ?? cb.Name;
                    MessageBox.Show($"Debe seleccionar una opción en '{campo}'.");
                    cb.Focus();
                    return false;
                }
            }

            // Si todos los controles son válidos, retorna true
            return true;
        }

        // Valida una lista específica de controles obligatorios
        public static bool ValidarControlesObligatorios(List<Control> controles)
        {
            foreach (var control in controles)
            {
                // Verifica si el TextBox está vacío
                if (control is TextBox tb && string.IsNullOrWhiteSpace(tb.Text))
                {
                    string campo = tb.Tag?.ToString() ?? tb.Name;
                    MessageBox.Show($"El campo '{campo}' no puede estar vacío.");
                    tb.Focus();
                    return false;
                }

                // Verifica si el ComboBox no tiene una opción seleccionada
                if (control is ComboBox cb && cb.SelectedItem == null)
                {
                    string campo = cb.Tag?.ToString() ?? cb.Name;
                    MessageBox.Show($"Debe seleccionar una opción en '{campo}'.");
                    cb.Focus();
                    return false;
                }
            }

            // Si todos los controles son válidos, retorna true
            return true;
        }

        // Restringe la entrada a solo letras, espacios y teclas de control
        public static void ValidarSoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        // Restringe la entrada a solo números y teclas de control
        public static void ValidarSoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Valida si un string tiene formato de correo electrónico válido
        public static bool ValidarEmail(string email)
        {
            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(email);
        }

        // Restringe la entrada a letras, espacios, caracteres de puntuación y teclas de control
        public static void ValidarTextoConCaracteresEspeciales(KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetter(c) && !char.IsWhiteSpace(c) && !char.IsControl(c) &&
                !"¿?¡!.,:;\"'()".Contains(c))
            {
                e.Handled = true;
            }
        }
    }
}
