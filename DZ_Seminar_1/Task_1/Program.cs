// Условия задачи:
// Напишите программу, 
// которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("Здравствуйте");

Console.Write("Задайте первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте второе число число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2)
{
    Console.WriteLine("Эти числа равны.");
}
else if(number1 > number2)
     {
        Console.WriteLine($"Число {number1} больше числа {number2}!");
     }
     else
     {
        Console.WriteLine($"Число {number2} больше числа {number1}!");
     }