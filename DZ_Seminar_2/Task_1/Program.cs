// Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

Console.WriteLine("Здравствуйте");

Console.Write("Задайте число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number / 100 > 0) && (number / 1000 == 0))
{
    number = number/10;
    number = number%10;
    Console.WriteLine($"Цифра в середине: {number}"!);
}
else
{
    Console.WriteLine("Число не трёхзначное!");
}