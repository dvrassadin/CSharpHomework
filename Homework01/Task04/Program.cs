/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int maxNumber = firstNumber;

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine($"{firstNumber} — самое большое число.");
    }
    else
    {
        Console.WriteLine($"{thirdNumber} — самое большое число.");
    }
}
else
{
    if (secondNumber > thirdNumber)
    {
        Console.WriteLine($"{secondNumber} — самое большое число.");
    }
    else
    {
        if (thirdNumber > secondNumber)
        {
            Console.WriteLine($"{thirdNumber} — самое большое число.");
        }
        else
        {
            if (secondNumber == thirdNumber)
            {
                Console.WriteLine($"{secondNumber} — самое большое число.");
            }
            else
            {
                Console.WriteLine("Все числа равны.");
            }
        }
    }
}