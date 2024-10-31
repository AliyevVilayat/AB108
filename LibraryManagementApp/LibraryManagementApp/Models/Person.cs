namespace LibraryManagementApp.Models;

public abstract class Person
{
    public int Id { get; set; }

    public string Name { get; set; }

    protected Person(string name)
    {
        Name = name;
    }

}



