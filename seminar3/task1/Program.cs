// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры:
// [ 1, 3, 4, 19, 3], 8 => Нет
// [ -4, 3, 4, 1 ], 3 => Да

// int[] array1 = new int[5];
// int[] array2 = new int[5] { 1, 3, 4, 19, 3 };
// int[] array3 = new int[] { 1, 3, 4, 19, 3 };

int[] array = { 1, 3, 4, 19, 7 };

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool isExitNum = false;

for (int i = 0; i < array.Length; i++)
{
     if (array[i] == num)
    {
         isExitNum = true;
         break;
    }
}


string result = isExitNum ? "Дв, введенное число присутствует в массиве" : "Нет, введенное число не присутствует в массиве";
Console.WriteLine(result); // Console.WriteLine(isExitNum ? "Дв, введенное число присутствует в массиве" : "Нет, введенное число не присутствует в массиве");

