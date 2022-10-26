//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if(number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while(number > 999)
        number = number / 10;
    Console.WriteLine(number % 10);
}