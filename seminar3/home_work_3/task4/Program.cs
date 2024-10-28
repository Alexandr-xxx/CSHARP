// Задача 4**(не обязательно): Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.
// Пример:
// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]

Console.Write("Введите натуральное число в диапозоне от 1 до 100 000: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int a = num;

if (num >= 1 && num <= 100000)
{
    while (a > 0)
    {
        a /= 10;
        count++;
    }


    int[] array = new int[count];

    for (int i = array.Length - 1; i >= 0; i--)
    {
        array[i] = num % 10;
        num = num / 10;
    }

    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
else
{
    Console.Write("Ошибочный ввод");
}