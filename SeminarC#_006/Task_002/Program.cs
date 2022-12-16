// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.  
// <aside> ❗ Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.  </aside>
// (a+b)>c
//
//

bool Return(int x, int y, int z){

    bool answer = false;
    if (x < y + z && y < x + z && z < x + y) { 
        answer = true;
    }
    return answer;
}

int GetNumber(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = GetNumber("Введите число a: ");
int b = GetNumber("Введите число b: ");
int c = GetNumber("Введите число c: ");

if (Return(a,b,c)) 
    Console.WriteLine("да");
else 
    Console.WriteLine("нет");