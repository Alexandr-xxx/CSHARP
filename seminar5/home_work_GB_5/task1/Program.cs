// Задание 1: Поиск максимального элемента в каждой строке.
// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// находит максимальный элемент в каждой строке массива и выводит его.

// Пример входных данных:
// 1 3 5 7
// 2 4 6 8
// 9 10 11 12
// Пример результата:
// Максимальный элемент в строке 0: 7
// Максимальный элемент в строке 1: 8
// Максимальный элемент в строке 2: 12


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
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void GetMaxElementInRowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int max = matrix[i, 0];

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max)
            {
                max = matrix[i, j];
            }
        }
        Console.Write($"Максимальный элемент в строке {i}: {max}");
        Console.WriteLine();
    }
}

int[,] array2d = CreateMatrixIntRnd(5, 5, 1, 100);
ShowMatrix(array2d);

GetMaxElementInRowMatrix(array2d);