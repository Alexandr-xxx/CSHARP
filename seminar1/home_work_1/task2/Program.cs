// Написать программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
// Пример:
// 2, 3, 7 => 7
// 44, 5, 78 =>78
// 22, 3, 9 =>22

Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdDigit = Convert.ToInt32(Console.ReadLine());

int maxNum = firstDigit;

if (secondDigit > maxNum)
{
    maxNum = secondDigit;
}
if (thirdDigit > maxNum)
{
    maxNum = thirdDigit;
}
Console.Write($"Максимальное число равно: {maxNum}");