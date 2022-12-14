// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] Change(int[] array) //длина равна 6
{
    int item = 0;
    if (array.Length % 2 != 0) { //длина равна 6%2 не равна 0
        item = 1;
    }
    int[] arr = new int[array.Length/2 + item]; //длина массива арр 6/2 + 0 = 2
    for (int i = 0; i < array.Length / 2; i++)
    { 
        Console.WriteLine(array[i] * array[array.Length - 1 - i]);
        arr[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0) {
        Console.WriteLine(array[array.Length / 2]);
        arr[array.Length / 2] = array[array.Length / 2];
    }
    return arr;
}
int[] CreateMassive(int count, int begin, int end) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = new Random().Next(begin, end + 1);
    }
    return array;
}
int[] way = CreateMassive(5, 1, 3);
Console.WriteLine($"[{string.Join(", " , way)}]");
int[] way1 = Change(way); 
Console.WriteLine($"[{string.Join(", " , way1)}]");
