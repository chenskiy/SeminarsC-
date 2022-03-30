// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите длину массива ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
int count = 0;

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
    if (array[i] % 2 == 0) count++;
}
Console.WriteLine("---> " + count);

// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.WriteLine("Введите длину массива ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
int count = 0;

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write(array[i] + " ");
    if (i % 2 > 0 || i % 2 < 0)
    {
        count = array[i] + count;
    }
}
Console.WriteLine("---> " + count);
*/
// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
Console.WriteLine("Введите длину массива ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];
double max = 0;
double count = 0;

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
    if (array[i] > max)
    {
        max = array[i];
    }
}
double min = max;
for (int i = 0; i < length; i++)
{
    count = array[i];
    if (count < min) min = count;
}
double result = max - min;

Console.WriteLine($"---> {max} - {min} = {result}");
*/