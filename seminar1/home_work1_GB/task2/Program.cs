// Поиск среднего из трех чисел
// Описание: Напишите метод, который принимает на вход три числа и возвращает
// среднее из этих чисел (то есть не самое большое и не самое маленькое).

// Пример использования: На входе:
// ● a: 5
// ● b: 3
// ● c: 8
// На выходе:
// ● 5

// На входе:
// ● a: 1
// ● b: 9
// ● c: 7
// На выходе:
// ● 7

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if ((firstNumber <= secondNumber && firstNumber >= thirdNumber) || (firstNumber >= secondNumber && firstNumber <= thirdNumber))
{
    Console.WriteLine($"Среднее число равно: {firstNumber}");
}
else
{
    if ((secondNumber <= firstNumber && secondNumber >= thirdNumber) || (secondNumber >= firstNumber && secondNumber <= thirdNumber))
    {
        Console.WriteLine($"Среднее число равно: {secondNumber}");
    }
    else
    {
        Console.WriteLine($"Среднее число равно: {thirdNumber}");
    }
}

