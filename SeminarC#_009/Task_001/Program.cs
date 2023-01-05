// Задача 63. Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int NaturalNumber(int n)
{
    if (n == 1) return n;
    else
    {
        Console.Write($"{NaturalNumber(n - 1)}, ");
    }
    return n;
}


int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int n = GetNumber("Задайте значение N: ");
Console.WriteLine(NaturalNumber(n));