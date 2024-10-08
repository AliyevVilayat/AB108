#region FibonaciWay1
//Fibonaçi ədədlərini ekrana çıxarın.
// 0 1  1 2 3 5 8 13 21 34 55 89 144
/*
int num = 0;
int fib = 1;

int index = 0;
while (true)
{

    Console.Write(num);
    Console.Write(" ");

    fib = fib + num;
    num = fib - num;

    index++;
    if (index == 100)
    {
        break;
    }
}*/
#endregion

#region FibonaciWay2

/*int[] nums = new int[20];
nums[1] = 1;

for (int i = 0; i < nums.Length - 2; i++)
{
    nums[i + 2] = nums[i] + nums[i + 1];
}

foreach (int i in nums)
{
    Console.Write(i);
    Console.Write(" ");
}*/
#endregion

#region MaxNumberWithDigits

//Verilmiş ədədi rəqəmlərindən düzələ biləcək ən böyük ədədi.   1613 => 6311

int number = 14857490; // 998764210
int finalNum = 0;
int tempData = number;
int countDigit = 0;

while (tempData > 0)
{
    tempData /= 10;  //tempData = tempData / 10;
    countDigit++;
}

int[] arr = new int[countDigit];
tempData = number;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = tempData % 10;
    tempData /= 10;
}

for (int j = 0; j < arr.Length; j++)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] < arr[i + 1])
        {
            arr[i] = arr[i] + arr[i + 1]; // arr[i] += arr[i+1]
            arr[i + 1] = arr[i] - arr[i + 1];
            arr[i] = arr[i] - arr[i + 1];
        }
    }
}

for (int i = 0; i < arr.Length; i++)
{
    finalNum = finalNum * 10;
    finalNum = finalNum + arr[i];
}

Console.WriteLine(number + " Ededinin reqemlerinden duzele bilecek en boyuk eded " + finalNum);

#endregion