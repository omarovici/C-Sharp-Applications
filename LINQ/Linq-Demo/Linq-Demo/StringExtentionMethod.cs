namespace Linq_Demo;

public static class StringExtentionMethod
{
    public static bool IsNumeric(this string str)
    {
        if (string.IsNullOrEmpty(str)) return false;
        foreach (var c in str)
            if (!char.IsDigit(c)) return false;

        return true;
    }
}