// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int? FindElementIn(int[,] array, int rowIndex, int columnIndex)
{
    if (rowIndex > array.GetLength(0) || columnIndex > array.GetLength(1))
        return null;
    else
        return array[rowIndex, columnIndex];
}

Console.Write("Введите количество строк в массиве:");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве:");
int columns = Convert.ToInt32(Console.ReadLine());

if (CreateIntArray(rows, columns, -100, 100) is int[,] array)
{
    PrintArray(array);

    Console.Write("Введите строку элемента: ");
    int row = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите столбец элемента: ");
    int column = Convert.ToInt32(Console.ReadLine());

    if (FindElementIn(array, row, column) is int element)
        Console.WriteLine($"Там находится: {element}.");
    else
        Console.WriteLine("Такого элемента нет.");
}
else
    Console.WriteLine("Такой массив нельзя создать.");


