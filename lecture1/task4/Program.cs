int a = 555;
int b = -677;
int c = 817;
int d = 976;
int e = -95;

int max = a;
int min = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
if (d > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}
if (b < min)
{
    min = b;
}
if (c < min)
{
    min = c;
}
if (d < min)
{
    min = d;
}
if (e < min)
{
    min = e;
}

Console.WriteLine($"Из чесел {a}, {b}, {c}, {d}, {e}, наибольшее число {max}, наименьшее число {min}\n");