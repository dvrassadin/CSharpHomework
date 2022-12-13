// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Возвращает массив с size количеством элементов со случайными значениями от minValue до maxValue.
int[] CreateArray(uint size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

// Возвращает сумму элементов массива с нечётными индексами или null, если в массиве нет нечётных индексов.
int? SumOfOddIndexElement(int[] array)
{
    if (array.Length < 2)
        return null;
    else
    {
        var sum = 0;
        for (int i = 1; i < array.Length; i += 2)
            sum += array[i];
        return sum;
    }
}

int[] array = CreateArray(10, -15, 15);
Console.WriteLine(String.Join(", ", array));

if (SumOfOddIndexElement(array) is int sum)
    Console.WriteLine($"Сумма элементов с нечётными индексами: {sum}.");
else
    Console.WriteLine("В массиве нет нечётных индексов.");
