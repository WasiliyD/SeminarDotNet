// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите число трехзначное: ");
int number = int.Parse(Console.ReadLine());

if (number > 999 || number < 100) {
    Console.WriteLine("Число не трехзначное");
 }
else { 
    int a = number / 10 % 10;
    Console.WriteLine(a);
}



