// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.
// Пример:
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

double[] array = new double[] {2.2, 0.4, 9.11, 7.2, 78.98};
// double[] array = new double[] {1.22, 4.5, 3.33};

double min = array[0];
double max = array[0];
double difference = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}

difference = max - min;
Console.Write($"Разница между максимальным и минимальным элементом массива равна: {difference}");