// Задача 1: Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90].

// Пример:
// массив [10 21 14 93 23] => 2

int[] array = new int[10] { 45, 18, 90, 10, 21, 14, 91, 23, 7, 89};

int min = 20;
int max = 90;
int quantity = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= min && array[i] <= max)
    {
        quantity++;
    }
}
Console.Write($"Количество элементов массива, значения которых лежат в отрезке [20,90] равно: {quantity}");














// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] <= max)
//     {
//         if (array[i] >= min && array[i] <= max)
//         {
//             quantity++;
//         }
//     }

// }
// Console.Write(quantity);


