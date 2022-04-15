int[,] NewMatrix(int row, int column)
{
    int[,] matr = new int[row, column];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matr;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] OrderingArray(int[,] matrix)
{
    int min = 0;
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            min = j;
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] < matrix[i, min]) min = k;
            }
            temp = matrix[i, j];
            matrix[i, j] = matrix[i, min];
            matrix[i, min] = temp;
        }
    }
    return matrix;
}
// int[,] array = NewMatrix(4, 4);
// PrintMatrix(OrderingArray(array));

// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void MinSumAr(int[,] matrix)
{
    int min = 0;
    int k = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        min = min + matrix[0, j];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp = temp + matrix[i, j];
        }
        if (temp < min)
        {
            min = temp;
            k = i;
        }
        Console.Write($"{temp} ");
    }
    Console.WriteLine($"---> {k + 1}");
}
// int[,] array = NewMatrix(4, 4);
// MinSumAr(array);

// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] arraycube = new int[,,]
{
    {
        {12,22},
        {75,31}
    },

    {
        {45,53},
        {32,23}
    },
};

void Tyajko(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($" {matrix[i, j, k]}{(i, j, k)}");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}
// Tyajko(arraycube);

// Задача 4: Заполните спирально массив 4 на 4.

int[,] Spiral(int n)
{
    int[,] matrix = new int[n, n];
    int start = 1;
    int rows = n; 
    int columns = n;
    int x = 0;
    int y = 0;
    while (x < rows)
    {
        for (int j = x; j < rows; j++)
        {
            matrix[y, j] = start;
            start++;
        }
        rows = rows - 1;
        for (int i = (y + 1); i < columns; i++)
        {
            matrix[i, columns - 1] = start;
            start++;
        }
        columns = columns - 1;
        for (int j = (rows - 1); j >= x; j = j - 1)
        {
            matrix[rows, j] = start;
            start++;
        }
        for (int i = (columns - 1); i > y; i = i - 1)
        {
            matrix[i, x] = start;
            start++;
        }
        x++; y++;
    }
    return matrix;
}

void ArraySpiral(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
ArraySpiral(Spiral(4));