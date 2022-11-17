// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine(" |");
    }
}

void SumMainDiagonalElements(int[,] matr)
{
    int length = matr.GetLength(0) < matr.GetLength(1) ? matr.GetLength(0) : matr.GetLength(1);
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (matr[i, i]<0) Console.Write("(");
        Console.Write(matr[i, i]);
        if (matr[i, i]<0) Console.Write(")");
        Console.Write (i < length - 1 ? " + " : " = ");
        sum += matr[i, i];
    }
    Console.WriteLine(sum);
}

Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(m, n, -9, 9);
PrintMatrix(matrix);
SumMainDiagonalElements(matrix);

