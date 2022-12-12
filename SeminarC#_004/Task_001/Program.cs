// 
int SumOfNumbers(int number) {
    int sum = 0;
    for (int count = 1; count <= number; count++) {
        sum = sum + count;
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
