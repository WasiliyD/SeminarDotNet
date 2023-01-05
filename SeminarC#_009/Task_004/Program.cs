// Задача 69. Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень B c помощью рекурсии.
// А=3; B=5 -> 243 (3 в 5)
// А=2; B=3 -> 8

int SumOfNumber(int a, int b)
{
    if (b == 0) return 1;
    if (b == 1) return a;
    return (a * SumOfNumber(a, (b - 1)));
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = GetNumber("Задайте значение A: ");
int b = GetNumber("Задайте значение B: ");
Console.WriteLine(SumOfNumber(a, b));