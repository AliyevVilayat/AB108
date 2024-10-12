#region Notes

//Void - Əgər method geriyə heç bir dəyər qaytarmayacaqsa(yəni return etməyəcəksə) bu zaman method-un geri dönüş tipi void olmalıdır.

#endregion


public class Program
{

    public static void Main(string[] args)
    {


    }

    #region CustomToLower()

    public static string CustomToLower(string str)
    {
        //Custom ToLower(); Elə bir method yazın ki göndərilən string-i kiçik hərflərlə yazılmış versiyasını geriyə qaytarsın.

        char newSymb = '\0';
        string lowerStr = ""; //=> string.Empty;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 65 && str[i] <= 90)
            {
                newSymb = (char)(str[i] + 32);
                lowerStr += newSymb;
            }
            else
            {
                lowerStr += str[i];
            }
        }

        return lowerStr;
    }

    #endregion


    #region CustomIndexOf()

    //Custom IndexOf(); Elə bir method yazın ki göndərilən array daxilində göndərilmiş olan dəyəri axtarsın və həmin index-i qaytarsın. Əgər yoxdursa geriyə -1 qaytarsın.

    public static int CustomIndexOf(int[] arr, int searchedVal)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == searchedVal)
            {
                return i;
            }

        }

        return -1;

    }

    #endregion


    #region HomeWork


    //Custom ToUpper(); Elə bir method yazın ki göndərilən string-i böyük hərflərlə yazılmış versiyasını geriyə qaytarsın.
    //Custom CleanStr(); Elə bir method yazın ki göndərilən string-in daxilində yer alan ƏLAVƏ simvolları təmizləsin(yəni sadəcə geriyə boşluqlar və sözlər qayıtsın.

    #endregion



}

