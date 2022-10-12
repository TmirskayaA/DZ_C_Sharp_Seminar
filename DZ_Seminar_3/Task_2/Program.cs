// Напишите программу, 
// которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double root = Math.Sqrt(Math.Pow((xb-xa), 2) + Math.Pow((yb-ya), 2) + Math.Pow((zb-za), 2));
    return root;
}

Console.WriteLine("Здравствуйте!");
Console.Write("Задайте координату x для точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте координату y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте координату z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте координату x для точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте координату y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте координату z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние = {result}"); 