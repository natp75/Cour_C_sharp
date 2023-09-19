// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число a: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32 (Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"max = {a}");
}
else
{
    Console.WriteLine($"max = {b}");
}

﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

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

﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число x: ");
int x = Convert.ToInt32 (Console.ReadLine());
if (x % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
   Console.WriteLine("нет");
}

﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число n: ");
int n = Convert.ToInt32 (Console.ReadLine());
for (int i = 1; i <= n; i++)
{
   if (i % 2 == 0)
   {
    Console.Write(i + " ");
   }
}