using OOP_Book.Model;

namespace OOP_Book.Service;

public class Bookservice
{
    private List<Book> books;
    public Bookservice()
    {
        books = new List<Book>();
    }

    public Book GetById(Guid id)
    {
        foreach(var bookId in books)
        {
            if (bookId.Id == id)
            {
                return bookId;
            }
        }
        return null;
    }

    public Book AddBook(Book book) 
    { 
        book.Id = Guid.NewGuid();
        books.Add(book);
        return book;
    }

    public bool DeleteBook(Guid deleteBookId)
    {
        var deleteCheck = GetById(deleteBookId);
        if (deleteCheck is null)
        {
            return false;
        }
        books.Remove(deleteCheck);
        return true;
    }

    public bool UpdateBook(Book updateBook)
    {
        var book = GetById(updateBook.Id);
        if (book is null)
        { 
            return false;
        }
        var index = books.IndexOf(book);
        books[index] = updateBook;
        return true;
    }
    
    public List<Book> GetAllBook()
    {
        return books;
    }

   
}
