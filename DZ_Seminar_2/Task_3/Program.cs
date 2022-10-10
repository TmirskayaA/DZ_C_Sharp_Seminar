// Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.

string NumberWeek(int day)
{
    string abb = "";

    if (day == 1) abb = "P";
    else if (day == 2) abb = "V";  
    else if (day == 3) abb = "S";
    else if (day == 4) abb = "C";
    else if (day == 5) abb = "Pt";
    else if (day == 6) abb = "Sb";
    else abb = "Vs";
    
    return abb;
}

string WeekendOrNot(string abbrev)
{
    string yesno = "";
    if (abbrev == "P") yesno = "F";
    else if (abbrev == "V") yesno = "F";
    else if (abbrev == "S") yesno = "F";
    else if (abbrev == "C") yesno = "F";
    else if (abbrev == "Pt") yesno = "F";
    else if (abbrev == "Sb") yesno = "T";
    else yesno = "T";

    return yesno;
}

Console.WriteLine("Здравствуйте");

Console.Write("Напишите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7) 
{
 Console.WriteLine($"Дня недели под номером {number} не существует!");
}
else
{
    string dayweek = NumberWeek(number);
    string weekend = WeekendOrNot(dayweek);
    if (weekend == "T") 
    {
    Console.WriteLine("Это выходной!");
    }
    else
    {
    Console.WriteLine("Это будний день:(");
    }
}

