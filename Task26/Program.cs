// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());

// int Num(int x)
// {
//     int count = 0;
//     for (int i = 0; i < x; i++)
//     {
//         x = x / 10;
//         count = count + 1;

//     }
//     return count;

// }

// int result = Num(x);
// Console.WriteLine(result);

int CountDigits(int num)
{
    int count=0;
    while (num!=0)
    {
        count++; // count = count + 1
        num/=10; // num = num / 10;
    }
    if (count==0) count = 1; 
    return count;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int countDigits = CountDigits(number);
Console.WriteLine($"В числе {number} - {countDigits} цифр(а).");
