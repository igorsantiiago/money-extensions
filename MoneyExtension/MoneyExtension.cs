namespace MoneyExtension;

public static class Money
{
    public static int ToCents(this decimal value)
    {
        if (value < 0)
            return 0;

        var valueString = value.ToString("N2").Replace(",", "").Replace(".", "");

        if (string.IsNullOrEmpty(valueString))
            return 0;

        int.TryParse(valueString, out var result);
        return result;
    }
}
