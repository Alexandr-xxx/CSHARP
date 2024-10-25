﻿// Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.
// Пример:
// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4

Console.Write("Введите координату x (положительное число): ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y (положительное число): ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находиться в 1-й четверти плоскости");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находиться в 2-й четверти плоскости");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находиться в 3-й четверти плоскости");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находиться в 4-й четверти плоскости");
}
else if (x == 0 || y == 0)
{
    Console.WriteLine("Некоректные координаты");
}