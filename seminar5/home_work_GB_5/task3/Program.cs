// Задание 3: Транспонирование двумерного массива
// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// транспонирует массив (меняет строки и столбцы местами).
// Пример входных данных:
// 1 2
// 3 4
// 5 6
// Пример результата:
// 1 3 5
// 2 4 6

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

int[,] TransposesAnMatrixSwapsRowsAndColumns(int[,] matrix)
{
    int[,] matrixTransposes = new int[matrix.GetLength(1), matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrixTransposes[j, i] = matrix[i, j];
        }
    }
    return matrixTransposes;

}

void ShowMatrixTransposes(int[,] matrixTransposes)
{
    for (int i = 0; i < matrixTransposes.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTransposes.GetLength(1); j++)
        {
            Console.Write($"{matrixTransposes[i, j],4} ");

        }
        Console.WriteLine();
    }
}

int[,] TransposedMatrix = CreateMatrixIntRnd(3, 2, 1, 10);
// int[,] array2d = CreateMatrixIntRnd(4, 5, 1, 10);
// int[,] array2d = CreateMatrixIntRnd(5, 5, 1, 10);

ShowMatrix(TransposedMatrix);

Console.WriteLine();

int[,] result = TransposesAnMatrixSwapsRowsAndColumns(TransposedMatrix);
ShowMatrixTransposes(result);