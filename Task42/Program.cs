// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string СonverterDigit(int num)
{
    string res = "";
    while (num > 0)
    {
        res = $"{(num % 2)}{res}";
        num /= 2;
    }
    return res;
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {a} в двоичной системе = {СonverterDigit(a)}");


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int DecToBin(int number)
// {
//     int binNumber = 0;
//     int d10 = 1;
//     while (number > 0)
//     {
//         binNumber = binNumber + number % 2 * d10;
//         number /= 2;
//         d10 *= 10;
//     }
//     return binNumber;
// }

// int decToBin = DecToBin(num);

// Console.WriteLine($"Число {num} в двоичной системе = {decToBin}");

// через рекурсию
// int ConvertDecToBinary(int dec)
// {
//     if (dec == 0) return 0;
//     if (dec == 1) return 1;
//     return ConvertDecToBinary(dec/2) * 10 + dec % 2;
// }

// Console.Write ("Введите десятичное число: ");
// int numberDec = Convert.ToInt32(Console.ReadLine());
// int numberBinary = ConvertDecToBinary(numberDec);
// Console.WriteLine($"Десятичное число {numberDec} будет в двоичном представлении выглядеть как: {numberBinary}.");

