using System.Globalization;

namespace RegistroNotasPOE.Clases;
public static class ValidadorNotas
{
    public static bool IntentarNota(string texto, string nombre, out decimal valor, out string error)
    {
        valor = 0m;
        error = string.Empty;
        if (string.IsNullOrWhiteSpace(texto)) { error = $"Ingrese la nota de {nombre}."; return false; }
        // Aqui dejo que acepte punto o coma como separador decimal, pero no separadores de miles.
        string normalizado = texto.Trim().Replace(',', '.');
        if (!decimal.TryParse(normalizado, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out valor))
        { error = $"La nota de {nombre} debe ser un número decimal."; return false; }
        if (valor < 0m || valor > 10m)
        { error = $"La nota de {nombre} debe estar entre 0 y 10."; return false; }
        if (decimal.Round(valor, 2) != valor)
        { error = $"La nota de {nombre} admite como máximo dos decimales."; return false; }
        return true;
    }

    public static decimal CalcularNotaFinal(decimal laboratorio, decimal parcial, decimal asistencia) =>
        decimal.Round(laboratorio * 0.50m + parcial * 0.40m + asistencia * 0.10m, 2,
                      MidpointRounding.AwayFromZero);

    public static bool IntentarEstudiante(string nombre, string apellido, string codigo,
        string laboratorio, string parcial, string asistencia, out Estudiante estudiante, out string error)
    {
        estudiante = new Estudiante(); error = string.Empty;
        if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(codigo))
        { error = "Nombre, apellido y código son obligatorios."; return false; }
        if (nombre.Trim().Length > 100 || apellido.Trim().Length > 100 || codigo.Trim().Length > 30)
        { error = "Nombre y apellido admiten 100 caracteres; código admite 30."; return false; }
        if (!IntentarNota(laboratorio, "Laboratorio", out decimal lab, out error)) return false;
        if (!IntentarNota(parcial, "Parcial", out decimal par, out error)) return false;
        if (!IntentarNota(asistencia, "Asistencia", out decimal asi, out error)) return false;
        estudiante = new Estudiante
        {
            // Bonus: Convierto a mayusculas antes de insertar o actualizar.
            Nombre = nombre.Trim().ToUpperInvariant(),
            Apellido = apellido.Trim().ToUpperInvariant(),
            Codigo = codigo.Trim().ToUpperInvariant(),
            Laboratorio = lab, Parcial = par, Asistencia = asi,
            NotaFinal = CalcularNotaFinal(lab, par, asi)
        };
        return true;
    }

    public static void SoloDecimal(object? sender, KeyPressEventArgs e)
    {
        if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) return;
        if (e.KeyChar == '.' || e.KeyChar == ',')
        {
            var tb = sender as TextBox;
            string texto = tb?.Text ?? string.Empty;
            if (!texto.Contains('.') && !texto.Contains(',')) return;
        }
        e.Handled = true;
    }
}
