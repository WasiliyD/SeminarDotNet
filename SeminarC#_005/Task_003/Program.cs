// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

void SumNumber(int[] array, int number)
{
    string answer = "Числа нет";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) { 
            
            answer = "Число есть";
            break;
        }
    }
    Console.WriteLine(answer);
}

int GetNumber(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] CreateMassive(int count, int begin, int end) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = new Random().Next(begin, end+1);
    }
    return array;
}

int[] way = CreateMassive(5, 0, 3);
int num = GetNumber("Задайте число: ");
Console.WriteLine($"[{string.Join(", " , way)}]");
SumNumber(way, num);