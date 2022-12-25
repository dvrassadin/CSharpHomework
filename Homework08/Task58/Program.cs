// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,]? MatrixProduct(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
        return null;

    int[,] product = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];

    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {

        }

    }

    return product;
}

int[,] firstMatrix = { { 2, 4 }, { 3, 2 } };
int[,] secondMatrix = { { 3, 4 }, { 3, 3 } };

if (MatrixProduct(firstMatrix, secondMatrix) is int[,] array)
    PrintArray(array);
else
    Console.WriteLine("Такие матрицы нельзя перемножить.");
