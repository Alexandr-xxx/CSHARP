// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

// Пример:
// 4 3 1   => 4 6 2
// 2 6 9      2 6 9
// 4 6 2      4 3 1

int[,] GreatMatrixIntRnd(int rows, int columns, int min, int max)
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
    Console.WriteLine("Двумерный массив:");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

void SwapsFirstAndLastRowOfMatrix(int[,] matrix)
{
    Console.WriteLine("Ниже двумерный масиив в котором поменяли местами первую и последнюю строку:");
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int temp;

            if (i == 0 || i == matrix.GetLength(0) - 1)
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[rows - 1, j];
                matrix[rows - 1, j] = temp;
                //Console.Write($"{matrix[i,j]} ");
            }
            Console.Write($"{matrix[i, j],4} ");

        }
        Console.WriteLine();
    }
}

int[,] array2d = GreatMatrixIntRnd(5, 6, 1, 100);
ShowMatrix(array2d);

Console.WriteLine();
SwapsFirstAndLastRowOfMatrix(array2d);