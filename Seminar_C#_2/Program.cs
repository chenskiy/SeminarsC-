/*
int FindMaxNum(int num)
{
    int n1 = num % 10;
    int n2 = num / 10;

    if(n1 > n2)
    {
        return n1;
    }
    else
    {
        return n2;
    }
}

int number = new Random().Next(10,99);
Console.WriteLine("Current number is " + number + "max part is " + FindMaxNum(number));
*/

/* // Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
int Max(int num)
{
    int n1 = (num / 100) * 10;
    int n2 = num % 10;
    return n1 + n2;
}

int number = new Random().Next(100,1000);

Console.WriteLine(number + " --- " + Max(number));
*/

/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число не кратно числу первому, то программа выводит остаток от деление.

void velure(int num1, int num2)
{
    if(num1 % num2 == 0)
    {
        Console.WriteLine("yes");
    }
    else{
        Console.WriteLine(num1 % num2);
    }
}
Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

velure(number1, number2);
*/
/*
void velure(int num1, int num2)
{
    if(num1 < num2)
    {
        int a = num1;
        num1 = num2;
        num2 = a;
    }
    if(num1 % num2 == 0)
    {
        Console.WriteLine("yes");
    }
    else{
        Console.WriteLine(num1 % num2);
    }
}
Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

velure(number1, number2);
*/

/*
void Proverka(int num1, int num2, int num3)
{
    if(num1 % num2 == 0 && num1 % num3 == 0)
    {
        Console.WriteLine("Число " + num1 + " является кратным числам " + num2 + " и " + num3);
    }
    else
    {
        Console.WriteLine("Число " + num1 + " не является кратным числам " + num2 + " и " + num3);
    }
}
Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int check1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число ");
int check2 = Convert.ToInt32(Console.ReadLine());

Proverka(number1, check1, check2);
*/