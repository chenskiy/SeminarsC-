// 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
/*
int[] mass = new int[12];

int pos = 0, neg = 0;

for (int i = 0; i < 12; i++)
{
    mass[i] = new Random().Next(-9, 10);

    if (mass[i] > 0) pos = mass[i] + pos;

    else neg = neg + mass[i];

    Console.Write(mass[i] + " ");
}
Console.WriteLine($"pos is {pos} neg is {neg}");
*/
// 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] mass = new int[12];

for (int i = 0; i < 12; i++)
{
    mass[i] = new Random().Next(-9, 10);

    Console.Write(mass[i] + " ");

    Console.WriteLine(mass[i] * (-1));
}
*/
// 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] arra = new int[50];
int tumbler = 0;
for (int i = 0; i < 50; i++)
{
    arra[i] = new Random().Next(1, 31);

    Console.Write(arra[i] + (" "));
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 50; i++)
{
    if (arra[i] == num)
    {
        Console.WriteLine("Yes");
        tumbler = 1;
        break;
    }
}

if (tumbler == 0) Console.WriteLine("NO");
*/
// 4. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
/*
int[] arra = new int[123];
int count = 0;
for (int i = 0; i < 123; i++)
{
    arra[i] = new Random().Next(1, 1000);
    
    if (arra[i] < 100 && arra[i] > 9) count++;
}
Console.WriteLine(count);
*/
// 5. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

Console.WriteLine("Введите длину массива ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arra = new int[num];

int dlina = 1;
if (num % 2 == 0) dlina = 0;
int[] arra2 = new int[(num / 2) + dlina];

for (int i = 0; i < num ; i++)
{
    arra[i] = i + 1;
    Console.Write(arra[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < ((num / 2) + dlina); i++)
{
    arra2[i] = arra[i] * (arra[num - i - 1]);
    if (i == num - i - 1) arra2[i] = arra[i];
    Console.Write(arra2[i] + " ");
}