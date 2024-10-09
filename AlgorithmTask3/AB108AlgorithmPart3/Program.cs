
#region Notes

// Biz gələcək olan numeric dataları console vasitəsi ilə əldə edən zamans string olaraq alırıq. Daha sonra parse və ya convert əməliyyatları icra edilməlidir.


//Console WriteLine("text") = Console Write("text \n");


//While Ön Şərtli operatordur. Şərt doğru olmazsa əməliyyat icra edilmir.
//Do While isə Son şərtli operatordur. Fərqi ondan ibarətdir ki, şərt doğru olmasa belə heç olmasa 1 dəfə əməliyyatı icra edir.

#endregion

#region Console Readline
/*
Console.Write("Zehmet olmasa yasinizi daxil edin: ");
ushort num = Convert.ToUInt16(Console.ReadLine());
*/
#endregion

#region Custom Contains
/*
string str = "SSalam AB108 bu gun tapsiriqlari isleyeceyikSalam.";

Console.Write("Zehmet olmasa axtarilan ifade daxil edin: ");
string searchedStr = Console.ReadLine().Trim();

bool isExist = false;

int index = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i] == searchedStr[index])
    {
        index++;
        if (index == searchedStr.Length)
        {
            isExist = true;
            break;
        }
    }
    else
    {
        if (index > 0)
        {
            i = i - index;
        }
        index = 0;
    }

}

if (isExist == true)
{
    Console.WriteLine("Axtarilan ifade bizim cumlemizde rast gelindi");
}
else
{
    Console.WriteLine("Axtarilan ifade bizim cumlemizde rast gelinmedi");
}
*/
#endregion

#region While and DoWhile
/*
Console.Write("Zehmet olmasa yasinizi daxil edin:");
int age = Convert.ToInt32(Console.ReadLine());

do
{
    Console.WriteLine("Sene icki satisi qadagandir.");
}
while (age < 18);

while (age < 18)
{
    Console.WriteLine("Sene icki satisi qadagandir.");
}
*/
#endregion

#region Array Comparing

int[] arr = { 200, 1, 2, 3, 5, 6, 7, 8, 9 };
int[] arr2 = { 1, 12, 2, 31, 5, 64, 7, 89, 9, 1, 21, 45, 1 };

bool isExist = false;

foreach (int arrItem in arr)
{
    foreach (int arr2Item in arr2)
    {
        if (arrItem == arr2Item)
        {
            isExist = true;
            break;
        }
    }

    if (!isExist)
    {
        Console.WriteLine(arrItem + " diger array daxilinde rast gelinmedi");
    }

    isExist = false;

}

#endregion
