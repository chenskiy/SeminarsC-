// 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void AcDc(int a, int b)
{
    int resault = a;

    for (int i = 1; i < b; i++)
    {
        resault = resault * a;
    }
    Console.WriteLine(resault);
}
Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень B");
int B = Convert.ToInt32(Console.ReadLine());
AcDc(A, B);


// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum(int a)
{
    if (a < 0)
    {
        a = -1 * a;
    }
    int resault = 0;
    while (a > 0)
    {
        int i = a % 10;
        resault = resault + i;
        a = a / 10;
    }
    return resault;

}
Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр " + A + " равняется " + Sum(A));
*/
// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
void bitArray()
{
    int[] a = new int[8];

    for (int i = 0; i < 8; i++)
    {
        Console.Write("Введите следующий элемент массива:");
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < 8; i++)
    {
        Console.Write(a[i] + " ");
    }
}
bitArray();
*/