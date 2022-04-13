// 1. Задайте двумерный массив размером m × n, заполненный случайными целыми числами.

void Array(int m, int n)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-99, 100);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// 2. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

void ArraySum(int m, int n)
{
    int[,] matrix = new int[m, n];
    int a = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            a = i + j;
            Console.Write($"{a} ");
        }
    }
}

// 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

void ArraySquared(int m, int n)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);

            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

void ArSumEl(int m)
{
    int sum = 0;
    int[,] matrix = new int[m, m];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            if (i == j)
            {
                sum = sum + matrix[i, j];
            }
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Сумма элементов равна {sum}");
}


Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
Array(m, n);
Console.WriteLine();
ArraySum(m, n);
Console.WriteLine();
Console.WriteLine();
ArraySquared(m, n);
Console.WriteLine();
ArSumEl(m);