// Напишите программу, котороая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (x и y).

//Тут будут методы
string WriteQuarter(int x) {
    string result = "Четверть должна быть от 1 до 4";
    if (x == 1) return result = "Диапазон Х от 0 до + бесконечности, Y от 0 до + бесконечности";
    if (x == 2) return result = "Диапазон Х от 0 до - бесконечности, Y от 0 до + бесконечности";
    if (x == 3) return result = "Диапазон Х от 0 до - бесконечности, Y от 0 до - бесконечности";
    if (x == 4) return result = "Диапазон Х от 0 до + бесконечности, Y от 0 до - бесконечности";
    return result;
} 

int EnterQuarter(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Запросим номер четверти
int x = EnterQuarter("Введите номер четверти:");
// Анализируем данные 
string number = WriteQuarter(x);
// Вывод информации
Console.WriteLine(number);