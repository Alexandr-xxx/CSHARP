// Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.
// Пример:
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

Console.Write("Введите натуральное число N: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    if (num < 10)
    {
        Console.WriteLine(num);
    }
    else
    {
        while (num > 0)
        {
            int currentDigit = num % 10;
            num /= 10; // num = num / 10; 
            if (num > 0)
            {
                Console.Write(currentDigit + ", ");
            }
            else
            {
                Console.WriteLine(currentDigit);
            }
        }
    }
}
else
{
    Console.Write("Ошибочный ввод");
}

