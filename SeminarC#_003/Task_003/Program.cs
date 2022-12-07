// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2д пространстве

//Тут будут методы
double FindDistance(int x1, int y1, int x2, int y2) { 
    double numb = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return numb;
} 

int EnterData(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Запросим координаты чисел
int x1 = EnterData("Введите координаты X1:");
int y1 = EnterData("Введите координаты Y1:");
int x2 = EnterData("Введите координаты X2:");
int y2 = EnterData("Введите координаты Y2:");
// Анализируем данные 
double number = FindDistance(x1, y1, x2, y2);
// Вывод информации
Console.WriteLine("Расстояние " + number);
