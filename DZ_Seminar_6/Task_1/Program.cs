// Пользователь вводит 
// с клавиатуры M чисел. 
// Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Здравствуйте!");
Console.WriteLine("Сколько чисел вы хотите ввести?");
int count = Convert.ToInt32(Console.ReadLine());

int[] massive = new int[count];

for (int i = 0; i < count; i++)
{
    Console.Write($"Введите {i+1} число: ");
    massive[i] = Convert.ToInt32(Console.ReadLine());
}

int SumPositive(int[] array)
{
    int quantity = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) quantity++;
    }
    return quantity;
}

if (SumPositive(massive) == massive.Length) Console.Write($"Все введённые вами числа >0!");
else if (SumPositive(massive) > 0) Console.Write($"Количество чисел >0 = {SumPositive(massive)}!");
else Console.Write($"Вы не ввели числа, которые >0!");