using System.Globalization;
using System.Text;

public static class GridUtils
{
    public static void FiltrarFilasPorTexto(DataGridView grid, string texto)
    {
        string filtro = RemoverAcentos(texto.Trim().ToLower());

        if (grid.IsCurrentCellInEditMode)
        {
            grid.EndEdit();
            grid.CurrentCell = null;
        }

        foreach (DataGridViewRow fila in grid.Rows)
        {
            if (fila.IsNewRow)
                continue;

            bool visible = false;

            foreach (DataGridViewCell celda in fila.Cells)
            {
                if (celda.Value != null)
                {
                    string contenido = RemoverAcentos(celda.Value.ToString()!.ToLower());
                    if (contenido.Contains(filtro))
                    {
                        visible = true;
                        break;
                    }
                }
            }

            fila.Visible = visible;
        }
    }

    private static string RemoverAcentos(string texto)
    {
        var normalizado = texto.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();

        foreach (var c in normalizado)
        {
            var unicode = CharUnicodeInfo.GetUnicodeCategory(c);
            if (unicode != UnicodeCategory.NonSpacingMark)
                sb.Append(c);
        }

        return sb.ToString().Normalize(NormalizationForm.FormC);
    }
}
