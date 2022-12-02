
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

int i = 2;

while ( i <= n ) {
    Console.Write($"{i}, ");
    i += 2;
}
