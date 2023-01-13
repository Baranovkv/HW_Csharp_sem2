// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), 
// выводящее это число в консоль вместе с правильным образом изменённым словом "программист", 
// для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи,
// как минимум до 100 человек.
Console.WriteLine("Введите количество программистов."); 
int amount = Convert.ToInt32(Console.ReadLine());
Console.Write($"{amount} программист");
if (amount % 100 < 15) switch (amount % 100) // если последние 2 цифры меньше 15, для таких чисел отдельные окончания
{
    case 1:
    break;
    
    case 2: case 3: case 4:
    Console.WriteLine("a");
    break;

    default:
    Console.WriteLine("ов");
    break;
}
else switch (amount % 10) // в остальных случаях работаем с последней цифрой числа, от которой зависит окончание
{
    case 1:
    break;
    
    case 2: case 3: case 4:
    Console.WriteLine("a");
    break;

    default:
    Console.WriteLine("ов");
    break;
}