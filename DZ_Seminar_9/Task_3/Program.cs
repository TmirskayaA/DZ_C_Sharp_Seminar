// Напишите программу 
// вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanRecurs(int m, int n)
{
    {
        if (m == 0) return n + 1;
        else if ((m != 0) && (n == 0)) return AkkermanRecurs(m - 1, 1);
        else return AkkermanRecurs(m - 1, AkkermanRecurs(m, n - 1));
    }
}

Console.WriteLine("Здравствуйте!");

Console.Write("Задайте положительное число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте положительное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

if (numM < 0 || numN < 0) Console.WriteLine("Числа не должны быть отрицательными!");
else if (numM > 3) Console.WriteLine("Мы поломаемся:\\");
else Console.Write($"Значение A({numM}, {numN}) = {AkkermanRecurs(numM, numN)}");