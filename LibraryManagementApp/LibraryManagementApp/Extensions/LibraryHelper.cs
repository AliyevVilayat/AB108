using LibraryManagementApp.Exceptions;
using LibraryManagementApp.Models;

namespace LibraryManagementApp.Extensions;

public static class LibraryHelper
{

    public static int CalculateAge(this LibraryItem libraryItem)
    {
        if (libraryItem.PublicationYear == null)
        {
            throw new CustomLibraryItemException("Library item is null");
        }

        int year = DateTime.Now.Year - libraryItem.PublicationYear.Value;
        return year;
    }

    public static string ToTitleCase(this LibraryItem libraryItem)
    {
        string str = string.Empty;

        str = libraryItem.Title[0].ToString().ToUpper() + libraryItem.Title.Substring(1).ToLower();

        return str;
    }
}
