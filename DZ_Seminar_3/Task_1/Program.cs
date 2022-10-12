// Напишите программу, 
// которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrome(int digit)
{
    if (digit/10000 != digit%10) return false;
    else if ((digit%10000)/1000 != (digit%100)/10) return false;
    else return true;
}

Console.WriteLine("Здравствуйте");
Console.Write("Напишите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 | number > 99999) Console.WriteLine("Это число не является пятизначным!");
   else if(Palindrome(number) == true) Console.WriteLine("Да");
           else Console.WriteLine("Нет");









