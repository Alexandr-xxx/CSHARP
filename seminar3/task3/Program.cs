// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример:
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int[] array = new int[6] { 1, 3, 2, 4, 2, 3 };
// int[] array = new int[7] { 2, 3, 1, 7, 5, 6, 3 };
int[] arrayResult = new int[array.Length / 2];

int left = 0;
int right = array.Length - 1;

while (left < right)
{
    arrayResult[left] = array[left] * array[right];
    left++;
    right--;
}

// или (при цикле for переменная <Left> не потребуется, её нужно закоментировать)
// for (int i = 0; i < right; i++)
// {
//     arrayResult[i] = array[i] * array[right];
//     right--;
// }

for (int i = 0; i < arrayResult.Length; i++)
{
    Console.Write($"{arrayResult[i]} ");
}