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

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. */

void A(int num)
{
    if(num > 99)
    {
    
        int b = num % 10;
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

A(number);

/*
void A(int num)
{
    while(num % 1000 == 0)
    {
        int num = num / 10;
    }
    if(num > 99)
    {
        int b = num % 10;
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

A(number);
*/