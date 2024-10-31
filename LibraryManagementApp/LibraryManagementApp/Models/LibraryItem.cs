using LibraryManagementApp.Enums;

namespace LibraryManagementApp.Models;

public abstract class LibraryItem
{
    private static int _counter;
    public int Id { get; }
    public string Title { get; set; }
    public int? PublicationYear { get; set; }
    protected LibraryItem(string title, int? publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
        _counter++;
        Id = _counter;
    }
    public abstract void DisplayInfo();
}

public struct LibraryLocation
{
    public int Aisle { get; set; }
    public int Shelf { get; set; }

}

public class Book : LibraryItem
{

    public BookGenre BookGenre { get; set; }
    public LibraryLocation LibraryLocation { get; set; }

    public Book(string title, int? publicationYear) : base(title, publicationYear)
    {

    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Id:{Id} Title:{Title} Genre:{BookGenre} ");
    }
}
