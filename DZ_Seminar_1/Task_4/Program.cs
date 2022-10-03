// Условия задачи:
// Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Здравствуйте");

Console.Write("Задайте число: ");
int number = Convert.ToInt32(Console.ReadLine());

int counter = 2;

while (counter < number+1)
{
    Console.Write($"{counter}");
    counter = counter+2; // Не запомнила более красивое написание присвоение больше чем 1. Если проходили вообще.
}