// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool Triangle(int num1, int num2, int num3)
{
    return  num1 < num2 + num3 &&
            num2 < num1 + num3 &&
            num3 < num1 + num2;
}


Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Triangle(a, b, c) ? "Да" : "Нет");
