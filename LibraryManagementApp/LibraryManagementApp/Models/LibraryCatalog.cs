using LibraryManagementApp.Exceptions;

namespace LibraryManagementApp.Models;

public class LibraryCatalog
{
    public List<Book> Books { get; set; }
    public Book this[int id]
    {
        get
        {
            Book? book = Books.Find(b => b.Id == id);
            if (book == null)
            {
                throw new CustomLibraryItemException($"Daxilin edilən Id-ə({id}) sahib kitab catalogda yer almir");
            }
            return book;
        }

        set
        {
            Book? book = Books.Find(b => b.Id == id);
            if (book == null)
            {
                throw new CustomLibraryItemException("Book is null");
            }
            book = value;
        }
    }


    public LibraryCatalog()
    {
        Books = new List<Book>();
    }
}
