// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// Пример:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1


void ReverseArray(int[] arr, int index)
{
    if (index < 0)
    {
        return;
    }

    if (index > 0)
    {
        Console.Write($"{arr[index]}, ");
        ReverseArray(arr, index - 1);
    }

    else
    {
        Console.Write($"{arr[index]}");
    }
}

// int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] array = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
Console.WriteLine("Массив в обратном порядке: ");
ReverseArray(array, array.Length - 1);