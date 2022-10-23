// Задайте массив,
// заполненный случайными положительными трёхзначными числами. 
// Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateNewArray(int size, int min, int max)
{
    int[] array = new int[size];
    var rnm = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnm.Next(min, max + 1);
    }
    return array;
} 

void PrintArray(int[] array)
{
    int count = 0;
    while (count != array.Length)
    {
        if (count == 0)  Console.Write($"[{array[count]},");
        else if (count + 1 == array.Length) Console.WriteLine($"{array[count]}]");
        else Console.Write($"{array[count]},");
        count++;
    }
}

int QuantityEvenNumb(int[]array)
{
    int i = 0;
    int count = 0;
    while (i < array.Length)
    {
        if (array[i]%2 == 0) 
        {
            count++;
            i++;
        }
        else i++;
    }
    return count;
}

Console.WriteLine("Здравствуйте!");
Console.WriteLine("Сколько чисел должно быть в массиве?");
int sizemuss = Convert.ToInt32(Console.ReadLine());

int[] newmuss = CreateNewArray(sizemuss, 100, 999);

Console.Write("Создаём новый массив: ");
PrintArray(newmuss);

Console.Write($"Количество чётных чисел = {QuantityEvenNumb(newmuss)}.");