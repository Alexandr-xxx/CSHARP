// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример:
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// char[] array = new char[] {'a', 'b', 'c', 'd'};

string CharArrayToString(char[] arr)
{
    string res = string.Empty; // string res = "";
    for (int i = 0; i < arr.Length; i++)
    {
        res += arr[i];
    }
    return res;
}

char[] array = { 'a', 'b', 'c', 'd' };

string result = CharArrayToString(array);
Console.WriteLine(result);