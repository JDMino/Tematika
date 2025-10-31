using System.Globalization;
using System.Text;

public static class GridUtils
{
    // Método público para filtrar las filas de un DataGridView según un texto ingresado
    public static void FiltrarFilasPorTexto(DataGridView grid, string texto)
    {
        // Normaliza el texto ingresado: elimina espacios, convierte a minúsculas y remueve acentos
        string filtro = RemoverAcentos(texto.Trim().ToLower());

        // Si hay una celda en modo edición, se finaliza la edición y se deselecciona
        if (grid.IsCurrentCellInEditMode)
        {
            grid.EndEdit();
            grid.CurrentCell = null;
        }

        // Recorre todas las filas del DataGridView
        foreach (DataGridViewRow fila in grid.Rows)
        {
            // Omite la fila nueva para ingreso de datos
            if (fila.IsNewRow)
                continue;

            bool visible = false;

            // Recorre todas las celdas de la fila
            foreach (DataGridViewCell celda in fila.Cells)
            {
                if (celda.Value != null)
                {
                    // Normaliza el contenido de la celda
                    string contenido = RemoverAcentos(celda.Value.ToString()!.ToLower());
                    // Si el contenido contiene el texto buscado, se marca la fila como visible
                    if (contenido.Contains(filtro))
                    {
                        visible = true;
                        break;
                    }
                }
            }

            // Aplica la visibilidad a la fila según el resultado del filtro
            fila.Visible = visible;
        }
    }

    // Método privado para remover acentos de una cadena de texto
    private static string RemoverAcentos(string texto)
    {
        // Normaliza el texto en forma de descomposición (separa letras y tildes)
        var normalizado = texto.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();

        // Recorre cada carácter del texto normalizado
        foreach (var c in normalizado)
        {
            // Obtiene la categoría Unicode del carácter
            var unicode = CharUnicodeInfo.GetUnicodeCategory(c);
            // Si no es una marca de acento, se agrega al resultado
            if (unicode != UnicodeCategory.NonSpacingMark)
                sb.Append(c);
        }

        // Devuelve el texto sin acentos, normalizado nuevamente a forma compuesta
        return sb.ToString().Normalize(NormalizationForm.FormC);
    }
}
