// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Number(int[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) { 
            num++;
        }
    }
    return num;
}

int[] CreateMassive(int count) {
    int[] array = new int[count];
    for (int i = 0; i < count; i++) {
        array[i] = GetNumber($"Введите число {i+1}: ");
    }
    return array;
}

int GetNumber(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int n = GetNumber("Сколько чисел вы введете: ");

int[] way = CreateMassive(n);
Console.WriteLine($"[{string.Join(", " , way)}]");
Console.WriteLine($"Чисел больше нуля: {Number(way)}");