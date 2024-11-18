// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.
// Пример:
// m = 2, n = 3 -> A(m,n) = 9

using System.Globalization;

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    else
    {
        if (m > 0 && n == 0)
        {
            return AckermanFunction(m - 1, 1);
        }

        else
        {
            if (m > 0 && n > 0)
            {
                return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
            }

        }
    }
    
    return 0;
}

Console.Write("Введите неотрицательное число m: ");
int numbersM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int numbersN = Convert.ToInt32(Console.ReadLine());

int m = numbersM;
int n = numbersN;
int result = AckermanFunction(m, n);

if (m < 0 || n < 0)
{
    Console.WriteLine("Некорректный ввод!!!");
}
else
{
    Console.WriteLine($"Значение функции Аккермана: A({m}, {n}) = {result}");
}