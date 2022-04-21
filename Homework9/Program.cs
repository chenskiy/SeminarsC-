// // Доработать и выслать релизацию программы по выводу треугольника Паскаля.

int[,] CreateTriangle(int size)
{
    int[,] triangle = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int j = 2; j < size; j++)
    {
        for (int k = 1; k < size; k++)
        {
            triangle[j, k] = triangle[j - 1, k - 1] + triangle[j - 1, k];
        }
    }
    PrintMatrix(triangle);
    return triangle;
}
CreateTriangle(5);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <= matrix.GetLength(1) - i; j++)
            Console.Write(" ");;
        for (int k = 0; k <= i; k++)
        {
            Console.Write(" ");
            Console.Write(matrix[i, k]);
        }
        Console.WriteLine();
    }
}