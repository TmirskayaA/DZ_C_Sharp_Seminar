// Напишите цикл, 
// который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int result = default;
// result *= a;

int NumberDagree (int a, int b)
{
    int count = 1;
    int result = a;
    while (count < b)
    {
        result *= a;
        count++;
    }
    return result;
}

Console.WriteLine("Здравствуйте!");
Console.Write("Напишите цифру, которую надо возвести в степень: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите, в какую степень возвести: ");
int degree = Convert.ToInt32(Console.ReadLine()); 

if (degree < 0 || degree == 0) Console.WriteLine ("Выбранная степень не является натуральным числом!");
else Console.WriteLine($"Число {number} в степени {degree} = {NumberDagree(number, degree)}");


