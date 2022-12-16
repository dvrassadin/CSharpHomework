// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray()
{
    Console.Write("Введите количество чисел: ");
    int[] array = new int[Convert.ToInt32(Console.ReadLine())];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} из {array.Length} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

int CountOfPositive(int[] array)
{
    var count = 0;
    foreach (int number in array)
        if (number > 0)
            count++;

    return count;
}


int[] array = CreateArray();

Console.WriteLine($"Вы ввели {CountOfPositive(array)} чисел больше нуля.");