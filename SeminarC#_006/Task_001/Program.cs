// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]  
// [6 7 3 6] -> [6 3 7 6]

void ReverseMyArray(int[] array){
    for (int i = 0; i < array.Length/2; i++){
        int el = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = el;
    }
}

void PrintArray(int[] array){
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] CreateMassive(int count, int begin, int end) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = new Random().Next(begin, end + 1);
    }
    return array;
}

int[] way = CreateMassive(6, 10, 99);
Console.WriteLine($"[{string.Join(", " , way)}]");
PrintArray(way);

Array.Reverse(way);
Console.WriteLine($"[{string.Join(", " , way)}]");
PrintArray(way);

ReverseMyArray(way);
PrintArray(way);