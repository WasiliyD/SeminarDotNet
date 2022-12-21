// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void FindNumber(int[,] matr, int a, int b)
{
    int net = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == a - 1 & j == b - 1)
            {
                net = 1;
                Console.Write($"Есть! значение {matr[i, j]}");
                break;
            }
        }
    }
    if (net == 0) Console.Write($"НЭТУ");
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
int[,] matrix = FillArray(rows, columns, -10, 100);
// Выводим массив
PrintArray(matrix);

int findRows = GetNumber("Введите номер строки: ");
// Запрос количества столбцов
int findColumns = GetNumber("Введите номер столбца: ");
FindNumber(matrix, findRows, findColumns);