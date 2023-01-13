// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа. Обращаться к числу как к строке нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = 0;
while (number < 100 || number > 999)
{
    Console.WriteLine("Enter a 3-digit number, please");
    number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(number / 10 % 10);