/*
// 1 задача

Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.Write("max = ");
    Console.Write(a);
}
else
{
    Console.Write("max = ");
    Console.Write(b);
}
*/

//  2 задача

Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.Write(max);