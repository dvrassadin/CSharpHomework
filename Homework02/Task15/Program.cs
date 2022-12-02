// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string? ShowDayName(int dayNumber)
{
    string? dayName = null;
    if (dayNumber >= 1 && dayNumber <= 5)
        dayName = "weekday";
    else if (dayNumber == 6 || dayNumber == 7)
        dayName = "weekend";
    
    return dayName;
}

Console.Write("Enter day number: ");
var dayName = ShowDayName(Convert.ToInt32(Console.ReadLine()));

if (dayName != null)
    Console.WriteLine($"It's a {dayName}.");
else
    Console.WriteLine("Такого дня нет.");
