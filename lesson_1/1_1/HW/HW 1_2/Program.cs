﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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

