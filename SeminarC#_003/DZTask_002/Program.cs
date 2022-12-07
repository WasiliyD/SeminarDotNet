// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3д пространстве

double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2) { 
    double numb = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return numb;
} 

int EnterData(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int x1 = EnterData("Введите координаты X1:");
int y1 = EnterData("Введите координаты Y1:");
int z1 = EnterData("Введите координаты Z1:");
int x2 = EnterData("Введите координаты X2:");
int y2 = EnterData("Введите координаты Y2:");
int z2 = EnterData("Введите координаты Z2:");

double number = FindDistance(x1, y1, z1, x2, y2, z2);

Console.WriteLine("Расстояние " + number);
