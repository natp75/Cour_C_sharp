﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


int number = new Random().Next(1, 8);
if (number == 6 || number == 7)
{
    Console.WriteLine($"{number} -> да"); 
}
else
{
    Console.WriteLine($"{number} -> нет");
}