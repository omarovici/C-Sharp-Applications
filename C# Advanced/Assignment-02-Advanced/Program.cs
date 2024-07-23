namespace Assignment_02_Advanced;

class Program
{
    public delegate string GetTitleDelegate(Book book);
    public delegate string GetAuthorsDelegate(Book book);
    public delegate string GetPriceDelegate(Book book);
    
    static void Main(string[] args)
    {
        #region First Non-Repeated Character

        // Console.Write("Enter a string : ");
        // string name = Console.ReadLine();
        // Console.WriteLine($"The index of the first non-repeated character is {FirstNonRepeatedCharacter(name)} ");
        
        #endregion

        #region Book Class & Book Functions

        // Book[] books = new Book[]
        // {
        //     new Book(
        //         "978-0-452-28423-4",
        //         "To Kill a Mockingbird",
        //         new string[] { "Harper Lee" },
        //         new DateTime(1960, 7, 11),
        //         10.99m
        //     ),
        //     new Book(
        //         "978-0-7432-7356-5",
        //         "1984",
        //         new string[] { "George Orwell" },
        //         new DateTime(1949, 6, 8),
        //         9.99m
        //     ),
        //     new Book(
        //         "978-0-140-14479-9",
        //         "Pride and Prejudice",
        //         new string[] { "Jane Austen" },
        //         new DateTime(1813, 1, 28),
        //         12.99m
        //     ),
        //     new Book(
        //         "978-0-618-00222-8",
        //         "The Hobbit",
        //         new string[] { "J.R.R. Tolkien" },
        //         new DateTime(1937, 9, 21),
        //         15.99m
        //     ),
        //     new Book(
        //         "978-0-7432-7356-5",
        //         "The Great Gatsby",
        //         new string[] { "F. Scott Fitzgerald" },
        //         new DateTime(1925, 4, 10),
        //         10.99m
        //     )
        // };
        //
        // foreach (var book in books)
        // {
        //     Console.WriteLine(book);
        // }
        //
        // foreach (var book in books)
        // {
        //     Console.WriteLine($"Title: {BookFunctions.GetTitle(book)}");
        //     Console.WriteLine($"Authors: {BookFunctions.GetAuthors(book)}");
        //     Console.WriteLine($"Price: {BookFunctions.GetPrice(book)}"); 
        //     Console.WriteLine("=====================================");
        // }

        #endregion

        #region Delegete

        // List<Book> book1 = new List<Book>
        // {
        //     new Book(
        //         "978-0-452-28423-4",
        //         "To Kill a Mockingbird",
        //         new string[] { "Harper Lee" },
        //         new DateTime(1960, 7, 11),
        //         10.99m
        //     ),
        //     new Book(
        //         "978-0-7432-7356-5",
        //         "1984",
        //         new string[] { "George Orwell" },
        //         new DateTime(1949, 6, 8),
        //         9.99m
        //     ),
        //     new Book(
        //         "978-0-140-14479-9",
        //         "Pride and Prejudice",
        //         new string[] { "Jane Austen" },
        //         new DateTime(1813, 1, 28),
        //         12.99m
        //     ),
        //     new Book(
        //         "978-0-618-00222-8",
        //         "The Hobbit",
        //         new string[] { "J.R.R. Tolkien" },
        //         new DateTime(1937, 9, 21),
        //         15.99m
        //     ),
        //     new Book(
        //         "978-0-7432-7356-5",
        //         "The Great Gatsby",
        //         new string[] { "F. Scott Fitzgerald" },
        //         new DateTime(1925, 4, 10),
        //         10.99m
        //     )
        // };
        //
        // Func<Book,string> getTitle = BookFunctions.GetTitle;
        // Func<Book,string> getAuthors = BookFunctions.GetAuthors;
        // Func<Book,string> getPrice = BookFunctions.GetPrice;
        // Func<Book, string> GetISBN = delegate(Book book)
        // {
        //     return book.ISBN;
        // };
        // Func<Book, DateTime> getPublicationDate = (Book B) => B.PublicationDate;
        //
        // LibraryEngine.ProcessBooks(book1, getTitle); 
        // LibraryEngine.ProcessBooks(book1, getAuthors);
        // LibraryEngine.ProcessBooks(book1, getPrice);
        // LibraryEngine.ProcessBooks(book1, GetISBN);
        // LibraryEngine.ProcessBooks(book1, b => getPublicationDate(b).ToString("dd-MM-yyyy"));


        #endregion

    }
    
    // 1) Given a string, find the first non-repeated character in it and return its 
    // index. If there is no such character, return -1. Hint you can use dictionary
    public static int FirstNonRepeatedCharacter(string name)
    {
        Dictionary<char, int> NonRepeated = new Dictionary<char, int>();
        foreach (char c in name)
        {
            if (NonRepeated.ContainsKey(c)) NonRepeated[c]++;
            else NonRepeated[c] = 1;
        }

        for (int i = 0; i < name.Length; i++)
        {
            if (NonRepeated[name[i]] == 1) return i;
        }

        return -1;
    }
}