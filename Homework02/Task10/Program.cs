// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int? ShowSecondNumber(int threeDigitNumber)
{
    int? secondNumber = null;
    if ((threeDigitNumber >= -999 && threeDigitNumber <= -100) || (threeDigitNumber <= 999 && threeDigitNumber >= 100))
    {
        secondNumber = threeDigitNumber / 10 % 10;
        if (secondNumber < 0)
            secondNumber = -secondNumber;
    }
    
    return secondNumber;
}

Console.WriteLine("Введите трёхзначное число: ");
var secondNumber = ShowSecondNumber(Convert.ToInt32(Console.ReadLine()));

if (secondNumber != null)
    Console.WriteLine($"Вторая цифра: {secondNumber}.");
else
    Console.WriteLine("Это не трёхзначное число.");

