// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();
Console.WriteLine("Введите координаты x для 1 точки:  ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y для 1 точки:  ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z для 1 точки:  ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x для 2 точки:  ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y для 2 точки:  ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z для 2 точки:  ");
int z2 = Convert.ToInt32(Console.ReadLine());

double GetDist(int xa, int ya, int za, int xb, int yb, int zb)
{

    return Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2)), 2, MidpointRounding.ToZero);
}
Console.WriteLine($" A ({x1}, {y1}, {z1}); В ({x2}, {y2}, {z2}) расстояние между точками-> {GetDist(x1, x2, y1, y2, z1, z2)}");


