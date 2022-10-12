// Напишите программу, 
// которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

int NumberСube( int quantity)
{
    int cube = (int)Math.Pow(quantity, 3);
    return cube;
}

Console.WriteLine("Здравствуйте!");
Console.Write("Напишите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;


while (count < number + 1)
{
    Console.WriteLine($"{count} | {NumberСube(count)}");
    count++;
}

