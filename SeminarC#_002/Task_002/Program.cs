// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int n = new Random().Next(100, 1000);
Console.WriteLine(n);
int numberA = (n / 100) * 10;
int numberB = n % 10;
int result = numberA + numberB;

Console.WriteLine(result);

