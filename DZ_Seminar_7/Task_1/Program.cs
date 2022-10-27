//  Задайте двумерный массив размером m×n, 
//  заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixDouble(int rows, int columns, int min, int max)
{
    var matrix = new double[rows, columns];
    var rnm = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double number = rnm.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(number, 1);
        }
    }
    return matrix;
} 

void PrintMatrxDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
          else Console.Write($"{matrix[i, j], 4}");  
        }
        Console.WriteLine("]");
    }
}

Console.WriteLine("Здравствуйте!");

Console.WriteLine();

Console.Write("Задайте число строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Новый массив:");
double[,] array2D = CreateMatrixDouble(x,y,-9,9);
PrintMatrxDouble(array2D);