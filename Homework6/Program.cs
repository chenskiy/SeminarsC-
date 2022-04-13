// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
int pos = 0;
for (int i = 0; i < size; i++)
{
    num[i] = new Random().Next(-99, 100);
    Console.Write($"{num[i]} ");
    if (num[i] > 0) pos++;
}
Console.Write($"---> {pos}");
*/
// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.
/*
void Array (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        matr [i, 0] = 1;
        matr [i, matr.GetLength(1)-1] = 1;
    }
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        matr [0, i] = 1;
        matr [matr.GetLength(0)-1, i] = 1;
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write ($"{matr [i,j]} ");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
int [,] Matrix = new int[row,col];
Array(Matrix);
*/