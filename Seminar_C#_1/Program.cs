/*
// 1 задача

Console.Write("Введите целое число ");
int value = Convert.ToInt32(Console.ReadLine());

int kvadrat_value = value * value;

Console.Write("Квадрат данного числа равен ");
Console.WriteLine(kvadrat_value);


// 2 задача

Console.Write("Введите первое целое число ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число ");
int value2 = Convert.ToInt32(Console.ReadLine());

int kvadrat_value2 = value2 * value2;

if(kvadrat_value2 == value1)
{
    Console.WriteLine("Квадрат второго числа соответствует первому");
}
else
{
    Console.WriteLine("Искомых соответствий не выявлено");
}


// 3 задача

Console.WriteLine("Введите номер дня недели ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <= 7 && number >= 1)
{
    if(number == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if(number == 2)
    {
        Console.WriteLine("Вторник");
    }
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}


// 4 задача

Console.WriteLine("Введите натуральное число ");
int n = Convert.ToInt32(Console.ReadLine());
int neg_n = n*(-1);

while(neg_n <= n)
{
    Console.Write(neg_n + " ");
    neg_n++;
}
*/