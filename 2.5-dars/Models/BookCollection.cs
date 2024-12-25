namespace _2._5_dars;

public class BookCollection
{
    private List<Book> _books;
    public BookCollection()
    {
        _books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public List<Book> GetBooksByAuthor(string author)
    {
        var authorBooks=new List<Book>();
        foreach (var book in _books)
        {
            if(book.Author == author)
            {
                authorBooks.Add(book);
            }
        }
        return authorBooks;
    }
}
