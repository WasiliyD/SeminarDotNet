// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли она палиндромом.

string Examination(string n)
{
    string result;
    if (n[0] == n[4] & n[1] == n[3]) {
        result = "число " + n + " палиндром";
    }
    else { 
        result = "число " + n + " не палиндром";
    }
    return result;
}

string EnterData(string text) {
    Console.WriteLine(text);
    string number = Console.ReadLine();
    return number;
}

string n = EnterData("Введите пятизначное число:");
string number = Examination(n);
Console.WriteLine(number);