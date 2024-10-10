
#region Tasks

/*

1.Verilən stringi tərsinə yaz

2. Ədədin perfect number olub olmadığını tap (Ədədin bölənləri cəmi özünü qaytarırsa bu perfect numberdir. 1+2+3=6)

3. Sözdəki saitlərin sayını tapın. (String arrayında ekrana sözlər verilir. Hər söz veriləndən sonra istifadəçidən rəqəm tələb olunur. İstifadəçi düzgün sait sayını taparsa ekrana düzdür yazsın əks halda səhvdir yazsın)

4. 2 arrayı birləşdirin

5. Arrayın sıralı olub olmadığını yoxlayın

 */



#endregion


#region Task3
//Sözdəki saitlərin sayını tapın. (String arrayında ekrana sözlər verilir. Hər söz veriləndən sonra istifadəçidən rəqəm tələb olunur. İstifadəçi düzgün sait sayını taparsa ekrana düzdür yazsın əks halda səhvdir yazsın)

string heart = "♥";

string saitlerStr = "aeuioAEIUO";
char[] saitlerArr = { 'a', 'e', 'u', 'i', 'o', 'A', 'E', 'U', 'I', 'O', };


string[] strArr = { "Salam", "SLM", "CNM", "NCSN", "<3", "Sagol" };
int countInput = 0;
int count = 0;

for (int i = 0; i < strArr.Length; i++)
{
    Console.WriteLine(strArr[i]);

    Console.Write("Zehmet olmasa ekranda gorduyunuz sozdeki saitlerin sayini daxilin edin:");
    countInput = int.Parse(Console.ReadLine());
    count = 0;
    for (int j = 0; j < strArr[i].Length; j++)
    {
        for (int k = 0; k < saitlerStr.Length; k++)
        {
            if (strArr[i][j] == saitlerStr[k])
            {
                count++;
                break;
            }
        }
    }

    if (count == countInput)
    {
        Console.WriteLine("Duzgun tapildi");
    }
    else
    {
        Console.WriteLine("Duzgun tapilmadi");
    }

}

#endregion