// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateNewArray(int size, int min, int max)
{
    double[] array = new double[size];
    var rnm = new Random();

    for (int i = 0; i < size; i++)
    {
        double number = rnm.NextDouble() * (max - min) + min;
        array[i] = Math.Round(number, 2);
    }
    return array;
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

double FindMin(double[] array)
{
    int i = 1;
    double min = array[0];
    while (i < array.Length)
    {
        if (min > array[i]) min = array[i];
        i++;
    }
    return min;
}

double FindMax(double[] array)
{
    int i = 1;
    double max = array[0];
    while (i < array.Length)
    {
        if (max < array[i]) max = array[i];
        i++;
    }
    return max;
}

Console.WriteLine("Здравствуйте!");
Console.WriteLine("Сколько чисел должно быть в массиве?");
int sizemuss = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Каким может быть минимальное число?");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Каким может быть максимальное число?");
int maximum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[] newmuss = CreateNewArray(sizemuss, minimum, maximum);
Console.Write("Создаём новый массив: ");
PrintArray(newmuss);
Console.WriteLine();

Console.Write("Минимальное число:");
Console.WriteLine(FindMin(newmuss));
Console.Write("Максимальное число:");
Console.WriteLine(FindMax(newmuss));
Console.WriteLine();

Console.Write($"Разница между минимальным и максимальным числом = {Math.Round((FindMax(newmuss) - FindMin(newmuss)), 2)}.");