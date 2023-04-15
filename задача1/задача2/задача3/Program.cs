//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом. (палиндром - число читается слева направо и справа налево одинаково)

//14212 -> нет

//12821 -> да

//23432 -> да



Console.WriteLine("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);

int x = number % 10;

//Console.WriteLine($"{x}");
int x1 = number / 10 % 10;

//Console.WriteLine($"{x1}");
int x2 = number / 100 % 10;

//Console.WriteLine($"{x2}");
int x3 = number / 1000 % 10;

//Console.WriteLine($"{x3}");
int x4 = number / 10000;

//Console.WriteLine($"{x4}");



int y = number / 10000;

//Console.WriteLine($"{y}");

int y1 = number / 1000 % 10;

//Console.WriteLine($"{y1}");

int y2 = number / 100 % 10;

//Console.WriteLine($"{y2}");
int y3 = number / 10 % 10;

//Console.WriteLine($"{y3}");

int y4 = number % 10;

//Console.WriteLine($"{y4}");

if (x == y && x1 == y1 && x2 == y2 && x3 == y3 && x4 == y4)
 {
    Console.WriteLine("Полиндром"); 
 }
else
 {
     Console.WriteLine("Не полиндром");
 }




//Console.WriteLine(14212 / 10000);