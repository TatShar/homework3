// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Enter the coordinates of poin x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinates of poin x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinates of poin y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinates of point y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinates of poin z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinates of poin z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));

Console.WriteLine($"d={d:f3}");

