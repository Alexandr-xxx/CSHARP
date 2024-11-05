// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример:
// 2 3 4 3       4 3 16 3
// 4 3 4 1  =>   4 3 4 1
// 2 9 5 4       4 9 25 4

int[,] CreatMatrixRndInt(int rows, int columns, int min, int max)
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
        //Console.Write("|");

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine(); //Console.WriteLine("|");
    }
}



// void ElemEventIndexesToSquare(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i, j] *= matrix[i,j]; // matrix[i,j] * matrix[i,j];
//             }
//         }
//     }
// }


// или
void ElemEventIndexesToSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            // if (i % 2 == 0 && j % 2 == 0)
            // {
                matrix[i, j] *= matrix[i,j]; // matrix[i,j] * matrix[i,j];
            // }
        }
    }
}


int[,] array2d = CreatMatrixRndInt(3, 4, 1, 10);
ShowMatrix(array2d);

Console.WriteLine();
ElemEventIndexesToSquare(array2d);
ShowMatrix(array2d);