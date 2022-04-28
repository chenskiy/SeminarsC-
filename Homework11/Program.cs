// Дополнить решение домашней задачи прошлого семинара, добавив возможность ввода массивов info и data пользователем. 
// Проработать возможные частные случаи несоответствия данных в этих массивах.

int[] SplitBinToDec(int[] bin, int[] digitInfo)
{
    Console.Write("{ ");
    int[] result = new int[digitInfo.Length];
    int binPosition = 0;
    
    for (int pos = 0; pos < digitInfo.Length; pos++)
    {
        int number = 0;
        if (binPosition + digitInfo[pos] > bin.Length)
        {
            int cut = digitInfo[pos] - bin.Length + binPosition;
            while (binPosition < bin.Length)
            {
                number += bin[binPosition] * (int)Math.Pow(2, bin.Length - 1 - binPosition);
                binPosition++;
            }
            result[pos] = number;
            Console.Write(number + " ");
            Console.WriteLine();
            Console.Write("Не хвататет данных в массиве data");
            return result;
        }
        for (int i = 0; i < digitInfo[pos]; i++)
        {
            number += bin[binPosition + i] * (int)Math.Pow(2, digitInfo[pos] - 1 - i);
        }
        Console.Write(number + " ");
        binPosition += digitInfo[pos];

        result[pos] = number;
    }
    Console.Write("}");
    return result;
}

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
int[] info = { 2, 3, 3, 2 };
int[] decArray = SplitBinToDec(data, info);
