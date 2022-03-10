/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 

int Vex(int num)
{
    int n1 = num % 100;
    int n2 = n1 / 10;

    return n2;
}
int number = new Random().Next(100,999);
Console.WriteLine(number + " ---> " + Vex(number));
*/

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 

void AcDc(int num)
{
    while(num / 1000 > 0)
    {
        num = num /10;
    }
    if(num > 99)
    {
        num = num % 10;
        Console.WriteLine(num);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
AcDc(number);
*/


/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
// Как во втором семинаре

void Day(int num)
{
    if(num <= 7 && num >= 1)
    {
        if(num == 1)
        {
            Console.Write("Понедельник");
        }
        if(num == 2)
        {
        Console.Write("Вторник");
        }
        if(num == 3)
        {
            Console.Write("Среда");
        }
        if(num == 4)
        {
            Console.Write("Четверг");
        }
        if(num == 5)
        {
            Console.Write("Пятница");
        }
        if(num == 6)
        {
            Console.Write("Суббота");
        }
        if(num == 7)
        {
            Console.Write("Воскресенье");
        }
        if(num == 6 || num == 7)
        {
            Console.Write(" - это выходной день!");
        }
        else
        {
            Console.Write(" - это рабочий день!");
        }
    }
    else
    {
        Console.WriteLine("Такого дня недели не существует");
    }
}

Console.WriteLine("Введите номер дня недели (от 1 до 7) ");
int num = Convert.ToInt32(Console.ReadLine());
Day(num);
*/

/* //Как в первом семинаре
Console.WriteLine("Введите номер дня недели ");
int number = Convert.ToInt32(Console.ReadLine());
if(number <= 7 && number >= 1)
{
    if(number == 1)
    {
        Console.Write("Понедельник");
    }
    if(number == 2)
    {
    Console.Write("Вторник");
    }
    if(number == 3)
    {
        Console.Write("Среда");
    }
    if(number == 4)
    {
        Console.Write("Четверг");
    }
    if(number == 5)
    {
        Console.Write("Пятница");
    }
    if(number == 6)
    {
        Console.Write("Суббота");
    }
    if(number == 7)
    {
        Console.Write("Воскресенье");
    }
    if(number == 6 || number == 7)
    {
        Console.Write(" - это выходной день!");
    }
    else
    {
        Console.Write(" - это рабочий день!");
    }
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}
*/
