﻿// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

char[] StringToCharArray(string s)
{
    char[] strArray = new char[s.Length];

    for (int i = 0; i < s.Length; i++)
    {
        strArray[i] = s[i];
    }
    return strArray;
}

void ShowStrArray(char[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

Console.Write("Введите строку: ");
string str = Console.ReadLine();
char[] resArray = StringToCharArray(str);

ShowStrArray(resArray);