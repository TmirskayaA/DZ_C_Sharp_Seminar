// Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] NewArray8()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}

int GetNumber(int[] array, int i)
{
    int number = array[i];
    return number;
}

Console.WriteLine("Здравствуйте!");

int count = 0;
int[] newmuss = NewArray8();

Console.Write($"Новый массив: ");

while (count != newmuss.Length)
{
    if (count == 0)  Console.Write($"[{GetNumber(newmuss, count)},");
       else if (count + 1 == newmuss.Length) Console.Write($"{GetNumber(newmuss, count)}]");
               else Console.Write($"{GetNumber(newmuss, count)},");
    count++;
}

