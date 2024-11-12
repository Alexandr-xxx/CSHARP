int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop requrson: n={n}");
        return 1;
    }
    Console.WriteLine(n);
    int result = n * Fact(n - 1);
    Console.WriteLine($"Возврат: n={n}, fact={result / n}");
    return result;
}

Console.WriteLine(Fact(5));