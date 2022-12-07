// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдает номер четверти плоскости, в которой находится эта точка.

//Тут будут методы
int FindQuarter(int x, int y) { // x и y относятся только к методу
    int result = 0;
    if (x > 0 && y > 0) return result = 1;
    if (x < 0 && y > 0) return result = 2;
    if (x < 0 && y < 0) return result = 3;
    if (x > 0 && y < 0) return result = 4;
    return result;
} 

int EnterData(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine()); // не относится к нумберу в программе
    return number;
}

// Запросим координаты чисел
int x = EnterData("Введите координаты X:");
int y = EnterData("Введите координаты Y:");
// Анализируем данные 
int number = FindQuarter(x, y);
// Вывод информации
Console.WriteLine("Ваши координаты находятся в " + number + " четверти");