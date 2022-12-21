// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Возвращает случайно вещественное число с digits количеством цифр после точки.
double? RandomRealNumber(int minValue, int maxValue, int digits)
{
    if (minValue + 1 >= maxValue)
        return null;

    double number = new Random().Next(minValue + 1, maxValue);
    if (new Random().Next(0, 2) % 2 == 0)
        number += Math.Round(new Random().NextDouble(), digits);
    else
        number -= Math.Round(new Random().NextDouble(), digits);

    return number;
}

// Возвращает массив вещественных чисел или null если нельзя создать массив с введёнными параметрами.
double[,]? CreateRealNumbersArray(int rows, int columns, int minValue, int maxValue, int digits)
{
    if (rows < 1 || columns < 1)
        return null;
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            if (RandomRealNumber(minValue, maxValue, digits) is double realNumber)
                array[i, j] = realNumber;
            else
                return null;
        }

    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($" | {array[i, j]} | ");
        Console.WriteLine();
    }
}

if (CreateRealNumbersArray(5, 5, -2, 2, 2) is double[,] array)
    PrintArray(array);
else
    Console.WriteLine("Нельзя создать массив с такими параметрами.");

