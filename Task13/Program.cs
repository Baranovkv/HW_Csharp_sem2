// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. Обращаться к числу как к строке нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter number, please");
Int64 num1 = Convert.ToInt64(Console.ReadLine());
Int64 index = num1;
int count = 0;
Int64 rem = 1;
while (index > 0) // считаем разрядность введенного числа в переменную count
{
    count++;
    index = index / 10;
}
Console.WriteLine($"You entered {count}-digit number");
if (count < 3) Console.WriteLine("third digit doesn`t exist"); //если число двухзначеное, выводим, что третьей цифры нет
else 
{
    while (count > 3) // получаем число для целочисленного деления num1, чтобы оно осталось трехзначным
    {
        rem = rem * 10;
        count--;
    }
    Console.WriteLine("third digit of the number is "+ (num1 / rem) % 10); // через целочисленное деление отбрасываем все цифры с конца, чтобы число стало трехзначным, затем выводим на экран последнюю цифру через остаток от деления
}
