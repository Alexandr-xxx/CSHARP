// Написать программу, которая на вход принимает два числа и выдает, какое число большее, а также меньшее.
// Пример:
// a=5; b=7 => max=7, min=5
// a=2; b=10 => max=10, min=2
// a=-9; b=-3 => max=-3, min=-9

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write($"Наибольшее число равно: {num1}, наименьшее число равно: {num2}");
}
if (num1 < num2)
{
    Console.Write($"Наибольшее число равно: {num2}, наименьшее число равно: {num1}");
}

if (num1 == num2)
{
    Console.Write($"Числа {num1} и {num2} равны");
}