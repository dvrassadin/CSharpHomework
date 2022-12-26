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

int[,]? MatrixProduct(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
        return null;

    int[,]? product = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
                product[i, j] += firstMatrix[i, k] * secondMatrix[k, j];

    return product;
}

//Матрицы из примера
int[,] firstMatrix = { { 2, 4 }, { 3, 2 } };
int[,] secondMatrix = { { 3, 4 }, { 3, 3 } };

// Должно получиться:
// 12 14
// 16 12
// int[,] firstMatrix = { { 1, 2, 2 }, { 3, 1, 1 } };
// int[,] secondMatrix = { { 4, 2 }, { 3, 1 }, { 1, 5 } };

// Должно получиться:
// 10 10 10
//  6  7  7
// 16  7  7
// int[,] firstMatrix = { { 4, 2 }, { 3, 1 }, { 1, 5 } };
// int[,] secondMatrix = { { 1, 2, 2 }, { 3, 1, 1 } };

if (MatrixProduct(firstMatrix, secondMatrix) is int[,] product)
    PrintArray(product);
else
    Console.WriteLine("Эти матрицы нельзя перемножить.");
