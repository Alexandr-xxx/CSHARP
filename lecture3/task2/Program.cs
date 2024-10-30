void PrintSquare(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i*i} ");
        i++; // i = i + 1;
    }
}

PrintSquare(5);
PrintSquare(10);
PrintSquare(15);
