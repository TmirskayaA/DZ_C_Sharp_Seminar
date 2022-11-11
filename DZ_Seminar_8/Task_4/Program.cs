// Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, 
// которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrix3D(int rows, int columns, int depth, int min, int max)
{
    var matrix = new int[rows, columns, depth];
    var rnm = new Random();
    int[] arrayNumbers = new int[rows*columns*depth];
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int a = 0;
                while (arrayNumbers.Contains(a))
                {
                    a = rnm.Next(min, max + 1);
                }
                matrix[i, j, k] = a;
                arrayNumbers[count] = a;
                count ++;
            }
        }
    }
    return matrix;
} 

void PrintMatrx3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write($"{matrix[i,j,k]}({i},{j},{k}) ");
            }
        }
    Console.WriteLine();
    }
}


Console.WriteLine("Здравствуйте!");

Console.Write("Задайте число строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте глубину: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array3D = CreateMatrix3D(x, y, z, 10, 99);

Console.WriteLine();

Console.WriteLine("Вывожу массив построчно: ");
PrintMatrx3D(array3D);