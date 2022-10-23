// Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int SumOdd(int[] array)
{
    int i = 0;
    int sum = default;
    while (i < array.Length)
    {
        if (i%2 > 0) 
        {
            sum += array[i];
            i++;
        }
        else i++;
    }
    return sum;
}

Console.WriteLine("Здравствуйте!");
Console.WriteLine("Сколько чисел должно быть в массиве?");
int sizemuss = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Каким может быть минимальное число?");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Каким может быть максимальное число?");
int maximum = Convert.ToInt32(Console.ReadLine());

int[] newmuss = CreateNewArray(sizemuss, minimum, maximum);

Console.Write("Создаём новый массив: ");
PrintArray(newmuss);

Console.Write($"Сумма чисел на нечётных позициях = {SumOdd(newmuss)}.");