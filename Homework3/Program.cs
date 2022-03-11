/*
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void ACDC(int x)
{
    int a1 = x % 10;
    int a2 = x / 10 % 10;
    int a3 = x / 100 % 10;
    int a4 = x / 1000 % 10;
    int a5 = x / 10000;
    int y = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;
    Console.WriteLine(y);
    if(y == x) Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число не является палиндромом");
}
Console.WriteLine("Введите пятизначное число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write(x + " ----> ");
ACDC(x);
*/
/*
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double zDistance = z2 - z1;

    return Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2) + Math.Pow(zDistance, 2));
}

double xA, yA, zA, xB, yB, zB;

Console.Write("Input X of point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z of point A: ");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X of point B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y of point B: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z of point B: ");
zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetDistance(xA, yA, zA, xB, yB, zB));
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(N >= count)
{
    Console.Write(Math.Pow(count,3) + " ");
    count++;   
}