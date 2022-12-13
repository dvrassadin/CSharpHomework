// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Возвращает массив с size количеством элементов со случайными значениями от minValue до maxValue.
int[] CreateArray(uint size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

// Возвращает количество чётных чисел в массиве.
uint CountOfEvenNumbers(int[] array)
{
    uint count = 0;
    foreach (var element in array)
    {
        if (element % 2 == 0)
            count++;
    }
    return count;
}

int[] array = CreateArray(15, 100, 999);
Console.WriteLine(string.Join(" | ", array));

Console.WriteLine($"В массиве {CountOfEvenNumbers(array)} чётных элементов");