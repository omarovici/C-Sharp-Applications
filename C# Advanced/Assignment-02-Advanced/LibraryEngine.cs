namespace Assignment_02_Advanced;

public class LibraryEngine
{
    public static void ProcessBooks(List<Book> bList,Func<Book, string> fPtr)
    {
        foreach (var B in bList)
        {
            Console.WriteLine(fPtr(B));
        }
    }
}