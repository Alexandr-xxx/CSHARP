// Определите, делится ли число на другое.
// Описание: Напишите метод, который на вход принимает два целых числа и проверяет,
// делится ли первое число на второе. Если делится, выводите "делится", иначе
// выводите "не делится".

// Пример использования: 
// На входе:
// ● firstNumber: 10
// ● secondNumber: 2
// На выходе:
// ● делится

// На входе:
// ● firstNumber: 10
// ● secondNumber: 3
// На выходе:
// ● не делится


Console.Write("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (secondNumber == 0)
{
    Console.Write($"Число {firstNumber} нельзя поделить на {secondNumber} (на ноль делить нельзя)");
}
else
{
    if (firstNumber % secondNumber == 0)
    {
        Console.Write($"Число {firstNumber} делится на число {secondNumber}");
    }
    else
    {
        Console.Write($"Число {firstNumber} не делится на число {secondNumber}");
    }
}


