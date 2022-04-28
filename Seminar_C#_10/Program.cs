// // Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
/*
int AlmostFibonacci(int num1, int num2, int size)
{
    if (size == 1) return num1;
    if (size == 2) return num2;
    else return AlmostFibonacci(num1, num2, size - 1) + AlmostFibonacci(num1, num2, size - 2);
}

int f1 = 5;
int f2 = 10;
int col = 10;

for (int i = 1; i <= col; i++)
{
    Console.Write(AlmostFibonacci(f1, f2, i) + " ");
}
*/
// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.

void PrintWords (string alf, int lengthWord, string currentWord)
{
    if (lengthWord == 0) Console.WriteLine (currentWord);
    else 
    {
        for (int i = 0; i < alf.Length; i++)
        {
            PrintWords(alf, lengthWord - 1, currentWord + alf[i]);
        }
    }
}
PrintWords("ABC", 3, "");