// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. A < B + C
/*
void Triangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Да");
    }
    else Console.WriteLine("Нет");
}
Console.WriteLine("Введите числа ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int numC = Convert.ToInt32(Console.ReadLine());
Triangle(numA, numB, numC);
*/
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
void Binar(int num10)
{
    int a = 0;
    string answer = "";
    while (num10 > 0)
    {
        a = num10 % 2;
        num10 = num10 / 2;
        answer = Convert.ToString(a) + answer;
    }
    Console.Write(answer);
}

Console.WriteLine("Введите десятичное число ");
int number = Convert.ToInt32(Console.ReadLine());
Binar(number);
*/
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
/*
void Fibonacci(int num)
{
    int f1 = 0;
    int f2 = 1;
    int fsum = 0;

    for (int i = 0; i < num; i++)
    {
        fsum = f1 + f2;
        Console.Write($"{f1} ");
        f1 = f2;
        f2 = fsum;
    }
}

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Fibonacci(number);
*/
// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int [,] matrix = new int[3,4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}  