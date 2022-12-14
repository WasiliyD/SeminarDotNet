// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Change(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0){ 
        res = (res) + (array[i]);
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
int[] way = CreateMassive(4, -100, 100);
Console.WriteLine($"[{string.Join(", " , way)}]");
int sumPlus = Change(way);
Console.WriteLine(sumPlus);
