// Задайте двумерный массив. 
// Напишите программу, 
// которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] ArrangeNumbersInArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = 0;
                    temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
    return matrix;
}

Console.WriteLine("Здравствуйте!");
Console.Write("Задайте число строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Новый массив:");
int[,] array2D = CreateMatrix(x,y, 0, 9);
PrintMatrx(array2D);

Console.WriteLine();

Console.WriteLine("Отсортированный массив:");
ArrangeNumbersInArray(array2D);
PrintMatrx(array2D);
