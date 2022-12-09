// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int CountOfNumbers(int number)
{
    var count = 0;
    if (number == 0)
    {
        count = 1;
        return count;
    }

    if (number < 0)
        number = -number;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"В числе {CountOfNumbers(number)} цифр.");