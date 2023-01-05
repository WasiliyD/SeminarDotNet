// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 2 встречается 1 раз  8 встречается 1 раз  9 встречается 3 раза 1, 2, 3  4, 6, 1  2, 1, 6 1 встречается 3 раза 2 встречается 2 раз  3 встречается 1 раз  4 встречается 1 раз  6 встречается 2 раза

void FrequenceNumber(int[,] array, int num)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == num) sum++;
        }
    }
    if(sum!=0) Console.WriteLine($"Число {num} встречается {sum} раз");
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rows, int columns, int begin, int end)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(begin, end); // [1;10}
        }
    }
    return array;
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Запрос количества строк
int rows = GetNumber("Введите количество строк: ");
// Запрос количества столбцов
int columns = GetNumber("Введите количество столбцов: ");
// Создаем двумерный массив и заполнем его случайными числами
int[,] matrix = FillArray(rows, columns, 1, 10);
// Выводим массив
PrintArray(matrix);
int num = GetNumber("Введите число: ");
FrequenceNumber(matrix, num);
