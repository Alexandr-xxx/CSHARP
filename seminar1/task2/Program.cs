﻿// Напишите программу, которая на вход принимает целое число N, 
// а на выходе показывает все целые числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    int count = -num; // num * -1

    while (count <= num)
    {
        Console.Write(count + " ");
        count++; // count = count + 1; (в python: count +=1;)
    }
}
else
{
    Console.Write("Ошибка ввода");
}
