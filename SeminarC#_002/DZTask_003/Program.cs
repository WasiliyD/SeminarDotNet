// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите номер дня: ");

int day = int.Parse(Console.ReadLine());

if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5 || day == 6 || day == 7){
    if (day == 1) Console.Write("Понедельник, не выходной");
    if (day == 2) Console.Write("Вторник, не выходной");
    if (day == 3) Console.Write("Среда, не выходной");
    if (day == 4) Console.Write("Четверг, не выходной");
    if (day == 5) Console.Write("Пятница, не выходной");
    if (day == 6) Console.Write("Суббота, выходной");
    if (day == 7) Console.Write("Воскресенье, выходной");
}
else Console.Write("не день недели");
