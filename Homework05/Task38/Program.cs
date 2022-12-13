// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Возвращает массив с size количеством элементов со случайными значениями от minValue до maxValue и digits количеством цифр после точки или null если указано количество элементов меньше 1.
double[]? CreateArrayWithDoubles(uint size, int minValue, int maxValue, int digits)
{
    if (size < 1)
        return null;
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = Math.Round(
            (Convert.ToDouble(new Random().Next(minValue, maxValue)))
            + new Random().NextDouble(), digits);
    return array;
}

// Возвращает разницу между максимальным и минимальным элементами массива.
double DiffBetweenMaxAndMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    return max - min;
}

// double[] array = { 1.43, 4.12, 5, 2.5 };
double[]? array = CreateArrayWithDoubles(5, 1, 5, 2);

if (array is double[])
{
    Console.WriteLine(String.Join(" | ", array));
    Console.WriteLine($"Разница между максимальным и минимальным элементами: {Math.Round(DiffBetweenMaxAndMin(array), 2)}");
}
else
    Console.WriteLine("Массив не создан.");
