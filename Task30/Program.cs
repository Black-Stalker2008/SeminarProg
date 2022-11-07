// int[] array = new int[8];
// for (int i = 0; i < array.Lenght; i++)

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// void FillArray(int[] arr)
// {

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 2);

//     }
// }
// void PrintArray(int[] arr)
// {

//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i != arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }
// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);

int[] CreateArray(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i<len; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i<arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i<arr.Length-1) Console.Write(",");
    }
    Console.WriteLine("]");
}

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
PrintArray(array);
