void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = { 1, 2, 3, 4, 5 };
ZeroEvenElements(array);
PrintArray(array);


// void Foo(int a)
// {
//     Console.Write(a);
// }

// int value = 5;
// Foo(value);


// void Foo(int a)
// {
//     a = 0;
// }

// int value = 5;
// Foo(value);
// Console.Write(value);