// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.

// Примеры:
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.Write("Введите целое положительное трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int secondtDigit = num / 10 % 10; // (487 / 10) % 10 = 48 % 10 = 40 + 8 = 8
    int thirDigit = num % 10; // 487 % 10 = 480 + 7 = 7

    int result = secondtDigit;
    int degree = 1; // если указать int degree = 2; то в 25 строке указываем while (degree <= thirDigit)
    // for (int degree = 2; degree <= thirDigit; degree++) // при этом цикле (for) требуется закоментировать строку 19 (int degree = 2;)
    // {
    //     result = result * secondtDigit; // result *= secondtDigit;
    // }
    // Console.Write($"{secondtDigit} (вторая цифра) возведенная в степень {thirDigit} (третья цифра) равна: {result}");
    while (degree < thirDigit)
    {
        result = result * secondtDigit; // result *= secondtDigit;
        degree++;
    }
    Console.Write($"Число {secondtDigit} (вторая цифра) возводим в степень {thirDigit} (третья цифра) и получаем результат: {result}");
}
else
{
    Console.Write("Ошибка ввода");
}