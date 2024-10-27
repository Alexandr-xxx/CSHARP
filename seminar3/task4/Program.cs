// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример:
// 456 => [6 5 4]
// 781 => [1 8 7]


Console.Write("Введите натуральное трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int[] array = new int[3];
    int index = 0;

    while (num > 0) // (num != 0)
    {
        array[index] = num % 10;
        num /= 10; // num = num / 10;
        index++; // index = index - 1;
    }
    // Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    // Console.Write("]");
}
else
{
     Console.Write("Ошибка ввода");
}





