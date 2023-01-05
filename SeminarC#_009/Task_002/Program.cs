// Задача 65. Задайте значение M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

string NaturalNumber(int begin, int end)
{
    if (begin == end) return begin.ToString();

    return (begin + ", " + NaturalNumber(begin + 1, end));
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int n = GetNumber("Задайте значение N: ");
int m = GetNumber("Задайте значение M: ");

Console.WriteLine(NaturalNumber(n, m));