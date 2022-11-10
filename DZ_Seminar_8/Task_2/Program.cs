//  Задайте прямоугольный двумерный массив. 
//  Напишите программу, 
//  которая будет находить строку 
//  с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int MaxAmountOfRow(int[,] matrix)
{
    int maxSum = 0;
    int max = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = matrix[i,0];
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            sum += matrix[i,j+1];
        }
        if (maxSum < sum)
        {
            maxSum = sum;
            max = i+1;
        }

    }
    return max;
}

Console.WriteLine("Здравствуйте!");

Console.Write("Задайте число строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (y == x)
{
    Console.WriteLine("Такой массив не будет прямоугольным!");
}
else
{
    Console.WriteLine("Новый массив:");
    int[,] array2D = CreateMatrix(x,y, 0, 9);
    PrintMatrx(array2D);
    
    Console.WriteLine();

    Console.Write($"{MaxAmountOfRow(array2D)} строка в массиве имеет наибольшую сумму.");
}