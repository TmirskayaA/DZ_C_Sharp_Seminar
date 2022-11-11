// Напишите программу, 
// которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

string[,] CreateMatrix(int rows, int columns)
{
    string[,] matrix = new string[rows, columns];
    
    int temp = 1;
    string tempNumber = string.Format("{0:d2}",temp);
    int i = 0;
    int j = 0;
    
    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = tempNumber;
        temp++;
        tempNumber = string.Format("{0:d2}",temp);
        
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1) j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1) i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1) j--;
        else i--;
    }
    return matrix;
} 

void PrintMatrx(string[,] matrix)
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

Console.WriteLine("Здравствуйте!");

Console.Write("Задайте число строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Новый массив:");
string[,] array2D = CreateMatrix(x,y);
PrintMatrx(array2D);