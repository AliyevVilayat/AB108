namespace LibraryManagementApp.Models;

public class Librarian : Person
{
    public DateTime HireDate { get; set; }


    public Librarian(string name) : base(name)
    {
    }
}



