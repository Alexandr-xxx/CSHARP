int a = 10;
long b = 150;
double c = 2.5;
double d = 7.5;

long product = a * b;
double sum = c + d;

double quotient = product / sum;

Console.WriteLine($"Даны переменные a = {a}; b = {b}; c = {c}; d = {d}; \n");

Console.WriteLine("Результат примера:");
Console.WriteLine($"(a * b) / (c + d) = {quotient} \n");