// Задайте значение N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ReturnAllNaturalNumbers(int n)
{
    if(n>0)
    {
        Console.Write($"{n} ");
        ReturnAllNaturalNumbers(n-1);
    }
    else return;
}

Console.WriteLine("Здравствуйте!");

Console.Write("До какого числа надо вывести все натуральные числа? ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write($"Вывожу: ");
ReturnAllNaturalNumbers(number);