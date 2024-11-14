// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример:
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d


void ShowConsonants(string txt, int index = 0)
{
    if (index == txt.Length)
    {
        return;
    }
    string consonants = "abcdfghjklmnpqrstvwxz";
    if (consonants.Contains(txt[index])) // если бы сверяли с гласными буквами => if (char.IsAsciiLetter(txt[index]) && !vowels.Contains(txt[index]))
    {
        Console.Write($"{txt[index]} "); 
    }
    ShowConsonants(txt, index + 1);
}

Console.Write("Введите строку содержащую латинские буквы: ");
string text = Console.ReadLine();
ShowConsonants(text);