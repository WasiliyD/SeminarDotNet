// Решение в группах задач:
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int SumOfNumbers(int number) {
    int sum = 1;
    for (int count = 1; count <= number; count++) {
        sum = sum * count;
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
Console.WriteLine($"Произведение чисел: {s}");