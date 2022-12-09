// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-1000, 1001);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write($"{element}, ");
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
