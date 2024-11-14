// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом..
// Пример:
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

void ShowAPalindromeOrNotAPalindrome(string[] args)
{
    string input = "а роза упала на лапу азора";
    // string input = "aBcD1ef!-";
    // string input = "шалаш";
    // string input = "55655";
    bool isPalindrome = StringСonversionRemovingNonAlphanumericCharTolower(input);
    Console.WriteLine(isPalindrome ? "Да" : "Нет");
}

bool StringСonversionRemovingNonAlphanumericCharTolower(string str)
{
    string normalized = new
    string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    return normalized.SequenceEqual(normalized.Reverse());
}

ShowAPalindromeOrNotAPalindrome(args);