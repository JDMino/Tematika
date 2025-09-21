using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tematika.Utils
{
    public static class Validaciones
    {
        public static bool ValidarCamposObligatorios(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is TextBox tb && string.IsNullOrWhiteSpace(tb.Text))
                {
                    string campo = tb.Tag?.ToString() ?? tb.Name;
                    MessageBox.Show($"El campo '{campo}' no puede estar vacío.");
                    tb.Focus();
                    return false;
                }

                if (control is ComboBox cb && cb.SelectedItem == null)
                {
                    string campo = cb.Tag?.ToString() ?? cb.Name;
                    MessageBox.Show($"Debe seleccionar una opción en '{campo}'.");
                    cb.Focus();
                    return false;
                }
            }

            return true;
        }


        public static bool ValidarControlesObligatorios(List<Control> controles)
        {
            foreach (var control in controles)
            {
                if (control is TextBox tb && string.IsNullOrWhiteSpace(tb.Text))
                {
                    string campo = tb.Tag?.ToString() ?? tb.Name;
                    MessageBox.Show($"El campo '{campo}' no puede estar vacío.");
                    tb.Focus();
                    return false;
                }

                if (control is ComboBox cb && cb.SelectedItem == null)
                {
                    string campo = cb.Tag?.ToString() ?? cb.Name;
                    MessageBox.Show($"Debe seleccionar una opción en '{campo}'.");
                    cb.Focus();
                    return false;
                }
            }

            return true;
        }


        public static void ValidarSoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        public static void ValidarSoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static bool ValidarEmail(string email)
        {
            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(email);
        }
    }
}
