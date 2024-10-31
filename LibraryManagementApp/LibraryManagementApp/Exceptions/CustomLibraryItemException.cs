namespace LibraryManagementApp.Exceptions;


public class CustomLibraryItemException : Exception
{
    public CustomLibraryItemException() : base("There is a Book Exception")
    {

    }

    public CustomLibraryItemException(string message) : base(message)
    {
    }


}