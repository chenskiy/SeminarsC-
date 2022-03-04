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
*/

// 3 задача
Console.Write("number = ");
int value = Convert.ToInt32(Console.ReadLine());

if (value % 2 == 0) 
{
    Console.Write(value);
    Console.Write(" - четное");
} 
else
{
    Console.Write(value);
    Console.Write(" - нечетное");
}