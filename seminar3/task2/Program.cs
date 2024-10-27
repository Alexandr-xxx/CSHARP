// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример:
// [1 -5 6]
// => [-1 5 -6]

int[] array = new int[10] { 1, 7, -2, 4, -6, -9, -3, -5, 8, 2 };

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"{array[i]}, ");
// }

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1; // array[i] = array[i] * -1;
}
// Console.WriteLine(" ");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");
}