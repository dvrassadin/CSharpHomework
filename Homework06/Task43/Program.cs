// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double[] point = { (b2 - b1) / (k1 - k2), 0 };
    point[1] = k1 * point[0] + b1;

    return point;
}



Console.WriteLine("Введите координаты первой прямой:");
var b1 = Convert.ToDouble(Console.ReadLine());
var k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй прямой:");
var b2 = Convert.ToDouble(Console.ReadLine());
var k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Точка пересечения: ({String.Join("; ", IntersectionPoint(b1, k1, b2, k2))}).");