// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}, ");
            else Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine(" |");
    }
}

void ReplaceEvenIndexElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i+=2) 
    {   
        for (int j = 0; j < matr.GetLength(1); j+=2)
        {
            matr[i,j]*=matr[i,j];
        }
    }
}

Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(m, n, -9, 9);
PrintMatrix(matrix);
Console.WriteLine();
ReplaceEvenIndexElements(matrix);
PrintMatrix(matrix);
