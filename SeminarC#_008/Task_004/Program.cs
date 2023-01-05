// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
// Например, задан массив: 1 4 7 2 5 9 2 3 8 4 2 4 5 2 6 7 
// Наименьший элемент - 1, на выходе получим  следующий массив: 9 4 2 2 2 6 3 4 7

int[,] FindMin(int[,] matr)
{
    int min = matr[0, 0];
    int minCol = 0;
    int minRow = 0;
    int k = -1;
    int ss = -1;
    int[,] newArray = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                minCol = i;
                minRow = j;

            }
        }
    }

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (i == minCol) continue;
        k++;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == minRow) continue;
            if (newArray.GetLength(1) - 1 == ss) ss = 0;
            else ss++;
            newArray[k, ss] = matr[i, j];

        }
    }
    return newArray;
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
int[,] matrix1 = FindMin(matrix);
Console.WriteLine();
PrintArray(matrix1);
