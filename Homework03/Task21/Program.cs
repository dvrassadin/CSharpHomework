// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.



// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance3D = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

    return distance3D;
}

Console.WriteLine("Введите координаты первой точки: ");
var x1 = Convert.ToDouble(Console.ReadLine());
var y1 = Convert.ToDouble(Console.ReadLine());
var z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
var x2 = Convert.ToDouble(Console.ReadLine());
var y2 = Convert.ToDouble(Console.ReadLine());
var z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние: {Distance3D(x1, y1, z1, x2, y2, z2),3}.");