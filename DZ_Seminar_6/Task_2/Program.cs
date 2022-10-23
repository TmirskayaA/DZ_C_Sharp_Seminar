// Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double FindCoordinateX(double a1, double a2, double c1, double c2)
{
    double xCoord = (-a2 + a1) / (-c1 + c2);
    return xCoord;
}

double FindCoordinateY(double c2, double xCoord, double a2)
{
    double yCoord = c2 * xCoord + a2;
    return yCoord;
}

Console.WriteLine("Здравствуйте!");
Console.WriteLine();
Console.Write("Задайте значение для B1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение для K1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение для B2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение для K2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 == b2) Console.Write("Эти прямые совпадают!");
else if (k1 == k2) Console.Write("Эти прямые параллельны!");

double x = FindCoordinateX(b1, b2, k1, k2);
double y = FindCoordinateY(k2, x, b2);

Console.WriteLine($"Эти прямые пересекутся в точке: ({x};{y})");