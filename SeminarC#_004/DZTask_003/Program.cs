// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void NewArray(int d) { 
int[] arr = new int[d];
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(0, 99);
    }
    Console.Write($"[{string.Join(", " , arr)}]");
}

int GetNumber(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = GetNumber("Задайте длину массива: ");
NewArray(a);
