// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 
// 4,6; 5,6; 3,6; 3.

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
          if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
          else Console.Write($"{matrix[i, j], 4}");  
        }
        Console.WriteLine("]");
    }
}

void PrintArray(double[] array)
{
    int count = 0;
    while (count != array.Length)
    {
        if (count == 0)  Console.Write($"[{array[count]}; ");
        else if (count + 1 == array.Length) Console.WriteLine($"{array[count]}]");
        else Console.Write($"{array[count]}; ");
        count++;
    }
}

double[] AverageColumns(int[,] matrix)
{
    double average = default;
    double[] arrayAverage = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = default;
        int i = 0;
        while (i < matrix.GetLength(0))
        {
            sum += matrix[i, j];
            i++;
        }
        average = Math.Round(sum / matrix.GetLength(0), 1);
        arrayAverage[j] = average;
    }
    return arrayAverage;
}

Console.WriteLine("Здравствуйте!");

Console.WriteLine();

Console.WriteLine("Новый массив:");
int[,] array2D = CreateMatrix(3,4,0,9);
PrintMatrx(array2D);

Console.WriteLine();

Console.WriteLine("Среднее арифметическое каждого столбца:");

double[] newarray = AverageColumns(array2D);
PrintArray(newarray);