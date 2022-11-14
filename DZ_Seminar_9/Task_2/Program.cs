// Задайте значения M и N. 
// Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumbers(int min, int max)
{
    if(min < max) return min + SumNaturalNumbers(min+1, max);
    else return max;
}

Console.WriteLine("Здравствуйте!");

Console.Write("От какого числа считаем сумму? ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.Write("До какого числа считаем сумму? ");
int maximum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write($"Сумма чисел = {SumNaturalNumbers(minimum, maximum)}");