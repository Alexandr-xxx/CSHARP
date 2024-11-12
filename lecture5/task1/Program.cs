

int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop requrson: n={n}");
        return 1;
    }
    Console.WriteLine(n);    
    return n * Fact(n - 1);
}

// int result = Fact(5);
// Console.WriteLine(result);
Console.WriteLine(Fact(5));

// F11 шаг с заходом
// f10 шаг с обходом
// F5 продолжить
