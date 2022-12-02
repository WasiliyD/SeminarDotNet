
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

int result1 = number1 * number1;
int result2 = number2 * number2;

if (number1 == result2) { 
    Console.WriteLine($"да");
}
else { 
    Console.WriteLine($"нет");
}