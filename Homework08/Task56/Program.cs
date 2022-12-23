// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

// Возвращает индекс минимального элемента.
int MinIndex(int[] array)
{
    int minValue = array[0];
    int minIndex = 0;

    for (int i = 1; i < array.Length; i++)
        if (array[i] < minValue)
        {
            minValue = array[i];
            minIndex = i;
        }

    return minIndex;
}

// Возвращает массив с суммами строк.
int[] SumsOfRows(int[,] array)
{
    int[] sums = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sums[i] += array[i, j];

    return sums;
}


if (CreateIntArray(4, 2, 0, 9) is int[,] array)
{
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма в {MinIndex(SumsOfRows(array)) + 1} строке.");
}
else
    Console.WriteLine("Такой массив нельзя создать.");