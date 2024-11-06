// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Пример:
// 4 3 1 (1,2) => 9
// 2 6 9

int[,] CreateMatrixIntRnd(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

int[,] array2d = CreateMatrixIntRnd(7, 8, -10, 100);
ShowMatrix(array2d);

Console.Write("Введите номер строки массива: ");
int rowsInput = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца массива: ");
int columnsInput = Convert.ToInt32(Console.ReadLine());

void ShowElementsInMatrix(int[,] matrix)
{
    if (rowsInput < matrix.GetLength(0) && columnsInput < matrix.GetLength(1))
    {
        Console.Write($"Элемент (с указанной позицией) имеет значение: ");
        Console.WriteLine(matrix[rowsInput, columnsInput]);
    }
    else
    {
        Console.WriteLine("Элемента (с указанной позицией) в массиве нет.");
    }
}

ShowElementsInMatrix(array2d);