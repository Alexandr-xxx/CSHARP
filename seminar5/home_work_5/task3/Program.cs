// // Задача 3: Задайте прямоугольный двумерный массив.
// // Напишите программу, которая будет находить строку с
// // наименьшей суммой элементов.

// // Пример:
// // 4 3 1 => Строка с индексом 0
// // 2 6 9
// // 4 6 2

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
    Console.WriteLine();
}

int[] GetArraySumElementsInRowsMatrix(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j]; // sum = sum + matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
}

void GetIndexMinSumElementsInRowsMatrix(int[] array)
{
    int IndexMinSum = 0;
    int minSum = array[IndexMinSum];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minSum)
        {
            minSum = array[i];
            IndexMinSum = i;
        }
    }
    Console.Write($"Наименьшая сумма элементов в строке с индексом: {IndexMinSum} ");
}

int[,] array2d = CreateMatrixIntRnd(5, 3, -10, 10);
ShowMatrix(array2d);


int[] array1d = GetArraySumElementsInRowsMatrix(array2d);

Console.Write("Сумма элементов в строках двумерного массива: ");
ShowArray(array1d);

Console.WriteLine();
GetIndexMinSumElementsInRowsMatrix(array1d);