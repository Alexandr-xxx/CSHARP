// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231


int[] CreatArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]} ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

int ArrayToNumbersInt(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result = result * 10 + array[i];
    }
    return result;
}


Console.Write("Введите размер массива (не более 8): ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1 || num > 8)
{
    Console.Write("Некорректный ввод!");
    return;
}

int[] arr = CreatArrayRndInt(num, 0, 10);
PrintArray(arr);

int res = ArrayToNumbersInt(arr);
Console.Write($" => {res}");

// или
// Console.Write($" => {ArrayToNumbersInt(arr)}");




