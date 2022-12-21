// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ArithmeticMean(int[,] matr)
{
    double arithm = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            if (j == 0)
            {
                arithm = 0;
            }
            arithm = (arithm + matr[j, i]);
        }

        arithm = arithm / matr.GetLength(0);
        Console.Write(arithm + "; ");
    }

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
int[,] matrix = FillArray(rows, columns, 0, 10);
// Выводим массив
PrintArray(matrix);
Console.Write($"Среднее арифметическое каждого столбца: ");
ArithmeticMean(matrix);