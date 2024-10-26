// Дано 5 гирь с разным весом в случайном порядке.
//  Найти вес самой тяжелой гири. 

// Действия, которые можно совершать с гирями:
// 1. Взять одну или несколько гирь.
// 2. Сравнить гири по весу.
// 3. Поменять две гири местами.
// 4. Запомнить вес нужной гири.

// int size = 5;
int[] array = { 2, 9, 21, 8, 17 }; // или int[] array = new int[5] { 2, 9, 21, 8, 17 }
int i = 0;
int max = array[i];

while (i < array.Length)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i++; // i = i + 1
}
Console.WriteLine($"Вес самой тяжелой гири равен: {max} (цикл While)");

max = array[0];

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
Console.WriteLine($"Вес самой тяжелой гири равен: {max} (цикл For)");

max = array[0];
foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine($"Вес самой тяжелой гири равен: {max} (цикл Foreach)");
