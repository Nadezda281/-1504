//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

//Решение:

//git remote add origin https://github.com/Nadezda281/-1504.git
//git branch -M main
//git push -u origin main"

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; Console.Write(i * i * i + ", "), i++) ;
