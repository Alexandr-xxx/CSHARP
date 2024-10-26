// Создать массив и заполнить его целыми
// числами от 1 до N (N – произвольное
// натуральное число). Вывести элементы
// массива на экран.

int n = 10;
//Console.Write("Введите натуральное число: ");
//int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];
int i = 0; // i - это счётчик

while (i < arr.Length)
{
    arr[i] = i + 1;
    Console.Write($"{arr[i]} "); // Console.Write(arr[i] + " ");
    i++; // i = i + 1;
}

