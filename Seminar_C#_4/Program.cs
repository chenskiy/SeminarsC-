// 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int ArSum(int A)
{
    int resault = 0;
    for (int i = 1; i <= A; i++)
    {
        resault = resault + i;
    }
    return resault;
}

Console.WriteLine("Введите ваше число: ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA < 1) Console.WriteLine("Вы ввели ненатурально число");
else Console.WriteLine($"Сумма чисел от 1 до {numA} равна {ArSum(numA)}");

// 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
void Dlinna(int N)
{
    int l = 1;
    while (Math.Abs(N / 10) >= 1)
    {
        N = N / 10;
        l++;
    }
    Console.WriteLine("Количество цифр в веденном числе " + l);
}
Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
Dlinna(number);
*/
// 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Factorial(int N)
{
    int resault = 1;
    int i = 1;
    while (i <= N)
    {
        resault = resault * i;
        i++;
    }
    return resault;
}

Console.WriteLine("Введите ваше число: ");
int numN = Convert.ToInt32(Console.ReadLine());
if (numN < 1) Console.WriteLine("Вы ввели ненатурально число");
else Console.WriteLine($"Произведение чисел от 1 до {numN} равна {Factorial(numN)}");
*/
// 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
/*
void bitArray()
{
    int[] a = new int[8];

    for (int i = 0; i < 8; i++)
    {
        a[i] = new Random().Next(0, 2);
        Console.Write(a[i] + " ");
    }
}
bitArray();
*/