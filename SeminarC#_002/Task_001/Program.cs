// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

// Сгенирировать число
int n = new Random().Next(10, 100);
Console.WriteLine(n);
// Разделить число на 2 переменные
int numberA = n % 10;
int numberB = n / 10;
Console.WriteLine(numberA);
Console.WriteLine(numberB);
// Сравнить 2 числа
int max = numberA;

if (max < numberB) {
    max = numberB;
 }
 // Вывести наибольшее число через max
Console.WriteLine($"В числе {n} наибольшее число {max}");
