// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
/*
void Line(int b1, int k1, int b2, int k2)
{
    double x = (double)(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"{x}; {y}");
}
int B1 = 2;
int B2 = 4;
int K1 = 5;
int K2 = 9;
Line(B1, B2, K1, K2);
*/
// Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.

int[,] CreateTriangle(int size)
{
    int[,] triangle = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}