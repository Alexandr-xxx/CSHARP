// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример:
// “hello” => 2
// “world” => 1
// Решение 2: (первое решение в task3)

int CountOfVowelLetters(string str)
{
    string vowels = "aeiouy";
    int count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (vowels.Contains(str[i]))
        {
            count++;
        }
    }

    return count;
}

Console.Write("Введите строку из латинских букв в нижнем регистре: ");
string str = Console.ReadLine();
Console.WriteLine($"Количество гласных равно: {CountOfVowelLetters(str)}");