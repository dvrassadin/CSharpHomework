// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int? FindThirdNumber(int? number)
{
    if (number < 0)
        number = -number;
    if (number > 99)
    {
        while (number > 1000)
            number /= 10;
        number %= 10;
    }
    else
        number = null;

    return number;
}

Console.Write("Введите число: ");
var thirdNumber = FindThirdNumber(Convert.ToInt32(Console.ReadLine()));

if (thirdNumber != null)
    Console.WriteLine($"Третья цифра: {thirdNumber}.");
else
    Console.WriteLine("Третьей цифры нет.");