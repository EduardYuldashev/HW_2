/* Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа*/

Console.Clear();
Console.WriteLine("Введите трёхзначное число");
string userInput1 = Console.ReadLine() ?? "";
int num = int.Parse(userInput1);
int a1 = num / 10;
int a2 = num % 10;
int res = a2;
Console.WriteLine("{num} -> {res}");


