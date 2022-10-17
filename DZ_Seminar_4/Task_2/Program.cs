// Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumbers(int digit)
{
    int sum = 0;
    while (digit > 0)
    {
        sum += digit % 10;
        digit /= 10;
    }
    return sum;
}

Console.WriteLine("Здравствуйте!");
Console.Write("Напишите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <0) number *= -1;

Console.WriteLine($"Сумма цифр в числе = {SumNumbers(number)}!");