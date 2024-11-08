// Считать с консоли строку, состоящую из цифр и латинских букв.
// Сформировать массив, состоящий из цифр этой строки.
// - Разделить логику алгоритмов на функции.
// - Память под массив выделять необходимого размера
// (не больше, чем количество элементов)

string GetDigitsFromString(string text)
{
    string digits = "";

    foreach (char e in text)
    {
        if (char.IsAsciiDigit(e) == true)
        {
            digits += e;
        }        
    }
    return digits;
}

int CountDigits(int digits)
{
    int countDigits = 0;

    while (digits > 0)
    {
        digits /= 10;
        countDigits++;
    }
    return countDigits;
}

int[] CetArrayDigitsFromString(int size, int digits)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        if (digits > 0)
        {
            array[array.Length - 1 - i] = digits % 10;
            digits /= 10;
        }
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[ ");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1 )
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }        
    }
    Console.Write(" ]");
}

Console.Write("Введите текст (используя латинские буквы, цифры, знаки): ");

string str = Console.ReadLine();
string resultDigits = GetDigitsFromString(str);

int digits = Convert.ToInt32(resultDigits);
int size = CountDigits(digits);

int[] arrayDigits = CetArrayDigitsFromString(size, digits);
ShowArray(arrayDigits);