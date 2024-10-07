#region Tasks

/*Verilmiş natural ədədlərdən ibarət olan array daxilində cüt elementlərin sayının tapılması.

Verilmiş natural ədədlərdən ibarət olan array daxilində ən böyük tək elementin tapılması.

Verilmiş array-ın elementlərinin sayının tapılması.


*/
#endregion

#region Task3

//Verilmiş array-ın elementlərinin tərsinə çevrilməsi.

int[] arr = { 1, 5, 15, 20, 13, 99, 22, 33, 101, 222 };

int[] reversedArr = new int[arr.Length];

#region Loop
/*
for (int i = 0; i < arr.Length; i++)
{
    reversedArr[arr.Length - 1 - i] = arr[i];
}

Console.Write("Reversed Array's items: ");
for (int i = 0; i < reversedArr.Length; i++)
{
    Console.Write(reversedArr[i]);
    if (i != reversedArr.Length - 1)
    {
        Console.Write(",");
    }
}*/

#endregion


#region LoopReverse
/*for (int i = arr.Length - 1; i >= 0; i--)
{
    reversedArr[arr.Length - 1 - i] = arr[i];
}
reversedArr[0] = arr[arr.Length - 1];

Console.Write("Before Reverse Array's items: ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]);
    if (i != arr.Length - 1)
    {
        Console.Write(",");
    }
}
Console.WriteLine("\n");
Console.Write("After Reverse Array's items: ");
for (int i = 0; i < reversedArr.Length; i++)
{
    Console.Write(reversedArr[i]);
    if (i != reversedArr.Length - 1)
    {
        Console.Write(",");
    }
}
*/
#endregion

#endregion

#region Task5

//Verilmiş elementin array-in daxilində yer alıb-almaması məlumatının əldə edilməsi.

/*int searchedNum = 2222;
int[] searchedArr = { 1, 5, 15, 20, 13, 99, 22, 33, 101, 222 };
bool isExist = false;

for (int i = 0; i < searchedArr.Length; i++)
{
    if (searchedArr[i] == searchedNum)
    {
        isExist = true;
        break;
    }
}

if (isExist)
{
    Console.WriteLine("Edede rast gelindi");
}
else
{
    Console.WriteLine("Edede rast gelinmedi");
}*/

#endregion

#region Task6
//Verilmiş element array daxilində yer alırsa neçə dəfə təkrarlandığı məlumatının əldə edilməsi.

int searchedNum = 222;
int[] searchedArr = { 1, 5, 15, 20, 13, 99, 222, 33, 101, 222 };
int counter = 0;

for (int i = 0; i < searchedArr.Length; i++)
{
    if (searchedArr[i] == searchedNum)
    {
        counter++;
    }
}

if (counter == 0)
{
    Console.WriteLine("Edede rast gelinmedi");
}
else
{
    Console.WriteLine("Axtarilan element(" + searchedNum + ") Array daxilinde " + counter + " defe tekrar edildi.");
}

#endregion
