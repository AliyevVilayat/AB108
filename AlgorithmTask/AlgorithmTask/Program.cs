#region Notes

// [datatype] [variableName] = value;   => Bərabərliyin solu  declare prosesidir. Sağ tərəfi isə assign prosesidir.

//Sadə və mürəkkəblik anlayışı yalnız Natural ədədlərə adiddir.

//Sadə ədədlər yalnız 1-ə və özünə bölünən ədədlərdir. Yəni 2 bölənə sahibdirlər.

// 1 nə sadə nə də mürəkkəb ədəddir.

// 2 ən kiçik sadə ədəddir (yeganə cüt ədəddir ki, sadə ədəddir.)

// Mürəkkəb ədədin tapılması qaydası

#endregion

#region Task
//Simple or Complex number - Ədədin sadə və ya mürəkkəb olub olmamasını tapan alqoritm yazılmalıdır.


int num = 1;
int counter = 0;

if (num == 1)
{
    Console.WriteLine("1 nə sadə ədəddir nə də mürəkkəb");
}
else if (num <= 0)
{
    Console.WriteLine("Eded ne sade ededdir ne de murekkeb");
}
else
{
    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            Console.WriteLine("Ededin bolenleri:" + i);
            counter = counter + 1;
        }
    }

    if (counter > 2)
    {
        Console.WriteLine(num + " ededi murekkeb ededdir");
    }
    else
    {
        Console.WriteLine(num + " ededi sade ededdir");
    }

}
#endregion
