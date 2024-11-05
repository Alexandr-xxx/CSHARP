// // 1-й способ:
// string str1 = "Hello world";
// Console.Write(str1[2]);
// // Console.Write(str1);

// // 2-й способ:
// char[] ch_array = {'w', 'o', 'r', 'l', 'd'};
// string str2 = new String(ch_array);
// Console.Write(str2[2]);
// // Console.Write(ch_array);

// // 3-й способ:

// string str3 = new string('a', 6); // результатом будет строка "aaaaaa"
// Console.Write(str3);


// Задача №3
// Лекция 4. Двумерные массивы
// Считать с консоли строку, состоящую из
// цифр и латинских букв.
// Сформировать новую строку, состоящую из
// букв исходной строки.


// Этапы решения:
// 1. Ввод строки
// 2. Проход по элементам строки
// 3. Проверка элемента: является ли
// он буквой?
// 4. Дописать подходящий элемент к
// новой строке

// Пример:
// 123passw0rd
// {1 2 3 p a s s w 0 r d}
// is letter?
// p ← a
// pa ← s
// pas ← s
// ...

string GetLettersFromString(string s)
{
    string Letters = "";
    foreach(char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            Letters = Letters + e;
        }
    }
    return Letters;
}

string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);


