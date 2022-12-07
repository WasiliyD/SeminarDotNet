// Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

void writeTable(int n) {
    int i = 1;
    while (i <= n) {
        int a = i * i;
        Console.Write(a + ", ");
        i++;
    }

} 

int EnterData(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Запросим номер четверти
int n = EnterData("Введите число:");
// Анализируем данные 
writeTable(n);

