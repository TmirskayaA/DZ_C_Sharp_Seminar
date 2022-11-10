// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnm = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnm.Next(min, max + 1);
        }
    }
    return matrix;
} 

void PrintMatrx(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 2}, ");
          else Console.Write($"{matrix[i, j], 2}");  
        }
        Console.WriteLine("]");
    }
}

int[,] ProductOfMatrices(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] productMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    for (int i = 0; i < productMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < productMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int h = 0; h < matrixOne.GetLength(1); h++)
            {
                sum += matrixOne[i,h] * matrixTwo[h,j];
            }
            productMatrix[i,j] = sum;
        }
    }
    return productMatrix;
}

Console.WriteLine("Здравствуйте!");

Console.Write("Сколько строк в 1 матрице? ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Сколько столбцов в 1 матрице? ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Сколько строк в 2 матрице? ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write("Сколько столбцов в 2 матрице? ");
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (x != k)
{
    Console.WriteLine("Такие матрицы невозможно перемножить!");
}
else
{
    Console.WriteLine("Первый массив:");
    int[,] oneArray2D = CreateMatrix(x,y, 0, 9);
    PrintMatrx(oneArray2D);
    
    Console.WriteLine();

    Console.WriteLine("Второй массив:");
    int[,] twoArray2D = CreateMatrix(x,y, 0, 9);
    PrintMatrx(twoArray2D);

    Console.WriteLine();

    Console.WriteLine("Их произведение:");
    int[,] productArray2D = ProductOfMatrices(oneArray2D, twoArray2D);
    PrintMatrx(productArray2D);
}