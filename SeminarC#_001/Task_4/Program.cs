Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine());

int num1 = number * -1;

while (num1 <= number) { 
    Console.Write($"{num1}, ");
    num1++;
}
