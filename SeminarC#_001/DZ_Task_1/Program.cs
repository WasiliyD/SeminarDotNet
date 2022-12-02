Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b) {
    int max = a;
    int min = b;
    Console.Write($"Число {max} больше {min}");
}

if (a < b) {
    int max = b;
    int min = a;
    Console.Write($"Число {max} больше {min}");
}

if (a == b) { 
    int max = b;
    int min = a;
    Console.Write($"Число {max} равно {min}");
}
