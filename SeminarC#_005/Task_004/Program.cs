// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int Change(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 & array[i] <100){ 
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
int[] way = CreateMassive(123, 0, 150);
Console.WriteLine($"[{string.Join(", " , way)}]");
int sumPlus = Change(way);
Console.WriteLine(sumPlus);