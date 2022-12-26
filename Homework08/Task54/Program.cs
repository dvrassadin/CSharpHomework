// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) - 1 - j; k++)
                if (array[i, k] < array[i, k + 1])
                {
                    var temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }

    return array;
}




if (CreateIntArray(rows: 3, columns: 4, minValue: 0, maxValue: 9) is int[,] array)
{
    PrintArray(array);
    Console.WriteLine();
    SortRows(array);
    PrintArray(array);
}
else Console.WriteLine("Такой массив нельзя создать.");
