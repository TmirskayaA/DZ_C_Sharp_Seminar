// Условия задачи:
// Напишите программу, 
// которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Здравствуйте");

Console.Write("Задайте первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте второе число число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте третье число число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(number1 == number2 && number2 == number3)
{
    Console.WriteLine("Эти числа равны.");
}
else
{
    if(number1 > number2 && number1 > number3)
    {
        max = number1;
        Console.WriteLine($"Самое большое число - это {max}!");
    }
    else if (number2 > number1 && number2 > number3)
         {
            max = number2;
            Console.WriteLine($"Самое большое число - это {max}!");
         }
         else 
         {
            max = number3;
            Console.WriteLine($"Самое большое число - это {max}!");
         }
}
