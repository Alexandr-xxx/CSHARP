// Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.
// Пример:
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]


while (true) // Бесконечный цикл [1](https://github.com/borogen100979/c4z1)
{
    Console.Write("Введите число или 'q' для выхода: ");
    string input = Console.ReadLine(); // Чтение строки ввода пользователя [1](https://github.com/borogen100979/c4z1)
    if (input == "q") // Проверка на ввод 'q' для выхода
    {
        break;
    }
    int number;
    if (int.TryParse(input, out number)) // Проверка, является ли ввод числом [1](https://github.com/borogen100979/c4z1)
    {
        int sum = 0;
        while (number > 0) // Вычисление суммы цифр числа
        {
            sum += number % 10; // Добавление последней цифры к сумме
            number /= 10; // Удаление последней цифры из числа
        }
        if (sum % 2 == 0) // Проверка, является ли сумма цифр чётной
        {
            Console.WriteLine("[STOP]");
            break;
        }
    }
    else // Если ввод не является числом и не 'q', повторить запрос
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
    }
}

// --------------------------------------------


// int SumOfDigits(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     return sum;
// }

// void SumOfDigitsIsEven(int sum)
// {
//     if (sum % 2 == 0)
//     {
//         Console.WriteLine("[STOP]");
//         //break;
//     }

//     else
//     {
//         Console.WriteLine("Некорректный ввод. Пожалуйста, введите число (сумма цифр которого четная) или 'q' для выхода: ");
//         //break;
//     }
// }

// Console.Write("Введите число (сумма цифр которого четная) или 'q' для выхода: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int sumDigit = SumOfDigits(num);
// // Console.Write(sumDigit);
// SumOfDigitsIsEven(sumDigit);