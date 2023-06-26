/* Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа*/
Console.Clear();
Console.Write("Введи трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(num);
Console.WriteLine("вторая цифра -> "+stringNumber[1]);