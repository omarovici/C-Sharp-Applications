namespace Assignment_02_Advanced;

// 1. Considering the Code Below, Write Down the Body 
// of all Listed Methods and Properties and 
// Constructor:

public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string[] Authors { get; set; }
    public DateTime PublicationDate { get; set; }
    public decimal Price { get; set; }
    
    public Book(string isbn, string title, string[] authors, DateTime publicationDate, decimal price)
    {
        ISBN = isbn;
        Title = title;
        Authors = authors;
        PublicationDate = publicationDate;
        Price = price;
    }

    public override string ToString()
    {
        string authors = string.Join(" - ", Authors);
        return $"ISBN: {ISBN}\n" +
               $"Title: {Title}\n" +
               $"Authors: {authors}\n" +
               $"Publication Date: {PublicationDate:dd-MM-yyyy}\n" +
               $"Price: {Price:C} \n" +
               $"====================================";
    }
}