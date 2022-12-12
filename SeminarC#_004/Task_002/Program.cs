// Решение в группах задач:
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int SumOfNumbers(int number) {
    int sum = 1;
    for (int count = 1; number > 0; count++) {
        number = number / 10;
        sum = count;
    }
    return sum;
}

int GetNumber(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = GetNumber("Введите число: ");
int s = SumOfNumbers(a);
Console.WriteLine($"Получение суммы: {s}");
