// Задание 4: Удаление всех отрицательных чисел
// Описание: Задайте массив целых чисел. Напишите программу, которая удаляет все
// отрицательные числа из массива и возвращает новый массив, содержащий только
// неотрицательные числа.

int[] array = new int[] { -8, 1, -6, -10, 2, -1, -9, 3, -5, -7, 4, -6, 5, -33 };
int count = 0;

foreach (int e in array)
{
    if (e > 0)
    {
        count++;
    }
}

int[] arrayResult = new int[count];
int index = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        arrayResult[index] = array[i];
        index++;
    }
}

for (int i = 0; i < arrayResult.Length; i++)
{
    Console.Write($"{arrayResult[i]} ");
}

