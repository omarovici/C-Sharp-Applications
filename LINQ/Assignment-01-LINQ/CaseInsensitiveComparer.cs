namespace Assignment_01_LINQ;

public class CaseInsensitiveComparer
{
    // 2. Uses a custom comparer to do a case-insensitive sort of the words in an array. use order by
    
     public static int Compare(string x, string y)
    {
        return StringComparer.OrdinalIgnoreCase.Compare(x, y);
    }
}