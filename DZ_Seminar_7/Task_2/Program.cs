// Напишите программу, 
// которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

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

bool PresenceOfValue(int[,] matrix, int a, int b)
{
    if (a <= matrix.GetLength(0) && b <= matrix.GetLength(1)) return true;
    else return false;
}

int GetMatrixValue(int[,] matrix, int a, int b)
{
    int value = matrix[a-1,b-1];
    return value;
}

Console.WriteLine("Здравствуйте!");

Console.WriteLine();

Console.Write("Задайте номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Новый массив:");
int[,] array2D = CreateMatrix(3,4,0,9);
PrintMatrx(array2D);

Console.WriteLine();

if (PresenceOfValue(array2D, x, y)) 
   Console.WriteLine($"Такая позиция есть в массиве: {GetMatrixValue(array2D, x, y)}");
else 
   Console.WriteLine("Такой позиции в массиве нет!");