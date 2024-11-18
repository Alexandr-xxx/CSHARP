// Домашнее задание (семинар 7)

// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Пример:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


void ShowNumbersRange(int m, int n)
{   
    if (m > n)
    {
        return;        
    }

    if (m < n)
    {        
        Console.Write($"{m}, ");
        ShowNumbersRange(m + 1, n);
    }    

    else
    {
        Console.Write(m);
    }
}

Console.Write("Введите первое натуральное число: ");
int numbersM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int numbersN = Convert.ToInt32(Console.ReadLine());

Console.Write($"Диапозон чисел в заданном промежутке: ");
ShowNumbersRange(numbersM, numbersN);