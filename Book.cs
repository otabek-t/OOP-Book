namespace OOP_Book.Model;

public class Book
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public DateTime PublicationDate { get; set; }
    public string Description { get; set; }
    public int PageNumber { get; set; }
    public double Price { get; set; }
    public string AuthorName { get; set; }
    public string ReadersName { get; set; }

}
