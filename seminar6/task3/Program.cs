// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример:
// “hello” => 2
// “world” => 1

int CountOfVowelLetters(string str)
{
    string vowels = "aeiouy";
    int count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (str[i] == vowels[j])
            {
                count++;
            }
        }
    }
    return count;
}

Console.Write("Введите строку из латинских букв в нижнем регистре: ");
string str = Console.ReadLine();
Console.WriteLine($"Количество гласных равно: {CountOfVowelLetters(str)}");