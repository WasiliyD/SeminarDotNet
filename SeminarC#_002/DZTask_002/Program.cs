// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

// if (number > 99) {
//     string numberText = Convert.ToString(number); 
//     Console.WriteLine(numberText[2]);
//  }
// else { 
//     Console.WriteLine("третьей цифры нет");
// }

if (number > 99) {
    while (number > 999) {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine(number);
 }
else { 
    Console.WriteLine("третьей цифры нет");
}