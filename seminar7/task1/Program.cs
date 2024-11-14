// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример:
// N=5 => 1 2 3 4 5

void ShowNaturalNumbers(int num)
{
    if(num == 0) return;
    ShowNaturalNumbers(num - 1); 
    Console.Write($"{num} ");        
}

Console.Write("Введите натуральное число число: ");
int number = Convert.ToInt32(Console.ReadLine());

 ShowNaturalNumbers(number);