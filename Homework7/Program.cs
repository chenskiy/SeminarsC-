// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
void Array(int m, int n)
{
    double[,] matrix = new double[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-99, 100) / 10.0);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
Array(m, n);
*/
// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
void ArraySearch(int row, int col)
{
    int[,] matrix = new int[4, 3];
    int num = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
            if (row == i || col == j)
            {
                num = matrix[row, col];
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Значение введенного элемента {num}");
}
Console.WriteLine("Введите строку ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец ");
int col = Convert.ToInt32(Console.ReadLine());
if (row < 4 || col < 3) ArraySearch(row, col);
else Console.WriteLine("Такого элемента нет");
*/
// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void ArithmeticMean(int row, int col)
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j <  matrix.GetLength(1); j++)
        {
            sum = sum + matrix[j, i];
        }
        sum = sum / matrix.GetLength(0);
        Console.WriteLine($"Среднее арифметическое {i + 1} столбца ---> {Math.Round(sum,1)}");
    }
}
Console.WriteLine("Введите строку ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец ");
int col = Convert.ToInt32(Console.ReadLine());
ArithmeticMean(row, col);