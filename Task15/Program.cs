// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int day = 0;
while (day < 1 || day > 7)
{
    Console.WriteLine("Please enter a day of the week (1-7)");
    day = Convert.ToInt32(Console.ReadLine());
}
switch (day)
{
    case < 6: 
        Console.WriteLine("This is a work day");
        break;
    case > 5:
        Console.WriteLine("This is a day off");
        break;
}