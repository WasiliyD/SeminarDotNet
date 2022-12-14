// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int Change(int[] array)
{
    
    int max = array[0];
    int min = array[0];
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }

Console.WriteLine("max: " + max);
Console.WriteLine("min: " + min);           
res = max - min;

    return res;
}
int[] CreateMassive(int count, int begin, int end) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = new Random().Next(begin, end+1);
    }
    return array;
}
int[] way = CreateMassive(4, -100, 100);
Console.WriteLine($"[{string.Join(", " , way)}]");
int sumPlus = Change(way);
Console.WriteLine("Разница: " + sumPlus);


