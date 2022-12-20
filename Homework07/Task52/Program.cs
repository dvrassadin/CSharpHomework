// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($" | {array[i, j]} | ");
        Console.WriteLine();
    }
}

int[,]? CreateIntArray(int rows, int columns, int minValue, int maxValue)
{
    if (rows <= 0 || columns <= 0)
        return null;
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

double[] AverageSumInColumns(int[,] array)
{
    double[] sums = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sums[j] += array[i, j];

    for (int i = 0; i < sums.Length; i++)
        sums[i] = Math.Round(sums[i] / array.GetLength(0), 1);

    return sums;
}

Console.Write("Введите количество строк в массиве:");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве:");
int columns = Convert.ToInt32(Console.ReadLine());

if (CreateIntArray(rows, columns, 1, 10) is int[,] array)
{
    PrintArray(array);
    Console.WriteLine($"Средние суммы в столбцах: {String.Join(" | ", AverageSumInColumns(array))}");
}
else
    Console.WriteLine("Такой массив нельзя создать.");