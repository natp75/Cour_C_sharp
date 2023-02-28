// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число a: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число x: ");
int x = Convert.ToInt32 (Console.ReadLine());
int max = 0;
if ( x < a & a > b)
{
    max = a;
}
else if (x < b & b > a)
{
    max = b;
}
else
{
    max = x;
}
Console.WriteLine($"{max}");



