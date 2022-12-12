// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfNumbers(int number) {
    int res = 0;
    Console.WriteLine(number);
    for (int count = 1; number > 0; count++) {
        res = res + number % 10;
        number /= 10;
    }
    return res;
}

int GetNumber(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = GetNumber("Введите число: ");
int s = SumOfNumbers(a);
Console.WriteLine($"Получение суммы: {s}");
