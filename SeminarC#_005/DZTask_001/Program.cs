// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Change(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0){ 
        res ++;
        }
    }
    return res;
}
int[] CreateMassive(int count, int begin, int end) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = new Random().Next(begin, end+1);
    }
    return array;
}
int[] way = CreateMassive(4, 100, 999);
Console.WriteLine($"[{string.Join(", " , way)}]");
int sumPlus = Change(way);
Console.WriteLine(sumPlus);