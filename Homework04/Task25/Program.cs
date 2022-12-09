// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int? Exponentiation(int number, int pow)
{
    int? result = null;
    if (pow <= 0)
        return result;

    if (number == 0)
        result = 0;
    else
    {
        result = number;
        for (int i = pow; i > 1; i--)
            result *= number;
    }
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень числа: ");
int pow = Convert.ToInt32(Console.ReadLine());

if (Exponentiation(number, pow) is int result)
    Console.WriteLine($"{number} в степени {pow} равно {result}.");
else
    Console.WriteLine("Введена некорректная степень.");

