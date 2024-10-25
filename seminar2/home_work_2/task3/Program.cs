// Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// Пример:
// 40 => 4
// 96 => 9
// 72 => 7


Console.Write("Введите целое число от 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());

int firstDigit = num / 10;
int secondeDigit = num % 10;

if (num >= 10 && num <= 99)
{
    if (firstDigit > secondeDigit)
    {
        Console.Write($"Наибольшая цифра из числа {num} равна {firstDigit}");
    }
    else if (secondeDigit > firstDigit)
    {
        Console.Write($"Наибольшая цифра из числа {num} равна {secondeDigit}");
    }
    else if (secondeDigit == firstDigit)
    {
        Console.Write($"Цифры из числа {num} равны");
    }
}
else
{
    Console.Write("Некоректный ввод");
}