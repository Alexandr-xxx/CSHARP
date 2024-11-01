// int n = 10;
// int[] arr = new int[n];
// int i = 0;

// while (i < n)
// {
//     arr[i] = i + 1;
//     i++;
// }

// i = 0;
// while (i < n)
// {
//     Console.Write($"{arr[i]} ");
//     i++;
// }

// i = 0;
// int sum = 0;
// while (i < n)
// {
//     sum = sum + arr[i];
//     i++;
// }

// i = 0;
// int product = 1;
// while (i < n)
// {
//     product = product * arr[i];
//     i++;
// }
// Console.WriteLine("");
// Console.WriteLine($"Сумма элементов массива равна: {sum}");
// Console.WriteLine($"Произведение элементов массива равно: {product}");

// Написать функции к коду выше.


int size = 10;
int[] array = new int[size];

int[] FillArray(int size)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("] ");
}

int GetSumOfElements(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }

    return sum;
}

int GetProductOfElements(int[] array)
{
    int product = 1;

    for (int i = 0; i < array.Length; i++)
    {
        product = product * array[i];
    }

    return product;
}

int[] arr = FillArray(size);
PrintArray(arr);

int sumElements = GetSumOfElements(arr);
Console.WriteLine("");
Console.Write($"Сумма всех элементов массива равна: {sumElements}");

int productElements = GetProductOfElements(arr);
Console.WriteLine("");
Console.Write($"Произведение всех элементов массива равно: {productElements}");




