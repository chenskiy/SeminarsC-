// Задача: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)

// Пример:

// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }

// выходные данные:
// 1, 7, 0, 1


int[] SplitBinToDec(int[] bin, int[] digitInfo)
{
    Console.Write("{ ");
    int[] result = new int[digitInfo.Length];
    int binPosition = 0;
    for (int pos = 0; pos < digitInfo.Length; pos++)
    {
        int number = 0;
        int pow = 0;
        for (int i = digitInfo[pos] - 1; i >= 0; i--)
        {
            number = number + bin[binPosition + i] * (int)Math.Pow(2, pow);
            pow++;
        }
        Console.Write($"{number} ");
        binPosition = binPosition + digitInfo[pos];
        result[pos] = number;
    }
    Console.WriteLine("}");
    return result;
}
int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] decArray = SplitBinToDec(data, info);