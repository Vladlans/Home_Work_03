Console.WriteLine("Введите номер дня недели (от 1 до 7): ");
int number = int.Parse(Console.ReadLine());

string[] days = {"нет", "нет", "нет", "нет", "нет", "да", "да"};

if(number > 7)
{
Console.WriteLine("В неделе только 7 дней, введите другую цифру");
}
else
{
Console.WriteLine(days[number]);
}