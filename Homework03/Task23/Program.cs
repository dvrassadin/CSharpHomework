// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
var number = Convert.ToDouble(Console.ReadLine());

if (number > 0)
    for (var i = 1; i <= number; i++)
        Console.Write($"{Math.Pow(i, 3)}, ");
else
    for (var i = 1; i >= number; i--)
        Console.Write($"{Math.Pow(i, 3)}, ");