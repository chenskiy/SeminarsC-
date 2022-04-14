// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
void ArrayShift(int row, int col)
{
    int[,] matrix = new int[row, col];
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[0, j];
        matrix[0, j] = matrix[(row - 1), j];
        matrix[(row - 1), j] = temp;
    }
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите row");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите col");
int col = Convert.ToInt32(Console.ReadLine());
ArrayShift(row, col);
*/
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
void ArrayTurn(int row, int col)
{
    int[,] matrix = new int[row, col];
    int[,] array = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i, j] = matrix[j, i];

            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите row");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите col");
int col = Convert.ToInt32(Console.ReadLine());
if (row == col) ArrayTurn(row, col);
else Console.WriteLine("Невозможно выполнить");
*/
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

void ArrayMin(int row, int col)
{
    int[,] matrix = new int[row, col];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minI = i;
                minJ = j;
            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        matrix[i, minJ] = 0;
    }
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[minI, j] = 0;
    }
    Console.WriteLine($"Первое минимальное число {min} ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите row");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите col");
int col = Convert.ToInt32(Console.ReadLine());
ArrayMin(row, col);