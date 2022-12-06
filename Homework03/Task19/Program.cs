// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int CountOfNumber(int number)
{
    var countOfNumbers = 0;

    if (number < 0) number = -number;

    while (number > 0)
    {
        number /= 10;
        countOfNumbers++;
    }

    return countOfNumbers;
}

bool IsPalindrome(int number) // Принимает любое число
{
    var isPalindrome = true;
    for (var i = Convert.ToInt32(Math.Pow(10, CountOfNumber(number) - 1)); i >= 10; i /= 100)
    {
        if (number / i == number % 10)
        {
            number -= number / i * i;
            number /= 10;
        }
        else
        {
            isPalindrome = false;
            break;
        }
    }
    return isPalindrome;
}

Console.Write("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());

if (IsPalindrome(number))
    Console.WriteLine("Палиндром.");
else
    Console.WriteLine("Не палиндром");