// Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)
// Пример:
// [1 3 5 6 7 8] => [8 7 6 5 3 1]


int[] array = {9, 8, 7, 6, 5, 4, 3, 2, 1};

void PrintArray(int[] array)
{
    Console.Write("[");
    
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]} ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }

    Console.Write("]");
}

PrintArray(array);

void InvertArray(int[] array)
{
    // int temp;
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

InvertArray(array);

void PrintInvertArray(int[] array)
{
    Console.Write("[");
    
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]} ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }

    Console.Write("]");
}

Console.Write($" Перевернутый массив => ");
PrintInvertArray(array);