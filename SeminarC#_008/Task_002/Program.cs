// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] ChangeColumns(int[,] matr)
{
    int temp;
    int tempindex = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = tempindex; j < matr.GetLength(1); j++)
        {
            temp = matr[i, j];
            matr[i, j] = matr[j, i];
            matr[j, i] = temp;
        }
        tempindex++;
    }
    return matr;
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

if (matrix.GetLength(0) == matrix.GetLength(1)) 
{
    int[,] changeMatrix = ChangeColumns(matrix);
    Console.WriteLine();
    PrintArray(changeMatrix);
}
else
{
    Console.WriteLine();
    Console.WriteLine("Не перевернуть!");
}
