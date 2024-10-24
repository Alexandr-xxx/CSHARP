﻿// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.

// Примеры:
// a = 256 => 26
// a = 891 => 81

Console.Write("Введите целое трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num >= 100 && num <=999) || (num >= -999 && num <= -100))
{
    int firstDigit = num / 100; // 256 / 100 = 2.56 = 2
    int thirDigit = num % 10; // 256 % 10 = 250 + 6 = 6

    int result = firstDigit * 10 + thirDigit;

    Console.Write($"Исключили вторую цифру из трёхзначного числа и получили {result}");
}
else
{
    Console.Write("Ошибка ввода");
}