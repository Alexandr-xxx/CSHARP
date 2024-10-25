// Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23
// Пример;
// a=50 => нет
// a=7 => нет
// a=322 => да

Console.Write("Ведите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int firstDigit = 7;
int secondeDigit = 23;

if (num % firstDigit == 0 && num % secondeDigit == 0)
{
    Console.Write($"Число {num} кратно числам {firstDigit} и {secondeDigit}");
}    
else
{
    Console.Write($"Число {num} не кратно числам {firstDigit} и {secondeDigit}");
}