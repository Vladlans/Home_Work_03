//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int secondDigit = (num / 10) % 10;

Console.WriteLine((num > 99 && num < 1000));