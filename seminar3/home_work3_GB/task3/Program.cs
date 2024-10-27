// Задание 3: Поиск среднего значения массива
// Описание: Задайте массив из 10 целых чисел. Найдите среднее значение элементов
// массива.

int[] array = new int[10] { 6, 1, 9, 2, 5, 3, 8, 7, 10, 4 };

double sum = 0;
double result = 0;
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    sum = sum + array[i];
    count++;
}

result = sum / count;

Console.Write($"Cреднее значение элементов массива равно: {result}");