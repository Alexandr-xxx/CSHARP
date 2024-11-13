// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива.
// Пример:
// a b c => “abcdef”
// d e f

string CreateStringOfCharMatrix(char[,] matrix)
{
    string result = string.Empty;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result += matrix[i, j];
        }
    }
    return result;
}

char[,] matrixChar = new char[2, 3]
{
{'a', 'b', 'c'},
{'d', 'e', 'f'},
};

string res = CreateStringOfCharMatrix(matrixChar);
Console.WriteLine(res);